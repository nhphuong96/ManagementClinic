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
    public partial class frmTicket : DevExpress.XtraEditors.XtraForm
    {
        SqlDatabase db = new SqlDatabase();

        //public List<BenhNhan> list = new List<BenhNhan>();
        public frmTicket()
        {
            InitializeComponent();

        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            DataTable data = db.GetDataTable("select tenkhoa from KHOA");
            khoa_combobox.DataSource = data;
            khoa_combobox.ValueMember = data.Columns[0].ToString();
            khoa_combobox.Text = "";

        }

        private void khoa_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = db.GetDataTable("SELECT TENDONVI, PHONG FROM KHOA INNER JOIN DONVI ON KHOA.MAKHOA = DONVI.KHOA WHERE TENKHOA LIKE N'"+khoa_combobox.SelectedValue.ToString()+"'");
            donvi_combobox.DataSource = data;
            donvi_combobox.ValueMember = data.Columns[0].ToString();
        }

        private void donvi_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int data = db.GetDataScalar("SELECT PHONG FROM DONVI WHERE TENDONVI LIKE N'"+ donvi_combobox.SelectedValue.ToString() +"'");
            phong_textBox.Text = data.ToString();
        }

        private void clearAll_btn_Click(object sender, EventArgs e)
        {
            tenNguoiBenh_textBox.Text = "";
            gioitinh_ComboBox.Text = "";
            namsinh_textBox.Text = "";
            thanhpho_combobox.Text = "";
            doituong_comboBox.Text = "";
            khoa_combobox.Text = "";
            donvi_combobox.Text = "";
            phong_textBox.Text = "";
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void ThemBenhNhan_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }



    }
}