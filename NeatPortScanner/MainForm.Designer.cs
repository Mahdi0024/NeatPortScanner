using System.Windows.Forms;

namespace NeatPortScanner
{
    partial class MainForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.currentPortLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rangesTextBot = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.progressBarRanges = new System.Windows.Forms.ProgressBar();
            this.progressBarRange = new System.Windows.Forms.ProgressBar();
            this.progressLableRanges = new System.Windows.Forms.Label();
            this.progressLabelRange = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goodsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentRangeLabel = new System.Windows.Forms.Label();
            this.portNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.threadsNum = new System.Windows.Forms.NumericUpDown();
            this.writePortChkBox = new System.Windows.Forms.CheckBox();
            this.timeOutNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.appendChkBox = new System.Windows.Forms.CheckBox();
            this.uiUpdaterTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOutNum)).BeginInit();
            this.SuspendLayout();
            // 
            // currentPortLable
            // 
            this.currentPortLable.Location = new System.Drawing.Point(371, 152);
            this.currentPortLable.Name = "currentPortLable";
            this.currentPortLable.Size = new System.Drawing.Size(210, 16);
            this.currentPortLable.TabIndex = 37;
            this.currentPortLable.Text = "-";
            this.currentPortLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Port :";
            // 
            // rangesTextBot
            // 
            this.rangesTextBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.rangesTextBot.ForeColor = System.Drawing.Color.White;
            this.rangesTextBot.Location = new System.Drawing.Point(10, 24);
            this.rangesTextBot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rangesTextBot.MaxLength = 0;
            this.rangesTextBot.Multiline = true;
            this.rangesTextBot.Name = "rangesTextBot";
            this.rangesTextBot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rangesTextBot.Size = new System.Drawing.Size(234, 287);
            this.rangesTextBot.TabIndex = 23;
            this.rangesTextBot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(106)))), ((int)(((byte)(214)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(270, 25);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(311, 28);
            this.startButton.TabIndex = 24;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Goods :";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(106)))), ((int)(((byte)(214)))));
            this.stopButton.Enabled = false;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(270, 61);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(311, 28);
            this.stopButton.TabIndex = 28;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // progressBarRanges
            // 
            this.progressBarRanges.Location = new System.Drawing.Point(269, 243);
            this.progressBarRanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarRanges.Name = "progressBarRanges";
            this.progressBarRanges.Size = new System.Drawing.Size(312, 10);
            this.progressBarRanges.TabIndex = 26;
            // 
            // progressBarRange
            // 
            this.progressBarRange.Location = new System.Drawing.Point(269, 234);
            this.progressBarRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarRange.Name = "progressBarRange";
            this.progressBarRange.Size = new System.Drawing.Size(312, 10);
            this.progressBarRange.TabIndex = 25;
            // 
            // progressLableRanges
            // 
            this.progressLableRanges.Location = new System.Drawing.Point(270, 259);
            this.progressLableRanges.Name = "progressLableRanges";
            this.progressLableRanges.Size = new System.Drawing.Size(308, 16);
            this.progressLableRanges.TabIndex = 35;
            this.progressLableRanges.Text = "0";
            this.progressLableRanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressLabelRange
            // 
            this.progressLabelRange.Location = new System.Drawing.Point(270, 215);
            this.progressLabelRange.Name = "progressLabelRange";
            this.progressLabelRange.Size = new System.Drawing.Size(311, 16);
            this.progressLabelRange.TabIndex = 34;
            this.progressLabelRange.Text = "0";
            this.progressLabelRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Range :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(266, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Main Progress";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goodsLabel
            // 
            this.goodsLabel.Location = new System.Drawing.Point(371, 109);
            this.goodsLabel.Name = "goodsLabel";
            this.goodsLabel.Size = new System.Drawing.Size(210, 16);
            this.goodsLabel.TabIndex = 30;
            this.goodsLabel.Text = "0";
            this.goodsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(270, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Current Progress";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentRangeLabel
            // 
            this.currentRangeLabel.Location = new System.Drawing.Point(371, 132);
            this.currentRangeLabel.Name = "currentRangeLabel";
            this.currentRangeLabel.Size = new System.Drawing.Size(210, 16);
            this.currentRangeLabel.TabIndex = 31;
            this.currentRangeLabel.Text = "-";
            this.currentRangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // portNum
            // 
            this.portNum.Location = new System.Drawing.Point(82, 187);
            this.portNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.portNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portNum.Name = "portNum";
            this.portNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.portNum.Size = new System.Drawing.Size(71, 28);
            this.portNum.TabIndex = 20;
            this.portNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portNum.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.threadsNum);
            this.groupBox1.Controls.Add(this.writePortChkBox);
            this.groupBox1.Controls.Add(this.portNum);
            this.groupBox1.Controls.Add(this.timeOutNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.appendChkBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(590, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 287);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opnions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 30;
            this.label8.Tag = "";
            this.label8.Text = "Threads:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 29;
            this.label7.Tag = "";
            this.label7.Text = "Port:";
            // 
            // threadsNum
            // 
            this.threadsNum.Location = new System.Drawing.Point(82, 251);
            this.threadsNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.threadsNum.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.threadsNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadsNum.Name = "threadsNum";
            this.threadsNum.Size = new System.Drawing.Size(71, 28);
            this.threadsNum.TabIndex = 28;
            this.threadsNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.threadsNum.ThousandsSeparator = true;
            this.threadsNum.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // writePortChkBox
            // 
            this.writePortChkBox.AutoSize = true;
            this.writePortChkBox.Location = new System.Drawing.Point(9, 23);
            this.writePortChkBox.Name = "writePortChkBox";
            this.writePortChkBox.Size = new System.Drawing.Size(110, 26);
            this.writePortChkBox.TabIndex = 26;
            this.writePortChkBox.Text = "Write Port";
            this.writePortChkBox.UseVisualStyleBackColor = true;
            // 
            // timeOutNum
            // 
            this.timeOutNum.Location = new System.Drawing.Point(83, 219);
            this.timeOutNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeOutNum.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.timeOutNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeOutNum.Name = "timeOutNum";
            this.timeOutNum.Size = new System.Drawing.Size(71, 28);
            this.timeOutNum.TabIndex = 22;
            this.timeOutNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeOutNum.ThousandsSeparator = true;
            this.timeOutNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 23;
            this.label6.Tag = "";
            this.label6.Text = "TimeOut:";
            // 
            // appendChkBox
            // 
            this.appendChkBox.AutoSize = true;
            this.appendChkBox.Location = new System.Drawing.Point(9, 49);
            this.appendChkBox.Name = "appendChkBox";
            this.appendChkBox.Size = new System.Drawing.Size(140, 26);
            this.appendChkBox.TabIndex = 27;
            this.appendChkBox.Text = "Append to file";
            this.appendChkBox.UseVisualStyleBackColor = true;
            // 
            // uiUpdaterTimer
            // 
            this.uiUpdaterTimer.Interval = 150;
            this.uiUpdaterTimer.Tick += new System.EventHandler(this.uiUpdaterTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(792, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currentPortLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rangesTextBot);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.progressBarRanges);
            this.Controls.Add(this.progressBarRange);
            this.Controls.Add(this.progressLableRanges);
            this.Controls.Add(this.progressLabelRange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.goodsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentRangeLabel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neat Port Scanner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOutNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentPortLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rangesTextBot;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ProgressBar progressBarRanges;
        private System.Windows.Forms.ProgressBar progressBarRange;
        private System.Windows.Forms.Label progressLableRanges;
        private System.Windows.Forms.Label progressLabelRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label goodsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentRangeLabel;
        private System.Windows.Forms.NumericUpDown portNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox writePortChkBox;
        private System.Windows.Forms.NumericUpDown timeOutNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox appendChkBox;
        private Timer uiUpdaterTimer;
        private NumericUpDown threadsNum;
        private Label label8;
        private Label label7;
    }
}

