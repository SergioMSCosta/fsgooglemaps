namespace FSGoogleMaps
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbxRealtime = new System.Windows.Forms.GroupBox();
            this.pnlAuthentication = new System.Windows.Forms.Panel();
            this.txtORTCAuthToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtORTCPvtKey = new System.Windows.Forms.TextBox();
            this.lblORTCPrivateKey = new System.Windows.Forms.Label();
            this.chkORTCAuth = new System.Windows.Forms.CheckBox();
            this.txtORTCChannel = new System.Windows.Forms.TextBox();
            this.lblORTCChannel = new System.Windows.Forms.Label();
            this.txtORTCAppKey = new System.Windows.Forms.TextBox();
            this.lblORTCAppKey = new System.Windows.Forms.Label();
            this.pnlORTCConfig = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tslFSX = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslORTC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslBroadcast = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbxBroadcast = new System.Windows.Forms.GroupBox();
            this.lblBroadcastIntervalUnits = new System.Windows.Forms.Label();
            this.nudIntervalTime = new System.Windows.Forms.NumericUpDown();
            this.lblBroadcastInterval = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.gbxRealtime.SuspendLayout();
            this.pnlAuthentication.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.gbxBroadcast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRealtime
            // 
            this.gbxRealtime.Controls.Add(this.pnlAuthentication);
            this.gbxRealtime.Controls.Add(this.chkORTCAuth);
            this.gbxRealtime.Controls.Add(this.txtORTCChannel);
            this.gbxRealtime.Controls.Add(this.lblORTCChannel);
            this.gbxRealtime.Controls.Add(this.txtORTCAppKey);
            this.gbxRealtime.Controls.Add(this.lblORTCAppKey);
            this.gbxRealtime.Controls.Add(this.pnlORTCConfig);
            this.gbxRealtime.Location = new System.Drawing.Point(12, 12);
            this.gbxRealtime.Name = "gbxRealtime";
            this.gbxRealtime.Size = new System.Drawing.Size(302, 215);
            this.gbxRealtime.TabIndex = 1;
            this.gbxRealtime.TabStop = false;
            this.gbxRealtime.Text = "Realtime";
            // 
            // pnlAuthentication
            // 
            this.pnlAuthentication.Controls.Add(this.txtORTCAuthToken);
            this.pnlAuthentication.Controls.Add(this.label1);
            this.pnlAuthentication.Controls.Add(this.txtORTCPvtKey);
            this.pnlAuthentication.Controls.Add(this.lblORTCPrivateKey);
            this.pnlAuthentication.Enabled = false;
            this.pnlAuthentication.Location = new System.Drawing.Point(7, 130);
            this.pnlAuthentication.Name = "pnlAuthentication";
            this.pnlAuthentication.Size = new System.Drawing.Size(286, 64);
            this.pnlAuthentication.TabIndex = 7;
            // 
            // txtORTCAuthToken
            // 
            this.txtORTCAuthToken.Location = new System.Drawing.Point(114, 39);
            this.txtORTCAuthToken.Name = "txtORTCAuthToken";
            this.txtORTCAuthToken.Size = new System.Drawing.Size(171, 22);
            this.txtORTCAuthToken.TabIndex = 5;
            this.txtORTCAuthToken.Text = "any_auth_token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Auth Token:";
            // 
            // txtORTCPvtKey
            // 
            this.txtORTCPvtKey.Location = new System.Drawing.Point(114, 3);
            this.txtORTCPvtKey.Name = "txtORTCPvtKey";
            this.txtORTCPvtKey.Size = new System.Drawing.Size(171, 22);
            this.txtORTCPvtKey.TabIndex = 3;
            this.txtORTCPvtKey.Text = "YOUR_PRIVATE_KEY";
            // 
            // lblORTCPrivateKey
            // 
            this.lblORTCPrivateKey.AutoSize = true;
            this.lblORTCPrivateKey.Location = new System.Drawing.Point(20, 6);
            this.lblORTCPrivateKey.Name = "lblORTCPrivateKey";
            this.lblORTCPrivateKey.Size = new System.Drawing.Size(84, 17);
            this.lblORTCPrivateKey.TabIndex = 2;
            this.lblORTCPrivateKey.Text = "Private Key:";
            // 
            // chkORTCAuth
            // 
            this.chkORTCAuth.AutoSize = true;
            this.chkORTCAuth.Location = new System.Drawing.Point(9, 101);
            this.chkORTCAuth.Name = "chkORTCAuth";
            this.chkORTCAuth.Size = new System.Drawing.Size(109, 21);
            this.chkORTCAuth.TabIndex = 6;
            this.chkORTCAuth.Text = "&Authenticate";
            this.chkORTCAuth.UseVisualStyleBackColor = true;
            // 
            // txtORTCChannel
            // 
            this.txtORTCChannel.Location = new System.Drawing.Point(121, 63);
            this.txtORTCChannel.Name = "txtORTCChannel";
            this.txtORTCChannel.Size = new System.Drawing.Size(171, 22);
            this.txtORTCChannel.TabIndex = 5;
            this.txtORTCChannel.Text = "fsx:session1";
            // 
            // lblORTCChannel
            // 
            this.lblORTCChannel.AutoSize = true;
            this.lblORTCChannel.Location = new System.Drawing.Point(6, 66);
            this.lblORTCChannel.Name = "lblORTCChannel";
            this.lblORTCChannel.Size = new System.Drawing.Size(64, 17);
            this.lblORTCChannel.TabIndex = 4;
            this.lblORTCChannel.Text = "Channel:";
            // 
            // txtORTCAppKey
            // 
            this.txtORTCAppKey.Location = new System.Drawing.Point(121, 29);
            this.txtORTCAppKey.Name = "txtORTCAppKey";
            this.txtORTCAppKey.Size = new System.Drawing.Size(171, 22);
            this.txtORTCAppKey.TabIndex = 1;
            this.txtORTCAppKey.Text = "YOUR_APPLICATION_KEY";
            // 
            // lblORTCAppKey
            // 
            this.lblORTCAppKey.AutoSize = true;
            this.lblORTCAppKey.Location = new System.Drawing.Point(6, 32);
            this.lblORTCAppKey.Name = "lblORTCAppKey";
            this.lblORTCAppKey.Size = new System.Drawing.Size(109, 17);
            this.lblORTCAppKey.TabIndex = 0;
            this.lblORTCAppKey.Text = "Application Key:";
            // 
            // pnlORTCConfig
            // 
            this.pnlORTCConfig.Location = new System.Drawing.Point(4, 21);
            this.pnlORTCConfig.Name = "pnlORTCConfig";
            this.pnlORTCConfig.Size = new System.Drawing.Size(290, 184);
            this.pnlORTCConfig.TabIndex = 9;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(169, 293);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(145, 30);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "Disconnected";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 293);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(145, 30);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFSX,
            this.tslORTC,
            this.tslBroadcast});
            this.stsStatus.Location = new System.Drawing.Point(0, 349);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(750, 25);
            this.stsStatus.TabIndex = 4;
            this.stsStatus.Text = "stsStatus";
            // 
            // tslFSX
            // 
            this.tslFSX.Name = "tslFSX";
            this.tslFSX.Size = new System.Drawing.Size(130, 20);
            this.tslFSX.Text = "FSX: Disconnected";
            // 
            // tslORTC
            // 
            this.tslORTC.Name = "tslORTC";
            this.tslORTC.Size = new System.Drawing.Size(143, 20);
            this.tslORTC.Text = "ORTC: Disconnected";
            // 
            // tslBroadcast
            // 
            this.tslBroadcast.Name = "tslBroadcast";
            this.tslBroadcast.Size = new System.Drawing.Size(125, 20);
            this.tslBroadcast.Text = "Not broadcasting";
            // 
            // gbxBroadcast
            // 
            this.gbxBroadcast.Controls.Add(this.lblBroadcastIntervalUnits);
            this.gbxBroadcast.Controls.Add(this.nudIntervalTime);
            this.gbxBroadcast.Controls.Add(this.lblBroadcastInterval);
            this.gbxBroadcast.Location = new System.Drawing.Point(12, 233);
            this.gbxBroadcast.Name = "gbxBroadcast";
            this.gbxBroadcast.Size = new System.Drawing.Size(302, 54);
            this.gbxBroadcast.TabIndex = 5;
            this.gbxBroadcast.TabStop = false;
            this.gbxBroadcast.Text = "Broadcast";
            // 
            // lblBroadcastIntervalUnits
            // 
            this.lblBroadcastIntervalUnits.AutoSize = true;
            this.lblBroadcastIntervalUnits.Location = new System.Drawing.Point(218, 26);
            this.lblBroadcastIntervalUnits.Name = "lblBroadcastIntervalUnits";
            this.lblBroadcastIntervalUnits.Size = new System.Drawing.Size(26, 17);
            this.lblBroadcastIntervalUnits.TabIndex = 6;
            this.lblBroadcastIntervalUnits.Text = "ms";
            // 
            // nudIntervalTime
            // 
            this.nudIntervalTime.Location = new System.Drawing.Point(138, 24);
            this.nudIntervalTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIntervalTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudIntervalTime.Name = "nudIntervalTime";
            this.nudIntervalTime.Size = new System.Drawing.Size(74, 22);
            this.nudIntervalTime.TabIndex = 5;
            this.nudIntervalTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblBroadcastInterval
            // 
            this.lblBroadcastInterval.AutoSize = true;
            this.lblBroadcastInterval.Location = new System.Drawing.Point(6, 26);
            this.lblBroadcastInterval.Name = "lblBroadcastInterval";
            this.lblBroadcastInterval.Size = new System.Drawing.Size(126, 17);
            this.lblBroadcastInterval.TabIndex = 4;
            this.lblBroadcastInterval.Text = "Broadcast Interval:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbLog);
            this.groupBox1.Location = new System.Drawing.Point(321, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(416, 310);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(8, 23);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(400, 279);
            this.rtbLog.TabIndex = 9;
            this.rtbLog.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 374);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBroadcast);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.gbxRealtime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "FSGoogleMaps";
            this.gbxRealtime.ResumeLayout(false);
            this.gbxRealtime.PerformLayout();
            this.pnlAuthentication.ResumeLayout(false);
            this.pnlAuthentication.PerformLayout();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.gbxBroadcast.ResumeLayout(false);
            this.gbxBroadcast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRealtime;
        private System.Windows.Forms.Label lblORTCPrivateKey;
        private System.Windows.Forms.TextBox txtORTCAppKey;
        private System.Windows.Forms.Label lblORTCAppKey;
        private System.Windows.Forms.TextBox txtORTCChannel;
        private System.Windows.Forms.Label lblORTCChannel;
        private System.Windows.Forms.TextBox txtORTCPvtKey;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnlAuthentication;
        private System.Windows.Forms.TextBox txtORTCAuthToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkORTCAuth;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslFSX;
        private System.Windows.Forms.ToolStripStatusLabel tslORTC;
        private System.Windows.Forms.ToolStripStatusLabel tslBroadcast;
        private System.Windows.Forms.GroupBox gbxBroadcast;
        private System.Windows.Forms.Label lblBroadcastInterval;
        private System.Windows.Forms.Panel pnlORTCConfig;
        private System.Windows.Forms.Label lblBroadcastIntervalUnits;
        private System.Windows.Forms.NumericUpDown nudIntervalTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

