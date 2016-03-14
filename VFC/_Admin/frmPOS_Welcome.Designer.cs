namespace VFC._Admin
{
    partial class frmPOS_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmPOS_Welcome ) );
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_SystemMessage = new DevExpress.XtraGrid.GridControl();
            this.gridView_SystemMessage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_ASN = new DevExpress.XtraGrid.GridControl();
            this.gridView_ASN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbStore = new DevExpress.XtraEditors.LabelControl();
            this.lbDateString = new DevExpress.XtraEditors.LabelControl();
            this.lbCountASN = new DevExpress.XtraEditors.LabelControl();
            this.lbCountMessage = new DevExpress.XtraEditors.LabelControl();
            this.timer5mins = new System.Windows.Forms.Timer( this.components );
            this.btViewMessage = new DevExpress.XtraEditors.SimpleButton();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            ( (System.ComponentModel.ISupportInitialize) ( this.splitContainerControl1 ) ).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).BeginInit();
            this.groupControl1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl_SystemMessage ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView_SystemMessage ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).BeginInit();
            this.groupControl2.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl_ASN ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView_ASN ) ).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.splitContainerControl1.Location = new System.Drawing.Point( 12 , 128 );
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add( this.groupControl1 );
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add( this.groupControl2 );
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size( 912 , 273 );
            this.splitContainerControl1.SplitterPosition = 456;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add( this.gridControl_SystemMessage );
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point( 0 , 0 );
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size( 456 , 273 );
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông báo chưa đọc";
            // 
            // gridControl_SystemMessage
            // 
            this.gridControl_SystemMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_SystemMessage.Location = new System.Drawing.Point( 2 , 27 );
            this.gridControl_SystemMessage.MainView = this.gridView_SystemMessage;
            this.gridControl_SystemMessage.Name = "gridControl_SystemMessage";
            this.gridControl_SystemMessage.Size = new System.Drawing.Size( 452 , 244 );
            this.gridControl_SystemMessage.TabIndex = 0;
            this.gridControl_SystemMessage.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_SystemMessage} );
            // 
            // gridView_SystemMessage
            // 
            this.gridView_SystemMessage.Appearance.HeaderPanel.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridView_SystemMessage.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_SystemMessage.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_SystemMessage.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_SystemMessage.Appearance.Row.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridView_SystemMessage.Appearance.Row.Options.UseFont = true;
            this.gridView_SystemMessage.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_SystemMessage.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_SystemMessage.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn9,
            this.gridColumn7} );
            this.gridView_SystemMessage.GridControl = this.gridControl_SystemMessage;
            this.gridView_SystemMessage.Name = "gridView_SystemMessage";
            this.gridView_SystemMessage.OptionsBehavior.Editable = false;
            this.gridView_SystemMessage.OptionsBehavior.ReadOnly = true;
            this.gridView_SystemMessage.OptionsSelection.MultiSelect = true;
            this.gridView_SystemMessage.OptionsView.EnableAppearanceOddRow = true;
            this.gridView_SystemMessage.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tiêu đề";
            this.gridColumn5.FieldName = "Title";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày";
            this.gridColumn6.FieldName = "CreatedDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Người gửi";
            this.gridColumn9.FieldName = "CreatedBy";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đã đọc";
            this.gridColumn7.FieldName = "StatusRead";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add( this.gridControl_ASN );
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point( 0 , 0 );
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size( 451 , 273 );
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Giấy báo gửi hàng";
            // 
            // gridControl_ASN
            // 
            this.gridControl_ASN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ASN.Location = new System.Drawing.Point( 2 , 27 );
            this.gridControl_ASN.MainView = this.gridView_ASN;
            this.gridControl_ASN.Name = "gridControl_ASN";
            this.gridControl_ASN.Size = new System.Drawing.Size( 447 , 244 );
            this.gridControl_ASN.TabIndex = 1;
            this.gridControl_ASN.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ASN} );
            // 
            // gridView_ASN
            // 
            this.gridView_ASN.Appearance.HeaderPanel.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridView_ASN.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_ASN.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_ASN.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ASN.Appearance.Row.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.gridView_ASN.Appearance.Row.Options.UseFont = true;
            this.gridView_ASN.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_ASN.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ASN.Columns.AddRange( new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4} );
            this.gridView_ASN.GridControl = this.gridControl_ASN;
            this.gridView_ASN.Name = "gridView_ASN";
            this.gridView_ASN.OptionsBehavior.Editable = false;
            this.gridView_ASN.OptionsBehavior.ReadOnly = true;
            this.gridView_ASN.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView_ASN.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số P.Xuất";
            this.gridColumn1.FieldName = "SLIP_NO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cửa hàng";
            this.gridColumn2.FieldName = "FROMSTORE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số lượng";
            this.gridColumn3.FieldName = "SUMQTY";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày xuất";
            this.gridColumn4.FieldName = "SLIP_CREATEDDATE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 14 , 12 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 175 , 23 );
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Xin chào cửa hàng";
            // 
            // lbStore
            // 
            this.lbStore.Appearance.Font = new System.Drawing.Font( "Tahoma" , 18F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbStore.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbStore.Location = new System.Drawing.Point( 195 , 7 );
            this.lbStore.Name = "lbStore";
            this.lbStore.Size = new System.Drawing.Size( 86 , 29 );
            this.lbStore.TabIndex = 1;
            this.lbStore.Text = "lbStore";
            // 
            // lbDateString
            // 
            this.lbDateString.Appearance.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbDateString.Location = new System.Drawing.Point( 92 , 41 );
            this.lbDateString.Name = "lbDateString";
            this.lbDateString.Size = new System.Drawing.Size( 120 , 23 );
            this.lbDateString.TabIndex = 1;
            this.lbDateString.Text = "lbDateString";
            // 
            // lbCountASN
            // 
            this.lbCountASN.Appearance.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbCountASN.Location = new System.Drawing.Point( 92 , 70 );
            this.lbCountASN.Name = "lbCountASN";
            this.lbCountASN.Size = new System.Drawing.Size( 115 , 23 );
            this.lbCountASN.TabIndex = 1;
            this.lbCountASN.Text = "lbCountASN";
            // 
            // lbCountMessage
            // 
            this.lbCountMessage.Appearance.Font = new System.Drawing.Font( "Tahoma" , 14.25F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.lbCountMessage.Location = new System.Drawing.Point( 92 , 99 );
            this.lbCountMessage.Name = "lbCountMessage";
            this.lbCountMessage.Size = new System.Drawing.Size( 157 , 23 );
            this.lbCountMessage.TabIndex = 1;
            this.lbCountMessage.Text = "lbCountMessage";
            // 
            // timer5mins
            // 
            this.timer5mins.Tick += new System.EventHandler( this.timer5mins_Tick );
            // 
            // btViewMessage
            // 
            this.btViewMessage.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btViewMessage.Appearance.Options.UseFont = true;
            this.btViewMessage.Location = new System.Drawing.Point( 11 , 99 );
            this.btViewMessage.Name = "btViewMessage";
            this.btViewMessage.Size = new System.Drawing.Size( 75 , 23 );
            this.btViewMessage.TabIndex = 2;
            this.btViewMessage.Text = "Xem";
            this.btViewMessage.Click += new System.EventHandler( this.btViewMessage_Click );
            // 
            // btRefresh
            // 
            this.btRefresh.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btRefresh.Appearance.Options.UseFont = true;
            this.btRefresh.Location = new System.Drawing.Point( 12 , 41 );
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size( 75 , 23 );
            this.btRefresh.TabIndex = 2;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler( this.btRefresh_Click );
            // 
            // frmPOS_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 936 , 413 );
            this.ControlBox = false;
            this.Controls.Add( this.btRefresh );
            this.Controls.Add( this.btViewMessage );
            this.Controls.Add( this.lbStore );
            this.Controls.Add( this.lbCountMessage );
            this.Controls.Add( this.lbCountASN );
            this.Controls.Add( this.lbDateString );
            this.Controls.Add( this.labelControl1 );
            this.Controls.Add( this.splitContainerControl1 );
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "frmPOS_Welcome";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler( this.frmPOS_Welcome_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.splitContainerControl1 ) ).EndInit();
            this.splitContainerControl1.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl1 ) ).EndInit();
            this.groupControl1.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl_SystemMessage ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView_SystemMessage ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.groupControl2 ) ).EndInit();
            this.groupControl2.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl_ASN ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView_ASN ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl_SystemMessage;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_SystemMessage;
        private DevExpress.XtraGrid.GridControl gridControl_ASN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ASN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbStore;
        private DevExpress.XtraEditors.LabelControl lbDateString;
        private DevExpress.XtraEditors.LabelControl lbCountASN;
        private DevExpress.XtraEditors.LabelControl lbCountMessage;
        private System.Windows.Forms.Timer timer5mins;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.SimpleButton btViewMessage;
        private DevExpress.XtraEditors.SimpleButton btRefresh;

    }
}