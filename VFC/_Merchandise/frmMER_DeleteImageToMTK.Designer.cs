namespace VFC._Merchandise
{
    partial class frmMER_DeleteImageToMTK
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
            this.cbbAttr = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbMTK = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btDeleteImage = new DevExpress.XtraEditors.SimpleButton();
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbAttr.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // cbbAttr
            // 
            this.cbbAttr.Location = new System.Drawing.Point( 136 , 53 );
            this.cbbAttr.Name = "cbbAttr";
            this.cbbAttr.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbbAttr.Properties.Appearance.Options.UseFont = true;
            this.cbbAttr.Properties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.cbbAttr.Properties.DisplayMember = "ATTR";
            this.cbbAttr.Properties.ValueMember = "ATTR";
            this.cbbAttr.Size = new System.Drawing.Size( 249 , 26 );
            this.cbbAttr.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Location = new System.Drawing.Point( 85 , 56 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 45 , 19 );
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Màu :";
            // 
            // lbMTK
            // 
            this.lbMTK.Appearance.Font = new System.Drawing.Font( "Tahoma" , 21.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbMTK.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbMTK.Location = new System.Drawing.Point( 136 , 12 );
            this.lbMTK.Name = "lbMTK";
            this.lbMTK.Size = new System.Drawing.Size( 92 , 35 );
            this.lbMTK.TabIndex = 2;
            this.lbMTK.Text = "lbMTK";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 21 , 25 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 109 , 19 );
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã Thiết Kế :";
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btDeleteImage.Appearance.Options.UseFont = true;
            this.btDeleteImage.Location = new System.Drawing.Point( 136 , 85 );
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size( 152 , 26 );
            this.btDeleteImage.TabIndex = 6;
            this.btDeleteImage.Text = "Xóa hình";
            this.btDeleteImage.Click += new System.EventHandler( this.btDeleteImage_Click );
            // 
            // frmMER_DeleteImageToMTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 402 , 126 );
            this.Controls.Add( this.btDeleteImage );
            this.Controls.Add( this.cbbAttr );
            this.Controls.Add( this.labelControl2 );
            this.Controls.Add( this.lbMTK );
            this.Controls.Add( this.labelControl1 );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMER_DeleteImageToMTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMER_DeleteImageToMTK";
            this.Load += new System.EventHandler( this.frmMER_DeleteImageToMTK_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbAttr.Properties ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cbbAttr;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbMTK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btDeleteImage;
    }
}