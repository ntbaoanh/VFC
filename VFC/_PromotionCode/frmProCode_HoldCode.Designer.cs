namespace VFC._PromotionCode
{
    partial class frmProCode_HoldCode
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
            this.cbbHoldCode_Stores = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdKhongCoNet = new System.Windows.Forms.RadioButton();
            this.rdKhongCoDien = new System.Windows.Forms.RadioButton();
            this.btHoldCode = new DevExpress.XtraEditors.SimpleButton();
            this.txtHoldCode_Phone1 = new DevExpress.XtraEditors.TextEdit();
            this.txtHoldCode_FName = new DevExpress.XtraEditors.TextEdit();
            this.txtHoldCode_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txtHoldCode_InvcNo = new DevExpress.XtraEditors.TextEdit();
            this.txtHoldCode_Amount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl_CheckCode = new DevExpress.XtraEditors.GroupControl();
            this.btCheck = new DevExpress.XtraEditors.SimpleButton();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lbResult = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbHoldCode_Stores.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView2 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_Phone1.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_FName.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_CMND.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_InvcNo.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_Amount.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl_CheckCode ) ).BeginInit();
            this.groupControl_CheckCode.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtCode.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // cbbHoldCode_Stores
            // 
            this.cbbHoldCode_Stores.Location = new System.Drawing.Point( 146 , 222 );
            this.cbbHoldCode_Stores.Name = "cbbHoldCode_Stores";
            this.cbbHoldCode_Stores.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.cbbHoldCode_Stores.Properties.Appearance.Options.UseFont = true;
            this.cbbHoldCode_Stores.Properties.Buttons.AddRange( new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)} );
            this.cbbHoldCode_Stores.Properties.DisplayMember = "STORE_CODE";
            this.cbbHoldCode_Stores.Properties.ValueMember = "STORE_CODE";
            this.cbbHoldCode_Stores.Properties.View = this.gridView2;
            this.cbbHoldCode_Stores.Size = new System.Drawing.Size( 120 , 26 );
            this.cbbHoldCode_Stores.TabIndex = 25;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 192 ) ) ) ) , ( (int) ( ( (byte) ( 255 ) ) ) ) , ( (int) ( ( (byte) ( 255 ) ) ) ) );
            this.gridView2.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2} );
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.Caption = "Cửa hàng";
            this.gridColumn2.FieldName = "STORE_CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // rdKhongCoNet
            // 
            this.rdKhongCoNet.AutoSize = true;
            this.rdKhongCoNet.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.rdKhongCoNet.Location = new System.Drawing.Point( 385 , 193 );
            this.rdKhongCoNet.Name = "rdKhongCoNet";
            this.rdKhongCoNet.Size = new System.Drawing.Size( 172 , 23 );
            this.rdKhongCoNet.TabIndex = 23;
            this.rdKhongCoNet.Text = "Không có internet";
            this.rdKhongCoNet.UseVisualStyleBackColor = true;
            // 
            // rdKhongCoDien
            // 
            this.rdKhongCoDien.AutoSize = true;
            this.rdKhongCoDien.Checked = true;
            this.rdKhongCoDien.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.rdKhongCoDien.Location = new System.Drawing.Point( 146 , 193 );
            this.rdKhongCoDien.Name = "rdKhongCoDien";
            this.rdKhongCoDien.Size = new System.Drawing.Size( 141 , 23 );
            this.rdKhongCoDien.TabIndex = 24;
            this.rdKhongCoDien.TabStop = true;
            this.rdKhongCoDien.Text = "Không có điện";
            this.rdKhongCoDien.UseVisualStyleBackColor = true;
            // 
            // btHoldCode
            // 
            this.btHoldCode.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btHoldCode.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btHoldCode.Appearance.Options.UseFont = true;
            this.btHoldCode.Appearance.Options.UseForeColor = true;
            this.btHoldCode.ImageIndex = 4;
            this.btHoldCode.Location = new System.Drawing.Point( 146 , 382 );
            this.btHoldCode.Name = "btHoldCode";
            this.btHoldCode.Size = new System.Drawing.Size( 227 , 31 );
            this.btHoldCode.TabIndex = 22;
            this.btHoldCode.Text = "Hold";
            this.btHoldCode.Click += new System.EventHandler( this.btHoldCode_Click );
            // 
            // txtHoldCode_Phone1
            // 
            this.txtHoldCode_Phone1.Location = new System.Drawing.Point( 146 , 350 );
            this.txtHoldCode_Phone1.Name = "txtHoldCode_Phone1";
            this.txtHoldCode_Phone1.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtHoldCode_Phone1.Properties.Appearance.Options.UseFont = true;
            this.txtHoldCode_Phone1.Size = new System.Drawing.Size( 227 , 26 );
            this.txtHoldCode_Phone1.TabIndex = 19;
            // 
            // txtHoldCode_FName
            // 
            this.txtHoldCode_FName.Location = new System.Drawing.Point( 146 , 286 );
            this.txtHoldCode_FName.Name = "txtHoldCode_FName";
            this.txtHoldCode_FName.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtHoldCode_FName.Properties.Appearance.Options.UseFont = true;
            this.txtHoldCode_FName.Size = new System.Drawing.Size( 227 , 26 );
            this.txtHoldCode_FName.TabIndex = 20;
            // 
            // txtHoldCode_CMND
            // 
            this.txtHoldCode_CMND.Location = new System.Drawing.Point( 146 , 318 );
            this.txtHoldCode_CMND.Name = "txtHoldCode_CMND";
            this.txtHoldCode_CMND.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtHoldCode_CMND.Properties.Appearance.Options.UseFont = true;
            this.txtHoldCode_CMND.Size = new System.Drawing.Size( 227 , 26 );
            this.txtHoldCode_CMND.TabIndex = 21;
            // 
            // txtHoldCode_InvcNo
            // 
            this.txtHoldCode_InvcNo.Location = new System.Drawing.Point( 476 , 222 );
            this.txtHoldCode_InvcNo.Name = "txtHoldCode_InvcNo";
            this.txtHoldCode_InvcNo.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtHoldCode_InvcNo.Properties.Appearance.Options.UseFont = true;
            this.txtHoldCode_InvcNo.Size = new System.Drawing.Size( 176 , 26 );
            this.txtHoldCode_InvcNo.TabIndex = 18;
            // 
            // txtHoldCode_Amount
            // 
            this.txtHoldCode_Amount.Location = new System.Drawing.Point( 146 , 254 );
            this.txtHoldCode_Amount.Name = "txtHoldCode_Amount";
            this.txtHoldCode_Amount.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtHoldCode_Amount.Properties.Appearance.Options.UseFont = true;
            this.txtHoldCode_Amount.Size = new System.Drawing.Size( 227 , 26 );
            this.txtHoldCode_Amount.TabIndex = 17;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl23.Location = new System.Drawing.Point( 61 , 356 );
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size( 79 , 16 );
            this.labelControl23.TabIndex = 13;
            this.labelControl23.Text = "Điện thoại : ";
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl25.Location = new System.Drawing.Point( 26 , 292 );
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size( 114 , 16 );
            this.labelControl25.TabIndex = 12;
            this.labelControl25.Text = "Tên khách hàng : ";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl24.Location = new System.Drawing.Point( 385 , 228 );
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size( 85 , 16 );
            this.labelControl24.TabIndex = 11;
            this.labelControl24.Text = "Số hóa đơn : ";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl22.Location = new System.Drawing.Point( 91 , 324 );
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size( 49 , 16 );
            this.labelControl22.TabIndex = 16;
            this.labelControl22.Text = "CMND : ";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl21.Location = new System.Drawing.Point( 59 , 260 );
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size( 81 , 16 );
            this.labelControl21.TabIndex = 15;
            this.labelControl21.Text = "Thành tiền : ";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl20.Location = new System.Drawing.Point( 66 , 228 );
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size( 74 , 16 );
            this.labelControl20.TabIndex = 14;
            this.labelControl20.Text = "Cửa hàng : ";
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
            this.groupControl_CheckCode.TabIndex = 26;
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
            // frmProCode_HoldCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 687 , 421 );
            this.Controls.Add( this.groupControl_CheckCode );
            this.Controls.Add( this.cbbHoldCode_Stores );
            this.Controls.Add( this.rdKhongCoNet );
            this.Controls.Add( this.rdKhongCoDien );
            this.Controls.Add( this.btHoldCode );
            this.Controls.Add( this.txtHoldCode_Phone1 );
            this.Controls.Add( this.txtHoldCode_FName );
            this.Controls.Add( this.txtHoldCode_CMND );
            this.Controls.Add( this.txtHoldCode_InvcNo );
            this.Controls.Add( this.txtHoldCode_Amount );
            this.Controls.Add( this.labelControl23 );
            this.Controls.Add( this.labelControl25 );
            this.Controls.Add( this.labelControl24 );
            this.Controls.Add( this.labelControl22 );
            this.Controls.Add( this.labelControl21 );
            this.Controls.Add( this.labelControl20 );
            this.Name = "frmProCode_HoldCode";
            this.Text = "Hold Code";
            this.Load += new System.EventHandler( this.frmProCode_HoldCode_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.cbbHoldCode_Stores.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView2 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_Phone1.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_FName.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_CMND.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_InvcNo.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtHoldCode_Amount.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl_CheckCode ) ).EndInit();
            this.groupControl_CheckCode.ResumeLayout( false );
            this.groupControl_CheckCode.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtCode.Properties ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit cbbHoldCode_Stores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.RadioButton rdKhongCoNet;
        private System.Windows.Forms.RadioButton rdKhongCoDien;
        private DevExpress.XtraEditors.SimpleButton btHoldCode;
        private DevExpress.XtraEditors.TextEdit txtHoldCode_Phone1;
        private DevExpress.XtraEditors.TextEdit txtHoldCode_FName;
        private DevExpress.XtraEditors.TextEdit txtHoldCode_CMND;
        private DevExpress.XtraEditors.TextEdit txtHoldCode_InvcNo;
        private DevExpress.XtraEditors.TextEdit txtHoldCode_Amount;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.GroupControl groupControl_CheckCode;
        private DevExpress.XtraEditors.SimpleButton btCheck;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lbResult;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}