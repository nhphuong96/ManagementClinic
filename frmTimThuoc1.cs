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
    public partial class frmTimThuoc1 : DevExpress.XtraEditors.XtraForm
    {
        SqlDatabase db = new SqlDatabase();
        public frmTimThuoc1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(timmathuoc_txt.Text) && string.IsNullOrEmpty(timtenthuoc_txt.Text) && string.IsNullOrEmpty(timdonvitinh_txt.Text) && string.IsNullOrEmpty(giadau_txt.Text) && string.IsNullOrEmpty(giacuoi_txt.Text))
                {
                    ErrorCatcher.SetError(timmathuoc_txt, "Thiếu thông tin tìm kiếm");
                }
                else
                {
                    ErrorCatcher.Clear();
                    if (!string.IsNullOrEmpty(timmathuoc_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM THUOC WHERE MATHUOC LIKE '" + timmathuoc_txt.Text + "'");
                        bindingSource.DataSource = dtb;
                        gridView2.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(timtenthuoc_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM THUOC WHERE TENTHUOC LIKE '%" + timtenthuoc_txt.Text + "%'");
                        bindingSource.DataSource = dtb;
                        gridView2.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(timdonvitinh_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM THUOC WHERE DONVITINH LIKE '%" + timdonvitinh_txt.Text + "%'");
                        bindingSource.DataSource = dtb;
                        gridView2.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(giacuoi_txt.Text) && !string.IsNullOrEmpty(giadau_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM THUOC WHERE DONGIA BETWEEN " + giadau_txt.Text + " AND " + giacuoi_txt.Text);
                        bindingSource.DataSource = dtb;
                        gridView2.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(giacuoi_txt.Text)) {
                        DataTable dtb = db.GetDataTable("SELECT * FROM THUOC WHERE DONGIA <= " +giacuoi_txt.Text);
                        bindingSource.DataSource = dtb;
                        gridView2.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(giadau_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM THUOC WHERE DONGIA >= " + giadau_txt.Text);
                        bindingSource.DataSource = dtb;
                        gridView2.DataSource = bindingSource;
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("Giá trị tìm kiếm không hợp lệ","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            timmathuoc_txt.Text = "";
            timtenthuoc_txt.Text = "";
            timdonvitinh_txt.Text = "";
            giadau_txt.Text = "";
            giacuoi_txt.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tìm gần đúng theo Mã thuốc, Tên thuốc và Đơn vị tính\nRiêng đơn giá nếu bỏ trống ô đầu sẽ tìm kiếm đơn giá nhỏ hơn hoặc bằng ô cuối và ngược lại", "Trợ giúp", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

    }
}