namespace Hospital_Pilot
{
    partial class frmTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicket));
            this.tenNguoiBenh_textBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.namsinh_textBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBN = new DevExpress.XtraEditors.GroupControl();
            this.thanhpho_combobox = new System.Windows.Forms.ComboBox();
            this.doituong_comboBox = new System.Windows.Forms.ComboBox();
            this.gioitinh_ComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ThemBenhNhan_btn = new DevExpress.XtraEditors.SimpleButton();
            this.donvi_combobox = new System.Windows.Forms.ComboBox();
            this.khoa_combobox = new System.Windows.Forms.ComboBox();
            this.clearAll_btn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.phong_textBox = new DevExpress.XtraEditors.TextEdit();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.tenNguoiBenh_textBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namsinh_textBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBN)).BeginInit();
            this.groupBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phong_textBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tenNguoiBenh_textBox
            // 
            this.tenNguoiBenh_textBox.Location = new System.Drawing.Point(107, 37);
            this.tenNguoiBenh_textBox.Name = "tenNguoiBenh_textBox";
            this.tenNguoiBenh_textBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNguoiBenh_textBox.Properties.Appearance.Options.UseFont = true;
            this.tenNguoiBenh_textBox.Size = new System.Drawing.Size(155, 22);
            this.tenNguoiBenh_textBox.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên người bệnh";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Năm sinh";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Giới tính";
            // 
            // namsinh_textBox
            // 
            this.namsinh_textBox.Location = new System.Drawing.Point(107, 115);
            this.namsinh_textBox.Name = "namsinh_textBox";
            this.namsinh_textBox.Size = new System.Drawing.Size(67, 20);
            this.namsinh_textBox.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tỉnh/TP";
            // 
            // groupBN
            // 
            this.groupBN.Controls.Add(this.thanhpho_combobox);
            this.groupBN.Controls.Add(this.doituong_comboBox);
            this.groupBN.Controls.Add(this.namsinh_textBox);
            this.groupBN.Controls.Add(this.gioitinh_ComboBox);
            this.groupBN.Controls.Add(this.labelControl5);
            this.groupBN.Controls.Add(this.tenNguoiBenh_textBox);
            this.groupBN.Controls.Add(this.labelControl1);
            this.groupBN.Controls.Add(this.labelControl4);
            this.groupBN.Controls.Add(this.labelControl2);
            this.groupBN.Controls.Add(this.labelControl3);
            this.groupBN.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBN.Location = new System.Drawing.Point(0, 0);
            this.groupBN.Name = "groupBN";
            this.groupBN.Size = new System.Drawing.Size(278, 555);
            this.groupBN.TabIndex = 8;
            this.groupBN.Text = "Thông tin người bệnh";
            // 
            // thanhpho_combobox
            // 
            this.thanhpho_combobox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhpho_combobox.FormattingEnabled = true;
            this.thanhpho_combobox.Items.AddRange(new object[] {
            "TP. Hồ Chí Minh",
            "Hà Nội",
            "Tuyên Quang",
            "Hải Phòng",
            "Đà Nẵng",
            "Cần Thơ",
            "Quy Nhơn",
            "Nha Trang"});
            this.thanhpho_combobox.Location = new System.Drawing.Point(107, 155);
            this.thanhpho_combobox.Name = "thanhpho_combobox";
            this.thanhpho_combobox.Size = new System.Drawing.Size(155, 24);
            this.thanhpho_combobox.TabIndex = 12;
            // 
            // doituong_comboBox
            // 
            this.doituong_comboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doituong_comboBox.FormattingEnabled = true;
            this.doituong_comboBox.Items.AddRange(new object[] {
            "Thu phí",
            "Miễn phí",
            "BHYT"});
            this.doituong_comboBox.Location = new System.Drawing.Point(107, 197);
            this.doituong_comboBox.Name = "doituong_comboBox";
            this.doituong_comboBox.Size = new System.Drawing.Size(155, 24);
            this.doituong_comboBox.TabIndex = 11;
            // 
            // gioitinh_ComboBox
            // 
            this.gioitinh_ComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioitinh_ComboBox.FormattingEnabled = true;
            this.gioitinh_ComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioitinh_ComboBox.Location = new System.Drawing.Point(107, 72);
            this.gioitinh_ComboBox.Name = "gioitinh_ComboBox";
            this.gioitinh_ComboBox.Size = new System.Drawing.Size(67, 24);
            this.gioitinh_ComboBox.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(12, 201);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Đối tượng";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.phong_textBox);
            this.groupControl1.Controls.Add(this.ThemBenhNhan_btn);
            this.groupControl1.Controls.Add(this.donvi_combobox);
            this.groupControl1.Controls.Add(this.khoa_combobox);
            this.groupControl1.Controls.Add(this.clearAll_btn);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(0, 251);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(278, 311);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Thông tin phòng khám";
            // 
            // ThemBenhNhan_btn
            // 
            this.ThemBenhNhan_btn.Location = new System.Drawing.Point(148, 206);
            this.ThemBenhNhan_btn.Name = "ThemBenhNhan_btn";
            this.ThemBenhNhan_btn.Size = new System.Drawing.Size(103, 39);
            this.ThemBenhNhan_btn.TabIndex = 18;
            this.ThemBenhNhan_btn.Text = "Thêm bệnh nhân";
            this.ThemBenhNhan_btn.Click += new System.EventHandler(this.ThemBenhNhan_btn_Click);
            // 
            // donvi_combobox
            // 
            this.donvi_combobox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donvi_combobox.FormattingEnabled = true;
            this.donvi_combobox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.donvi_combobox.Location = new System.Drawing.Point(107, 76);
            this.donvi_combobox.Name = "donvi_combobox";
            this.donvi_combobox.Size = new System.Drawing.Size(155, 24);
            this.donvi_combobox.TabIndex = 16;
            this.donvi_combobox.SelectedIndexChanged += new System.EventHandler(this.donvi_combobox_SelectedIndexChanged);
            // 
            // khoa_combobox
            // 
            this.khoa_combobox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoa_combobox.FormattingEnabled = true;
            this.khoa_combobox.Location = new System.Drawing.Point(107, 36);
            this.khoa_combobox.Name = "khoa_combobox";
            this.khoa_combobox.Size = new System.Drawing.Size(155, 24);
            this.khoa_combobox.TabIndex = 13;
            this.khoa_combobox.SelectedIndexChanged += new System.EventHandler(this.khoa_combobox_SelectedIndexChanged);
            // 
            // clearAll_btn
            // 
            this.clearAll_btn.Location = new System.Drawing.Point(26, 206);
            this.clearAll_btn.Name = "clearAll_btn";
            this.clearAll_btn.Size = new System.Drawing.Size(100, 39);
            this.clearAll_btn.TabIndex = 14;
            this.clearAll_btn.Text = "Xóa hết";
            this.clearAll_btn.Click += new System.EventHandler(this.clearAll_btn_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(12, 40);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 14);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Tên khoa";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(12, 121);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 14);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Số phòng";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(12, 80);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(34, 14);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Đơn vị";
            // 
            // phong_textBox
            // 
            this.phong_textBox.Location = new System.Drawing.Point(107, 119);
            this.phong_textBox.Name = "phong_textBox";
            this.phong_textBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phong_textBox.Properties.Appearance.Options.UseFont = true;
            this.phong_textBox.Properties.Mask.EditMask = "d";
            this.phong_textBox.Properties.ReadOnly = true;
            this.phong_textBox.Size = new System.Drawing.Size(67, 22);
            this.phong_textBox.TabIndex = 11;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.printPreviewControl1.Location = new System.Drawing.Point(268, 0);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(568, 555);
            this.printPreviewControl1.TabIndex = 11;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // frmTicket
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 555);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBN);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(852, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(852, 528);
            this.Name = "frmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Phiếu";
            this.Load += new System.EventHandler(this.frmTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tenNguoiBenh_textBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namsinh_textBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBN)).EndInit();
            this.groupBN.ResumeLayout(false);
            this.groupBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phong_textBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tenNguoiBenh_textBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit namsinh_textBox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupBN;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.ComboBox gioitinh_ComboBox;
        private System.Windows.Forms.ComboBox thanhpho_combobox;
        private System.Windows.Forms.ComboBox doituong_comboBox;
        private DevExpress.XtraEditors.SimpleButton ThemBenhNhan_btn;
        private System.Windows.Forms.ComboBox donvi_combobox;
        private System.Windows.Forms.ComboBox khoa_combobox;
        private DevExpress.XtraEditors.SimpleButton clearAll_btn;
        private DevExpress.XtraEditors.TextEdit phong_textBox;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}