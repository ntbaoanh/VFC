namespace VFC._IT
{
    partial class frmIT_CapNhatTonKho
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStore_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKKQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKKDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreated_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModified_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserGetTicket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btFalse = new DevExpress.XtraEditors.SimpleButton();
            this.btAll = new DevExpress.XtraEditors.SimpleButton();
            this.btDone = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbDate = new DevExpress.XtraEditors.LabelControl();
            this.lbQty = new DevExpress.XtraEditors.LabelControl();
            this.lbStore = new DevExpress.XtraEditors.LabelControl();
            this.lbSTT = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).BeginInit();
            this.groupControl2.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add( this.gridControl1 );
            this.groupControl2.Location = new System.Drawing.Point( 12 , 174 );
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size( 845 , 274 );
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point( 2 , 24 );
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size( 841 , 248 );
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1} );
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font( "Tahoma" , 8.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridView1.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colStore_Code,
            this.colKKQty,
            this.colKKDate,
            this.colCreated_Date,
            this.colModified_Date,
            this.colModified_By,
            this.colUserGetTicket,
            this.colStatus,
            this.colRegion} );
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler( this.gridView1_FocusedRowChanged );
            // 
            // colNo
            // 
            this.colNo.AppearanceCell.Options.UseTextOptions = true;
            this.colNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.Caption = "No";
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.Summary.AddRange( new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "No", "{0:#,#}")} );
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colStore_Code
            // 
            this.colStore_Code.AppearanceCell.Options.UseTextOptions = true;
            this.colStore_Code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStore_Code.Caption = "Cửa hàng";
            this.colStore_Code.FieldName = "Store_Code";
            this.colStore_Code.Name = "colStore_Code";
            this.colStore_Code.Visible = true;
            this.colStore_Code.VisibleIndex = 1;
            // 
            // colKKQty
            // 
            this.colKKQty.AppearanceCell.Options.UseTextOptions = true;
            this.colKKQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKKQty.Caption = "Slg";
            this.colKKQty.FieldName = "KKQty";
            this.colKKQty.Name = "colKKQty";
            this.colKKQty.Visible = true;
            this.colKKQty.VisibleIndex = 2;
            // 
            // colKKDate
            // 
            this.colKKDate.AppearanceCell.Options.UseTextOptions = true;
            this.colKKDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKKDate.Caption = "Ngày kiểm kê";
            this.colKKDate.FieldName = "KKDate";
            this.colKKDate.Name = "colKKDate";
            this.colKKDate.Visible = true;
            this.colKKDate.VisibleIndex = 3;
            // 
            // colCreated_Date
            // 
            this.colCreated_Date.AppearanceCell.Options.UseTextOptions = true;
            this.colCreated_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCreated_Date.Caption = "Ngày tạo";
            this.colCreated_Date.FieldName = "Created_Date";
            this.colCreated_Date.Name = "colCreated_Date";
            this.colCreated_Date.Visible = true;
            this.colCreated_Date.VisibleIndex = 4;
            // 
            // colModified_Date
            // 
            this.colModified_Date.AppearanceCell.Options.UseTextOptions = true;
            this.colModified_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModified_Date.Caption = "Ngày cập nhật";
            this.colModified_Date.FieldName = "Modified_Date";
            this.colModified_Date.Name = "colModified_Date";
            this.colModified_Date.Visible = true;
            this.colModified_Date.VisibleIndex = 5;
            // 
            // colModified_By
            // 
            this.colModified_By.AppearanceCell.Options.UseTextOptions = true;
            this.colModified_By.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModified_By.Caption = "Cập nhật bởi";
            this.colModified_By.FieldName = "Modified_By";
            this.colModified_By.Name = "colModified_By";
            this.colModified_By.Visible = true;
            this.colModified_By.VisibleIndex = 6;
            // 
            // colUserGetTicket
            // 
            this.colUserGetTicket.AppearanceCell.Options.UseTextOptions = true;
            this.colUserGetTicket.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserGetTicket.Caption = "IT Phụ Trách";
            this.colUserGetTicket.FieldName = "UserGetTicket";
            this.colUserGetTicket.Name = "colUserGetTicket";
            this.colUserGetTicket.Visible = true;
            this.colUserGetTicket.VisibleIndex = 7;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 8;
            // 
            // colRegion
            // 
            this.colRegion.AppearanceCell.Options.UseTextOptions = true;
            this.colRegion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegion.Caption = "Khu vực";
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.Visible = true;
            this.colRegion.VisibleIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add( this.btRefresh );
            this.groupControl1.Controls.Add( this.btFalse );
            this.groupControl1.Controls.Add( this.btAll );
            this.groupControl1.Controls.Add( this.btDone );
            this.groupControl1.Controls.Add( this.labelControl4 );
            this.groupControl1.Controls.Add( this.labelControl3 );
            this.groupControl1.Controls.Add( this.labelControl2 );
            this.groupControl1.Controls.Add( this.lbDate );
            this.groupControl1.Controls.Add( this.lbQty );
            this.groupControl1.Controls.Add( this.lbStore );
            this.groupControl1.Controls.Add( this.lbSTT );
            this.groupControl1.Controls.Add( this.labelControl1 );
            this.groupControl1.Location = new System.Drawing.Point( 12 , 12 );
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size( 523 , 156 );
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin";
            // 
            // btRefresh
            // 
            this.btRefresh.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btRefresh.Appearance.Options.UseFont = true;
            this.btRefresh.Location = new System.Drawing.Point( 420 , 120 );
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size( 87 , 23 );
            this.btRefresh.TabIndex = 1;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler( this.btRefresh_Click );
            // 
            // btFalse
            // 
            this.btFalse.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btFalse.Appearance.Options.UseFont = true;
            this.btFalse.Location = new System.Drawing.Point( 327 , 120 );
            this.btFalse.Name = "btFalse";
            this.btFalse.Size = new System.Drawing.Size( 87 , 23 );
            this.btFalse.TabIndex = 1;
            this.btFalse.Text = "Un-Done";
            this.btFalse.Click += new System.EventHandler( this.btFalse_Click );
            // 
            // btAll
            // 
            this.btAll.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btAll.Appearance.Options.UseFont = true;
            this.btAll.Location = new System.Drawing.Point( 234 , 120 );
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size( 87 , 23 );
            this.btAll.TabIndex = 1;
            this.btAll.Text = "Show All";
            this.btAll.Click += new System.EventHandler( this.btAll_Click );
            // 
            // btDone
            // 
            this.btDone.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btDone.Appearance.Options.UseFont = true;
            this.btDone.Location = new System.Drawing.Point( 138 , 120 );
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size( 87 , 23 );
            this.btDone.TabIndex = 1;
            this.btDone.Text = "Cập nhật";
            this.btDone.Click += new System.EventHandler( this.btDone_Click );
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl4.Location = new System.Drawing.Point( 35 , 98 );
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size( 97 , 16 );
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ngày kiểm kê : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl3.Location = new System.Drawing.Point( 11 , 76 );
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size( 121 , 16 );
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Số lượng kiểm kê : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Location = new System.Drawing.Point( 58 , 54 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 74 , 16 );
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cửa hàng : ";
            // 
            // lbDate
            // 
            this.lbDate.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbDate.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbDate.Location = new System.Drawing.Point( 138 , 98 );
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size( 42 , 16 );
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "lbDate";
            // 
            // lbQty
            // 
            this.lbQty.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbQty.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbQty.Location = new System.Drawing.Point( 138 , 76 );
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size( 34 , 16 );
            this.lbQty.TabIndex = 0;
            this.lbQty.Text = "lbQty";
            // 
            // lbStore
            // 
            this.lbStore.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbStore.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbStore.Location = new System.Drawing.Point( 138 , 54 );
            this.lbStore.Name = "lbStore";
            this.lbStore.Size = new System.Drawing.Size( 47 , 16 );
            this.lbStore.TabIndex = 0;
            this.lbStore.Text = "lbStore";
            // 
            // lbSTT
            // 
            this.lbSTT.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbSTT.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbSTT.Location = new System.Drawing.Point( 138 , 32 );
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size( 34 , 16 );
            this.lbSTT.TabIndex = 0;
            this.lbSTT.Text = "lbSTT";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 57 , 32 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 75 , 16 );
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số thứ tự : ";
            // 
            // frmIT_CapNhatTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 869 , 460 );
            this.Controls.Add( this.groupControl2 );
            this.Controls.Add( this.groupControl1 );
            this.Name = "frmIT_CapNhatTonKho";
            this.Text = "Cập nhật tồn kho";
            this.Load += new System.EventHandler( this.frmIT_CapNhatTonKho_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).EndInit();
            this.groupControl2.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).EndInit();
            this.groupControl1.ResumeLayout( false );
            this.groupControl1.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStore_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colKKQty;
        private DevExpress.XtraGrid.Columns.GridColumn colKKDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colModified_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colModified_By;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGetTicket;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private DevExpress.XtraEditors.SimpleButton btFalse;
        private DevExpress.XtraEditors.SimpleButton btAll;
        private DevExpress.XtraEditors.SimpleButton btDone;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbDate;
        private DevExpress.XtraEditors.LabelControl lbQty;
        private DevExpress.XtraEditors.LabelControl lbStore;
        private DevExpress.XtraEditors.LabelControl lbSTT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}