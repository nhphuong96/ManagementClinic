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
using DatabaseLib;

namespace Hospital_Pilot
{
    public partial class frmTimKiemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        SqlDatabase db = new SqlDatabase();
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (string.IsNullOrEmpty(manhanvien_txt.Text) && string.IsNullOrEmpty(holot_txt.Text) && string.IsNullOrEmpty(tennv_txt.Text) && string.IsNullOrEmpty(ngaybatdau2_txt.Text) && string.IsNullOrEmpty(ngayketthuc2_txt.Text) && string.IsNullOrEmpty(ngaybatdau1_txt.Text) && string.IsNullOrEmpty(ngayketthuc1_txt.Text))
                {
                    ErrorCatcher.SetError(manhanvien_txt, "Thiếu thông tin tìm kiếm");
                }
                else
                {
                    ErrorCatcher.Clear();
                    if (!string.IsNullOrEmpty(manhanvien_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM NHANVIEN WHERE MANV LIKE '" + manhanvien_txt.Text + "'");
                        bindingSource.DataSource = dtb;
                        gridControl1.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(holot_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM NHANVIEN WHERE HOLOT LIKE N'%" + holot_txt.Text + "%'");
                        bindingSource.DataSource = dtb;
                        gridControl1.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(tennv_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM NHANVIEN WHERE TENNV LIKE N'%" + tennv_txt.Text + "%'");
                        bindingSource.DataSource = dtb;
                        gridControl1.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(ngayketthuc2_txt.Text) && !string.IsNullOrEmpty(ngaybatdau2_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM NHANVIEN WHERE NGAYLAMVIEC BETWEEN '" + Convert.ToDateTime(ngaybatdau1_txt.Text).ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + Convert.ToDateTime(ngayketthuc2_txt.Text).ToString("yyyy-MM-dd hh:mm:ss") + "'");
                        bindingSource.DataSource = dtb;
                        gridControl1.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(ngayketthuc2_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM NHANVIEN WHERE NGAYLAMVIEC <= '" + Convert.ToDateTime(ngayketthuc2_txt.Text).ToString() + "'");
                        bindingSource.DataSource = dtb;
                        gridControl1.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(ngaybatdau2_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM NHANVIEN WHERE NGAYLAMVIEC >= '" + Convert.ToDateTime(ngaybatdau2_txt.Text).ToString());
                        bindingSource.DataSource = dtb;
                        gridControl1.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(ngayketthuc1_txt.Text) && !string.IsNullOrEmpty(ngaybatdau1_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM NHANVIEN WHERE NGAYSINH BETWEEN '" + (DateTime.ParseExact(ngaybatdau2_txt.Text, "dd/mm/yyyy", null)).ToString() + "' AND '" + (DateTime.ParseExact(ngayketthuc2_txt.Text, "dd/mm/yyyy", null)).ToString() + "'");
                        bindingSource.DataSource = dtb;
                        gridControl1.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(ngayketthuc1_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM NHANVIEN WHERE NGAYSINH <= '" + Convert.ToDateTime(ngayketthuc2_txt.Text).ToString() + "'");
                        bindingSource.DataSource = dtb;
                        gridControl1.DataSource = bindingSource;
                    }
                    if (!string.IsNullOrEmpty(ngaybatdau1_txt.Text))
                    {
                        DataTable dtb = db.GetDataTable("SELECT * FROM NHANVIEN WHERE NGAYSINH >= '" + Convert.ToDateTime(ngaybatdau2_txt.Text).ToString()+ "'");
                        bindingSource.DataSource = dtb;
                        gridControl1.DataSource = bindingSource;
                    }
                }
            //}
            //catch (Exception)
            //{
                //MessageBox.Show("Giá trị tìm kiếm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            manhanvien_txt.Text = "";
            holot_txt.Text = "";
            tennv_txt.Text = "";
            ngayketthuc1_txt.Text = "";
            ngaybatdau1_txt.Text = "";
            ngaybatdau2_txt.Text = "";
            ngayketthuc2_txt.Text = "";
        }


    }
}