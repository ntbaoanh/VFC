namespace VFC._SoLieu
{
    partial class frmSoLieu_TaoMoiCapNhatTonKho
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateDateKK = new DevExpress.XtraEditors.DateEdit();
            this.txtKKQty = new DevExpress.XtraEditors.TextEdit();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.btCreate = new DevExpress.XtraEditors.SimpleButton();
            this.cbbStores = new DevExpress.XtraEditors.LookUpEdit();
            this.lbITPhuTrach = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).BeginInit();
            this.groupControl1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateDateKK.Properties.CalendarTimeProperties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateDateKK.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtKKQty.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbStores.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add( this.dateDateKK );
            this.groupControl1.Controls.Add( this.txtKKQty );
            this.groupControl1.Controls.Add( this.btClose );
            this.groupControl1.Controls.Add( this.btCreate );
            this.groupControl1.Controls.Add( this.cbbStores );
            this.groupControl1.Controls.Add( this.lbITPhuTrach );
            this.groupControl1.Controls.Add( this.labelControl4 );
            this.groupControl1.Controls.Add( this.labelControl3 );
            this.groupControl1.Controls.Add( this.labelControl2 );
            this.groupControl1.Controls.Add( this.labelControl1 );
            this.groupControl1.Location = new System.Drawing.Point( 12 , 12 );
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size( 328 , 173 );
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin";
            // 
            // dateDateKK
            // 
            this.dateDateKK.EditValue = null;
            this.dateDateKK.Location = new System.Drawing.Point( 129 , 88 );
            this.dateDateKK.Name = "dateDateKK";
            this.dateDateKK.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.dateDateKK.Properties.Appearance.Options.UseFont = true;
            this.dateDateKK.Properties.Appearance.Options.UseTextOptions = true;
            this.dateDateKK.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateDateKK.Properties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.dateDateKK.Properties.CalendarTimeProperties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.dateDateKK.Size = new System.Drawing.Size( 155 , 20 );
            this.dateDateKK.TabIndex = 3;
            // 
            // txtKKQty
            // 
            this.txtKKQty.Location = new System.Drawing.Point( 129 , 60 );
            this.txtKKQty.Name = "txtKKQty";
            this.txtKKQty.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtKKQty.Properties.Appearance.Options.UseFont = true;
            this.txtKKQty.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKKQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKKQty.Size = new System.Drawing.Size( 155 , 22 );
            this.txtKKQty.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btClose.Appearance.Options.UseFont = true;
            this.btClose.Location = new System.Drawing.Point( 209 , 138 );
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size( 75 , 23 );
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.Click += new System.EventHandler( this.btClose_Click );
            // 
            // btCreate
            // 
            this.btCreate.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btCreate.Appearance.Options.UseFont = true;
            this.btCreate.Location = new System.Drawing.Point( 128 , 138 );
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size( 75 , 23 );
            this.btCreate.TabIndex = 4;
            this.btCreate.Text = "Tạo";
            this.btCreate.Click += new System.EventHandler( this.btCreate_Click );
            // 
            // cbbStores
            // 
            this.cbbStores.Location = new System.Drawing.Point( 129 , 32 );
            this.cbbStores.Name = "cbbStores";
            this.cbbStores.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbbStores.Properties.Appearance.Options.UseFont = true;
            this.cbbStores.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbStores.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbStores.Properties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.cbbStores.Properties.Columns.AddRange( new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STORE_CODE", "Cửa hàng")} );
            this.cbbStores.Properties.DisplayMember = "STORE_CODE";
            this.cbbStores.Properties.DropDownRows = 10;
            this.cbbStores.Properties.ValueMember = "STORE_CODE";
            this.cbbStores.Size = new System.Drawing.Size( 155 , 22 );
            this.cbbStores.TabIndex = 1;
            this.cbbStores.EditValueChanged += new System.EventHandler( this.cbbStores_EditValueChanged );
            // 
            // lbITPhuTrach
            // 
            this.lbITPhuTrach.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbITPhuTrach.Location = new System.Drawing.Point( 129 , 116 );
            this.lbITPhuTrach.Name = "lbITPhuTrach";
            this.lbITPhuTrach.Size = new System.Drawing.Size( 83 , 16 );
            this.lbITPhuTrach.TabIndex = 0;
            this.lbITPhuTrach.Text = "lbITPhuTrach";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl4.Location = new System.Drawing.Point( 31 , 116 );
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size( 92 , 16 );
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "IT Phụ trách : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl3.Location = new System.Drawing.Point( 26 , 91 );
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size( 97 , 16 );
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày kiểm kê : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Location = new System.Drawing.Point( 40 , 63 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 83 , 16 );
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tồn đầy kỳ : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 49 , 35 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 74 , 16 );
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cửa hàng : ";
            // 
            // frmSoLieu_TaoMoiCapNhatTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 354 , 193 );
            this.Controls.Add( this.groupControl1 );
            this.Name = "frmSoLieu_TaoMoiCapNhatTonKho";
            this.Text = "Tạo mới Cập Nhật Tồn Kho";
            this.Load += new System.EventHandler( this.frmSoLieu_TaoMoiCapNhatTonKho_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).EndInit();
            this.groupControl1.ResumeLayout( false );
            this.groupControl1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateDateKK.Properties.CalendarTimeProperties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.dateDateKK.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtKKQty.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbStores.Properties ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateDateKK;
        private DevExpress.XtraEditors.TextEdit txtKKQty;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private DevExpress.XtraEditors.SimpleButton btCreate;
        private DevExpress.XtraEditors.LookUpEdit cbbStores;
        private DevExpress.XtraEditors.LabelControl lbITPhuTrach;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}