namespace VFC._Admin
{
    partial class frmUnlockForm
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
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btUnlock = new DevExpress.XtraEditors.SimpleButton();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtPassword.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point( 12 , 12 );
            this.txtPassword.MaximumSize = new System.Drawing.Size( 243 , 46 );
            this.txtPassword.MinimumSize = new System.Drawing.Size( 243 , 46 );
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 24F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size( 243 , 46 );
            this.txtPassword.TabIndex = 0;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler( this.txtPassword_KeyDown );
            // 
            // btUnlock
            // 
            this.btUnlock.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btUnlock.Appearance.Options.UseFont = true;
            this.btUnlock.Location = new System.Drawing.Point( 12 , 64 );
            this.btUnlock.Name = "btUnlock";
            this.btUnlock.Size = new System.Drawing.Size( 243 , 36 );
            this.btUnlock.TabIndex = 1;
            this.btUnlock.Text = "UNLOCK";
            this.btUnlock.Click += new System.EventHandler( this.btUnlock_Click );
            // 
            // frmUnlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 267 , 112 );
            this.Controls.Add( this.btUnlock );
            this.Controls.Add( this.txtPassword );
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size( 283 , 151 );
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size( 283 , 151 );
            this.Name = "frmUnlockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unlock";
            this.Load += new System.EventHandler( this.frmOpenManageConfigForm_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtPassword.Properties ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btUnlock;
    }
}