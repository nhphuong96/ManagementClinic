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
    public partial class frmTimKiemNguoiBenh : DevExpress.XtraEditors.XtraForm
    {
        public string manguoibenh = "";
        public frmTimKiemNguoiBenh()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            manguoibenh = manguoibenh_txt.Text;
            this.Close();
        }


    }
}