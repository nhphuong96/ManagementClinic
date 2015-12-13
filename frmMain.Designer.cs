namespace Hospital_Pilot
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup5 = new DevExpress.XtraEditors.TileGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Logout_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Exit_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Login_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Setting_btn = new DevExpress.XtraEditors.SimpleButton();
            this.boxKhamBenh = new System.Windows.Forms.GroupBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.boxThuoc = new System.Windows.Forms.GroupBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.boxNhanVien = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.boxTicket = new System.Windows.Forms.GroupBox();
            this.Ticket_btn = new DevExpress.XtraEditors.SimpleButton();
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.progress_logout = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.boxKhamBenh.SuspendLayout();
            this.boxThuoc.SuspendLayout();
            this.boxNhanVien.SuspendLayout();
            this.boxTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tileGroup4
            // 
            this.tileGroup4.Name = "tileGroup4";
            // 
            // tileGroup5
            // 
            this.tileGroup5.Name = "tileGroup5";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Logout_btn);
            this.panelControl1.Controls.Add(this.Exit_btn);
            this.panelControl1.Controls.Add(this.Login_btn);
            this.panelControl1.Controls.Add(this.Setting_btn);
            this.panelControl1.Controls.Add(this.boxKhamBenh);
            this.panelControl1.Controls.Add(this.boxThuoc);
            this.panelControl1.Controls.Add(this.boxNhanVien);
            this.panelControl1.Controls.Add(this.boxTicket);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(984, 99);
            this.panelControl1.TabIndex = 1;
            // 
            // Logout_btn
            // 
            this.Logout_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.Appearance.Options.UseFont = true;
            this.Logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("Logout_btn.Image")));
            this.Logout_btn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Logout_btn.Location = new System.Drawing.Point(815, 24);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(78, 57);
            this.Logout_btn.TabIndex = 7;
            this.Logout_btn.Text = "Đăng Xuất";
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Appearance.Options.UseFont = true;
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Exit_btn.Location = new System.Drawing.Point(899, 24);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(59, 57);
            this.Exit_btn.TabIndex = 6;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Appearance.Options.UseFont = true;
            this.Login_btn.Image = ((System.Drawing.Image)(resources.GetObject("Login_btn.Image")));
            this.Login_btn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Login_btn.Location = new System.Drawing.Point(731, 24);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(78, 57);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Đăng Nhập";
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Setting_btn
            // 
            this.Setting_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_btn.Appearance.Options.UseFont = true;
            this.Setting_btn.Image = ((System.Drawing.Image)(resources.GetObject("Setting_btn.Image")));
            this.Setting_btn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Setting_btn.Location = new System.Drawing.Point(662, 24);
            this.Setting_btn.Name = "Setting_btn";
            this.Setting_btn.Size = new System.Drawing.Size(63, 57);
            this.Setting_btn.TabIndex = 4;
            this.Setting_btn.Text = "Cài đặt";
            // 
            // boxKhamBenh
            // 
            this.boxKhamBenh.Controls.Add(this.simpleButton4);
            this.boxKhamBenh.Location = new System.Drawing.Point(130, 5);
            this.boxKhamBenh.Name = "boxKhamBenh";
            this.boxKhamBenh.Size = new System.Drawing.Size(120, 83);
            this.boxKhamBenh.TabIndex = 3;
            this.boxKhamBenh.TabStop = false;
            this.boxKhamBenh.Text = "Khám chữa bệnh";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.AutoSize = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton4.Location = new System.Drawing.Point(19, 19);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(84, 58);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "Khám bệnh";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // boxThuoc
            // 
            this.boxThuoc.Controls.Add(this.simpleButton5);
            this.boxThuoc.Controls.Add(this.simpleButton3);
            this.boxThuoc.Location = new System.Drawing.Point(265, 5);
            this.boxThuoc.Name = "boxThuoc";
            this.boxThuoc.Size = new System.Drawing.Size(189, 83);
            this.boxThuoc.TabIndex = 3;
            this.boxThuoc.TabStop = false;
            this.boxThuoc.Text = "Quản lí thuốc";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton5.Location = new System.Drawing.Point(85, 19);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(86, 58);
            this.simpleButton5.TabIndex = 2;
            this.simpleButton5.Text = "Cấp thuốc";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton3.Location = new System.Drawing.Point(20, 19);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(59, 58);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "Kho";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // boxNhanVien
            // 
            this.boxNhanVien.Controls.Add(this.simpleButton1);
            this.boxNhanVien.Controls.Add(this.simpleButton2);
            this.boxNhanVien.Location = new System.Drawing.Point(469, 5);
            this.boxNhanVien.Name = "boxNhanVien";
            this.boxNhanVien.Size = new System.Drawing.Size(187, 83);
            this.boxNhanVien.TabIndex = 2;
            this.boxNhanVien.TabStop = false;
            this.boxNhanVien.Text = "Thông tin Nhân viên";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(99, 19);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(71, 58);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Bác sĩ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AutoSize = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(18, 19);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 58);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Nhân viên";
            // 
            // boxTicket
            // 
            this.boxTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxTicket.Controls.Add(this.Ticket_btn);
            this.boxTicket.Location = new System.Drawing.Point(12, 5);
            this.boxTicket.Name = "boxTicket";
            this.boxTicket.Size = new System.Drawing.Size(102, 83);
            this.boxTicket.TabIndex = 2;
            this.boxTicket.TabStop = false;
            this.boxTicket.Text = "Sảnh";
            // 
            // Ticket_btn
            // 
            this.Ticket_btn.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticket_btn.Appearance.Options.UseFont = true;
            this.Ticket_btn.Image = ((System.Drawing.Image)(resources.GetObject("Ticket_btn.Image")));
            this.Ticket_btn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Ticket_btn.Location = new System.Drawing.Point(16, 20);
            this.Ticket_btn.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red;
            this.Ticket_btn.Name = "Ticket_btn";
            this.Ticket_btn.Size = new System.Drawing.Size(68, 57);
            this.Ticket_btn.TabIndex = 2;
            this.Ticket_btn.Tag = "";
            this.Ticket_btn.Text = "In phiếu";
            this.Ticket_btn.Click += new System.EventHandler(this.Ticket_btn_Click);
            // 
            // mdiManager
            // 
            this.mdiManager.MdiParent = this;
            // 
            // progress_logout
            // 
            this.progress_logout.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progress_logout.Appearance.Options.UseBackColor = true;
            this.progress_logout.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progress_logout.Description = "Logging out ...";
            this.progress_logout.Location = new System.Drawing.Point(350, 212);
            this.progress_logout.Name = "progress_logout";
            this.progress_logout.Size = new System.Drawing.Size(246, 66);
            this.progress_logout.TabIndex = 2;
            this.progress_logout.Text = "progressPanel1";
            this.progress_logout.Visible = false;
            this.progress_logout.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.progress_logout);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.Yellow;
            this.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Pilot Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.boxKhamBenh.ResumeLayout(false);
            this.boxKhamBenh.PerformLayout();
            this.boxThuoc.ResumeLayout(false);
            this.boxNhanVien.ResumeLayout(false);
            this.boxNhanVien.PerformLayout();
            this.boxTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileGroup tileGroup5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox boxTicket;
        private DevExpress.XtraEditors.SimpleButton Ticket_btn;
        private System.Windows.Forms.GroupBox boxKhamBenh;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.GroupBox boxThuoc;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox boxNhanVien;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton Login_btn;
        private DevExpress.XtraEditors.SimpleButton Setting_btn;
        private DevExpress.XtraEditors.SimpleButton Exit_btn;
        private DevExpress.XtraEditors.SimpleButton Logout_btn;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
        private DevExpress.XtraWaitForm.ProgressPanel progress_logout;





    }
}

