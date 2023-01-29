using Dasync.Collections;
using PortScannerLib.Events;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace PortScannerLib
{
    public static class PortScanner
    {
        public static async Task ScanIpsAndLogAsync(IEnumerable<IPAddress> ips,
            int port, int timeOut, int threads,
            ThreadSafeLogger logger, bool writePort,
            IProgress<PortScannerProgressReport> progressReporter, CancellationToken cancellationToken)
        {
            await ips.ParallelForEachAsync(async ip =>
            {
                var ipIsAlive = await CheckIpAsync(ip, port, timeOut);
                progressReporter.Report(new PortScannerProgressReport
                {
                    Ip = ip,
                    IsAlive = ipIsAlive
                });

                if (ipIsAlive) // log
                    logger.WriteLine(writePort ? $"{ip}:{port}" : ip.ToString());
            }, threads, cancellationToken);
        }

        public static async Task<bool> CheckIpAsync(IPAddress iP, int port, int timeOut)
        {
            try
            {
                using (var client = new TcpClient())
                using (var cts = new CancellationTokenSource(timeOut))
                {
                    await client.ConnectAsync(iP, port, cts.Token);
                    return client.Connected;
                }
            }
            catch (SocketException) //socket timed out
            {
                return false;
            }
            catch (OperationCanceledException) // operation timed out
            {
                return false;
            }
        }
    }
}