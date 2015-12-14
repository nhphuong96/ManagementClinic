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
    public partial class frmChonThuoc : DevExpress.XtraEditors.XtraForm
    {
        SqlDatabase db = new SqlDatabase();
        public frmChonThuoc()
        {
            InitializeComponent();
        }

        private void frmChonThuoc_Load(object sender, EventArgs e)
        {
            DataTable dataThuoc = db.GetDataTable("SELECT REPLACE(TENTHUOC, ' ', '') FROM THUOC");
            AutoCompleteStringCollection data1 = new AutoCompleteStringCollection();
            foreach (DataRow row in dataThuoc.Rows)
            {
                data1.Add(row[0].ToString());
            }
            thuoc_txt.AutoCompleteCustomSource = data1;
        }
    }
}