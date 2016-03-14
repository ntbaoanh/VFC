namespace VFC._Merchandise
{
    partial class frmMER_KiemTraTonKho_UPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmMER_KiemTraTonKho_UPC ) );
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager( this , typeof( global::VFC.WaitForm1 ) , true , true );
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btFind = new DevExpress.XtraEditors.SimpleButton();
            this.chbExactly = new System.Windows.Forms.CheckBox();
            this.rdLAN = new DevExpress.XtraEditors.RadioGroup();
            this.rdGroup = new DevExpress.XtraEditors.RadioGroup();
            this.txtUPC = new DevExpress.XtraEditors.TextEdit();
            this.lbTenSanPham = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbMaThietKe = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).BeginInit();
            this.groupControl1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.rdLAN.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.rdGroup.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtUPC.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).BeginInit();
            this.groupControl2.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 15.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.CaptionImage = ( (System.Drawing.Image) ( resources.GetObject( "groupControl1.CaptionImage" ) ) );
            this.groupControl1.Controls.Add( this.btFind );
            this.groupControl1.Controls.Add( this.chbExactly );
            this.groupControl1.Controls.Add( this.rdLAN );
            this.groupControl1.Controls.Add( this.rdGroup );
            this.groupControl1.Controls.Add( this.txtUPC );
            this.groupControl1.Controls.Add( this.lbTenSanPham );
            this.groupControl1.Controls.Add( this.labelControl3 );
            this.groupControl1.Controls.Add( this.labelControl2 );
            this.groupControl1.Controls.Add( this.lbMaThietKe );
            this.groupControl1.Controls.Add( this.labelControl1 );
            this.groupControl1.Location = new System.Drawing.Point( 12 , 12 );
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size( 772 , 211 );
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin tra cứu";
            // 
            // btFind
            // 
            this.btFind.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btFind.Appearance.Options.UseFont = true;
            this.btFind.Image = ( (System.Drawing.Image) ( resources.GetObject( "btFind.Image" ) ) );
            this.btFind.Location = new System.Drawing.Point( 409 , 120 );
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size( 76 , 27 );
            this.btFind.TabIndex = 3;
            this.btFind.Text = "Tìm";
            this.btFind.Click += new System.EventHandler( this.btFind_Click );
            // 
            // chbExactly
            // 
            this.chbExactly.AutoSize = true;
            this.chbExactly.Font = new System.Drawing.Font( "Tahoma" , 11.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.chbExactly.Location = new System.Drawing.Point( 90 , 121 );
            this.chbExactly.Name = "chbExactly";
            this.chbExactly.Size = new System.Drawing.Size( 111 , 22 );
            this.chbExactly.TabIndex = 1;
            this.chbExactly.Text = "Dò chính xác";
            this.chbExactly.UseVisualStyleBackColor = true;
            this.chbExactly.CheckedChanged += new System.EventHandler( this.chbExactly_CheckedChanged );
            // 
            // rdLAN
            // 
            this.rdLAN.Location = new System.Drawing.Point( 633 , 43 );
            this.rdLAN.Name = "rdLAN";
            this.rdLAN.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.rdLAN.Properties.Appearance.Options.UseFont = true;
            this.rdLAN.Properties.Items.AddRange( new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Local"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "LAN")} );
            this.rdLAN.Size = new System.Drawing.Size( 123 , 104 );
            this.rdLAN.TabIndex = 2;
            this.rdLAN.SelectedIndexChanged += new System.EventHandler( this.rdLAN_SelectedIndexChanged );
            // 
            // rdGroup
            // 
            this.rdGroup.Location = new System.Drawing.Point( 491 , 43 );
            this.rdGroup.Name = "rdGroup";
            this.rdGroup.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.rdGroup.Properties.Appearance.Options.UseFont = true;
            this.rdGroup.Properties.Items.AddRange( new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cửa hàng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Khu vực"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Toàn quốc")} );
            this.rdGroup.Size = new System.Drawing.Size( 136 , 104 );
            this.rdGroup.TabIndex = 2;
            this.rdGroup.SelectedIndexChanged += new System.EventHandler( this.rdGroup_SelectedIndexChanged );
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point( 90 , 44 );
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 39.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtUPC.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtUPC.Properties.Appearance.Options.UseFont = true;
            this.txtUPC.Properties.Appearance.Options.UseForeColor = true;
            this.txtUPC.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUPC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUPC.Size = new System.Drawing.Size( 395 , 70 );
            this.txtUPC.TabIndex = 0;
            this.txtUPC.KeyDown += new System.Windows.Forms.KeyEventHandler( this.txtUPC_KeyDown );
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.Appearance.Font = new System.Drawing.Font( "Tahoma" , 15.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbTenSanPham.Appearance.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbTenSanPham.Location = new System.Drawing.Point( 180 , 180 );
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size( 156 , 25 );
            this.lbTenSanPham.TabIndex = 0;
            this.lbTenSanPham.Text = "lbTenSanPham";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font( "Tahoma" , 15.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl3.Location = new System.Drawing.Point( 8 , 180 );
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size( 166 , 25 );
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên sản phẩm : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 15.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Location = new System.Drawing.Point( 36 , 149 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 138 , 25 );
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã thiết kế : ";
            // 
            // lbMaThietKe
            // 
            this.lbMaThietKe.Appearance.Font = new System.Drawing.Font( "Tahoma" , 15.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbMaThietKe.Appearance.ForeColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 255 ) ) ) ) , ( (int) ( ( (byte) ( 128 ) ) ) ) , ( (int) ( ( (byte) ( 0 ) ) ) ) );
            this.lbMaThietKe.Location = new System.Drawing.Point( 180 , 149 );
            this.lbMaThietKe.Name = "lbMaThietKe";
            this.lbMaThietKe.Size = new System.Drawing.Size( 131 , 25 );
            this.lbMaThietKe.TabIndex = 0;
            this.lbMaThietKe.Text = "lbMaThietKe";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 26.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 12 , 59 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 72 , 42 );
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "UPC";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 15.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.CaptionImage = ( (System.Drawing.Image) ( resources.GetObject( "groupControl2.CaptionImage" ) ) );
            this.groupControl2.Controls.Add( this.gridControl1 );
            this.groupControl2.Location = new System.Drawing.Point( 12 , 229 );
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size( 772 , 216 );
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Kết quả";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point( 2 , 40 );
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size( 768 , 174 );
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1} );
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 255 ) ) ) ) , ( (int) ( ( (byte) ( 255 ) ) ) ) , ( (int) ( ( (byte) ( 192 ) ) ) ) );
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7} );
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cửa hàng";
            this.gridColumn1.FieldName = "STORE_CODE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "UPC";
            this.gridColumn2.FieldName = "UPC";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Size";
            this.gridColumn3.FieldName = "SIZ";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số lượng";
            this.gridColumn4.FieldName = "QTY";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Màu";
            this.gridColumn5.FieldName = "ATTR";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Giá bán";
            this.gridColumn6.DisplayFormat.FormatString = "{0:#,#}";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "PRICE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Khu vực";
            this.gridColumn7.FieldName = "REGION_NAME";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // frmMER_KiemTraTonKho_UPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 801 , 457 );
            this.Controls.Add( this.groupControl2 );
            this.Controls.Add( this.groupControl1 );
            this.Name = "frmMER_KiemTraTonKho_UPC";
            this.Text = "Kiểm Tra Tồn Kho Theo UPC";
            this.Load += new System.EventHandler( this.frmMER_KiemTraTonKho_UPC_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).EndInit();
            this.groupControl1.ResumeLayout( false );
            this.groupControl1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.rdLAN.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.rdGroup.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtUPC.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).EndInit();
            this.groupControl2.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btFind;
        private System.Windows.Forms.CheckBox chbExactly;
        private DevExpress.XtraEditors.RadioGroup rdLAN;
        private DevExpress.XtraEditors.RadioGroup rdGroup;
        private DevExpress.XtraEditors.TextEdit txtUPC;
        private DevExpress.XtraEditors.LabelControl lbTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbMaThietKe;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}