namespace VFC._Message
{
    partial class frmMessage_ShowMessageInfo
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbTieuDe = new DevExpress.XtraEditors.LabelControl();
            this.txtBody = new DevExpress.XtraEditors.MemoEdit();
            this.checkAgree = new DevExpress.XtraEditors.CheckEdit();
            this.btAgree = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.lbStore = new DevExpress.XtraEditors.LabelControl();
            this.lbMessageID = new DevExpress.XtraEditors.LabelControl();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtBody.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.checkAgree.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , ( (System.Drawing.FontStyle) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ) , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 32 , 23 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 72 , 19 );
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tiêu đề :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , ( (System.Drawing.FontStyle) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ) , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Location = new System.Drawing.Point( 21 , 54 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 83 , 19 );
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nội dung :";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Appearance.Font = new System.Drawing.Font( "Tahoma" , 20.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbTieuDe.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTieuDe.Location = new System.Drawing.Point( 110 , 12 );
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size( 104 , 33 );
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "lbTieuDe";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point( 110 , 51 );
            this.txtBody.Name = "txtBody";
            this.txtBody.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtBody.Properties.Appearance.Options.UseFont = true;
            this.txtBody.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtBody.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.txtBody.Properties.AppearanceDisabled.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtBody.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtBody.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtBody.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtBody.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.txtBody.Properties.AppearanceReadOnly.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtBody.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtBody.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtBody.Properties.ReadOnly = true;
            this.txtBody.Size = new System.Drawing.Size( 677 , 217 );
            this.txtBody.TabIndex = 1;
            this.txtBody.UseOptimizedRendering = true;
            // 
            // checkAgree
            // 
            this.checkAgree.Location = new System.Drawing.Point( 108 , 274 );
            this.checkAgree.Name = "checkAgree";
            this.checkAgree.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.checkAgree.Properties.Appearance.Options.UseFont = true;
            this.checkAgree.Properties.Caption = "Tôi đã đọc và hiểu rõ nội dung của thông báo.";
            this.checkAgree.Size = new System.Drawing.Size( 498 , 20 );
            this.checkAgree.TabIndex = 2;
            this.checkAgree.CheckedChanged += new System.EventHandler( this.checkAgree_CheckedChanged );
            // 
            // btAgree
            // 
            this.btAgree.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btAgree.Appearance.Options.UseFont = true;
            this.btAgree.Enabled = false;
            this.btAgree.Location = new System.Drawing.Point( 110 , 300 );
            this.btAgree.Name = "btAgree";
            this.btAgree.Size = new System.Drawing.Size( 172 , 43 );
            this.btAgree.TabIndex = 3;
            this.btAgree.Text = "Đã đọc và Hiểu rõ";
            this.btAgree.Click += new System.EventHandler( this.btAgree_Click );
            // 
            // btClose
            // 
            this.btClose.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btClose.Appearance.Options.UseFont = true;
            this.btClose.Location = new System.Drawing.Point( 288 , 300 );
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size( 172 , 43 );
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Đóng";
            this.btClose.Click += new System.EventHandler( this.btClose_Click );
            // 
            // lbStore
            // 
            this.lbStore.Appearance.Font = new System.Drawing.Font( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbStore.Location = new System.Drawing.Point( 21 , 79 );
            this.lbStore.Name = "lbStore";
            this.lbStore.Size = new System.Drawing.Size( 34 , 13 );
            this.lbStore.TabIndex = 0;
            this.lbStore.Text = "lbStore";
            // 
            // lbMessageID
            // 
            this.lbMessageID.Appearance.Font = new System.Drawing.Font( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbMessageID.Location = new System.Drawing.Point( 21 , 98 );
            this.lbMessageID.Name = "lbMessageID";
            this.lbMessageID.Size = new System.Drawing.Size( 61 , 13 );
            this.lbMessageID.TabIndex = 0;
            this.lbMessageID.Text = "lbMessageID";
            // 
            // frmMessage_ShowMessageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 799 , 355 );
            this.Controls.Add( this.btClose );
            this.Controls.Add( this.btAgree );
            this.Controls.Add( this.checkAgree );
            this.Controls.Add( this.txtBody );
            this.Controls.Add( this.lbMessageID );
            this.Controls.Add( this.lbStore );
            this.Controls.Add( this.labelControl2 );
            this.Controls.Add( this.lbTieuDe );
            this.Controls.Add( this.labelControl1 );
            this.Name = "frmMessage_ShowMessageInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessage_ShowMessageInfo";
            this.Load += new System.EventHandler( this.frmMessage_ShowMessageInfo_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtBody.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.checkAgree.Properties ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbTieuDe;
        private DevExpress.XtraEditors.MemoEdit txtBody;
        private DevExpress.XtraEditors.CheckEdit checkAgree;
        private DevExpress.XtraEditors.SimpleButton btAgree;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private DevExpress.XtraEditors.LabelControl lbStore;
        private DevExpress.XtraEditors.LabelControl lbMessageID;
    }
}