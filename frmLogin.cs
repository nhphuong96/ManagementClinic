using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Hospital_Pilot
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public string username="";
        public bool isConnected = false;
        public string ChucVu = "";
        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            groupLogin.Enabled = false;
            Login_btn.Enabled = false;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupLogin.Enabled = true;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            progress_login.Visible = true;
            SqlDatabase db = new SqlDatabase();
            var chucvu = NhomNV.EditValue.ToString();
            DataTable data = db.GetDataTable("select * from TAIKHOAN inner join NHANVIEN on TAIKHOAN.MANV = NHANVIEN.MANV where TENTK LIKE '" + user_txt.Text + "' AND MATKHAU like '" + pass_txt.Text + "' AND NHOMNV LIKE '" + chucvu + "' AND TRANGTHAI LIKE 'Available'");            
            progress_login.Visible = true;
            if (data.Rows.Count > 0)
            {
                var t = Task.Delay(1000); //1 second/1000 ms
                t.Wait();
                progress_login.Visible = false;
                MessageBox.Show("Đăng nhập thành công");
                username = user_txt.Text;
                isConnected = true;
                ChucVu = chucvu;
                this.Dispose();
            }
            else MessageBox.Show("Đăng nhập thất bại");
        }

        private void user_txt_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (user_txt.Text.Length > 0) Login_btn.Enabled = true;
        }



    }
}