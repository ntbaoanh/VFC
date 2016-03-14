namespace VFC._Message
{
    partial class frmMessage_Push
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
            this.txtBody = new DevExpress.XtraEditors.MemoEdit();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkAllStores = new DevExpress.XtraEditors.CheckEdit();
            this.checkAllRegion = new DevExpress.XtraEditors.CheckEdit();
            this.listStores = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.listRegion = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl_MessageList = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btPush = new DevExpress.XtraEditors.SimpleButton();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).BeginInit();
            this.groupControl1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtBody.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtTitle.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.checkAllStores.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.checkAllRegion.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.listStores ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.listRegion ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl_MessageList ) ).BeginInit();
            this.groupControl_MessageList.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add( this.txtBody );
            this.groupControl1.Controls.Add( this.txtTitle );
            this.groupControl1.Controls.Add( this.labelControl3 );
            this.groupControl1.Controls.Add( this.labelControl2 );
            this.groupControl1.Controls.Add( this.lbID );
            this.groupControl1.Controls.Add( this.labelControl1 );
            this.groupControl1.Location = new System.Drawing.Point( 12 , 12 );
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size( 334 , 240 );
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chung";
            // 
            // txtBody
            // 
            this.txtBody.Enabled = false;
            this.txtBody.Location = new System.Drawing.Point( 100 , 84 );
            this.txtBody.Name = "txtBody";
            this.txtBody.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtBody.Properties.Appearance.Options.UseFont = true;
            this.txtBody.Size = new System.Drawing.Size( 229 , 145 );
            this.txtBody.TabIndex = 2;
            this.txtBody.UseOptimizedRendering = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point( 100 , 56 );
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtTitle.Properties.Appearance.Options.UseFont = true;
            this.txtTitle.Size = new System.Drawing.Size( 229 , 22 );
            this.txtTitle.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl3.Location = new System.Drawing.Point( 30 , 87 );
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size( 64 , 16 );
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Nội dung :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Location = new System.Drawing.Point( 39 , 59 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 55 , 16 );
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tiêu đề :";
            // 
            // lbID
            // 
            this.lbID.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbID.Location = new System.Drawing.Point( 100 , 34 );
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size( 25 , 16 );
            this.lbID.TabIndex = 0;
            this.lbID.Text = "lbID";
            this.lbID.TextChanged += new System.EventHandler( this.lbID_TextChanged );
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 10 , 34 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 84 , 16 );
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Message ID :";
            // 
            // checkAllStores
            // 
            this.checkAllStores.Location = new System.Drawing.Point( 494 , 37 );
            this.checkAllStores.Name = "checkAllStores";
            this.checkAllStores.Properties.Caption = "Check All";
            this.checkAllStores.Size = new System.Drawing.Size( 75 , 19 );
            this.checkAllStores.TabIndex = 8;
            this.checkAllStores.CheckedChanged += new System.EventHandler( this.checkAllStores_CheckedChanged );
            // 
            // checkAllRegion
            // 
            this.checkAllRegion.Location = new System.Drawing.Point( 360 , 37 );
            this.checkAllRegion.Name = "checkAllRegion";
            this.checkAllRegion.Properties.Caption = "Check All";
            this.checkAllRegion.Size = new System.Drawing.Size( 75 , 19 );
            this.checkAllRegion.TabIndex = 9;
            this.checkAllRegion.CheckedChanged += new System.EventHandler( this.checkAllRegion_CheckedChanged );
            // 
            // listStores
            // 
            this.listStores.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.listStores.Appearance.Options.UseFont = true;
            this.listStores.HorizontalScrollbar = true;
            this.listStores.Location = new System.Drawing.Point( 496 , 62 );
            this.listStores.MultiColumn = true;
            this.listStores.Name = "listStores";
            this.listStores.Size = new System.Drawing.Size( 375 , 190 );
            this.listStores.TabIndex = 7;
            // 
            // listRegion
            // 
            this.listRegion.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.listRegion.Appearance.Options.UseFont = true;
            this.listRegion.Items.AddRange( new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("HO CHI MINH", "Hồ Chí Minh"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("MIEN BAC", "Miền Bắc"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("MIEN DONG", "Miền Đông"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("MIEN TRUNG", "Miền Trung"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("MIEN TAY", "Miền Tây")} );
            this.listRegion.Location = new System.Drawing.Point( 362 , 62 );
            this.listRegion.Name = "listRegion";
            this.listRegion.Size = new System.Drawing.Size( 120 , 95 );
            this.listRegion.TabIndex = 6;
            this.listRegion.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler( this.listRegion_ItemCheck );
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl4.Location = new System.Drawing.Point( 496 , 12 );
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size( 93 , 19 );
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Cửa hàng : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl5.Location = new System.Drawing.Point( 362 , 12 );
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size( 80 , 19 );
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Khu vực : ";
            // 
            // groupControl_MessageList
            // 
            this.groupControl_MessageList.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.groupControl_MessageList.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl_MessageList.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl_MessageList.AppearanceCaption.Options.UseFont = true;
            this.groupControl_MessageList.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl_MessageList.Controls.Add( this.gridControl1 );
            this.groupControl_MessageList.Location = new System.Drawing.Point( 12 , 258 );
            this.groupControl_MessageList.Name = "groupControl_MessageList";
            this.groupControl_MessageList.Size = new System.Drawing.Size( 859 , 172 );
            this.groupControl_MessageList.TabIndex = 10;
            this.groupControl_MessageList.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point( 2 , 27 );
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size( 855 , 143 );
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1} );
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Red;
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
            this.gridColumn6} );
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler( this.gridView1_RowStyle );
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler( this.gridView1_FocusedRowChanged );
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MessageID";
            this.gridColumn1.FieldName = "MessageID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tiêu đề";
            this.gridColumn2.FieldName = "Title";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ưu tiên";
            this.gridColumn3.FieldName = "Important";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày tạo";
            this.gridColumn4.FieldName = "CreatedDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tạo bởi";
            this.gridColumn5.FieldName = "CreatedBy";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Active";
            this.gridColumn6.FieldName = "Active";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // btPush
            // 
            this.btPush.Location = new System.Drawing.Point( 360 , 163 );
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size( 122 , 23 );
            this.btPush.TabIndex = 11;
            this.btPush.Text = "Push";
            this.btPush.Click += new System.EventHandler( this.btPush_Click );
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point( 362 , 192 );
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size( 122 , 23 );
            this.btRefresh.TabIndex = 11;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler( this.btRefresh_Click );
            // 
            // frmMessage_Push
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 883 , 442 );
            this.Controls.Add( this.btRefresh );
            this.Controls.Add( this.btPush );
            this.Controls.Add( this.groupControl_MessageList );
            this.Controls.Add( this.checkAllStores );
            this.Controls.Add( this.checkAllRegion );
            this.Controls.Add( this.listStores );
            this.Controls.Add( this.listRegion );
            this.Controls.Add( this.labelControl4 );
            this.Controls.Add( this.labelControl5 );
            this.Controls.Add( this.groupControl1 );
            this.Name = "frmMessage_Push";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Push Message";
            this.Load += new System.EventHandler( this.frmMessage_Push_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).EndInit();
            this.groupControl1.ResumeLayout( false );
            this.groupControl1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtBody.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtTitle.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.checkAllStores.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.checkAllRegion.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.listStores ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.listRegion ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl_MessageList ) ).EndInit();
            this.groupControl_MessageList.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbID;
        private DevExpress.XtraEditors.MemoEdit txtBody;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.CheckEdit checkAllStores;
        private DevExpress.XtraEditors.CheckEdit checkAllRegion;
        private DevExpress.XtraEditors.CheckedListBoxControl listStores;
        private DevExpress.XtraEditors.CheckedListBoxControl listRegion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl_MessageList;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btPush;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
    }
}