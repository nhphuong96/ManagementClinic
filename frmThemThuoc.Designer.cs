namespace Hospital_Pilot
{
    partial class frmThemThuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mathuoc_txt = new DevExpress.XtraEditors.TextEdit();
            this.tenthuoc_txt = new DevExpress.XtraEditors.TextEdit();
            this.dongia_txt = new DevExpress.XtraEditors.TextEdit();
            this.donvitinh_txt = new DevExpress.XtraEditors.TextEdit();
            this.ThemThuoc_btn = new DevExpress.XtraEditors.SimpleButton();
            this.close_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mathuoc_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenthuoc_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongia_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinh_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã thuốc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tên thuốc :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập đơn vị tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập đơn giá :";
            // 
            // mathuoc_txt
            // 
            this.mathuoc_txt.Location = new System.Drawing.Point(163, 36);
            this.mathuoc_txt.Name = "mathuoc_txt";
            this.mathuoc_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathuoc_txt.Properties.Appearance.Options.UseFont = true;
            this.mathuoc_txt.Size = new System.Drawing.Size(165, 22);
            this.mathuoc_txt.TabIndex = 4;
            // 
            // tenthuoc_txt
            // 
            this.tenthuoc_txt.Location = new System.Drawing.Point(163, 89);
            this.tenthuoc_txt.Name = "tenthuoc_txt";
            this.tenthuoc_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenthuoc_txt.Properties.Appearance.Options.UseFont = true;
            this.tenthuoc_txt.Size = new System.Drawing.Size(165, 22);
            this.tenthuoc_txt.TabIndex = 5;
            // 
            // dongia_txt
            // 
            this.dongia_txt.Location = new System.Drawing.Point(163, 203);
            this.dongia_txt.Name = "dongia_txt";
            this.dongia_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongia_txt.Properties.Appearance.Options.UseFont = true;
            this.dongia_txt.Properties.Mask.EditMask = "c0";
            this.dongia_txt.Size = new System.Drawing.Size(165, 22);
            this.dongia_txt.TabIndex = 7;
            // 
            // donvitinh_txt
            // 
            this.donvitinh_txt.Location = new System.Drawing.Point(163, 143);
            this.donvitinh_txt.Name = "donvitinh_txt";
            this.donvitinh_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donvitinh_txt.Properties.Appearance.Options.UseFont = true;
            this.donvitinh_txt.Size = new System.Drawing.Size(87, 22);
            this.donvitinh_txt.TabIndex = 6;
            // 
            // ThemThuoc_btn
            // 
            this.ThemThuoc_btn.Location = new System.Drawing.Point(54, 261);
            this.ThemThuoc_btn.Name = "ThemThuoc_btn";
            this.ThemThuoc_btn.Size = new System.Drawing.Size(103, 42);
            this.ThemThuoc_btn.TabIndex = 9;
            this.ThemThuoc_btn.Text = "Thêm thuốc mới";
            this.ThemThuoc_btn.Click += new System.EventHandler(this.ThemThuoc_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(204, 261);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(103, 42);
            this.close_btn.TabIndex = 10;
            this.close_btn.Text = "Đóng";
            this.close_btn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // frmThemThuoc
            // 
            this.AcceptButton = this.ThemThuoc_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 332);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.ThemThuoc_btn);
            this.Controls.Add(this.donvitinh_txt);
            this.Controls.Add(this.dongia_txt);
            this.Controls.Add(this.tenthuoc_txt);
            this.Controls.Add(this.mathuoc_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm thuốc";
            this.Load += new System.EventHandler(this.frmThemThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mathuoc_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenthuoc_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongia_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinh_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit mathuoc_txt;
        private DevExpress.XtraEditors.TextEdit tenthuoc_txt;
        private DevExpress.XtraEditors.TextEdit dongia_txt;
        private DevExpress.XtraEditors.TextEdit donvitinh_txt;
        private DevExpress.XtraEditors.SimpleButton ThemThuoc_btn;
        private DevExpress.XtraEditors.SimpleButton close_btn;
        private System.Windows.Forms.ErrorProvider Error;
    }
}