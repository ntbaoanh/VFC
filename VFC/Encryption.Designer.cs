namespace VFC
{
    partial class Encryption
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtInput = new DevExpress.XtraEditors.TextEdit();
            this.btHash = new DevExpress.XtraEditors.SimpleButton();
            this.txtEncrypt = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btDecrypt = new DevExpress.XtraEditors.SimpleButton();
            this.txtDecrypt = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtInput.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtEncrypt.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtDecrypt.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 37 , 28 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 114 , 19 );
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Input String : ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point( 157 , 25 );
            this.txtInput.Name = "txtInput";
            this.txtInput.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtInput.Properties.Appearance.Options.UseFont = true;
            this.txtInput.Size = new System.Drawing.Size( 329 , 26 );
            this.txtInput.TabIndex = 1;
            // 
            // btHash
            // 
            this.btHash.Location = new System.Drawing.Point( 157 , 57 );
            this.btHash.Name = "btHash";
            this.btHash.Size = new System.Drawing.Size( 75 , 23 );
            this.btHash.TabIndex = 2;
            this.btHash.Text = "Encrypt";
            this.btHash.Click += new System.EventHandler( this.btHash_Click );
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point( 157 , 86 );
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtEncrypt.Properties.Appearance.Options.UseFont = true;
            this.txtEncrypt.Size = new System.Drawing.Size( 329 , 96 );
            this.txtEncrypt.TabIndex = 3;
            this.txtEncrypt.UseOptimizedRendering = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Location = new System.Drawing.Point( 74 , 89 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 77 , 19 );
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Encrypt : ";
            // 
            // btDecrypt
            // 
            this.btDecrypt.Location = new System.Drawing.Point( 157 , 188 );
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size( 75 , 23 );
            this.btDecrypt.TabIndex = 2;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.Click += new System.EventHandler( this.btDecrypt_Click );
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point( 157 , 217 );
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtDecrypt.Properties.Appearance.Options.UseFont = true;
            this.txtDecrypt.Size = new System.Drawing.Size( 329 , 96 );
            this.txtDecrypt.TabIndex = 3;
            this.txtDecrypt.UseOptimizedRendering = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl3.Location = new System.Drawing.Point( 74 , 220 );
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size( 79 , 19 );
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Decrypt : ";
            // 
            // frmHashMD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 549 , 336 );
            this.Controls.Add( this.txtDecrypt );
            this.Controls.Add( this.txtEncrypt );
            this.Controls.Add( this.btDecrypt );
            this.Controls.Add( this.btHash );
            this.Controls.Add( this.txtInput );
            this.Controls.Add( this.labelControl3 );
            this.Controls.Add( this.labelControl2 );
            this.Controls.Add( this.labelControl1 );
            this.Name = "frmHashMD5";
            this.Text = "frmHashMD5";
            this.Load += new System.EventHandler( this.frmHashMD5_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtInput.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtEncrypt.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtDecrypt.Properties ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtInput;
        private DevExpress.XtraEditors.SimpleButton btHash;
        private DevExpress.XtraEditors.MemoEdit txtEncrypt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btDecrypt;
        private DevExpress.XtraEditors.MemoEdit txtDecrypt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}