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
    public partial class frmTimKiemBacSi : DevExpress.XtraEditors.XtraForm
    {
        public string donvi = "";
        SqlDatabase db = new SqlDatabase();
        public frmTimKiemBacSi()
        {
            InitializeComponent();
        }
        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }
        private void frmTimKiemBacSi_Load(object sender, EventArgs e)
        {
            DataTable data = db.GetDataTable("select tenkhoa from KHOA");
            KHOA_COMBOBOX.DataSource = data;
            KHOA_COMBOBOX.ValueMember = data.Columns[0].ToString();
            KHOA_COMBOBOX.Text = "";
        }

        private void KHOA_COMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = db.GetDataTable("SELECT TENDONVI, PHONG FROM KHOA INNER JOIN DONVI ON KHOA.MAKHOA = DONVI.KHOA WHERE TENKHOA LIKE N'" + KHOA_COMBOBOX.SelectedValue.ToString() + "'");
            donvi_combobox.DataSource = data;
            donvi_combobox.ValueMember = data.Columns[0].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            donvi = donvi_combobox.Text;
            this.Close();
        }



    }
}