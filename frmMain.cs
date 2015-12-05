using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;


namespace Hospital_Pilot
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private string _username = "";
        public  bool isConnected  = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                boxTicket.Enabled = false;
                boxKhamBenh.Enabled = false;
                boxThuoc.Enabled = false;
                boxNhanVien.Enabled = false;
                Setting_btn.Enabled = false;
                Logout_btn.Enabled = false;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            var frmLog = new frmLogin();
            frmLog.ShowDialog();
            _username = frmLog.username;
            if (frmLog.isConnected == true) isConnected = true;
            if (isConnected == true)
            {
                if (frmLog.ChucVu == "NV")
                {
                    boxTicket.Enabled = true;
                    Setting_btn.Enabled = true;
                    Login_btn.Enabled = false;
                    Logout_btn.Enabled = true;
                }
                else if (frmLog.ChucVu == "DH")
                {
                    boxThuoc.Enabled = true;
                    boxNhanVien.Enabled = true;
                    Setting_btn.Enabled = true;
                    Login_btn.Enabled = false;
                    Logout_btn.Enabled = true;
                }
                else if (frmLog.ChucVu == "DS")
                {
                    boxThuoc.Enabled = true;
                    Setting_btn.Enabled = true;
                    Login_btn.Enabled = false;
                    Logout_btn.Enabled = true;
                }
                else
                {
                    boxKhamBenh.Enabled = true;
                    Setting_btn.Enabled = true;
                    Login_btn.Enabled = false;
                    Logout_btn.Enabled = true;
                }
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) this.Close();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            _username = "";
            isConnected = false;
            boxTicket.Enabled = false;
            boxKhamBenh.Enabled = false;
            boxThuoc.Enabled = false;
            boxNhanVien.Enabled = false;
            Setting_btn.Enabled = false;
            Logout_btn.Enabled = false;
            Login_btn.Enabled = true;
        }
    }
}
