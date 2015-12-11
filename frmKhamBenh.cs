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
    public partial class frmKhamBenh : DevExpress.XtraEditors.XtraForm
    {
        frmTimKiemBacSi frmtimkiem;
        frmTimKiemNguoiBenh frmNguoiBenh;
        SqlDatabase db = new SqlDatabase();
        public frmKhamBenh()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchDoctor_btn_Click(object sender, EventArgs e)
        {
            frmtimkiem = new frmTimKiemBacSi();
            frmtimkiem.TopLevel = true;
            frmtimkiem.ShowInTaskbar = false;
            frmtimkiem.ShowDialog();
            Group_bacsi.Enabled = true;
            groupBN.Enabled = true;
            timkiemnguoibenh_btn.Enabled = true;
            DataTable data = db.GetDataTable("SELECT MABS FROM BACSI INNER JOIN DONVI ON BACSI.DONVI = DONVI.MADV WHERE TENDONVI LIKE N'" + frmtimkiem.donvi + "'");
            mabs_combobox.DataSource = data;
            mabs_combobox.ValueMember = data.Columns[0].ToString();
        }

        private void mabs_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = db.GetDataTable("SELECT HOLOT +' '+ TENBS, GIOITINH, TENKHOA, TENDONVI FROM BACSI INNER JOIN KHOA ON BACSI.KHOA = KHOA.MAKHOA INNER JOIN DONVI ON BACSI.DONVI = DONVI.MADV WHERE MABS LIKE '"+ mabs_combobox.Text +"'");
            tenbs_txt.Text = data.Rows[0][0].ToString();
            gioitinh_txt.Text = data.Rows[0][1].ToString();
            khoa_txt.Text = data.Rows[0][2].ToString();
            donvi_txt.Text = data.Rows[0][3].ToString();
            searchDoctor_btn.Enabled = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmNguoiBenh = new frmTimKiemNguoiBenh();
            frmNguoiBenh.TopLevel = true;
            frmNguoiBenh.ShowInTaskbar = false;
            frmNguoiBenh.ShowDialog();
            DataTable data = db.GetDataTable("SELECT HOTEN,GIOITINH,NAMSINH,DIACHI FROM BENHNHAN WHERE MABN LIKE '" + frmNguoiBenh.manguoibenh + "'");
            tenNguoiBenh_textBox.Text = data.Rows[0][0].ToString();
            gioitinhBN_txt.Text = data.Rows[0][1].ToString();
            namsinh_textBox.Text = data.Rows[0][2].ToString();
            diachi_txt.Text = data.Rows[0][3].ToString();
            group_benhan.Enabled = true;
            loidan_txt.Enabled = true;
            dateTimePicker1.Enabled = true;
            DataTable dataThuoc = db.GetDataTable("SELECT REPLACE(TENTHUOC, ' ', '') FROM THUOC");
            AutoCompleteStringCollection data1 = new AutoCompleteStringCollection();    
            foreach (DataRow row in dataThuoc.Rows) {
                data1.Add(row[0].ToString());
            }
            thuoc_txt.AutoCompleteCustomSource = data1;

        }

    }
}