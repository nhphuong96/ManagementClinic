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
        frmTimKiemNguoiBenh frmNguoiBenh = new frmTimKiemNguoiBenh();
        SqlDatabase db = new SqlDatabase();
        BenhNhan tmpNguoiBenh;

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
            DataTable data = db.GetDataTable("SELECT HOLOT +' '+ TENBS, GIOITINH, HOCVI, TENDONVI FROM BACSI INNER JOIN KHOA ON BACSI.KHOA = KHOA.MAKHOA INNER JOIN DONVI ON BACSI.DONVI = DONVI.MADV WHERE MABS LIKE '"+ mabs_combobox.Text +"'");
            tenbs_txt.Text = data.Rows[0][0].ToString();
            gioitinh_txt.Text = data.Rows[0][1].ToString();
            hocvi_txt.Text = data.Rows[0][2].ToString();
            donvi_txt.Text = data.Rows[0][3].ToString();
            searchDoctor_btn.Enabled = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(thuoc_txt.Text);
            lvi.SubItems.Add(soluong_txt.Text);
            lvi.SubItems.Add(donvitinh_combobox.Text);
            lvi.SubItems.Add(cachsudung_txt.Text);
            listView1.Items.Add(lvi);
            thuoc_txt.Text = "";
            soluong_txt.Text = "";
            donvitinh_combobox.Text = "";
            cachsudung_txt.Text = "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            listView1.SelectedItems[0].Remove();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = ThuocprintDocument;
            ThuocprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(TaoToaThuoc);
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ThuocprintDocument.Print();
            }
            DataAccess.UpdateGeneric(new { MABN = frmNguoiBenh.manguoibenh }, "CHANDOAN");
            tenNguoiBenh_textBox.Text = "";
            gioitinhBN_txt.Text = "";
            namsinh_textBox.Text = "";
            diachi_txt.Text = "";
            chandoan_txt.Text = "";
            loidan_txt.Text = "";
            listView1.Clear();
        }
        public void TaoToaThuoc(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            graphic.DrawString("               TOA THUỐC", new Font("Times New Roman", 30), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 10;
            offset += (int)fontHeight + 20;
            graphic.DrawString("Họ tên: " + tenNguoiBenh_textBox.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 10;
            graphic.DrawString("Giới tính: " + gioitinhBN_txt.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 10;
            graphic.DrawString("Năm sinh: " + namsinh_textBox.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 10;
            graphic.DrawString("Địa chỉ: " + diachi_txt.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 10;
            graphic.DrawString("Chẩn đoán: " + chandoan_txt.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 30;
            int i = 1;
            foreach (ListViewItem item in listView1.Items) {
                string thuoc = "";
                for (int j = 0; j < listView1.Columns.Count ; j++)
                {
                    if (j != 3)
                       thuoc += item.SubItems[j].Text.ToString()+"   ";
                    else {
                        thuoc+= "\n" + item.SubItems[j].Text.ToString();
                    }
                }   
                graphic.DrawString(i.ToString() + ".  " + thuoc, font, Brushes.Black, startX, startY + offset);
                offset += (int)fontHeight + 40;
                i++;
            }
            offset = 800;
            graphic.DrawString("Dặn dò: \n" + loidan_txt.Text , new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Ngày " + DateTime.Today.Day.ToString() + " tháng " + DateTime.Today.Month.ToString() + " năm " + DateTime.Today.Year.ToString(), new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX + 400, startY + offset);
            graphic.DrawString("         Bác sĩ điều trị", new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX + 400, startY + offset + (int)fontHeight + 10);
            offset += (int)fontHeight + 150;
            string date = dateTimePicker1.Value.ToString("dd/mm/yyyy");
            graphic.DrawString("Tái khám: " + date, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX,startY+offset);
            graphic.DrawString("    " + hocvi_txt.Text.Trim()+ "." + tenbs_txt.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX + 400, startY + offset);
        }

    }
}