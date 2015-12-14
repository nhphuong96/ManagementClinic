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
using System.Threading.Tasks;


namespace Hospital_Pilot
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        frmTicket frmTicket;
        frmKhamBenh frmKhamBenh;
        frmKhoThuoc frmKhoThuoc;
        public string _username = "";
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
                Exit_btn.Enabled = false;
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) this.Close();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            progress_logout.Visible = true;
            var t = Task.Delay(2000);
            t.Wait();
            progress_logout.Visible = false;
            _username = "";
            isConnected = false;
            boxTicket.Enabled = false;
            boxKhamBenh.Enabled = false;
            boxThuoc.Enabled = false;
            boxNhanVien.Enabled = false;
            Setting_btn.Enabled = false;
            Logout_btn.Enabled = false;
            Login_btn.Enabled = true;
            Exit_btn.Enabled = true;
            if (frmTicket != null) frmTicket.Dispose();
            MessageBox.Show("Đăng xuất thành công!");
            
        }

        private void Ticket_btn_Click(object sender, EventArgs e)
        {
            frmTicket = new frmTicket();
            frmTicket.MdiParent = this;
            frmTicket._username = this._username;
            frmTicket.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmKhamBenh = new frmKhamBenh();
            frmKhamBenh.TopLevel = true;
            frmKhamBenh.ShowInTaskbar = false;
            frmKhamBenh.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmKhoThuoc = new frmKhoThuoc();
            frmKhoThuoc.TopLevel = true;
            frmKhoThuoc.ShowInTaskbar = false;
            frmKhoThuoc.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
