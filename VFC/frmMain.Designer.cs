namespace VFC
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmMain ) );
            this.btStore = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList( this.components );
            this.btHO = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDelevelopedBy = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager( this , typeof( global::VFC.WaitForm1 ) , true , true );
            this.timer_Update = new System.Windows.Forms.Timer( this.components );
            this.SuspendLayout();
            // 
            // btStore
            // 
            this.btStore.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btStore.Appearance.Options.UseFont = true;
            this.btStore.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btStore.ImageIndex = 1;
            this.btStore.ImageList = this.imageList1;
            this.btStore.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btStore.Location = new System.Drawing.Point( 58 , 25 );
            this.btStore.LookAndFeel.SkinName = "Blueprint";
            this.btStore.Name = "btStore";
            this.btStore.Size = new System.Drawing.Size( 114 , 114 );
            this.btStore.TabIndex = 0;
            this.btStore.Text = "Cửa hàng";
            this.btStore.Click += new System.EventHandler( this.btStore_Click );
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ( (System.Windows.Forms.ImageListStreamer) ( resources.GetObject( "imageList1.ImageStream" ) ) );
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName( 0 , "ic_HeadOffice_2.jpg" );
            this.imageList1.Images.SetKeyName( 1 , "ic_Store_1.jpg" );
            // 
            // btHO
            // 
            this.btHO.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btHO.Appearance.Options.UseFont = true;
            this.btHO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btHO.ImageIndex = 0;
            this.btHO.ImageList = this.imageList1;
            this.btHO.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btHO.Location = new System.Drawing.Point( 178 , 25 );
            this.btHO.Name = "btHO";
            this.btHO.Size = new System.Drawing.Size( 114 , 114 );
            this.btHO.TabIndex = 0;
            this.btHO.Text = "HO";
            this.btHO.Click += new System.EventHandler( this.btHO_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.label1.ForeColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 0 ) ) ) ) , ( (int) ( ( (byte) ( 0 ) ) ) ) , ( (int) ( ( (byte) ( 192 ) ) ) ) );
            this.label1.Location = new System.Drawing.Point( 32 , 155 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 285 , 19 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Vui lòng chọn môi trường làm việc";
            // 
            // lbDelevelopedBy
            // 
            this.lbDelevelopedBy.AutoSize = true;
            this.lbDelevelopedBy.BackColor = System.Drawing.Color.Transparent;
            this.lbDelevelopedBy.Font = new System.Drawing.Font( "Tahoma" , 8.25F , System.Drawing.FontStyle.Italic , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbDelevelopedBy.Location = new System.Drawing.Point( 208 , 196 );
            this.lbDelevelopedBy.Name = "lbDelevelopedBy";
            this.lbDelevelopedBy.Size = new System.Drawing.Size( 141 , 13 );
            this.lbDelevelopedBy.TabIndex = 2;
            this.lbDelevelopedBy.Text = "Developed by Nguyễn Nhân";
            this.lbDelevelopedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDelevelopedBy.DoubleClick += new System.EventHandler( this.lbDelevelopedBy_DoubleClick );
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.Font = new System.Drawing.Font( "Tahoma" , 8.25F , System.Drawing.FontStyle.Italic , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbVersion.Location = new System.Drawing.Point( 3 , 197 );
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size( 50 , 13 );
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "lbVersion";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbVersion.DoubleClick += new System.EventHandler( this.lbVersion_DoubleClick );
            // 
            // timer_Update
            // 
            this.timer_Update.Tick += new System.EventHandler( this.timer_Update_Tick );
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::VFC.Properties.Resources.Abstract_3;
            this.ClientSize = new System.Drawing.Size( 354 , 214 );
            this.Controls.Add( this.lbVersion );
            this.Controls.Add( this.lbDelevelopedBy );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.btHO );
            this.Controls.Add( this.btStore );
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size( 370 , 253 );
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size( 370 , 253 );
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cty Thời Trang Việt";
            this.Load += new System.EventHandler( this.frmMain_Load );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btStore;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btHO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDelevelopedBy;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Timer timer_Update;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;

    }
}

