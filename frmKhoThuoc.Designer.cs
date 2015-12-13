namespace Hospital_Pilot
{
    partial class frmKhoThuoc
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Them_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Xoa_btn = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MATHUOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTHUOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONVITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.Them_btn);
            this.groupControl1.Controls.Add(this.Xoa_btn);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(252, 461);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tùy chọn";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(73, 291);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(109, 35);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Tìm kiếm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Them_btn
            // 
            this.Them_btn.Location = new System.Drawing.Point(73, 82);
            this.Them_btn.Name = "Them_btn";
            this.Them_btn.Size = new System.Drawing.Size(109, 35);
            this.Them_btn.TabIndex = 1;
            this.Them_btn.TabStop = false;
            this.Them_btn.Text = "Thêm thuốc";
            this.Them_btn.Click += new System.EventHandler(this.Them_btn_Click);
            // 
            // Xoa_btn
            // 
            this.Xoa_btn.Location = new System.Drawing.Point(73, 187);
            this.Xoa_btn.Name = "Xoa_btn";
            this.Xoa_btn.Size = new System.Drawing.Size(109, 35);
            this.Xoa_btn.TabIndex = 2;
            this.Xoa_btn.TabStop = false;
            this.Xoa_btn.Text = "Xóa thuốc";
            this.Xoa_btn.Click += new System.EventHandler(this.Xoa_btn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(252, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(657, 461);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MATHUOC,
            this.TENTHUOC,
            this.DONVITINH,
            this.DONGIA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // MATHUOC
            // 
            this.MATHUOC.Caption = "Mã thuốc";
            this.MATHUOC.FieldName = "MATHUOC";
            this.MATHUOC.Name = "MATHUOC";
            this.MATHUOC.Visible = true;
            this.MATHUOC.VisibleIndex = 0;
            this.MATHUOC.Width = 60;
            // 
            // TENTHUOC
            // 
            this.TENTHUOC.Caption = "Tên thuốc";
            this.TENTHUOC.FieldName = "TENTHUOC";
            this.TENTHUOC.Name = "TENTHUOC";
            this.TENTHUOC.Visible = true;
            this.TENTHUOC.VisibleIndex = 1;
            // 
            // DONVITINH
            // 
            this.DONVITINH.Caption = "Đơn vị tính";
            this.DONVITINH.FieldName = "DONVITINH";
            this.DONVITINH.Name = "DONVITINH";
            this.DONVITINH.Visible = true;
            this.DONVITINH.VisibleIndex = 2;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "Đơn giá";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 3;
            // 
            // frmKhoThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 461);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frmKhoThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho thuốc";
            this.Load += new System.EventHandler(this.KhoThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Them_btn;
        private DevExpress.XtraEditors.SimpleButton Xoa_btn;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MATHUOC;
        private DevExpress.XtraGrid.Columns.GridColumn TENTHUOC;
        private DevExpress.XtraGrid.Columns.GridColumn DONVITINH;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;

    }
}