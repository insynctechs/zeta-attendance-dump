namespace DeviceComm
{
    partial class UserInfoMainTFT
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
            this.label29 = new System.Windows.Forms.Label();
            this.txtMachineSN2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnUSBConnect = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Body = new System.Windows.Forms.GroupBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPageLogR = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Body.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPageLogR.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.lblState);
            this.groupBox2.Location = new System.Drawing.Point(4, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(974, 84);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication with Device";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 58);
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
            this.tabPage1.Size = new System.Drawing.Size(720, 32);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TCP/IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(300, 6);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "4370";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(118, 6);
            this.txtIP.Name = "txtIP";
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIP.Size = new System.Drawing.Size(95, 20);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.1.160";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(431, 5);
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
            this.tabPage2.Size = new System.Drawing.Size(720, 32);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RS232/485";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRsConnect
            // 
            this.btnRsConnect.Location = new System.Drawing.Point(470, 3);
            this.btnRsConnect.Name = "btnRsConnect";
            this.btnRsConnect.Size = new System.Drawing.Size(120, 23);
            this.btnRsConnect.TabIndex = 11;
            this.btnRsConnect.Text = "Connect";
            this.btnRsConnect.UseVisualStyleBackColor = true;
            this.btnRsConnect.Click += new System.EventHandler(this.btnRsConnect_Click);
            // 
            // txtMachineSN
            // 
            this.txtMachineSN.Location = new System.Drawing.Point(356, 6);
            this.txtMachineSN.Name = "txtMachineSN";
            this.txtMachineSN.Size = new System.Drawing.Size(56, 20);
            this.txtMachineSN.TabIndex = 10;
            this.txtMachineSN.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 10);
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
            this.cbBaudRate.Location = new System.Drawing.Point(206, 6);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(65, 21);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.Text = "115200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 10);
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
            this.cbPort.Location = new System.Drawing.Point(71, 6);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(56, 21);
            this.cbPort.TabIndex = 5;
            this.cbPort.Text = "COM1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.txtMachineSN2);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.btnUSBConnect);
            this.tabPage3.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(720, 32);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "USBClient";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(233, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(63, 13);
            this.label29.TabIndex = 10;
            this.label29.Text = "MachineSN";
            // 
            // txtMachineSN2
            // 
            this.txtMachineSN2.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMachineSN2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMachineSN2.Location = new System.Drawing.Point(294, 5);
            this.txtMachineSN2.Name = "txtMachineSN2";
            this.txtMachineSN2.Size = new System.Drawing.Size(27, 20);
            this.txtMachineSN2.TabIndex = 9;
            this.txtMachineSN2.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Crimson;
            this.label18.Location = new System.Drawing.Point(120, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Virtual USBClient";
            // 
            // btnUSBConnect
            // 
            this.btnUSBConnect.Location = new System.Drawing.Point(437, 3);
            this.btnUSBConnect.Name = "btnUSBConnect";
            this.btnUSBConnect.Size = new System.Drawing.Size(120, 23);
            this.btnUSBConnect.TabIndex = 0;
            this.btnUSBConnect.Text = "Connect";
            this.btnUSBConnect.UseVisualStyleBackColor = true;
            this.btnUSBConnect.Click += new System.EventHandler(this.btnUSBConnect_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(752, 48);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(182, 15);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Current State:Disconnected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceComm.Properties.Resources.TFT;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 30);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.Silver;
            this.Body.Controls.Add(this.tab);
            this.Body.Location = new System.Drawing.Point(1, 122);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(989, 497);
            this.Body.TabIndex = 84;
            this.Body.TabStop = false;
            this.Body.Text = "Download or Upload Fingerprint Templates And Records";
            // 
            // tab
            // 
            this.tab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab.Controls.Add(this.tabPageLogR);
            this.tab.Location = new System.Drawing.Point(6, 19);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(975, 465);
            this.tab.TabIndex = 8;
            // 
            // tabPageLogR
            // 
            this.tabPageLogR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageLogR.Controls.Add(this.groupBox9);
            this.tabPageLogR.Controls.Add(this.lvLogs);
            this.tabPageLogR.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPageLogR.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogR.Name = "tabPageLogR";
            this.tabPageLogR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogR.Size = new System.Drawing.Size(967, 436);
            this.tabPageLogR.TabIndex = 1;
            this.tabPageLogR.Text = "Log Records";
            this.tabPageLogR.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.White;
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.btnGetDeviceStatus);
            this.groupBox9.Controls.Add(this.btnGetGeneralLogData);
            this.groupBox9.ForeColor = System.Drawing.Color.Blue;
            this.groupBox9.Location = new System.Drawing.Point(498, 9);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(454, 170);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Download or Clear Attendance Records";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(182, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Get the total of logs.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(182, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Get attendance logs.";
            // 
            // btnGetDeviceStatus
            // 
            this.btnGetDeviceStatus.ForeColor = System.Drawing.Color.Black;
            this.btnGetDeviceStatus.Location = new System.Drawing.Point(19, 79);
            this.btnGetDeviceStatus.Name = "btnGetDeviceStatus";
            this.btnGetDeviceStatus.Size = new System.Drawing.Size(111, 23);
            this.btnGetDeviceStatus.TabIndex = 13;
            this.btnGetDeviceStatus.Text = "GetRecordCount";
            this.btnGetDeviceStatus.UseVisualStyleBackColor = true;
            this.btnGetDeviceStatus.Click += new System.EventHandler(this.btnGetDeviceStatus_Click);
            // 
            // btnGetGeneralLogData
            // 
            this.btnGetGeneralLogData.ForeColor = System.Drawing.Color.Black;
            this.btnGetGeneralLogData.Location = new System.Drawing.Point(19, 36);
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
            this.lvLogs.Location = new System.Drawing.Point(8, 15);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(471, 411);
            this.lvLogs.TabIndex = 1;
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
            // UserInfoMainTFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "UserInfoMainTFT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfoMainTFT";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Body.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tabPageLogR.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRsConnect;
        private System.Windows.Forms.TextBox txtMachineSN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtMachineSN2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnUSBConnect;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox Body;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPageLogR;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
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