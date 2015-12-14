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
    public partial class frmCapThuoc : DevExpress.XtraEditors.XtraForm
    {
        SqlDatabase db = new SqlDatabase();
        frmTimKiemNguoiBenh frmNguoiBenh = new frmTimKiemNguoiBenh();
        frmChonThuoc frmChonThuoc;
        int Total = 0;
        public frmCapThuoc()
        {
            InitializeComponent();
        }

        private void frmCapThuoc_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmNguoiBenh.TopLevel = true;
            frmNguoiBenh.ShowInTaskbar = false;
            frmNguoiBenh.ShowDialog();
            DataTable data = db.GetDataTable("SELECT HOTEN,GIOITINH,NAMSINH,DIACHI FROM BENHNHAN WHERE MABN LIKE '" + frmNguoiBenh.manguoibenh + "'");
            tennguoibenh_txt.Text = data.Rows[0][0].ToString();
            gioitinh_txt.Text = data.Rows[0][1].ToString();
            diachi_txt.Text = data.Rows[0][3].ToString();
            groupThemThuoc.Enabled = true;
            DataTable dataThuoc = db.GetDataTable("SELECT TENTHUOC FROM THUOC");
            AutoCompleteStringCollection data1 = new AutoCompleteStringCollection();
            foreach (DataRow row in dataThuoc.Rows)
            {
                data1.Add(row[0].ToString());
            }
            thuoc_txt.AutoCompleteCustomSource = data1;
        }

        private void capthuoc_btn_Click(object sender, EventArgs e)
        {
            frmChonThuoc = new frmChonThuoc();
            frmChonThuoc.TopLevel = true;
            frmChonThuoc.ShowInTaskbar = false;
            frmChonThuoc.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = db.GetDataTable("SELECT * FROM THUOC WHERE TENTHUOC LIKE '%" + thuoc_txt.Text + "%'");
                ListViewItem lvi = new ListViewItem(thuoc_txt.Text);
                lvi.SubItems.Add(soluong_txt.Text);
                lvi.SubItems.Add(donvitinh_combobox.Text);
                lvi.SubItems.Add(data.Rows[0][3].ToString());
                int result = Convert.ToInt32(soluong_txt.Text) * Convert.ToInt32(data.Rows[0][3].ToString());
                lvi.SubItems.Add(result.ToString());
                listView1.Items.Add(lvi);
                thuoc_txt.Text = "";
                soluong_txt.Text = "";
                donvitinh_combobox.Text = "";
            }
            catch (Exception) {
                MessageBox.Show("Thiếu dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                Total += Convert.ToInt32(item.SubItems[4].Text.ToString());
            }
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = ThuocprintDocument;
            ThuocprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(TaoHoaDon);
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ThuocprintDocument.Print();
            }
            tennguoibenh_txt.Text = "";
            gioitinh_txt.Text = "";
            diachi_txt.Text = "";
            listView1.Items.Clear();
        }
        public void TaoHoaDon(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startX = 150;
            int startY = 40;
            int offset = 40;

            graphic.DrawString("                     Hospital Pilot Software", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startX, startY);
            offset = offset + (int)fontHeight + 10;
            offset += (int)fontHeight + 20;
            graphic.DrawString("                 HÓA ĐƠN", new Font("Times New Roman", 30), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 10;
            offset += (int)fontHeight + 20;
            graphic.DrawString("Họ tên: " + tennguoibenh_txt.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 10;
            graphic.DrawString("Giới tính: " + gioitinh_txt.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 10;
            graphic.DrawString("Địa chỉ: " + diachi_txt.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 30;
            int i = 1;
            foreach (ListViewItem item in listView1.Items)
            {
                string thuoc = "";
                for (int j = 0; j < listView1.Columns.Count; j++)
                {
                    if (j != 1)
                        thuoc += item.SubItems[j].Text.ToString() + "   ";
                    else
                    {
                        thuoc += "\n" + item.SubItems[j].Text.ToString();
                    }
                }
                graphic.DrawString(i.ToString() + ".  " + thuoc, font, Brushes.Black, startX, startY + offset);
                offset += (int)fontHeight + 40;
                i++;
            }
            offset = 800;
            graphic.DrawString("TỔNG CỘNG: " + Total.ToString()+" đồng", new Font("Times New Roman", 28), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("    Người cấp thuốc".PadRight(80) + "Người nhận thuốc", new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset +50);
        }
    }
}