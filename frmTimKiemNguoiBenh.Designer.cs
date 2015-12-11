namespace Hospital_Pilot
{
    partial class frmTimKiemNguoiBenh
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.manguoibenh_txt = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.manguoibenh_txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập mã người bệnh";
            // 
            // manguoibenh_txt
            // 
            this.manguoibenh_txt.Location = new System.Drawing.Point(139, 27);
            this.manguoibenh_txt.Name = "manguoibenh_txt";
            this.manguoibenh_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manguoibenh_txt.Properties.Appearance.Options.UseFont = true;
            this.manguoibenh_txt.Size = new System.Drawing.Size(100, 22);
            this.manguoibenh_txt.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(76, 70);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmTimKiemNguoiBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 117);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.manguoibenh_txt);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmTimKiemNguoiBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm người bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.manguoibenh_txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit manguoibenh_txt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}