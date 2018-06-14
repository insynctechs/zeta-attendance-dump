using System;
using System.Windows.Forms;


namespace DeviceComm
{
    public partial class DeviceComunication : Form
    {
        public DeviceComunication()
        {
            InitializeComponent();
        }

        private void btnBW_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogresult = MessageBox.Show("Are you Connecting Black and White Device ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogresult == DialogResult.Yes)
                {
                    UserInfoMainBW obj = new UserInfoMainBW();
                    obj.ShowDialog();
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                DeviceComm.Class.CommonLogger.Info(ex.ToString());
            }
        }

        private void btnTFT_Click(object sender, EventArgs e)
        {

            DialogResult dialogresult = MessageBox.Show("Are you connecting TFT Device?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                UserInfoMainTFT obj = new UserInfoMainTFT();
                obj.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnIFACE_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you connecting  IFace Device?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                UserInfoMainIFACE obj = new UserInfoMainIFACE();
                obj.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
