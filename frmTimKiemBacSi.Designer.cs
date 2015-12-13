namespace Hospital_Pilot
{
    partial class frmTimKiemBacSi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.KHOA_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.donvi_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(173, 58);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(129, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // KHOA_COMBOBOX
            // 
            this.KHOA_COMBOBOX.FormattingEnabled = true;
            this.KHOA_COMBOBOX.Location = new System.Drawing.Point(79, 21);
            this.KHOA_COMBOBOX.Name = "KHOA_COMBOBOX";
            this.KHOA_COMBOBOX.Size = new System.Drawing.Size(154, 21);
            this.KHOA_COMBOBOX.TabIndex = 5;
            this.KHOA_COMBOBOX.SelectedIndexChanged += new System.EventHandler(this.KHOA_COMBOBOX_SelectedIndexChanged);
            // 
            // donvi_combobox
            // 
            this.donvi_combobox.FormattingEnabled = true;
            this.donvi_combobox.Location = new System.Drawing.Point(283, 21);
            this.donvi_combobox.Name = "donvi_combobox";
            this.donvi_combobox.Size = new System.Drawing.Size(154, 21);
            this.donvi_combobox.TabIndex = 6;
            // 
            // frmTimKiemBacSi
            // 
            this.AcceptButton = this.simpleButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 97);
            this.Controls.Add(this.donvi_combobox);
            this.Controls.Add(this.KHOA_COMBOBOX);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiemBacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm bác sĩ";
            this.Load += new System.EventHandler(this.frmTimKiemBacSi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox KHOA_COMBOBOX;
        private System.Windows.Forms.ComboBox donvi_combobox;
    }
}