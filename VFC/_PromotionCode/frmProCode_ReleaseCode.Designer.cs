namespace VFC._PromotionCode
{
    partial class frmProCode_ReleaseCode
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
            this.groupControl_CheckCode = new DevExpress.XtraEditors.GroupControl();
            this.btCheck = new DevExpress.XtraEditors.SimpleButton();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lbResult = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtReleaseCode_InvcNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.cbbReleaseCode_Stores = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btReleaseCode = new DevExpress.XtraEditors.SimpleButton();
            this.txtReleaseCode_Phone1 = new DevExpress.XtraEditors.TextEdit();
            this.txtReleaseCode_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txtReleaseCode_Amount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl_CheckCode ) ).BeginInit();
            this.groupControl_CheckCode.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtCode.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtReleaseCode_InvcNo.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbReleaseCode_Stores.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView3 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtReleaseCode_Phone1.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtReleaseCode_CMND.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtReleaseCode_Amount.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl_CheckCode
            // 
            this.groupControl_CheckCode.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl_CheckCode.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl_CheckCode.AppearanceCaption.Options.UseFont = true;
            this.groupControl_CheckCode.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl_CheckCode.Controls.Add( this.btCheck );
            this.groupControl_CheckCode.Controls.Add( this.txtCode );
            this.groupControl_CheckCode.Controls.Add( this.lbResult );
            this.groupControl_CheckCode.Controls.Add( this.labelControl1 );
            this.groupControl_CheckCode.Location = new System.Drawing.Point( 12 , 12 );
            this.groupControl_CheckCode.Name = "groupControl_CheckCode";
            this.groupControl_CheckCode.Size = new System.Drawing.Size( 478 , 152 );
            this.groupControl_CheckCode.TabIndex = 27;
            this.groupControl_CheckCode.Text = "Kiểm tra";
            // 
            // btCheck
            // 
            this.btCheck.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btCheck.Appearance.Options.UseFont = true;
            this.btCheck.Location = new System.Drawing.Point( 397 , 39 );
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size( 66 , 46 );
            this.btCheck.TabIndex = 2;
            this.btCheck.Text = "Check";
            this.btCheck.Click += new System.EventHandler( this.btCheck_Click );
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point( 165 , 39 );
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 24F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCode.Properties.PasswordChar = '*';
            this.txtCode.Size = new System.Drawing.Size( 226 , 46 );
            this.txtCode.TabIndex = 1;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler( this.txtCode_KeyDown );
            // 
            // lbResult
            // 
            this.lbResult.Appearance.Font = new System.Drawing.Font( "Tahoma" , 21.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbResult.Location = new System.Drawing.Point( 5 , 102 );
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size( 120 , 35 );
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "lbResult";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 21.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 10 , 45 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 149 , 35 );
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã code : ";
            // 
            // txtReleaseCode_InvcNo
            // 
            this.txtReleaseCode_InvcNo.Location = new System.Drawing.Point( 177 , 298 );
            this.txtReleaseCode_InvcNo.Name = "txtReleaseCode_InvcNo";
            this.txtReleaseCode_InvcNo.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtReleaseCode_InvcNo.Properties.Appearance.Options.UseFont = true;
            this.txtReleaseCode_InvcNo.Size = new System.Drawing.Size( 227 , 26 );
            this.txtReleaseCode_InvcNo.TabIndex = 38;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl28.Location = new System.Drawing.Point( 86 , 304 );
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size( 85 , 16 );
            this.labelControl28.TabIndex = 37;
            this.labelControl28.Text = "Số hóa đơn : ";
            // 
            // cbbReleaseCode_Stores
            // 
            this.cbbReleaseCode_Stores.Location = new System.Drawing.Point( 177 , 170 );
            this.cbbReleaseCode_Stores.Name = "cbbReleaseCode_Stores";
            this.cbbReleaseCode_Stores.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbbReleaseCode_Stores.Properties.Appearance.Options.UseFont = true;
            this.cbbReleaseCode_Stores.Properties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.cbbReleaseCode_Stores.Properties.DisplayMember = "STORE_CODE";
            this.cbbReleaseCode_Stores.Properties.ValueMember = "STORE_CODE";
            this.cbbReleaseCode_Stores.Properties.View = this.gridView3;
            this.cbbReleaseCode_Stores.Size = new System.Drawing.Size( 120 , 26 );
            this.cbbReleaseCode_Stores.TabIndex = 36;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 192 ) ) ) ) , ( (int) ( ( (byte) ( 255 ) ) ) ) , ( (int) ( ( (byte) ( 255 ) ) ) ) );
            this.gridView3.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView3.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3} );
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsBehavior.ReadOnly = true;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.Caption = "Cửa hàng";
            this.gridColumn3.FieldName = "STORE_CODE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // btReleaseCode
            // 
            this.btReleaseCode.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btReleaseCode.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btReleaseCode.Appearance.Options.UseFont = true;
            this.btReleaseCode.Appearance.Options.UseForeColor = true;
            this.btReleaseCode.ImageIndex = 6;
            this.btReleaseCode.Location = new System.Drawing.Point( 177 , 330 );
            this.btReleaseCode.Name = "btReleaseCode";
            this.btReleaseCode.Size = new System.Drawing.Size( 227 , 30 );
            this.btReleaseCode.TabIndex = 35;
            this.btReleaseCode.Text = "Release";
            this.btReleaseCode.Click += new System.EventHandler( this.btReleaseCode_Click );
            // 
            // txtReleaseCode_Phone1
            // 
            this.txtReleaseCode_Phone1.Location = new System.Drawing.Point( 177 , 266 );
            this.txtReleaseCode_Phone1.Name = "txtReleaseCode_Phone1";
            this.txtReleaseCode_Phone1.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtReleaseCode_Phone1.Properties.Appearance.Options.UseFont = true;
            this.txtReleaseCode_Phone1.Size = new System.Drawing.Size( 227 , 26 );
            this.txtReleaseCode_Phone1.TabIndex = 34;
            // 
            // txtReleaseCode_CMND
            // 
            this.txtReleaseCode_CMND.Location = new System.Drawing.Point( 177 , 234 );
            this.txtReleaseCode_CMND.Name = "txtReleaseCode_CMND";
            this.txtReleaseCode_CMND.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtReleaseCode_CMND.Properties.Appearance.Options.UseFont = true;
            this.txtReleaseCode_CMND.Size = new System.Drawing.Size( 227 , 26 );
            this.txtReleaseCode_CMND.TabIndex = 33;
            // 
            // txtReleaseCode_Amount
            // 
            this.txtReleaseCode_Amount.Location = new System.Drawing.Point( 177 , 202 );
            this.txtReleaseCode_Amount.Name = "txtReleaseCode_Amount";
            this.txtReleaseCode_Amount.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtReleaseCode_Amount.Properties.Appearance.Options.UseFont = true;
            this.txtReleaseCode_Amount.Size = new System.Drawing.Size( 227 , 26 );
            this.txtReleaseCode_Amount.TabIndex = 32;
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl26.Location = new System.Drawing.Point( 92 , 272 );
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size( 79 , 16 );
            this.labelControl26.TabIndex = 29;
            this.labelControl26.Text = "Điện thoại : ";
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl29.Location = new System.Drawing.Point( 122 , 240 );
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size( 49 , 16 );
            this.labelControl29.TabIndex = 28;
            this.labelControl29.Text = "CMND : ";
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl30.Location = new System.Drawing.Point( 90 , 208 );
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size( 81 , 16 );
            this.labelControl30.TabIndex = 31;
            this.labelControl30.Text = "Thành tiền : ";
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl31.Location = new System.Drawing.Point( 97 , 176 );
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size( 74 , 16 );
            this.labelControl31.TabIndex = 30;
            this.labelControl31.Text = "Cửa hàng : ";
            // 
            // frmProCode_ReleaseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 785 , 434 );
            this.Controls.Add( this.txtReleaseCode_InvcNo );
            this.Controls.Add( this.labelControl28 );
            this.Controls.Add( this.cbbReleaseCode_Stores );
            this.Controls.Add( this.btReleaseCode );
            this.Controls.Add( this.txtReleaseCode_Phone1 );
            this.Controls.Add( this.txtReleaseCode_CMND );
            this.Controls.Add( this.txtReleaseCode_Amount );
            this.Controls.Add( this.labelControl26 );
            this.Controls.Add( this.labelControl29 );
            this.Controls.Add( this.labelControl30 );
            this.Controls.Add( this.labelControl31 );
            this.Controls.Add( this.groupControl_CheckCode );
            this.Name = "frmProCode_ReleaseCode";
            this.Text = "Release Code";
            this.Load += new System.EventHandler( this.frmProCode_ReleaseCode_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl_CheckCode ) ).EndInit();
            this.groupControl_CheckCode.ResumeLayout( false );
            this.groupControl_CheckCode.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtCode.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtReleaseCode_InvcNo.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbReleaseCode_Stores.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView3 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtReleaseCode_Phone1.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtReleaseCode_CMND.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtReleaseCode_Amount.Properties ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_CheckCode;
        private DevExpress.XtraEditors.SimpleButton btCheck;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lbResult;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtReleaseCode_InvcNo;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.GridLookUpEdit cbbReleaseCode_Stores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btReleaseCode;
        private DevExpress.XtraEditors.TextEdit txtReleaseCode_Phone1;
        private DevExpress.XtraEditors.TextEdit txtReleaseCode_CMND;
        private DevExpress.XtraEditors.TextEdit txtReleaseCode_Amount;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl31;
    }
}