namespace VFC._PromotionCode
{
    partial class frmProCode_Export_Code
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
            this.btExport = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Expire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).BeginInit();
            this.groupControl1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).BeginInit();
            this.groupControl2.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl2 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView2 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtNotes.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // btExport
            // 
            this.btExport.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btExport.Appearance.Options.UseFont = true;
            this.btExport.Location = new System.Drawing.Point( 12 , 308 );
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size( 126 , 30 );
            this.btExport.TabIndex = 5;
            this.btExport.Text = "Export to Excel";
            this.btExport.Click += new System.EventHandler( this.btExport_Click );
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add( this.gridControl1 );
            this.groupControl1.Location = new System.Drawing.Point( 12 , 12 );
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size( 620 , 290 );
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point( 2 , 31 );
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size( 616 , 257 );
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1} );
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPartNumber,
            this.colDate_Create,
            this.colDate_Expire,
            this.colQTY,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3} );
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler( this.gridView1_RowStyle );
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler( this.gridView1_FocusedRowChanged );
            // 
            // colPartNumber
            // 
            this.colPartNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colPartNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPartNumber.AppearanceHeader.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.colPartNumber.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colPartNumber.AppearanceHeader.Options.UseFont = true;
            this.colPartNumber.AppearanceHeader.Options.UseForeColor = true;
            this.colPartNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colPartNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPartNumber.Caption = "Part No";
            this.colPartNumber.FieldName = "PartNumber";
            this.colPartNumber.Name = "colPartNumber";
            this.colPartNumber.Summary.AddRange( new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PartNumber", "{0:#,#}")} );
            this.colPartNumber.Visible = true;
            this.colPartNumber.VisibleIndex = 0;
            // 
            // colDate_Create
            // 
            this.colDate_Create.AppearanceCell.Options.UseTextOptions = true;
            this.colDate_Create.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate_Create.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate_Create.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate_Create.Caption = "Ngày tạo";
            this.colDate_Create.FieldName = "Date_Create";
            this.colDate_Create.Name = "colDate_Create";
            this.colDate_Create.Visible = true;
            this.colDate_Create.VisibleIndex = 1;
            // 
            // colDate_Expire
            // 
            this.colDate_Expire.AppearanceCell.Options.UseTextOptions = true;
            this.colDate_Expire.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate_Expire.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate_Expire.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate_Expire.Caption = "Ngày hết hạn";
            this.colDate_Expire.FieldName = "Date_Expire";
            this.colDate_Expire.Name = "colDate_Expire";
            this.colDate_Expire.Visible = true;
            this.colDate_Expire.VisibleIndex = 2;
            // 
            // colQTY
            // 
            this.colQTY.AppearanceCell.Options.UseTextOptions = true;
            this.colQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.AppearanceHeader.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.colQTY.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colQTY.AppearanceHeader.Options.UseFont = true;
            this.colQTY.AppearanceHeader.Options.UseForeColor = true;
            this.colQTY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQTY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQTY.Caption = "Số lượng";
            this.colQTY.DisplayFormat.FormatString = "{0:#,#}";
            this.colQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Loại KM";
            this.gridColumn1.FieldName = "LoaiKMDescription";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Amount KM";
            this.gridColumn2.DisplayFormat.FormatString = "{0:#,#}";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "AmountKM";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Status";
            this.gridColumn3.FieldName = "Status";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add( this.gridControl2 );
            this.groupControl2.Location = new System.Drawing.Point( 636 , 12 );
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size( 196 , 398 );
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Code";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point( 2 , 31 );
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size( 192 , 365 );
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2} );
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler( this.saveFileDialog1_FileOk );
            // 
            // txtNotes
            // 
            this.txtNotes.Enabled = false;
            this.txtNotes.Location = new System.Drawing.Point( 144 , 308 );
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtNotes.Properties.Appearance.Options.UseFont = true;
            this.txtNotes.Size = new System.Drawing.Size( 486 , 102 );
            this.txtNotes.TabIndex = 6;
            this.txtNotes.UseOptimizedRendering = true;
            // 
            // frmProCode_Export_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 875 , 470 );
            this.Controls.Add( this.btExport );
            this.Controls.Add( this.groupControl1 );
            this.Controls.Add( this.groupControl2 );
            this.Controls.Add( this.txtNotes );
            this.Name = "frmProCode_Export_Code";
            this.Text = "Export Code";
            this.Load += new System.EventHandler( this.frmProCode_Export_Code_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).EndInit();
            this.groupControl1.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).EndInit();
            this.groupControl2.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl2 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView2 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtNotes.Properties ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btExport;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Create;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Expire;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.MemoEdit txtNotes;
    }
}