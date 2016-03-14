namespace VFC._IT
{
    partial class frmIT_HoTroKyThuat_Create
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
            this.cbbIT = new System.Windows.Forms.ComboBox();
            this.cbbStores = new DevExpress.XtraEditors.LookUpEdit();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbCaiSoftwares = new System.Windows.Forms.CheckBox();
            this.cbXoaNhapChinhNgay = new System.Windows.Forms.CheckBox();
            this.cbKhongBanHangDuoc = new System.Windows.Forms.CheckBox();
            this.cbSoLieuTonKhongDung = new System.Windows.Forms.CheckBox();
            this.cbKhac = new System.Windows.Forms.CheckBox();
            this.cbHuRpro9 = new System.Windows.Forms.CheckBox();
            this.cbHuBarcode = new System.Windows.Forms.CheckBox();
            this.cbHuCPU = new System.Windows.Forms.CheckBox();
            this.cbHuMayIn = new System.Windows.Forms.CheckBox();
            this.cbHuDienThoai = new System.Windows.Forms.CheckBox();
            this.cbHuInternet = new System.Windows.Forms.CheckBox();
            this.xtraTab = new DevExpress.XtraTab.XtraTabControl();
            this.xtra_2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtSoLieuTonKhongDung = new DevExpress.XtraEditors.MemoEdit();
            this.xtra_3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtKhongBanHangDuoc = new DevExpress.XtraEditors.MemoEdit();
            this.xtra_4 = new DevExpress.XtraTab.XtraTabPage();
            this.txtXoaNhapChinhNgay = new DevExpress.XtraEditors.MemoEdit();
            this.xtra_5 = new DevExpress.XtraTab.XtraTabPage();
            this.txtKhac = new DevExpress.XtraEditors.MemoEdit();
            this.xtra_6 = new DevExpress.XtraTab.XtraTabPage();
            this.txtCaiDatSoftwares = new DevExpress.XtraEditors.MemoEdit();
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbStores.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).BeginInit();
            this.groupControl2.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.xtraTab ) ).BeginInit();
            this.xtraTab.SuspendLayout();
            this.xtra_2.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtSoLieuTonKhongDung.Properties ) ).BeginInit();
            this.xtra_3.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtKhongBanHangDuoc.Properties ) ).BeginInit();
            this.xtra_4.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtXoaNhapChinhNgay.Properties ) ).BeginInit();
            this.xtra_5.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtKhac.Properties ) ).BeginInit();
            this.xtra_6.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtCaiDatSoftwares.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // cbbIT
            // 
            this.cbbIT.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbbIT.FormattingEnabled = true;
            this.cbbIT.Items.AddRange( new object[] {
            "NHANNT\t",
            "TAMNT",
            "NINHTTH",
            "THIENTC",
            "HAVM",
            "CHAMNV"} );
            this.cbbIT.Location = new System.Drawing.Point( 114 , 37 );
            this.cbbIT.Name = "cbbIT";
            this.cbbIT.Size = new System.Drawing.Size( 189 , 24 );
            this.cbbIT.TabIndex = 11;
            // 
            // cbbStores
            // 
            this.cbbStores.Location = new System.Drawing.Point( 114 , 9 );
            this.cbbStores.Name = "cbbStores";
            this.cbbStores.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbbStores.Properties.Appearance.Options.UseFont = true;
            this.cbbStores.Properties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.cbbStores.Properties.Columns.AddRange( new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORE_CODE", "Store")} );
            this.cbbStores.Properties.DisplayMember = "STORE_CODE";
            this.cbbStores.Properties.DropDownRows = 10;
            this.cbbStores.Properties.ValueMember = "STORE_CODE";
            this.cbbStores.Size = new System.Drawing.Size( 189 , 22 );
            this.cbbStores.TabIndex = 9;
            this.cbbStores.EditValueChanged += new System.EventHandler( this.cbbStores_EditValueChanged );
            // 
            // btSave
            // 
            this.btSave.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btSave.Appearance.Options.UseFont = true;
            this.btSave.Location = new System.Drawing.Point( 16 , 284 );
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size( 92 , 23 );
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Tạo";
            this.btSave.Click += new System.EventHandler( this.btSave_Click );
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Location = new System.Drawing.Point( 34 , 12 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 74 , 16 );
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Cửa hàng : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl3.Location = new System.Drawing.Point( 16 , 40 );
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size( 92 , 16 );
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "IT Phụ trách : ";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add( this.cbCaiSoftwares );
            this.groupControl2.Controls.Add( this.cbXoaNhapChinhNgay );
            this.groupControl2.Controls.Add( this.cbKhongBanHangDuoc );
            this.groupControl2.Controls.Add( this.cbSoLieuTonKhongDung );
            this.groupControl2.Controls.Add( this.cbKhac );
            this.groupControl2.Controls.Add( this.cbHuRpro9 );
            this.groupControl2.Controls.Add( this.cbHuBarcode );
            this.groupControl2.Controls.Add( this.cbHuCPU );
            this.groupControl2.Controls.Add( this.cbHuMayIn );
            this.groupControl2.Controls.Add( this.cbHuDienThoai );
            this.groupControl2.Controls.Add( this.cbHuInternet );
            this.groupControl2.Location = new System.Drawing.Point( 16 , 69 );
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size( 343 , 209 );
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Tác vụ";
            // 
            // cbCaiSoftwares
            // 
            this.cbCaiSoftwares.AutoSize = true;
            this.cbCaiSoftwares.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbCaiSoftwares.Location = new System.Drawing.Point( 16 , 183 );
            this.cbCaiSoftwares.Name = "cbCaiSoftwares";
            this.cbCaiSoftwares.Size = new System.Drawing.Size( 171 , 20 );
            this.cbCaiSoftwares.TabIndex = 0;
            this.cbCaiSoftwares.Text = "Yêu cầu cài softwares";
            this.cbCaiSoftwares.UseVisualStyleBackColor = true;
            // 
            // cbXoaNhapChinhNgay
            // 
            this.cbXoaNhapChinhNgay.AutoSize = true;
            this.cbXoaNhapChinhNgay.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbXoaNhapChinhNgay.Location = new System.Drawing.Point( 16 , 157 );
            this.cbXoaNhapChinhNgay.Name = "cbXoaNhapChinhNgay";
            this.cbXoaNhapChinhNgay.Size = new System.Drawing.Size( 209 , 20 );
            this.cbXoaNhapChinhNgay.TabIndex = 0;
            this.cbXoaNhapChinhNgay.Text = "Xóa, nhập phiếu, chỉnh ngày";
            this.cbXoaNhapChinhNgay.UseVisualStyleBackColor = true;
            // 
            // cbKhongBanHangDuoc
            // 
            this.cbKhongBanHangDuoc.AutoSize = true;
            this.cbKhongBanHangDuoc.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbKhongBanHangDuoc.Location = new System.Drawing.Point( 16 , 131 );
            this.cbKhongBanHangDuoc.Name = "cbKhongBanHangDuoc";
            this.cbKhongBanHangDuoc.Size = new System.Drawing.Size( 285 , 20 );
            this.cbKhongBanHangDuoc.TabIndex = 0;
            this.cbKhongBanHangDuoc.Text = "Không bán hàng được (ko có tồn tại CH)";
            this.cbKhongBanHangDuoc.UseVisualStyleBackColor = true;
            // 
            // cbSoLieuTonKhongDung
            // 
            this.cbSoLieuTonKhongDung.AutoSize = true;
            this.cbSoLieuTonKhongDung.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbSoLieuTonKhongDung.Location = new System.Drawing.Point( 16 , 105 );
            this.cbSoLieuTonKhongDung.Name = "cbSoLieuTonKhongDung";
            this.cbSoLieuTonKhongDung.Size = new System.Drawing.Size( 174 , 20 );
            this.cbSoLieuTonKhongDung.TabIndex = 0;
            this.cbSoLieuTonKhongDung.Text = "Số liệu tồn không đúng";
            this.cbSoLieuTonKhongDung.UseVisualStyleBackColor = true;
            // 
            // cbKhac
            // 
            this.cbKhac.AutoSize = true;
            this.cbKhac.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbKhac.Location = new System.Drawing.Point( 225 , 105 );
            this.cbKhac.Name = "cbKhac";
            this.cbKhac.Size = new System.Drawing.Size( 58 , 20 );
            this.cbKhac.TabIndex = 0;
            this.cbKhac.Text = "Khác";
            this.cbKhac.UseVisualStyleBackColor = true;
            // 
            // cbHuRpro9
            // 
            this.cbHuRpro9.AutoSize = true;
            this.cbHuRpro9.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbHuRpro9.Location = new System.Drawing.Point( 225 , 79 );
            this.cbHuRpro9.Name = "cbHuRpro9";
            this.cbHuRpro9.Size = new System.Drawing.Size( 92 , 20 );
            this.cbHuRpro9.TabIndex = 0;
            this.cbHuRpro9.Text = "Hư RPro 9";
            this.cbHuRpro9.UseVisualStyleBackColor = true;
            // 
            // cbHuBarcode
            // 
            this.cbHuBarcode.AutoSize = true;
            this.cbHuBarcode.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbHuBarcode.Location = new System.Drawing.Point( 16 , 79 );
            this.cbHuBarcode.Name = "cbHuBarcode";
            this.cbHuBarcode.Size = new System.Drawing.Size( 159 , 20 );
            this.cbHuBarcode.TabIndex = 0;
            this.cbHuBarcode.Text = "Hư Barcode Scanner";
            this.cbHuBarcode.UseVisualStyleBackColor = true;
            // 
            // cbHuCPU
            // 
            this.cbHuCPU.AutoSize = true;
            this.cbHuCPU.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbHuCPU.Location = new System.Drawing.Point( 226 , 53 );
            this.cbHuCPU.Name = "cbHuCPU";
            this.cbHuCPU.Size = new System.Drawing.Size( 73 , 20 );
            this.cbHuCPU.TabIndex = 0;
            this.cbHuCPU.Text = "Hư CPU";
            this.cbHuCPU.UseVisualStyleBackColor = true;
            // 
            // cbHuMayIn
            // 
            this.cbHuMayIn.AutoSize = true;
            this.cbHuMayIn.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbHuMayIn.Location = new System.Drawing.Point( 226 , 27 );
            this.cbHuMayIn.Name = "cbHuMayIn";
            this.cbHuMayIn.Size = new System.Drawing.Size( 91 , 20 );
            this.cbHuMayIn.TabIndex = 0;
            this.cbHuMayIn.Text = "Hư Máy in";
            this.cbHuMayIn.UseVisualStyleBackColor = true;
            // 
            // cbHuDienThoai
            // 
            this.cbHuDienThoai.AutoSize = true;
            this.cbHuDienThoai.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbHuDienThoai.Location = new System.Drawing.Point( 16 , 53 );
            this.cbHuDienThoai.Name = "cbHuDienThoai";
            this.cbHuDienThoai.Size = new System.Drawing.Size( 115 , 20 );
            this.cbHuDienThoai.TabIndex = 0;
            this.cbHuDienThoai.Text = "Hư Điện thoại";
            this.cbHuDienThoai.UseVisualStyleBackColor = true;
            // 
            // cbHuInternet
            // 
            this.cbHuInternet.AutoSize = true;
            this.cbHuInternet.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbHuInternet.Location = new System.Drawing.Point( 16 , 27 );
            this.cbHuInternet.Name = "cbHuInternet";
            this.cbHuInternet.Size = new System.Drawing.Size( 104 , 20 );
            this.cbHuInternet.TabIndex = 0;
            this.cbHuInternet.Text = "Hư Internet";
            this.cbHuInternet.UseVisualStyleBackColor = true;
            // 
            // xtraTab
            // 
            this.xtraTab.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.xtraTab.Location = new System.Drawing.Point( 365 , 69 );
            this.xtraTab.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTab.Name = "xtraTab";
            this.xtraTab.PaintStyleName = "PropertyView";
            this.xtraTab.SelectedTabPage = this.xtra_2;
            this.xtraTab.Size = new System.Drawing.Size( 360 , 209 );
            this.xtraTab.TabIndex = 12;
            this.xtraTab.TabPages.AddRange( new DevExpress.XtraTab.XtraTabPage[] {
            this.xtra_2,
            this.xtra_3,
            this.xtra_4,
            this.xtra_5,
            this.xtra_6} );
            // 
            // xtra_2
            // 
            this.xtra_2.Controls.Add( this.txtSoLieuTonKhongDung );
            this.xtra_2.Name = "xtra_2";
            this.xtra_2.Size = new System.Drawing.Size( 358 , 168 );
            this.xtra_2.Text = "Số liệu tồn không đúng";
            // 
            // txtSoLieuTonKhongDung
            // 
            this.txtSoLieuTonKhongDung.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtSoLieuTonKhongDung.Location = new System.Drawing.Point( 3 , 3 );
            this.txtSoLieuTonKhongDung.Name = "txtSoLieuTonKhongDung";
            this.txtSoLieuTonKhongDung.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtSoLieuTonKhongDung.Properties.Appearance.Options.UseFont = true;
            this.txtSoLieuTonKhongDung.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSoLieuTonKhongDung.Size = new System.Drawing.Size( 352 , 160 );
            this.txtSoLieuTonKhongDung.TabIndex = 0;
            this.txtSoLieuTonKhongDung.UseOptimizedRendering = true;
            // 
            // xtra_3
            // 
            this.xtra_3.Controls.Add( this.txtKhongBanHangDuoc );
            this.xtra_3.Name = "xtra_3";
            this.xtra_3.Size = new System.Drawing.Size( 358 , 168 );
            this.xtra_3.Text = "Không bán hàng được";
            // 
            // txtKhongBanHangDuoc
            // 
            this.txtKhongBanHangDuoc.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtKhongBanHangDuoc.Location = new System.Drawing.Point( 3 , 3 );
            this.txtKhongBanHangDuoc.Name = "txtKhongBanHangDuoc";
            this.txtKhongBanHangDuoc.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtKhongBanHangDuoc.Properties.Appearance.Options.UseFont = true;
            this.txtKhongBanHangDuoc.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKhongBanHangDuoc.Size = new System.Drawing.Size( 352 , 160 );
            this.txtKhongBanHangDuoc.TabIndex = 1;
            this.txtKhongBanHangDuoc.UseOptimizedRendering = true;
            // 
            // xtra_4
            // 
            this.xtra_4.Controls.Add( this.txtXoaNhapChinhNgay );
            this.xtra_4.Name = "xtra_4";
            this.xtra_4.Size = new System.Drawing.Size( 358 , 168 );
            this.xtra_4.Text = "Chỉnh sửa chứng từ";
            // 
            // txtXoaNhapChinhNgay
            // 
            this.txtXoaNhapChinhNgay.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtXoaNhapChinhNgay.Location = new System.Drawing.Point( 3 , 3 );
            this.txtXoaNhapChinhNgay.Name = "txtXoaNhapChinhNgay";
            this.txtXoaNhapChinhNgay.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtXoaNhapChinhNgay.Properties.Appearance.Options.UseFont = true;
            this.txtXoaNhapChinhNgay.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXoaNhapChinhNgay.Size = new System.Drawing.Size( 352 , 162 );
            this.txtXoaNhapChinhNgay.TabIndex = 1;
            this.txtXoaNhapChinhNgay.UseOptimizedRendering = true;
            // 
            // xtra_5
            // 
            this.xtra_5.Controls.Add( this.txtKhac );
            this.xtra_5.Name = "xtra_5";
            this.xtra_5.Size = new System.Drawing.Size( 358 , 168 );
            this.xtra_5.Text = "Khác";
            // 
            // txtKhac
            // 
            this.txtKhac.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtKhac.Location = new System.Drawing.Point( 3 , 3 );
            this.txtKhac.Name = "txtKhac";
            this.txtKhac.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtKhac.Properties.Appearance.Options.UseFont = true;
            this.txtKhac.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKhac.Size = new System.Drawing.Size( 352 , 160 );
            this.txtKhac.TabIndex = 2;
            this.txtKhac.UseOptimizedRendering = true;
            // 
            // xtra_6
            // 
            this.xtra_6.Controls.Add( this.txtCaiDatSoftwares );
            this.xtra_6.Name = "xtra_6";
            this.xtra_6.Size = new System.Drawing.Size( 358 , 168 );
            this.xtra_6.Text = "Cài đặt softwares";
            // 
            // txtCaiDatSoftwares
            // 
            this.txtCaiDatSoftwares.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtCaiDatSoftwares.Location = new System.Drawing.Point( 3 , 3 );
            this.txtCaiDatSoftwares.Name = "txtCaiDatSoftwares";
            this.txtCaiDatSoftwares.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtCaiDatSoftwares.Properties.Appearance.Options.UseFont = true;
            this.txtCaiDatSoftwares.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCaiDatSoftwares.Size = new System.Drawing.Size( 352 , 162 );
            this.txtCaiDatSoftwares.TabIndex = 3;
            this.txtCaiDatSoftwares.UseOptimizedRendering = true;
            // 
            // frmIT_HoTroKyThuat_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 737 , 334 );
            this.Controls.Add( this.xtraTab );
            this.Controls.Add( this.cbbIT );
            this.Controls.Add( this.cbbStores );
            this.Controls.Add( this.btSave );
            this.Controls.Add( this.labelControl2 );
            this.Controls.Add( this.labelControl3 );
            this.Controls.Add( this.groupControl2 );
            this.Name = "frmIT_HoTroKyThuat_Create";
            this.Text = "Tạo mới - Hổ trợ";
            this.Load += new System.EventHandler( this.frmIT_HoTroKyThuat_Create_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbStores.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).EndInit();
            this.groupControl2.ResumeLayout( false );
            this.groupControl2.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.xtraTab ) ).EndInit();
            this.xtraTab.ResumeLayout( false );
            this.xtra_2.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtSoLieuTonKhongDung.Properties ) ).EndInit();
            this.xtra_3.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtKhongBanHangDuoc.Properties ) ).EndInit();
            this.xtra_4.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtXoaNhapChinhNgay.Properties ) ).EndInit();
            this.xtra_5.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtKhac.Properties ) ).EndInit();
            this.xtra_6.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtCaiDatSoftwares.Properties ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbIT;
        private DevExpress.XtraEditors.LookUpEdit cbbStores;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.CheckBox cbCaiSoftwares;
        private System.Windows.Forms.CheckBox cbXoaNhapChinhNgay;
        private System.Windows.Forms.CheckBox cbKhongBanHangDuoc;
        private System.Windows.Forms.CheckBox cbSoLieuTonKhongDung;
        private System.Windows.Forms.CheckBox cbKhac;
        private System.Windows.Forms.CheckBox cbHuRpro9;
        private System.Windows.Forms.CheckBox cbHuBarcode;
        private System.Windows.Forms.CheckBox cbHuCPU;
        private System.Windows.Forms.CheckBox cbHuMayIn;
        private System.Windows.Forms.CheckBox cbHuDienThoai;
        private System.Windows.Forms.CheckBox cbHuInternet;
        private DevExpress.XtraTab.XtraTabControl xtraTab;
        private DevExpress.XtraTab.XtraTabPage xtra_2;
        private DevExpress.XtraEditors.MemoEdit txtSoLieuTonKhongDung;
        private DevExpress.XtraTab.XtraTabPage xtra_3;
        private DevExpress.XtraEditors.MemoEdit txtKhongBanHangDuoc;
        private DevExpress.XtraTab.XtraTabPage xtra_4;
        private DevExpress.XtraEditors.MemoEdit txtXoaNhapChinhNgay;
        private DevExpress.XtraTab.XtraTabPage xtra_5;
        private DevExpress.XtraEditors.MemoEdit txtKhac;
        private DevExpress.XtraTab.XtraTabPage xtra_6;
        private DevExpress.XtraEditors.MemoEdit txtCaiDatSoftwares;
    }
}