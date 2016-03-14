namespace VFC._Admin
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtNew2 = new DevExpress.XtraEditors.TextEdit();
            this.txtNew1 = new DevExpress.XtraEditors.TextEdit();
            this.txtOld = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbUserID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Appearance.Options.UseFont = true;
            this.btCancel.Location = new System.Drawing.Point(297, 138);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Hủy";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Appearance.Options.UseFont = true;
            this.btSave.Location = new System.Drawing.Point(216, 138);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtNew2
            // 
            this.txtNew2.Location = new System.Drawing.Point(216, 101);
            this.txtNew2.Name = "txtNew2";
            this.txtNew2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew2.Properties.Appearance.Options.UseFont = true;
            this.txtNew2.Properties.PasswordChar = '*';
            this.txtNew2.Size = new System.Drawing.Size(201, 26);
            this.txtNew2.TabIndex = 13;
            // 
            // txtNew1
            // 
            this.txtNew1.Location = new System.Drawing.Point(216, 69);
            this.txtNew1.Name = "txtNew1";
            this.txtNew1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew1.Properties.Appearance.Options.UseFont = true;
            this.txtNew1.Properties.PasswordChar = '*';
            this.txtNew1.Size = new System.Drawing.Size(201, 26);
            this.txtNew1.TabIndex = 12;
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(216, 37);
            this.txtOld.Name = "txtOld";
            this.txtOld.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOld.Properties.Appearance.Options.UseFont = true;
            this.txtOld.Properties.PasswordChar = '*';
            this.txtOld.Size = new System.Drawing.Size(201, 26);
            this.txtOld.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(13, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(195, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Nhập lại mật khẩu mới :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(86, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(122, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Mật khẩu mới :";
            // 
            // lbUserID
            // 
            this.lbUserID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbUserID.Location = new System.Drawing.Point(214, 12);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(49, 19);
            this.lbUserID.TabIndex = 8;
            this.lbUserID.Text = "[user]";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(98, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 19);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Mật khẩu cũ :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(76, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 19);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên đăng nhập :";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 175);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtNew2);
            this.Controls.Add(this.txtNew1);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbUserID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNew2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.TextEdit txtNew2;
        private DevExpress.XtraEditors.TextEdit txtNew1;
        private DevExpress.XtraEditors.TextEdit txtOld;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbUserID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}