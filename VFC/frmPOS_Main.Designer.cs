namespace VFC
{
    partial class frmPOS_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS_Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection_16 = new DevExpress.Utils.ImageCollection(this.components);
            this.bt_MER_InventoryLookUp = new DevExpress.XtraBars.BarButtonItem();
            this.lbComputerName = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lbStoreNo = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.lbStoreCode = new DevExpress.XtraBars.BarStaticItem();
            this.bt_SALE_XemDoanhThu_Store = new DevExpress.XtraBars.BarButtonItem();
            this.lbCheckPOS = new DevExpress.XtraBars.BarStaticItem();
            this.bt_ProCode_UseCode = new DevExpress.XtraBars.BarButtonItem();
            this.bt_TOOLS_CheckASN = new DevExpress.XtraBars.BarButtonItem();
            this.bt_VFCHO = new DevExpress.XtraBars.BarButtonItem();
            this.btBNDoSua = new DevExpress.XtraBars.BarButtonItem();
            this.bt_CTKM_TriAnKH_112015 = new DevExpress.XtraBars.BarButtonItem();
            this.bt_Insert_DS_NVBH = new DevExpress.XtraBars.BarButtonItem();
            this.bt_NVBH_CheckInOut = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection_64 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage_LookUp = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_POS = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_Promotion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_Tools = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer_Admin_POS_ForceUpdate = new System.Windows.Forms.Timer(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.timer_10mins = new System.Windows.Forms.Timer(this.components);
            this.bt_NVBH_Insert = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.imageCollection_16;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bt_MER_InventoryLookUp,
            this.lbComputerName,
            this.barStaticItem1,
            this.lbStoreNo,
            this.barStaticItem2,
            this.lbStoreCode,
            this.bt_SALE_XemDoanhThu_Store,
            this.lbCheckPOS,
            this.bt_ProCode_UseCode,
            this.bt_TOOLS_CheckASN,
            this.bt_VFCHO,
            this.btBNDoSua,
            this.bt_CTKM_TriAnKH_112015,
            this.bt_Insert_DS_NVBH,
            this.bt_NVBH_CheckInOut,
            this.bt_NVBH_Insert});
            this.ribbon.LargeImages = this.imageCollection_64;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 24;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_LookUp,
            this.ribbonPage_POS,
            this.ribbonPage_Promotion,
            this.ribbonPage_Tools});
            this.ribbon.Size = new System.Drawing.Size(771, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ItemLinks.Add(this.bt_VFCHO);
            // 
            // imageCollection_16
            // 
            this.imageCollection_16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection_16.ImageStream")));
            this.imageCollection_16.Images.SetKeyName(0, "User_16x16.png");
            this.imageCollection_16.Images.SetKeyName(1, "Globe_16x16.png");
            this.imageCollection_16.Images.SetKeyName(2, "computer16x16 24-bit.png");
            this.imageCollection_16.Images.SetKeyName(3, "Number-1-icon.png");
            this.imageCollection_16.Images.SetKeyName(4, "Number-2-icon.png");
            this.imageCollection_16.Images.SetKeyName(5, "Number-3-icon.png");
            this.imageCollection_16.Images.SetKeyName(6, "Number-4-icon.png");
            this.imageCollection_16.Images.SetKeyName(7, "Number-5-icon.png");
            this.imageCollection_16.Images.SetKeyName(8, "Number-6-icon.png");
            this.imageCollection_16.Images.SetKeyName(9, "Number-7-icon.png");
            this.imageCollection_16.Images.SetKeyName(10, "Number-8-icon.png");
            this.imageCollection_16.Images.SetKeyName(11, "Number-9-icon.png");
            this.imageCollection_16.Images.SetKeyName(12, "System.ico");
            this.imageCollection_16.Images.SetKeyName(13, "Computer.png");
            this.imageCollection_16.Images.SetKeyName(14, "Sale.png");
            this.imageCollection_16.Images.SetKeyName(15, "login.png");
            this.imageCollection_16.Images.SetKeyName(16, "Question.png");
            this.imageCollection_16.Images.SetKeyName(17, "alert.png");
            this.imageCollection_16.Images.SetKeyName(18, "Apply.png");
            this.imageCollection_16.Images.SetKeyName(19, "cancel.png");
            this.imageCollection_16.Images.SetKeyName(20, "Cube.png");
            this.imageCollection_16.Images.SetKeyName(21, "email.png");
            this.imageCollection_16.Images.SetKeyName(22, "Error.png");
            this.imageCollection_16.Images.SetKeyName(23, "logs.jpg");
            this.imageCollection_16.Images.SetKeyName(24, "padlock.png");
            this.imageCollection_16.Images.SetKeyName(25, "Planet.png");
            this.imageCollection_16.Images.SetKeyName(26, "Plus.png");
            this.imageCollection_16.Images.SetKeyName(27, "question.png");
            this.imageCollection_16.Images.SetKeyName(28, "star_48.png");
            this.imageCollection_16.Images.SetKeyName(29, "attachment.ico");
            this.imageCollection_16.Images.SetKeyName(30, "calculator.ico");
            this.imageCollection_16.Images.SetKeyName(31, "contact.ico");
            this.imageCollection_16.Images.SetKeyName(32, "maintenance.ico");
            this.imageCollection_16.Images.SetKeyName(33, "Podium.ico");
            this.imageCollection_16.Images.SetKeyName(34, "tests.ico");
            this.imageCollection_16.Images.SetKeyName(35, "themes.ico");
            this.imageCollection_16.Images.SetKeyName(36, "Search.png");
            this.imageCollection_16.Images.SetKeyName(37, "Switch.png");
            this.imageCollection_16.Images.SetKeyName(38, "asterisk_orange.png");
            this.imageCollection_16.Images.SetKeyName(39, "auction_hammer_gavel.png");
            this.imageCollection_16.Images.SetKeyName(40, "file_extension_xls.png");
            this.imageCollection_16.Images.SetKeyName(41, "personal_finance.png");
            this.imageCollection_16.Images.SetKeyName(42, "pill.png");
            this.imageCollection_16.Images.SetKeyName(43, "Plant.png");
            this.imageCollection_16.Images.SetKeyName(44, "roadworks.png");
            this.imageCollection_16.Images.SetKeyName(45, "rubber_duck.png");
            this.imageCollection_16.Images.SetKeyName(46, "ruby.png");
            this.imageCollection_16.Images.SetKeyName(47, "setting_tools.png");
            this.imageCollection_16.Images.SetKeyName(48, "small_business.png");
            this.imageCollection_16.Images.SetKeyName(49, "ic_Store_1.jpg");
            this.imageCollection_16.Images.SetKeyName(50, "images.jpg");
            // 
            // bt_MER_InventoryLookUp
            // 
            this.bt_MER_InventoryLookUp.Caption = "Tồn kho";
            this.bt_MER_InventoryLookUp.Id = 1;
            this.bt_MER_InventoryLookUp.LargeImageIndex = 11;
            this.bt_MER_InventoryLookUp.Name = "bt_MER_InventoryLookUp";
            this.bt_MER_InventoryLookUp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bt_MER_InventoryLookUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_MER_InventoryLookUp_ItemClick);
            // 
            // lbComputerName
            // 
            this.lbComputerName.Caption = "lbCompName";
            this.lbComputerName.Id = 2;
            this.lbComputerName.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerName.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lbComputerName.ItemAppearance.Normal.Options.UseFont = true;
            this.lbComputerName.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lbComputerName.Name = "lbComputerName";
            this.lbComputerName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "/";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbStoreNo
            // 
            this.lbStoreNo.Caption = "lbStoreNo";
            this.lbStoreNo.Id = 4;
            this.lbStoreNo.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStoreNo.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbStoreNo.ItemAppearance.Normal.Options.UseFont = true;
            this.lbStoreNo.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lbStoreNo.Name = "lbStoreNo";
            this.lbStoreNo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "/";
            this.barStaticItem2.Id = 5;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbStoreCode
            // 
            this.lbStoreCode.Caption = "lbStoreCode";
            this.lbStoreCode.Id = 6;
            this.lbStoreCode.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStoreCode.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            this.lbStoreCode.ItemAppearance.Normal.Options.UseFont = true;
            this.lbStoreCode.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lbStoreCode.Name = "lbStoreCode";
            this.lbStoreCode.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bt_SALE_XemDoanhThu_Store
            // 
            this.bt_SALE_XemDoanhThu_Store.Caption = "Xem Doanh Thu";
            this.bt_SALE_XemDoanhThu_Store.Id = 8;
            this.bt_SALE_XemDoanhThu_Store.LargeImageIndex = 19;
            this.bt_SALE_XemDoanhThu_Store.Name = "bt_SALE_XemDoanhThu_Store";
            this.bt_SALE_XemDoanhThu_Store.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bt_SALE_XemDoanhThu_Store.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_SALE_XemDoanhThu_Store_ItemClick);
            // 
            // lbCheckPOS
            // 
            this.lbCheckPOS.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbCheckPOS.Caption = "lbCheckPOS";
            this.lbCheckPOS.Id = 10;
            this.lbCheckPOS.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckPOS.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lbCheckPOS.ItemAppearance.Normal.Options.UseFont = true;
            this.lbCheckPOS.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lbCheckPOS.Name = "lbCheckPOS";
            this.lbCheckPOS.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bt_ProCode_UseCode
            // 
            this.bt_ProCode_UseCode.Caption = "Sử dụng Code";
            this.bt_ProCode_UseCode.Id = 11;
            this.bt_ProCode_UseCode.LargeImageIndex = 3;
            this.bt_ProCode_UseCode.Name = "bt_ProCode_UseCode";
            this.bt_ProCode_UseCode.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bt_ProCode_UseCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ProCode_UseCode_ItemClick);
            // 
            // bt_TOOLS_CheckASN
            // 
            this.bt_TOOLS_CheckASN.Caption = "Kiểm tra ASN";
            this.bt_TOOLS_CheckASN.Id = 12;
            this.bt_TOOLS_CheckASN.LargeImageIndex = 20;
            this.bt_TOOLS_CheckASN.Name = "bt_TOOLS_CheckASN";
            this.bt_TOOLS_CheckASN.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bt_TOOLS_CheckASN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_TOOLS_CheckASN_ItemClick);
            // 
            // bt_VFCHO
            // 
            this.bt_VFCHO.Caption = "VFC HO";
            this.bt_VFCHO.Id = 18;
            this.bt_VFCHO.Name = "bt_VFCHO";
            this.bt_VFCHO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_VFCHO_ItemClick);
            // 
            // btBNDoSua
            // 
            this.btBNDoSua.Caption = "Biên nhận Đồ sửa";
            this.btBNDoSua.Enabled = false;
            this.btBNDoSua.Id = 19;
            this.btBNDoSua.Name = "btBNDoSua";
            this.btBNDoSua.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btBNDoSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btBNDoSua_ItemClick);
            // 
            // bt_CTKM_TriAnKH_112015
            // 
            this.bt_CTKM_TriAnKH_112015.Caption = "Tri Ân Khách Hàng";
            this.bt_CTKM_TriAnKH_112015.Enabled = false;
            this.bt_CTKM_TriAnKH_112015.Id = 20;
            this.bt_CTKM_TriAnKH_112015.LargeImageIndex = 22;
            this.bt_CTKM_TriAnKH_112015.Name = "bt_CTKM_TriAnKH_112015";
            this.bt_CTKM_TriAnKH_112015.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bt_CTKM_TriAnKH_112015.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_CTKM_TriAnKH_112015_ItemClick);
            // 
            // bt_Insert_DS_NVBH
            // 
            this.bt_Insert_DS_NVBH.Caption = "Add Doanh Số NVBH";
            this.bt_Insert_DS_NVBH.Glyph = ((System.Drawing.Image)(resources.GetObject("bt_Insert_DS_NVBH.Glyph")));
            this.bt_Insert_DS_NVBH.Id = 21;
            this.bt_Insert_DS_NVBH.Name = "bt_Insert_DS_NVBH";
            this.bt_Insert_DS_NVBH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bt_Insert_DS_NVBH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_Insert_DS_NVBH_ItemClick);
            // 
            // bt_NVBH_CheckInOut
            // 
            this.bt_NVBH_CheckInOut.Caption = "Chấm công";
            this.bt_NVBH_CheckInOut.Glyph = ((System.Drawing.Image)(resources.GetObject("bt_NVBH_CheckInOut.Glyph")));
            this.bt_NVBH_CheckInOut.Id = 22;
            this.bt_NVBH_CheckInOut.Name = "bt_NVBH_CheckInOut";
            this.bt_NVBH_CheckInOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bt_NVBH_CheckInOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_NVBH_CheckInOut_ItemClick);
            // 
            // imageCollection_64
            // 
            this.imageCollection_64.ImageSize = new System.Drawing.Size(96, 96);
            this.imageCollection_64.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection_64.ImageStream")));
            this.imageCollection_64.Images.SetKeyName(0, "logs.jpg");
            this.imageCollection_64.Images.SetKeyName(1, "manageUser.jpg");
            this.imageCollection_64.Images.SetKeyName(2, "Pin.png");
            this.imageCollection_64.Images.SetKeyName(3, "Planet.png");
            this.imageCollection_64.Images.SetKeyName(4, "Question_mark.png");
            this.imageCollection_64.Images.SetKeyName(5, "Reciept.png");
            this.imageCollection_64.Images.SetKeyName(6, "ResetPass.jpg");
            this.imageCollection_64.Images.SetKeyName(7, "stop.ico");
            this.imageCollection_64.Images.SetKeyName(8, "stop-red.ico");
            this.imageCollection_64.Images.SetKeyName(9, "print.ico");
            this.imageCollection_64.Images.SetKeyName(10, "Database.png");
            this.imageCollection_64.Images.SetKeyName(11, "ic_Store_1.jpg");
            this.imageCollection_64.Images.SetKeyName(12, "images.jpg");
            this.imageCollection_64.Images.SetKeyName(13, "contact.ico");
            this.imageCollection_64.Images.SetKeyName(14, "ResetPass.jpg");
            this.imageCollection_64.Images.SetKeyName(15, "logout-button-md.png");
            this.imageCollection_64.Images.SetKeyName(16, "quit.jpg");
            this.imageCollection_64.Images.SetKeyName(17, "stock-photo-logout-power-off-icon-glossy-red-reflected-square-button-115427041.jp" +
        "g");
            this.imageCollection_64.Images.SetKeyName(18, "400_F_30491549_XpEdNEd4soF2bV8z95CuCSkTwxMySP9p.jpg");
            this.imageCollection_64.Images.SetKeyName(19, "80.png");
            this.imageCollection_64.Images.SetKeyName(20, "10.png");
            this.imageCollection_64.Images.SetKeyName(21, "image_!.gif");
            this.imageCollection_64.Images.SetKeyName(22, "[FREE-RELAX.RU] (51).png");
            // 
            // ribbonPage_LookUp
            // 
            this.ribbonPage_LookUp.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage_LookUp.Name = "ribbonPage_LookUp";
            this.ribbonPage_LookUp.Text = "Tra cứu thông tin";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bt_MER_InventoryLookUp);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hàng hóa";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bt_SALE_XemDoanhThu_Store);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Doanh thu";
            // 
            // ribbonPage_POS
            // 
            this.ribbonPage_POS.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage_POS.Name = "ribbonPage_POS";
            this.ribbonPage_POS.Text = "Cửa hàng";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.bt_Insert_DS_NVBH);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.bt_NVBH_CheckInOut);
            this.ribbonPageGroup8.ItemLinks.Add(this.bt_NVBH_Insert);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPage_Promotion
            // 
            this.ribbonPage_Promotion.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.ribbonPage_Promotion.Name = "ribbonPage_Promotion";
            this.ribbonPage_Promotion.Text = "Chương trình khuyến mại";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.bt_ProCode_UseCode);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Promotion Code";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.bt_CTKM_TriAnKH_112015);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Tri Ân Khách Hàng";
            // 
            // ribbonPage_Tools
            // 
            this.ribbonPage_Tools.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage_Tools.Name = "ribbonPage_Tools";
            this.ribbonPage_Tools.Text = "Hổ trợ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.bt_TOOLS_CheckASN);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btBNDoSua);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lbComputerName);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.lbStoreNo);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.ItemLinks.Add(this.lbStoreCode);
            this.ribbonStatusBar.ItemLinks.Add(this.lbCheckPOS);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 475);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(771, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Red;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.xtraTabbedMdiManager1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // timer_Admin_POS_ForceUpdate
            // 
            this.timer_Admin_POS_ForceUpdate.Interval = 60000;
            this.timer_Admin_POS_ForceUpdate.Tick += new System.EventHandler(this.timer_Admin_POS_ForceUpdate_Tick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kiểm tra ASN";
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Kiểm tra ASN";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // timer_10mins
            // 
            this.timer_10mins.Interval = 600000;
            this.timer_10mins.Tick += new System.EventHandler(this.timer_10mins_Tick);
            // 
            // bt_NVBH_Insert
            // 
            this.bt_NVBH_Insert.Caption = "Tạo mới NVBH";
            this.bt_NVBH_Insert.Glyph = ((System.Drawing.Image)(resources.GetObject("bt_NVBH_Insert.Glyph")));
            this.bt_NVBH_Insert.Id = 23;
            this.bt_NVBH_Insert.Name = "bt_NVBH_Insert";
            this.bt_NVBH_Insert.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bt_NVBH_Insert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_NVBH_Insert_ItemClick);
            // 
            // frmPOS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 506);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPOS_Main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "VFC - POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPOS_Main_FormClosed);
            this.Load += new System.EventHandler(this.frmPOS_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_LookUp;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bt_MER_InventoryLookUp;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarStaticItem lbComputerName;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem lbStoreNo;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem lbStoreCode;
        private DevExpress.XtraBars.BarButtonItem bt_SALE_XemDoanhThu_Store;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem lbCheckPOS;
        private DevExpress.XtraBars.BarButtonItem bt_ProCode_UseCode;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Promotion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bt_TOOLS_CheckASN;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Tools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private System.Windows.Forms.Timer timer_Admin_POS_ForceUpdate;
        private DevExpress.XtraBars.BarButtonItem bt_VFCHO;
        private DevExpress.XtraBars.BarButtonItem btBNDoSua;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.Utils.ImageCollection imageCollection_64;
        private DevExpress.Utils.ImageCollection imageCollection_16;
        private System.Windows.Forms.Timer timer_10mins;
        private DevExpress.XtraBars.BarButtonItem bt_CTKM_TriAnKH_112015;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem bt_Insert_DS_NVBH;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_POS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem bt_NVBH_CheckInOut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem bt_NVBH_Insert;
    }
}