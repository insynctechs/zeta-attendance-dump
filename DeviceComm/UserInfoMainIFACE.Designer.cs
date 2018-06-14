namespace DeviceComm
{
    partial class UserInfoMainIFACE
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnRsConnect = new System.Windows.Forms.Button();
            this.txtMachineSN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBody = new System.Windows.Forms.GroupBox();
            this.tabBody = new System.Windows.Forms.TabControl();
            this.tabpageLog = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnGetDeviceStatus = new System.Windows.Forms.Button();
            this.btnGetGeneralLogData = new System.Windows.Forms.Button();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.lvLogsch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLogsch7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbBody.SuspendLayout();
            this.tabBody.SuspendLayout();
            this.tabpageLog.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl3);
            this.groupBox2.Controls.Add(this.lblState);
            this.groupBox2.Location = new System.Drawing.Point(15, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 91);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication with Device";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(6, 20);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(687, 63);
            this.tabControl3.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtPort);
            this.tabPage3.Controls.Add(this.txtIP);
            this.tabPage3.Controls.Add(this.btnConnect);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(679, 37);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "TCP/IP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(300, 9);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "4370";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(118, 9);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(95, 20);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.1.159";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(459, 9);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.btnRsConnect);
            this.tabPage6.Controls.Add(this.txtMachineSN);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.cbBaudRate);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.cbPort);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(679, 37);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "RS232/485";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnRsConnect
            // 
            this.btnRsConnect.Location = new System.Drawing.Point(511, 5);
            this.btnRsConnect.Name = "btnRsConnect";
            this.btnRsConnect.Size = new System.Drawing.Size(120, 23);
            this.btnRsConnect.TabIndex = 11;
            this.btnRsConnect.Text = "Connect";
            this.btnRsConnect.UseVisualStyleBackColor = true;
            this.btnRsConnect.Click += new System.EventHandler(this.btnRsConnect_Click);
            // 
            // txtMachineSN
            // 
            this.txtMachineSN.Location = new System.Drawing.Point(406, 7);
            this.txtMachineSN.Name = "txtMachineSN";
            this.txtMachineSN.Size = new System.Drawing.Size(56, 20);
            this.txtMachineSN.TabIndex = 10;
            this.txtMachineSN.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "MachineSN";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(221, 6);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(65, 21);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.Text = "115200";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(150, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "BaudRate";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbPort.Location = new System.Drawing.Point(80, 8);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(56, 21);
            this.cbPort.TabIndex = 5;
            this.cbPort.Text = "COM1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Port";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(703, 54);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(182, 15);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Current State:Disconnected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceComm.Properties.Resources.IFACE;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 30);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // gbBody
            // 
            this.gbBody.BackColor = System.Drawing.Color.Silver;
            this.gbBody.Controls.Add(this.tabBody);
            this.gbBody.Location = new System.Drawing.Point(2, 129);
            this.gbBody.Name = "gbBody";
            this.gbBody.Size = new System.Drawing.Size(978, 470);
            this.gbBody.TabIndex = 94;
            this.gbBody.TabStop = false;
            this.gbBody.Text = "Download or Upload Fingerprint Templates And Records";
            // 
            // tabBody
            // 
            this.tabBody.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabBody.Controls.Add(this.tabpageLog);
            this.tabBody.Location = new System.Drawing.Point(8, 27);
            this.tabBody.Name = "tabBody";
            this.tabBody.SelectedIndex = 0;
            this.tabBody.Size = new System.Drawing.Size(960, 432);
            this.tabBody.TabIndex = 93;
            // 
            // tabpageLog
            // 
            this.tabpageLog.Controls.Add(this.groupBox10);
            this.tabpageLog.Controls.Add(this.lvLogs);
            this.tabpageLog.Location = new System.Drawing.Point(4, 25);
            this.tabpageLog.Name = "tabpageLog";
            this.tabpageLog.Size = new System.Drawing.Size(952, 403);
            this.tabpageLog.TabIndex = 2;
            this.tabpageLog.Text = "Log Records";
            this.tabpageLog.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.btnGetDeviceStatus);
            this.groupBox10.Controls.Add(this.btnGetGeneralLogData);
            this.groupBox10.Location = new System.Drawing.Point(488, 10);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(451, 104);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Download or Clear Attendance Records";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(140, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Get the total of logs.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(141, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Get attendance logs.";
            // 
            // btnGetDeviceStatus
            // 
            this.btnGetDeviceStatus.Location = new System.Drawing.Point(19, 45);
            this.btnGetDeviceStatus.Name = "btnGetDeviceStatus";
            this.btnGetDeviceStatus.Size = new System.Drawing.Size(111, 23);
            this.btnGetDeviceStatus.TabIndex = 13;
            this.btnGetDeviceStatus.Text = "GetRecordCount";
            this.btnGetDeviceStatus.UseVisualStyleBackColor = true;
            this.btnGetDeviceStatus.Click += new System.EventHandler(this.btnGetDeviceStatus_Click);
            // 
            // btnGetGeneralLogData
            // 
            this.btnGetGeneralLogData.Location = new System.Drawing.Point(19, 18);
            this.btnGetGeneralLogData.Name = "btnGetGeneralLogData";
            this.btnGetGeneralLogData.Size = new System.Drawing.Size(111, 23);
            this.btnGetGeneralLogData.TabIndex = 12;
            this.btnGetGeneralLogData.Text = "DownloadAttLogs";
            this.btnGetGeneralLogData.UseVisualStyleBackColor = true;
            this.btnGetGeneralLogData.Click += new System.EventHandler(this.btnGetGeneralLogData_Click);
            // 
            // lvLogs
            // 
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvLogsch1,
            this.lvLogsch2,
            this.lvLogsch3,
            this.lvLogsch4,
            this.lvLogsch5,
            this.lvLogsch6,
            this.lvLogsch7});
            this.lvLogs.GridLines = true;
            this.lvLogs.Location = new System.Drawing.Point(5, 7);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(471, 362);
            this.lvLogs.TabIndex = 5;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // lvLogsch1
            // 
            this.lvLogsch1.Text = "Count";
            this.lvLogsch1.Width = 40;
            // 
            // lvLogsch2
            // 
            this.lvLogsch2.Text = "EnrollNumber";
            this.lvLogsch2.Width = 70;
            // 
            // lvLogsch3
            // 
            this.lvLogsch3.Text = "VerifyMode";
            this.lvLogsch3.Width = 50;
            // 
            // lvLogsch4
            // 
            this.lvLogsch4.Text = "InOutMode";
            // 
            // lvLogsch5
            // 
            this.lvLogsch5.Text = "Date";
            this.lvLogsch5.Width = 150;
            // 
            // lvLogsch6
            // 
            this.lvLogsch6.Text = "WorkCode";
            this.lvLogsch6.Width = 50;
            // 
            // lvLogsch7
            // 
            this.lvLogsch7.Text = "Reserved";
            this.lvLogsch7.Width = 50;
            // 
            // UserInfoMainIFACE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.gbBody);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "UserInfoMainIFACE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbBody.ResumeLayout(false);
            this.tabBody.ResumeLayout(false);
            this.tabpageLog.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnRsConnect;
        private System.Windows.Forms.TextBox txtMachineSN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox gbBody;
        private System.Windows.Forms.TabControl tabBody;
        private System.Windows.Forms.TabPage tabpageLog;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnGetDeviceStatus;
        private System.Windows.Forms.Button btnGetGeneralLogData;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader lvLogsch1;
        private System.Windows.Forms.ColumnHeader lvLogsch2;
        private System.Windows.Forms.ColumnHeader lvLogsch3;
        private System.Windows.Forms.ColumnHeader lvLogsch4;
        private System.Windows.Forms.ColumnHeader lvLogsch5;
        private System.Windows.Forms.ColumnHeader lvLogsch6;
        private System.Windows.Forms.ColumnHeader lvLogsch7;
    }
}