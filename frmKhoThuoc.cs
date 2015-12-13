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
using System.Data.SqlClient;
namespace Hospital_Pilot
{
    public partial class frmKhoThuoc : DevExpress.XtraEditors.XtraForm
    {
        SqlDatabase db = new SqlDatabase();
        frmThemThuoc frmThemThuoc;
        frmTimThuoc1 frmTimThuoc;
        DataTable data;
//public List<Thuoc> data = new List<Thuoc>();
        public frmKhoThuoc()
        {
            InitializeComponent();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void KhoThuoc_Load(object sender, EventArgs e)
        {
            data = db.GetDataTable("SELECT * FROM THUOC");
            bindingSource.DataSource = data;
            gridControl1.DataSource = bindingSource;

        }

        private void Them_btn_Click(object sender, EventArgs e)
        {
            frmThemThuoc = new frmThemThuoc();
            frmThemThuoc.TopLevel = true;
            frmThemThuoc.ShowInTaskbar = false;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                frmThemThuoc.ShowDialog();
                data = db.GetDataTable("SELECT * FROM THUOC");
                bindingSource.DataSource = data;
                gridControl1.DataSource = bindingSource; 
            }
            else MessageBox.Show("Vui lòng bật Caplock để thực hiện việc thêm thuốc mới\nMở Caplock và chọn Thêm thuốc", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


        }

        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("MATHUOC") == null)
            {
                this.bindingSource.CancelEdit();
            }
            else {
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa Thuốc này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataAccess.DeleteGeneric(new { MATHUOC = gridView1.GetFocusedRowCellValue(MATHUOC) }, "THUOC");
                    this.bindingSource.RemoveCurrent();
                    gridView1.RefreshData();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmTimThuoc = new frmTimThuoc1();
            frmTimThuoc.TopLevel = true;
            frmTimThuoc.ShowInTaskbar = false;
            frmTimThuoc.ShowDialog();
        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
            data.AcceptChanges();
            bindingSource.DataSource = data;
            gridControl1.DataSource = bindingSource; 
        }


    }
}