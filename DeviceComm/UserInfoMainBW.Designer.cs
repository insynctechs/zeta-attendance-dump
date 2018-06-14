namespace DeviceComm
{
    partial class UserInfoMainBW
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRsConnect = new System.Windows.Forms.Button();
            this.txtMachineSN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rbVUSB = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMachineSN2 = new System.Windows.Forms.TextBox();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.btnUSBConnect = new System.Windows.Forms.Button();
            this.gbBody = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbBody.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(4, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 88);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication with Device";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 62);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.txtIP);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(653, 36);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TCP/IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(300, 8);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "4370";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(118, 8);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(95, 20);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.1.201";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(480, 7);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnRsConnect);
            this.tabPage2.Controls.Add(this.txtMachineSN);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbBaudRate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbPort);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(653, 36);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RS232/485";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRsConnect
            // 
            this.btnRsConnect.Location = new System.Drawing.Point(480, 8);
            this.btnRsConnect.Name = "btnRsConnect";
            this.btnRsConnect.Size = new System.Drawing.Size(120, 23);
            this.btnRsConnect.TabIndex = 11;
            this.btnRsConnect.Text = "Connect";
            this.btnRsConnect.UseVisualStyleBackColor = true;
            this.btnRsConnect.Click += new System.EventHandler(this.btnRsConnect_Click);
            // 
            // txtMachineSN
            // 
            this.txtMachineSN.Location = new System.Drawing.Point(396, 10);
            this.txtMachineSN.Name = "txtMachineSN";
            this.txtMachineSN.Size = new System.Drawing.Size(56, 20);
            this.txtMachineSN.TabIndex = 10;
            this.txtMachineSN.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "MachineSN";
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
            this.cbBaudRate.Location = new System.Drawing.Point(224, 10);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(65, 21);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.Text = "115200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "BaudRate";
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
            this.cbPort.Location = new System.Drawing.Point(71, 10);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(56, 21);
            this.cbPort.TabIndex = 5;
            this.cbPort.Text = "COM1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.rbVUSB);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtMachineSN2);
            this.tabPage3.Controls.Add(this.rbUSB);
            this.tabPage3.Controls.Add(this.btnUSBConnect);
            this.tabPage3.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(653, 36);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "USBClient";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rbVUSB
            // 
            this.rbVUSB.AutoSize = true;
            this.rbVUSB.Checked = true;
            this.rbVUSB.Location = new System.Drawing.Point(32, 10);
            this.rbVUSB.Name = "rbVUSB";
            this.rbVUSB.Size = new System.Drawing.Size(105, 17);
            this.rbVUSB.TabIndex = 11;
            this.rbVUSB.TabStop = true;
            this.rbVUSB.Text = "Virtual USBClient";
            this.rbVUSB.UseVisualStyleBackColor = true;
            this.rbVUSB.CheckedChanged += new System.EventHandler(this.rbVUSB_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "MachineSN";
            // 
            // txtMachineSN2
            // 
            this.txtMachineSN2.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMachineSN2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMachineSN2.Location = new System.Drawing.Point(236, 8);
            this.txtMachineSN2.Name = "txtMachineSN2";
            this.txtMachineSN2.Size = new System.Drawing.Size(27, 20);
            this.txtMachineSN2.TabIndex = 12;
            this.txtMachineSN2.Text = "1";
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.BackColor = System.Drawing.Color.White;
            this.rbUSB.Location = new System.Drawing.Point(326, 10);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(73, 17);
            this.rbUSB.TabIndex = 10;
            this.rbUSB.Text = "USBClient";
            this.rbUSB.UseVisualStyleBackColor = false;
            this.rbUSB.CheckedChanged += new System.EventHandler(this.rbUSB_CheckedChanged);
            // 
            // btnUSBConnect
            // 
            this.btnUSBConnect.Location = new System.Drawing.Point(480, 5);
            this.btnUSBConnect.Name = "btnUSBConnect";
            this.btnUSBConnect.Size = new System.Drawing.Size(120, 23);
            this.btnUSBConnect.TabIndex = 0;
            this.btnUSBConnect.Text = "Connect";
            this.btnUSBConnect.UseVisualStyleBackColor = true;
            this.btnUSBConnect.Click += new System.EventHandler(this.btnUSBConnect_Click);
            // 
            // gbBody
            // 
            this.gbBody.BackColor = System.Drawing.Color.Silver;
            this.gbBody.Controls.Add(this.tabControl2);
            this.gbBody.Location = new System.Drawing.Point(-2, 127);
            this.gbBody.Name = "gbBody";
            this.gbBody.Size = new System.Drawing.Size(991, 472);
            this.gbBody.TabIndex = 84;
            this.gbBody.TabStop = false;
            this.gbBody.Text = "Download or Upload Fingerprint Templates";
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.tabPageLog);
            this.tabControl2.Location = new System.Drawing.Point(6, 19);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(979, 439);
            this.tabControl2.TabIndex = 8;
            // 
            // tabPageLog
            // 
            this.tabPageLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageLog.Controls.Add(this.groupBox11);
            this.tabPageLog.Controls.Add(this.lvLogs);
            this.tabPageLog.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(971, 410);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "Log Records";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Controls.Add(this.btnGetDeviceStatus);
            this.groupBox11.Controls.Add(this.btnGetGeneralLogData);
            this.groupBox11.Location = new System.Drawing.Point(582, 8);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(383, 396);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Download or Clear Attendance Records";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(182, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Get the total of logs.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(178, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Get attendance logs.";
            // 
            // btnGetDeviceStatus
            // 
            this.btnGetDeviceStatus.Location = new System.Drawing.Point(20, 87);
            this.btnGetDeviceStatus.Name = "btnGetDeviceStatus";
            this.btnGetDeviceStatus.Size = new System.Drawing.Size(136, 23);
            this.btnGetDeviceStatus.TabIndex = 13;
            this.btnGetDeviceStatus.Text = "GetRecordCount";
            this.btnGetDeviceStatus.UseVisualStyleBackColor = true;
            this.btnGetDeviceStatus.Click += new System.EventHandler(this.btnGetDeviceStatus_Click);
            // 
            // btnGetGeneralLogData
            // 
            this.btnGetGeneralLogData.Location = new System.Drawing.Point(20, 44);
            this.btnGetGeneralLogData.Name = "btnGetGeneralLogData";
            this.btnGetGeneralLogData.Size = new System.Drawing.Size(137, 23);
            this.btnGetGeneralLogData.TabIndex = 12;
            this.btnGetGeneralLogData.Text = "GetGeneralLogData";
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
            this.lvLogs.Location = new System.Drawing.Point(6, 8);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(570, 399);
            this.lvLogs.TabIndex = 3;
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
            this.lvLogsch2.Width = 80;
            // 
            // lvLogsch3
            // 
            this.lvLogsch3.Text = "VerifyMode";
            this.lvLogsch3.Width = 50;
            // 
            // lvLogsch4
            // 
            this.lvLogsch4.Text = "InOutMode";
            this.lvLogsch4.Width = 80;
            // 
            // lvLogsch5
            // 
            this.lvLogsch5.Text = "Date";
            this.lvLogsch5.Width = 180;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceComm.Properties.Resources.Black_white;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 27);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(720, 86);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(182, 15);
            this.lblState.TabIndex = 87;
            this.lblState.Text = "Current State:Disconnected";
            // 
            // UserInfoMainBW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 597);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbBody);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "UserInfoMainBW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfoMainBW";
          
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.gbBody.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRsConnect;
        private System.Windows.Forms.TextBox txtMachineSN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnUSBConnect;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.RadioButton rbVUSB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMachineSN2;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
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