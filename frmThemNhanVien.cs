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
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(manhanvien_txt.Text) || string.IsNullOrEmpty(gioitinh_combobox.Text) || string.IsNullOrEmpty(ngaysinh_txt.Text) || string.IsNullOrEmpty(holot_txt.Text) || string.IsNullOrEmpty(tennv_txt.Text) || string.IsNullOrEmpty(NhomNV_combobox.Text) || string.IsNullOrEmpty(ngaylamviec_txt.Text))
                {
                    MessageBox.Show("Thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NhanVien item = new NhanVien();
                    item.MaNV = manhanvien_txt.Text;
                    item.Holot = holot_txt.Text;
                    item.Tennv = tennv_txt.Text;
                    item.Gioitinh = gioitinh_combobox.Text;
                    item.Ngaysinh = Convert.ToDateTime(ngaysinh_txt.Text);
                    item.NhomNV = NhomNV_combobox.Text;
                    item.Ngaylamviec = Convert.ToDateTime(ngaylamviec_txt.Text);
                    DataAccess.InsertGeneric(item);
                    Error.Clear();
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
                    manhanvien_txt.Text = "";
                    holot_txt.Text = "";
                    tennv_txt.Text = "";
                    gioitinh_combobox.Text = "";
                    ngaysinh_txt.Text = "";
                    ngaylamviec_txt.Text = "";
                    NhomNV_combobox.Text = "";
                }
            }
            catch (Exception)
            {
                Error.SetError(manhanvien_txt, "Trùng mã nhân viên");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            manhanvien_txt.Text = "";
            holot_txt.Text = "";
            tennv_txt.Text = "";
            gioitinh_combobox.Text = "";
            ngaysinh_txt.Text = "";
            ngaylamviec_txt.Text = "";
            NhomNV_combobox.Text = "";
        }
    }
}