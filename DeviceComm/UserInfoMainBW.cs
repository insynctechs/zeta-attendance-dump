﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace DeviceComm
{
    public partial class UserInfoMainBW : Form
    {
        public UserInfoMainBW()
        {
            InitializeComponent();
        }

        //Create Standalone SDK class dynamicly.
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        /********************************************************************************************************************************************
        * Before you refer to this demo,we strongly suggest you read the development manual deeply first.                                           *
        * This part is for demonstrating the communication with your device.There are 3 communication ways: "TCP/IP","Serial Port" and "USB Client".*
        * The communication way which you can use duing to the model of the device.                                                                 *
        * *******************************************************************************************************************************************/
        #region Communication
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.

        private static Int32 MyCount;
        

        //If your device supports the TCP/IP communications, you can refer to this.
        //when you are using the tcp/ip communication,you can distinguish different devices by their IP address.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Connect clicked!");
                if (txtIP.Text.Trim() == "" || txtPort.Text.Trim() == "")
                {
                    MessageBox.Show("IP and Port cannot be null", "Error");
                    return;
                }
                int idwErrorCode = 0;

                Cursor = Cursors.WaitCursor;
                if (btnConnect.Text == "DisConnect")
                {
                    MessageBox.Show("DisConnect clicked!");
                    axCZKEM1.Disconnect();
                    /*
                    this.axCZKEM1.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
                    this.axCZKEM1.OnAttTransaction -= new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler(axCZKEM1_OnAttTransaction);
                    this.axCZKEM1.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                    this.axCZKEM1.OnNewUser -= new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
                    this.axCZKEM1.OnHIDNum -= new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
                    this.axCZKEM1.OnWriteCard -= new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
                    this.axCZKEM1.OnEmptyCard -= new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);
                    */
                    bIsConnected = false;
                    btnConnect.Text = "Connect";
                    lblState.Text = "Current State:DisConnected";
                    Cursor = Cursors.Default;
                    return;
                }
                MessageBox.Show("Connect fn going to call "+ txtIP.Text+"--"+ Convert.ToInt32(txtPort.Text).ToString());
                bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
                MessageBox.Show("bIsConnected - "+bIsConnected.ToString());
                if (bIsConnected == true)
                {
                    btnConnect.Text = "DisConnect";
                    btnConnect.Refresh();
                    lblState.Text = "Current State:Connected";
                    iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                    /*
                    if (axCZKEM1.RegEvent(iMachineNumber, 65535))//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                    {
                        this.axCZKEM1.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
                        this.axCZKEM1.OnAttTransaction += new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler(axCZKEM1_OnAttTransaction);
                        this.axCZKEM1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                        this.axCZKEM1.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
                        this.axCZKEM1.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
                        this.axCZKEM1.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
                        this.axCZKEM1.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);
                    }
                  */

                    MyCount = 1;
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                DeviceComm.Class.CommonLogger.Info(ex.ToString());
            }
        }

        //If your device supports the SerialPort communications, you can refer to this.
        private void btnRsConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPort.Text.Trim() == "" || cbBaudRate.Text.Trim() == "" || txtMachineSN.Text.Trim() == "")
                {
                    MessageBox.Show("Port,BaudRate and MachineSN cannot be null", "Error");
                    return;
                }
                int idwErrorCode = 0;
                //accept serialport number from string like "COMi"
                int iPort;
                string sPort = cbPort.Text.Trim();
                for (iPort = 1; iPort < 10; iPort++)
                {
                    if (sPort.IndexOf(iPort.ToString()) > -1)
                    {
                        break;
                    }
                }

                Cursor = Cursors.WaitCursor;
                if (btnRsConnect.Text == "Disconnect")
                {
                    axCZKEM1.Disconnect();
                    /*
                    this.axCZKEM1.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
                    this.axCZKEM1.OnAttTransaction -= new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler(axCZKEM1_OnAttTransaction);
                    this.axCZKEM1.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                    this.axCZKEM1.OnNewUser -= new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
                    this.axCZKEM1.OnHIDNum -= new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
                    this.axCZKEM1.OnWriteCard -= new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
                    this.axCZKEM1.OnEmptyCard -= new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);
                    */
                    bIsConnected = false;
                    btnRsConnect.Text = "Connect";
                    btnRsConnect.Refresh();
                    lblState.Text = "Current State:Disconnected";
                    Cursor = Cursors.Default;
                    return;
                }

                iMachineNumber = Convert.ToInt32(txtMachineSN.Text.Trim());//when you are using the serial port communication,you can distinguish different devices by their serial port number.
                bIsConnected = axCZKEM1.Connect_Com(iPort, iMachineNumber, Convert.ToInt32(cbBaudRate.Text.Trim()));

                if (bIsConnected == true)
                {
                    btnRsConnect.Text = "Disconnect";
                    btnRsConnect.Refresh();
                    lblState.Text = "Current State:Connected";
                    /*
                    if (axCZKEM1.RegEvent(iMachineNumber, 65535))//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                    {
                        
                        this.axCZKEM1.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
                        this.axCZKEM1.OnAttTransaction += new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler(axCZKEM1_OnAttTransaction);
                        this.axCZKEM1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                        this.axCZKEM1.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
                        this.axCZKEM1.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
                        this.axCZKEM1.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
                        this.axCZKEM1.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);
                        
                        }*/
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
                }

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                DeviceComm.Class.CommonLogger.Info(ex.ToString());
            }
        }

        //If your device supports the USBCLient, you can refer to this.
        //Not all series devices can support this kind of connection.Please make sure your device supports USBClient.
        //Connect the device via the virtual serial port created by USBClient
        private void btnUSBConnect_Click(object sender, EventArgs e)
        {
            int idwErrorCode = 0;
            try
            {

                Cursor = Cursors.WaitCursor;
                if (btnUSBConnect.Text == "Disconnect")
                {
                    axCZKEM1.Disconnect();
                    /*
                    this.axCZKEM1.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
                    this.axCZKEM1.OnAttTransaction -= new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler(axCZKEM1_OnAttTransaction);
                    this.axCZKEM1.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                    this.axCZKEM1.OnNewUser -= new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
                    this.axCZKEM1.OnHIDNum -= new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
                    this.axCZKEM1.OnWriteCard -= new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
                    this.axCZKEM1.OnEmptyCard -= new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);
                    */
                    bIsConnected = false;
                    btnUSBConnect.Text = "Connect";
                    btnUSBConnect.Refresh();
                    lblState.Text = "Current State:Disconnected";
                    Cursor = Cursors.Default;
                    return;
                }

                if (rbUSB.Checked == true)//the common USBClient
                {
                    iMachineNumber = 1;//In fact,when you are using common USBClient communication,parameter Machinenumber will be ignored,that is any integer will all right.Here we use 1.
                    bIsConnected = axCZKEM1.Connect_USB(iMachineNumber);
                }
                else if (rbVUSB.Checked == true)//connect the device via the virtual serial port created by USB
                {
                    SearchforUSBCom usbcom = new SearchforUSBCom();
                    string sCom = "";
                    bool bSearch = usbcom.SearchforCom(ref sCom);//modify by Darcy on Nov.26 2009
                    if (bSearch == false)//modify by Darcy on Nov.26 2009
                    {
                        MessageBox.Show("Can not find the virtual serial port that can be used", "Error");
                        Cursor = Cursors.Default;
                        return;
                    }

                    int iPort;
                    for (iPort = 1; iPort < 10; iPort++)
                    {
                        if (sCom.IndexOf(iPort.ToString()) > -1)
                        {
                            break;
                        }
                    }

                    iMachineNumber = Convert.ToInt32(txtMachineSN2.Text.Trim());
                    if (iMachineNumber == 0 || iMachineNumber > 255)
                    {
                        MessageBox.Show("The Machine Number is invalid!", "Error");
                        Cursor = Cursors.Default;
                        return;
                    }

                    int iBaudRate = 115200;//115200 is one possible baudrate value(its value cannot be 0)
                    bIsConnected = axCZKEM1.Connect_Com(iPort, iMachineNumber, iBaudRate);
                }

                if (bIsConnected == true)
                {
                    btnUSBConnect.Text = "Disconnect";
                    btnUSBConnect.Refresh();
                    lblState.Text = "Current State:Connected";
                    /*
                    if (axCZKEM1.RegEvent(iMachineNumber, 65535))//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                    {
                        
                        this.axCZKEM1.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
                        this.axCZKEM1.OnAttTransaction += new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler(axCZKEM1_OnAttTransaction);
                        this.axCZKEM1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                        this.axCZKEM1.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
                        this.axCZKEM1.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
                        this.axCZKEM1.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
                        this.axCZKEM1.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);
                      
                    }  */
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
                }
            }
            catch (Exception ex)
            {
                DeviceComm.Class.CommonLogger.Info(ex.ToString());
            }
            Cursor = Cursors.Default;
           
        }

        private void rbVUSB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbVUSB.Checked == true)
                {
                    if (bIsConnected == true)
                    {
                        MessageBox.Show("Invalid Operation!", "Error");
                        rbVUSB.Checked = false;
                        return;
                    }
                    rbUSB.Checked = false;
                    txtMachineSN2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                DeviceComm.Class.CommonLogger.Info(ex.ToString());
            }

        }

        private void rbUSB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbUSB.Checked == true)
                {
                    if (bIsConnected == true)
                    {
                        MessageBox.Show("Invalid Operation!", "Error");
                        rbUSB.Checked = false;
                        return;
                    }
                    rbVUSB.Checked = false;
                    txtMachineSN2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                DeviceComm.Class.CommonLogger.Info(ex.ToString());
            }

        }


        #endregion

        #region AttLogs

        //Download the attendance records from the device.
        private void btnGetGeneralLogData_Click(object sender, EventArgs e)
        {
            string attDetails = "";
            if (!File.Exists(DeviceComm.Program.attFile))
            {
                // Create a file to write to.
                attDetails = "Attendance Details" + Environment.NewLine;
                File.WriteAllText(DeviceComm.Program.attFile, attDetails);
            }

            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
                return;
            }

            int idwTMachineNumber = 0;
            int idwEnrollNumber = 0;
            int idwEMachineNumber = 0;
            int idwVerifyMode = 0;
            int idwInOutMode = 0;
            int idwYear = 0;
            int idwMonth = 0;
            int idwDay = 0;
            int idwHour = 0;
            int idwMinute = 0;

            int idwErrorCode = 0;
            int iGLCount = 0;
            int iIndex = 0;

            try
            {
                Cursor = Cursors.WaitCursor;
                lvLogs.Items.Clear();
                //string attDetails = "";
                if (!File.Exists(DeviceComm.Program.attFile))
                {
                    // Create a file to write to.
                    attDetails = "Attendance Details" + Environment.NewLine;
                    File.WriteAllText(DeviceComm.Program.attFile, attDetails);
                }
                axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
                if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
                {
                    while (axCZKEM1.GetGeneralLogData(iMachineNumber, ref idwTMachineNumber, ref idwEnrollNumber,
                            ref idwEMachineNumber, ref idwVerifyMode, ref idwInOutMode, ref idwYear, ref idwMonth, ref idwDay, ref idwHour, ref idwMinute))//get records from the memory
                    {
                        iGLCount++;
                        lvLogs.Items.Add(iGLCount.ToString());
                        lvLogs.Items[iIndex].SubItems.Add(idwEnrollNumber.ToString());
                        lvLogs.Items[iIndex].SubItems.Add(idwVerifyMode.ToString());
                        lvLogs.Items[iIndex].SubItems.Add(idwInOutMode.ToString());
                        lvLogs.Items[iIndex].SubItems.Add(idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString());
                        attDetails = "Enroll#: " + idwEnrollNumber.ToString() + Environment.NewLine;
                        attDetails += "VerifyMode: " + idwVerifyMode.ToString() + Environment.NewLine;
                        attDetails += "InOutMode: " + idwInOutMode.ToString() + Environment.NewLine;
                        attDetails += "Time: " + idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + Environment.NewLine + Environment.NewLine+"-------------------------"+Environment.NewLine;
                        File.AppendAllText(DeviceComm.Program.attFile, attDetails);
                        iIndex++;
                    }
                    
                }
                else
                {
                    Cursor = Cursors.Default;
                    axCZKEM1.GetLastError(ref idwErrorCode);

                    if (idwErrorCode != 0)
                    {
                        MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
                    }
                    else
                    {
                        MessageBox.Show("No data from terminal returns!", "Error");
                    }
                }
                axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            }
            catch (Exception ex)
            {
                DeviceComm.Class.CommonLogger.Info(ex.ToString());
            }

            Cursor = Cursors.Default;
        }

        //Download the attendance records from the device.
        //The returned time is in strings(different from function GetGeneralLogData)
        private void btnGetGeneralLogDataStr_Click(object sender, EventArgs e)
        {

        }

        //Download the attendance records from the device.
        //"GetGeneralExtLogData" is an enhanced function of the function GetGeneralLogData, but it is compatible with GetGeneralLogData. 
        //Some machines have the WorkCode function; this function can gain the WorkCode when user passes the virification.
        private void btnGetGeneralExtLogData_Click(object sender, EventArgs e)
        {

        }

      
        //Get the count of attendance records in from ternimal.
        private void btnGetDeviceStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (bIsConnected == false)
                {
                    MessageBox.Show("Please connect the device first", "Error");
                    return;
                }
                int idwErrorCode = 0;
                int iValue = 0;

                axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
                if (axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue)) //Here we use the function "GetDeviceStatus" to get the record's count.The parameter "Status" is 6.
                {
                    MessageBox.Show("The count of the AttLogs in the device is " + iValue.ToString(), "Success");
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                }
                axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            }
            catch (Exception ex)
            {
                DeviceComm.Class.CommonLogger.Info(ex.ToString());
            }

        }
        #endregion




    }
}
