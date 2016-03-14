namespace VFC._PromotionCode
{
    partial class frmProCode_GetCode
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
            this.lbInfo = new DevExpress.XtraEditors.LabelControl();
            this.listLoaiKM = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.dateCreate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbTotalWaiting = new DevExpress.XtraEditors.LabelControl();
            this.lbTotalAvailable = new DevExpress.XtraEditors.LabelControl();
            this.lbTotalExpire = new DevExpress.XtraEditors.LabelControl();
            this.lbTotalUsed = new DevExpress.XtraEditors.LabelControl();
            this.lbTotalGet = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbCountDown = new DevExpress.XtraEditors.LabelControl();
            this.dateExpire = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btCreate = new DevExpress.XtraEditors.SimpleButton();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.txtAmountKM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.txtSlgNgayHetHan = new DevExpress.XtraEditors.TextEdit();
            this.timer1 = new System.Windows.Forms.Timer( this.components );
            this.lbTotalWaitingHide = new DevExpress.XtraEditors.LabelControl();
            ( (System.ComponentModel.ISupportInitialize) ( this.listLoaiKM.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateCreate.Properties.CalendarTimeProperties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateCreate.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).BeginInit();
            this.groupControl2.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateExpire.Properties.CalendarTimeProperties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateExpire.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtNote.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtAmountKM.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).BeginInit();
            this.groupControl1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtQty.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtSlgNgayHetHan.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Appearance.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbInfo.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbInfo.Location = new System.Drawing.Point( 16 , 170 );
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size( 58 , 23 );
            this.lbInfo.TabIndex = 7;
            this.lbInfo.Text = "lbInfo";
            // 
            // listLoaiKM
            // 
            this.listLoaiKM.Location = new System.Drawing.Point( 175 , 167 );
            this.listLoaiKM.Name = "listLoaiKM";
            this.listLoaiKM.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.listLoaiKM.Properties.Appearance.Options.UseFont = true;
            this.listLoaiKM.Properties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.listLoaiKM.Properties.Columns.AddRange( new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoaiKMDescription", "Loại Khuyến Mãi")} );
            this.listLoaiKM.Properties.DisplayMember = "LoaiKMDescription";
            this.listLoaiKM.Properties.ValueMember = "LoaiKMID";
            this.listLoaiKM.Size = new System.Drawing.Size( 158 , 26 );
            this.listLoaiKM.TabIndex = 8;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl11.Location = new System.Drawing.Point( 16 , 67 );
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size( 217 , 19 );
            this.labelControl11.TabIndex = 6;
            this.labelControl11.Text = "Số code đã được sử dụng : ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl7.Location = new System.Drawing.Point( 12 , 292 );
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size( 76 , 19 );
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Ghi chú : ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl8.Location = new System.Drawing.Point( 33 , 117 );
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size( 200 , 19 );
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "Số code đang lưu hành : ";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl12.Location = new System.Drawing.Point( 42 , 42 );
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size( 191 , 19 );
            this.labelControl12.TabIndex = 7;
            this.labelControl12.Text = "Số code đã phát hành : ";
            // 
            // dateCreate
            // 
            this.dateCreate.EditValue = null;
            this.dateCreate.Enabled = false;
            this.dateCreate.Location = new System.Drawing.Point( 174 , 71 );
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.dateCreate.Properties.Appearance.Options.UseFont = true;
            this.dateCreate.Properties.Appearance.Options.UseTextOptions = true;
            this.dateCreate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateCreate.Properties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.dateCreate.Properties.CalendarTimeProperties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.dateCreate.Size = new System.Drawing.Size( 157 , 26 );
            this.dateCreate.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl5.Location = new System.Drawing.Point( 11 , 106 );
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size( 154 , 19 );
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Slg ngày sử dụng : ";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add( this.labelControl12 );
            this.groupControl2.Controls.Add( this.lbInfo );
            this.groupControl2.Controls.Add( this.labelControl11 );
            this.groupControl2.Controls.Add( this.labelControl8 );
            this.groupControl2.Controls.Add( this.lbTotalWaitingHide );
            this.groupControl2.Controls.Add( this.lbTotalWaiting );
            this.groupControl2.Controls.Add( this.lbTotalAvailable );
            this.groupControl2.Controls.Add( this.lbTotalExpire );
            this.groupControl2.Controls.Add( this.lbTotalUsed );
            this.groupControl2.Controls.Add( this.lbTotalGet );
            this.groupControl2.Controls.Add( this.labelControl9 );
            this.groupControl2.Controls.Add( this.labelControl10 );
            this.groupControl2.Location = new System.Drawing.Point( 371 , 12 );
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size( 387 , 271 );
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "Inventory";
            // 
            // lbTotalWaiting
            // 
            this.lbTotalWaiting.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbTotalWaiting.Location = new System.Drawing.Point( 239 , 142 );
            this.lbTotalWaiting.Name = "lbTotalWaiting";
            this.lbTotalWaiting.Size = new System.Drawing.Size( 121 , 19 );
            this.lbTotalWaiting.TabIndex = 7;
            this.lbTotalWaiting.Text = "lbTotalWaiting";
            // 
            // lbTotalAvailable
            // 
            this.lbTotalAvailable.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbTotalAvailable.Location = new System.Drawing.Point( 239 , 117 );
            this.lbTotalAvailable.Name = "lbTotalAvailable";
            this.lbTotalAvailable.Size = new System.Drawing.Size( 134 , 19 );
            this.lbTotalAvailable.TabIndex = 7;
            this.lbTotalAvailable.Text = "lbTotalAvailable";
            // 
            // lbTotalExpire
            // 
            this.lbTotalExpire.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbTotalExpire.Location = new System.Drawing.Point( 239 , 92 );
            this.lbTotalExpire.Name = "lbTotalExpire";
            this.lbTotalExpire.Size = new System.Drawing.Size( 110 , 19 );
            this.lbTotalExpire.TabIndex = 7;
            this.lbTotalExpire.Text = "lbTotalExpire";
            // 
            // lbTotalUsed
            // 
            this.lbTotalUsed.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbTotalUsed.Location = new System.Drawing.Point( 239 , 67 );
            this.lbTotalUsed.Name = "lbTotalUsed";
            this.lbTotalUsed.Size = new System.Drawing.Size( 98 , 19 );
            this.lbTotalUsed.TabIndex = 7;
            this.lbTotalUsed.Text = "lbTotalUsed";
            // 
            // lbTotalGet
            // 
            this.lbTotalGet.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbTotalGet.Location = new System.Drawing.Point( 239 , 42 );
            this.lbTotalGet.Name = "lbTotalGet";
            this.lbTotalGet.Size = new System.Drawing.Size( 87 , 19 );
            this.lbTotalGet.TabIndex = 7;
            this.lbTotalGet.Text = "lbTotalGet";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl9.Location = new System.Drawing.Point( 161 , 142 );
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size( 72 , 19 );
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Còn lại : ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl10.Location = new System.Drawing.Point( 62 , 92 );
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size( 171 , 19 );
            this.labelControl10.TabIndex = 7;
            this.labelControl10.Text = "Số code đã hết hạn : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl3.Location = new System.Drawing.Point( 76 , 74 );
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size( 89 , 19 );
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ngày tạo : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 32 , 42 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 133 , 19 );
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Số lượng Code : ";
            // 
            // lbCountDown
            // 
            this.lbCountDown.Appearance.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbCountDown.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbCountDown.Location = new System.Drawing.Point( 5 , 243 );
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size( 130 , 23 );
            this.lbCountDown.TabIndex = 12;
            this.lbCountDown.Text = "lbCountDown";
            // 
            // dateExpire
            // 
            this.dateExpire.EditValue = null;
            this.dateExpire.Enabled = false;
            this.dateExpire.Location = new System.Drawing.Point( 174 , 135 );
            this.dateExpire.Name = "dateExpire";
            this.dateExpire.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.dateExpire.Properties.Appearance.Options.UseFont = true;
            this.dateExpire.Properties.Appearance.Options.UseTextOptions = true;
            this.dateExpire.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateExpire.Properties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.dateExpire.Properties.CalendarTimeProperties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.dateExpire.Size = new System.Drawing.Size( 157 , 26 );
            this.dateExpire.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Location = new System.Drawing.Point( 16 , 170 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 149 , 19 );
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Loại khuyển mãi : ";
            // 
            // btCancel
            // 
            this.btCancel.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btCancel.Appearance.Options.UseFont = true;
            this.btCancel.Location = new System.Drawing.Point( 255 , 231 );
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size( 75 , 30 );
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Hủy";
            this.btCancel.Click += new System.EventHandler( this.btCancel_Click );
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl4.Location = new System.Drawing.Point( 41 , 138 );
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size( 124 , 19 );
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Ngày hết hạn : ";
            // 
            // btCreate
            // 
            this.btCreate.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btCreate.Appearance.Options.UseFont = true;
            this.btCreate.Location = new System.Drawing.Point( 174 , 231 );
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size( 75 , 30 );
            this.btCreate.TabIndex = 4;
            this.btCreate.Text = "Tạo";
            this.btCreate.Click += new System.EventHandler( this.btCreate_Click );
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point( 88 , 289 );
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Size = new System.Drawing.Size( 670 , 113 );
            this.txtNote.TabIndex = 16;
            this.txtNote.UseOptimizedRendering = true;
            // 
            // txtAmountKM
            // 
            this.txtAmountKM.Location = new System.Drawing.Point( 174 , 199 );
            this.txtAmountKM.Name = "txtAmountKM";
            this.txtAmountKM.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtAmountKM.Properties.Appearance.Options.UseFont = true;
            this.txtAmountKM.Size = new System.Drawing.Size( 158 , 26 );
            this.txtAmountKM.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl6.Location = new System.Drawing.Point( 98 , 202 );
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size( 67 , 19 );
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Giá trị : ";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add( this.lbCountDown );
            this.groupControl1.Controls.Add( this.labelControl1 );
            this.groupControl1.Controls.Add( this.listLoaiKM );
            this.groupControl1.Controls.Add( this.labelControl3 );
            this.groupControl1.Controls.Add( this.dateCreate );
            this.groupControl1.Controls.Add( this.labelControl5 );
            this.groupControl1.Controls.Add( this.dateExpire );
            this.groupControl1.Controls.Add( this.labelControl2 );
            this.groupControl1.Controls.Add( this.btCancel );
            this.groupControl1.Controls.Add( this.labelControl4 );
            this.groupControl1.Controls.Add( this.btCreate );
            this.groupControl1.Controls.Add( this.labelControl6 );
            this.groupControl1.Controls.Add( this.txtAmountKM );
            this.groupControl1.Controls.Add( this.txtQty );
            this.groupControl1.Controls.Add( this.txtSlgNgayHetHan );
            this.groupControl1.Location = new System.Drawing.Point( 12 , 12 );
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size( 350 , 271 );
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Get Promotion Code";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point( 174 , 39 );
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtQty.Properties.Appearance.Options.UseFont = true;
            this.txtQty.Size = new System.Drawing.Size( 158 , 26 );
            this.txtQty.TabIndex = 1;
            // 
            // txtSlgNgayHetHan
            // 
            this.txtSlgNgayHetHan.Location = new System.Drawing.Point( 174 , 103 );
            this.txtSlgNgayHetHan.Name = "txtSlgNgayHetHan";
            this.txtSlgNgayHetHan.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtSlgNgayHetHan.Properties.Appearance.Options.UseFont = true;
            this.txtSlgNgayHetHan.Size = new System.Drawing.Size( 158 , 26 );
            this.txtSlgNgayHetHan.TabIndex = 1;
            this.txtSlgNgayHetHan.EditValueChanged += new System.EventHandler( this.txtSlgNgayHetHan_EditValueChanged );
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler( this.timer1_Tick );
            // 
            // lbTotalWaitingHide
            // 
            this.lbTotalWaitingHide.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbTotalWaitingHide.Location = new System.Drawing.Point( 5 , 145 );
            this.lbTotalWaitingHide.Name = "lbTotalWaitingHide";
            this.lbTotalWaitingHide.Size = new System.Drawing.Size( 121 , 19 );
            this.lbTotalWaitingHide.TabIndex = 7;
            this.lbTotalWaitingHide.Text = "lbTotalWaiting";
            this.lbTotalWaitingHide.Visible = false;
            // 
            // frmProCode_GetCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 773 , 414 );
            this.Controls.Add( this.labelControl7 );
            this.Controls.Add( this.groupControl2 );
            this.Controls.Add( this.txtNote );
            this.Controls.Add( this.groupControl1 );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProCode_GetCode";
            this.Text = "Get Code";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler( this.frmProCode_GetCode_FormClosed );
            this.Load += new System.EventHandler( this.frmProCode_GetCode_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.listLoaiKM.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateCreate.Properties.CalendarTimeProperties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateCreate.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).EndInit();
            this.groupControl2.ResumeLayout( false );
            this.groupControl2.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateExpire.Properties.CalendarTimeProperties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateExpire.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtNote.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtAmountKM.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).EndInit();
            this.groupControl1.ResumeLayout( false );
            this.groupControl1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtQty.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtSlgNgayHetHan.Properties ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbInfo;
        private DevExpress.XtraEditors.LookUpEdit listLoaiKM;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.DateEdit dateCreate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lbTotalWaiting;
        private DevExpress.XtraEditors.LabelControl lbTotalAvailable;
        private DevExpress.XtraEditors.LabelControl lbTotalExpire;
        private DevExpress.XtraEditors.LabelControl lbTotalUsed;
        private DevExpress.XtraEditors.LabelControl lbTotalGet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbCountDown;
        private DevExpress.XtraEditors.DateEdit dateExpire;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btCreate;
        private DevExpress.XtraEditors.MemoEdit txtNote;
        private DevExpress.XtraEditors.TextEdit txtAmountKM;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private DevExpress.XtraEditors.TextEdit txtSlgNgayHetHan;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lbTotalWaitingHide;
    }
}