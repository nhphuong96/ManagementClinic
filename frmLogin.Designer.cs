namespace Hospital_Pilot
{
    partial class frmLogin
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.user_txt = new DevExpress.XtraEditors.TextEdit();
            this.pass_txt = new DevExpress.XtraEditors.TextEdit();
            this.groupLogin = new DevExpress.XtraEditors.GroupControl();
            this.progress_login = new DevExpress.XtraWaitForm.ProgressPanel();
            this.Login_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Exit_btn = new DevExpress.XtraEditors.SimpleButton();
            this.NhomNV = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.user_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLogin)).BeginInit();
            this.groupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhomNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(20, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(20, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu          :";
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(132, 39);
            this.user_txt.Name = "user_txt";
            this.user_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txt.Properties.Appearance.Options.UseFont = true;
            this.user_txt.Size = new System.Drawing.Size(159, 22);
            this.user_txt.TabIndex = 2;
            this.user_txt.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.user_txt_EditValueChanging);
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(132, 75);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Properties.Appearance.Options.UseFont = true;
            this.pass_txt.Properties.PasswordChar = '●';
            this.pass_txt.Size = new System.Drawing.Size(159, 22);
            this.pass_txt.TabIndex = 3;
            // 
            // groupLogin
            // 
            this.groupLogin.Controls.Add(this.progress_login);
            this.groupLogin.Controls.Add(this.labelControl1);
            this.groupLogin.Controls.Add(this.pass_txt);
            this.groupLogin.Controls.Add(this.labelControl2);
            this.groupLogin.Controls.Add(this.user_txt);
            this.groupLogin.Location = new System.Drawing.Point(28, 37);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Size = new System.Drawing.Size(342, 113);
            this.groupLogin.TabIndex = 4;
            this.groupLogin.Text = "Nhập tài khoản";
            // 
            // progress_login
            // 
            this.progress_login.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.progress_login.Appearance.Options.UseBackColor = true;
            this.progress_login.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.progress_login.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progress_login.Description = "Logging in ...";
            this.progress_login.Location = new System.Drawing.Point(90, 44);
            this.progress_login.Name = "progress_login";
            this.progress_login.Size = new System.Drawing.Size(155, 69);
            this.progress_login.TabIndex = 4;
            this.progress_login.Text = "progressPanel1";
            this.progress_login.Visible = false;
            this.progress_login.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // Login_btn
            // 
            this.Login_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Appearance.Options.UseFont = true;
            this.Login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Login_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.Login_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Login_btn.Location = new System.Drawing.Point(48, 226);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(118, 43);
            this.Login_btn.TabIndex = 9;
            this.Login_btn.Text = "Đăng nhập";
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Appearance.Options.UseFont = true;
            this.Exit_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.Exit_btn.Location = new System.Drawing.Point(230, 226);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(123, 43);
            this.Exit_btn.TabIndex = 10;
            this.Exit_btn.Text = "Đóng";
            this.Exit_btn.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // NhomNV
            // 
            this.NhomNV.Location = new System.Drawing.Point(28, 167);
            this.NhomNV.Name = "NhomNV";
            this.NhomNV.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.NhomNV.Properties.Appearance.Options.UseBackColor = true;
            this.NhomNV.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("DH", "Điều hành"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("DS", "Dược sĩ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("YT", "Y tá"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NV", "Nhân viên")});
            this.NhomNV.Size = new System.Drawing.Size(342, 33);
            this.NhomNV.TabIndex = 13;
            this.NhomNV.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 311);
            this.Controls.Add(this.NhomNV);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.groupLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(415, 350);
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLogin)).EndInit();
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhomNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit user_txt;
        private DevExpress.XtraEditors.TextEdit pass_txt;
        private DevExpress.XtraEditors.GroupControl groupLogin;
        private DevExpress.XtraEditors.SimpleButton Login_btn;
        private DevExpress.XtraEditors.SimpleButton Exit_btn;
        private DevExpress.XtraEditors.RadioGroup NhomNV;
        private DevExpress.XtraWaitForm.ProgressPanel progress_login;
    }
}