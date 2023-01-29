using NetTools;
using PortScannerLib;
using PortScannerLib.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace NeatPortScanner
{
    public partial class MainForm : Form
    {
        private readonly Queue<IPAddressRange> rangeQueue;
        private readonly ThreadSafeLogger logger;
        private CancellationTokenSource tokenSource;

        private int ipsChecked = 0, goods = 0, rangesScanned = 0;

        public MainForm()
        {
            InitializeComponent();
            rangeQueue = new Queue<IPAddressRange>();
            logger = new ThreadSafeLogger();
        }

        private async void ButtonStart_Click(object sender, System.EventArgs e)
        {
            if (LoadQueueFromInputTextBox())
            {
                MakeUiReadyForStart();

                logger.StartSession("Goods.txt", appendChkBox.Checked);

                var reporter = new Progress<PortScannerProgressReport>();
                reporter.ProgressChanged += Reporter_ProgressChanged;

                using (tokenSource = new CancellationTokenSource())
                    while (rangeQueue.Count > 0)
                    {
                        var rangeToScan = rangeQueue.Dequeue();

                        MakeUiReadyForNewRange(rangeToScan);

                        try
                        {
                            await PortScanner.ScanIpsAndLogAsync(rangeToScan, (int)portNum.Value,
                                (int)timeOutNum.Value, (int)threadsNum.Value,
                                logger, writePortChkBox.Checked,
                                reporter, tokenSource.Token);
                        }
                        catch (OperationCanceledException)
                        {
                            break;
                        }
                        finally
                        {
                            rangesScanned++;
                            ipsChecked = 0;
                        }
                    }
                logger.StopSession();

                CleanupAfterScanIsComplete();
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            stopButton.Enabled = false;
        }

        private void Reporter_ProgressChanged(object sender, PortScannerProgressReport e)
        {
            Interlocked.Increment(ref ipsChecked);
            if (e.IsAlive)
                Interlocked.Increment(ref goods);
        }

        private void uiUpdaterTimer_Tick(object sender, EventArgs e)
        {
            if (tokenSource is not null && tokenSource.IsCancellationRequested is not true)
            {
                goodsLabel.Text = goods.ToString();
                progressBarRange.Value = ipsChecked;
                progressLabelRange.Text = $"{ipsChecked} of {progressBarRange.Maximum}";
                progressBarRanges.Value = rangesScanned;
                progressLableRanges.Text = $"{rangesScanned} of {progressBarRanges.Maximum}";
            }
        }

        private bool LoadQueueFromInputTextBox()
        {
            var inputRanges = rangesTextBot.Text.Contains(',') ?
                rangesTextBot.Text.Split(',').Select(x => x.Trim()).ToArray() :
                rangesTextBot.Lines;
            foreach (var line in inputRanges)
            {
                if (IPAddressRange.TryParse(line, out IPAddressRange range))
                {
                    rangeQueue.Enqueue(range);
                }
            }
            return rangeQueue.Count > 0;
        }

        private void MakeUiReadyForStart()
        {
            stopButton.Enabled = true;
            startButton.Enabled = false;
            progressBarRanges.Maximum = rangeQueue.Count;
            uiUpdaterTimer.Start();
        }

        private void MakeUiReadyForNewRange(IPAddressRange rangeToScan)
        {
            currentRangeLabel.Text = rangeToScan.ToString();
            currentPortLable.Text = portNum.Value.ToString();
            progressBarRange.Maximum = rangeToScan.AsEnumerable().Count();
        }

        private void CleanupAfterScanIsComplete()
        {
            rangesScanned = 0;
            goods = 0;
            ipsChecked = 0;
            tokenSource.Dispose();

            startButton.Enabled = true;
            stopButton.Enabled = false;
            currentPortLable.Text = "-";
            currentRangeLabel.Text = "-";
            progressBarRange.Value = 0;
            progressBarRanges.Value = 0;
            progressLabelRange.Text = "-";
            progressLableRanges.Text = "-";
            rangesTextBot.Clear();
            rangesTextBot.Lines = rangeQueue.Select(ip => ip.ToString()).ToArray();
            rangeQueue.Clear();
            uiUpdaterTimer.Stop();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}