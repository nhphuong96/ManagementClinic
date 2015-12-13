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
    public partial class frmThemThuoc : DevExpress.XtraEditors.XtraForm
    {

        public frmThemThuoc()
        {
            InitializeComponent();
        }




        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemThuoc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(mathuoc_txt.Text) || string.IsNullOrEmpty(tenthuoc_txt.Text) || string.IsNullOrEmpty(donvitinh_txt.Text) || string.IsNullOrEmpty(dongia_txt.Text))
                {
                    MessageBox.Show("Thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Thuoc item = new Thuoc();
                    item.MaThuoc = mathuoc_txt.Text;
                    item.TenThuoc = tenthuoc_txt.Text;
                    item.DonViTinh = donvitinh_txt.Text;
                    item.DonGia = Convert.ToInt32(dongia_txt.Text);
                    DataAccess.InsertGeneric(item);
                    Error.Clear();
                    MessageBox.Show("Thêm thuốc thành công", "Thông báo");
                    mathuoc_txt.Text = "";
                    tenthuoc_txt.Text = "";
                    donvitinh_txt.Text = "";
                    dongia_txt.Text = "";
                }
            }
            catch (Exception)
            {
                Error.SetError(mathuoc_txt, "Trùng mã thuốc");
            }

        }

        private void frmThemThuoc_Load(object sender, EventArgs e)
        {


        }
    }
}