namespace VFC._Admin
{
    partial class frmOverrideLogin
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
            this.checkShowPass = new DevExpress.XtraEditors.CheckEdit();
            this.btExit = new DevExpress.XtraEditors.SimpleButton();
            this.btLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkShowPass
            // 
            this.checkShowPass.Location = new System.Drawing.Point(184, 94);
            this.checkShowPass.Name = "checkShowPass";
            this.checkShowPass.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkShowPass.Properties.Appearance.Options.UseForeColor = true;
            this.checkShowPass.Properties.Caption = "Hiện mật khẩu";
            this.checkShowPass.Size = new System.Drawing.Size(110, 19);
            this.checkShowPass.TabIndex = 12;
            this.checkShowPass.CheckedChanged += new System.EventHandler(this.checkShowPass_CheckedChanged);
            // 
            // btExit
            // 
            this.btExit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Appearance.Options.UseFont = true;
            this.btExit.Location = new System.Drawing.Point(302, 119);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(110, 30);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Appearance.Options.UseFont = true;
            this.btLogin.Location = new System.Drawing.Point(186, 119);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(110, 30);
            this.btLogin.TabIndex = 10;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(186, 54);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPass.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(317, 36);
            this.txtPass.TabIndex = 9;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(186, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUser.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUser.Size = new System.Drawing.Size(317, 36);
            this.txtUser.TabIndex = 6;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(67, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 25);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Mật khẩu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(12, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 25);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tên đăng nhập :";
            // 
            // frmOverrideLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 160);
            this.Controls.Add(this.checkShowPass);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(534, 199);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(534, 199);
            this.Name = "frmOverrideLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghi đè !";
            this.Load += new System.EventHandler(this.frmOverrideLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkShowPass;
        private DevExpress.XtraEditors.SimpleButton btExit;
        private DevExpress.XtraEditors.SimpleButton btLogin;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}