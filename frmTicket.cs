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
using System.Drawing.Printing;
using DatabaseLib;


namespace Hospital_Pilot
{
    public partial class frmTicket : DevExpress.XtraEditors.XtraForm
    {
        public List<BenhNhan> data = new List<BenhNhan>();
        SqlDatabase db = new SqlDatabase();
        public string _username = "";
        PrintPreviewDialog printPreview = new PrintPreviewDialog();

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
            diachi_txt.Text = "";
            xemtruocphieu_btn.Enabled = false;
        }



        private void ThemBenhNhan_btn_Click(object sender, EventArgs e)
        {
            var item = new BenhNhan();
            item.Hoten = tenNguoiBenh_textBox.Text;
            item.Gioitinh = gioitinh_ComboBox.Text;
            item.Namsinh = Convert.ToInt32(namsinh_textBox.Text);
            item.Diachi = diachi_txt.Text;
            item.Donvi = donvi_combobox.Text;
            data.Add(item);
            DataAccess.InsertGeneric(item);
            xemtruocphieu_btn.Enabled = true;
        }

        public void TaoPhieu(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            DataTable dtb = db.GetDataTable("SELECT DIADIEM FROM DONVI WHERE TENDONVI LIKE N'"+ donvi_combobox.SelectedValue.ToString() +"'");
            string diadiem = dtb.Rows[0][0].ToString();
                Graphics graphic = e.Graphics;
                Font font = new Font("Courier New", 14);
                float fontHeight = font.GetHeight();
                int startX = 20;
                int startY = 10;
                int offset = 40;

                graphic.DrawString("  Hospital Pilot Software", new Font("Times New Roman", 20), new SolidBrush(Color.Black), startX, startY);
                graphic.DrawString(diadiem, new Font("Times New Roman", 18), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 10;
                int data = db.GetDataScalar("SELECT PHONG FROM DONVI WHERE TENDONVI LIKE N'" + donvi_combobox.SelectedValue.ToString() + "'");
                graphic.DrawString("Phòng khám: Phòng "+ data.ToString(), new Font("Times New Roman", 18), new SolidBrush(Color.Black),startX, startY + offset);
                offset += (int)fontHeight + 10;
                graphic.DrawString("Số thứ tự khám " + donvi_combobox.SelectedValue.ToString(), new Font("Times New Roman", 18), new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight + 10;
                graphic.DrawString(BenhNhan._mabn.ToString(), new Font("Times New Roman", 28), new SolidBrush(Color.Black), startX+80, startY + offset);
                offset += (int)fontHeight + 40;
                graphic.DrawString("Họ tên: " + tenNguoiBenh_textBox.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight + 10;
                graphic.DrawString("Giới tính: " + gioitinh_ComboBox.Text.PadRight(10) + "Năm sinh: " + namsinh_textBox.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight + 10;
                graphic.DrawString("Tỉnh/TP: " + thanhpho_combobox.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight + 10;
                graphic.DrawString("Đối tượng: " + doituong_comboBox.Text, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight + 10;
                graphic.DrawString("Ngày khám: " + DateTime.Today.ToString("d/m/yyyy"), new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight + 10;
                graphic.DrawString("Số hồ sơ: " + BenhNhan._mabn, new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight + 10;
                DataTable tennv = db.GetDataTable("SELECT HOLOT + ' ' + TENNV FROM TAIKHOAN INNER JOIN  NHANVIEN ON TAIKHOAN.MANV = NHANVIEN.MANV WHERE TENTK LIKE '" + _username + "'");
                graphic.DrawString("Nhân viên: " + tennv.Rows[0][0].ToString(), new Font("Times New Roman", 14), new SolidBrush(Color.Black), startX, startY + offset );
        }

        private void xemtruocphieu_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(TaoPhieu);
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK) {
                printDocument1.Print();
            }
        }


       



    }
}