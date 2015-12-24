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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        SqlDatabase db = new SqlDatabase();
        DataTable data;
        frmThemNhanVien frmThemNhanVien;
        frmTimKiemNhanVien frmTimKiemNhanVien;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            data = db.GetDataTable("SELECT * FROM NHANVIEN");
            bindingSource.DataSource = data;
            gridControl1.DataSource = bindingSource;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmThemNhanVien = new frmThemNhanVien();
            frmThemNhanVien.TopLevel = true;
            frmThemNhanVien.ShowInTaskbar = false;
            frmThemNhanVien.ShowDialog();
            data = db.GetDataTable("SELECT * FROM NHANVIEN");
            bindingSource.DataSource = data;
            gridControl1.DataSource = bindingSource;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("MANV") == null)
            {
                this.bindingSource.CancelEdit();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa Nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataAccess.DeleteGeneric(new { MANV = gridView1.GetFocusedRowCellValue(MANV) }, "NHANVIEN");
                    this.bindingSource.RemoveCurrent();
                    gridView1.RefreshData();
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien = new frmTimKiemNhanVien();
            frmTimKiemNhanVien.TopLevel = true;
            frmTimKiemNhanVien.ShowInTaskbar = false;
            frmTimKiemNhanVien.ShowDialog();
        }

    }
}