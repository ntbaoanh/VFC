namespace VFC._Sale
{
    partial class frmSale_HO_NVBH_BaoCaoTongHop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale_HO_NVBH_BaoCaoTongHop));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_DuLieuTho = new DevExpress.XtraGrid.GridControl();
            this.gridView_DuLieuTho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btGo = new DevExpress.XtraEditors.SimpleButton();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.listCheckKhuVuc = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.listCheckCuaHang = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.chkAllCuaHang = new DevExpress.XtraEditors.CheckEdit();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.btExport = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btExportRawData = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.lbDuration = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::VFC.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DuLieuTho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DuLieuTho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCheckKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCheckCuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllCuaHang.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.lbDuration);
            this.groupControl1.Controls.Add(this.gridControl_DuLieuTho);
            this.groupControl1.Controls.Add(this.btGo);
            this.groupControl1.Controls.Add(this.dateTo);
            this.groupControl1.Controls.Add(this.dateFrom);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(334, 147);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thời gian";
            // 
            // gridControl_DuLieuTho
            // 
            this.gridControl_DuLieuTho.Location = new System.Drawing.Point(5, 28);
            this.gridControl_DuLieuTho.MainView = this.gridView_DuLieuTho;
            this.gridControl_DuLieuTho.Name = "gridControl_DuLieuTho";
            this.gridControl_DuLieuTho.Size = new System.Drawing.Size(53, 30);
            this.gridControl_DuLieuTho.TabIndex = 3;
            this.gridControl_DuLieuTho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DuLieuTho});
            this.gridControl_DuLieuTho.Visible = false;
            // 
            // gridView_DuLieuTho
            // 
            this.gridView_DuLieuTho.GridControl = this.gridControl_DuLieuTho;
            this.gridView_DuLieuTho.Name = "gridView_DuLieuTho";
            // 
            // btGo
            // 
            this.btGo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGo.Appearance.Options.UseFont = true;
            this.btGo.Image = ((System.Drawing.Image)(resources.GetObject("btGo.Image")));
            this.btGo.Location = new System.Drawing.Point(132, 96);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(160, 41);
            this.btGo.TabIndex = 2;
            this.btGo.Text = "Xem báo cáo";
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // dateTo
            // 
            this.dateTo.EditValue = null;
            this.dateTo.Location = new System.Drawing.Point(132, 64);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Properties.Appearance.Options.UseFont = true;
            this.dateTo.Properties.Appearance.Options.UseTextOptions = true;
            this.dateTo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Size = new System.Drawing.Size(160, 26);
            this.dateTo.TabIndex = 1;
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = null;
            this.dateFrom.Location = new System.Drawing.Point(132, 32);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Properties.Appearance.Options.UseFont = true;
            this.dateFrom.Properties.Appearance.Options.UseTextOptions = true;
            this.dateFrom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(160, 26);
            this.dateFrom.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(34, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Đến ngày : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(44, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Từ ngày : ";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.listCheckKhuVuc);
            this.groupControl2.Location = new System.Drawing.Point(3, 156);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(151, 149);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Khu vực";
            // 
            // listCheckKhuVuc
            // 
            this.listCheckKhuVuc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCheckKhuVuc.Appearance.Options.UseFont = true;
            this.listCheckKhuVuc.HorizontalScrollbar = true;
            this.listCheckKhuVuc.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("\'HO CHI MINH\'", "Hồ Chí Minh"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("\'MIEN DONG\'", "Miền Đông"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("\'MIEN BAC\'", "Miền Bắc"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("\'MIEN TAY\'", "Miền Tây"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("\'MIEN TRUNG\'", "Miền Trung")});
            this.listCheckKhuVuc.Location = new System.Drawing.Point(9, 30);
            this.listCheckKhuVuc.MultiColumn = true;
            this.listCheckKhuVuc.Name = "listCheckKhuVuc";
            this.listCheckKhuVuc.Size = new System.Drawing.Size(135, 114);
            this.listCheckKhuVuc.TabIndex = 1;
            this.listCheckKhuVuc.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.listCheckKhuVuc_ItemCheck);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.listCheckCuaHang);
            this.groupControl3.Controls.Add(this.chkAllCuaHang);
            this.groupControl3.Location = new System.Drawing.Point(3, 311);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(334, 177);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Cửa hàng";
            // 
            // listCheckCuaHang
            // 
            this.listCheckCuaHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCheckCuaHang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCheckCuaHang.Appearance.Options.UseFont = true;
            this.listCheckCuaHang.DisplayMember = "STORE_CODE";
            this.listCheckCuaHang.HorizontalScrollbar = true;
            this.listCheckCuaHang.Location = new System.Drawing.Point(5, 60);
            this.listCheckCuaHang.MultiColumn = true;
            this.listCheckCuaHang.Name = "listCheckCuaHang";
            this.listCheckCuaHang.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listCheckCuaHang.Size = new System.Drawing.Size(324, 112);
            this.listCheckCuaHang.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.listCheckCuaHang.TabIndex = 0;
            this.listCheckCuaHang.ValueMember = "STORE_NO";
            // 
            // chkAllCuaHang
            // 
            this.chkAllCuaHang.Location = new System.Drawing.Point(10, 31);
            this.chkAllCuaHang.Name = "chkAllCuaHang";
            this.chkAllCuaHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllCuaHang.Properties.Appearance.Options.UseFont = true;
            this.chkAllCuaHang.Properties.Caption = "All";
            this.chkAllCuaHang.Size = new System.Drawing.Size(77, 23);
            this.chkAllCuaHang.TabIndex = 0;
            this.chkAllCuaHang.CheckedChanged += new System.EventHandler(this.chkAllCuaHang_CheckedChanged);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraScrollableControl1.Controls.Add(this.pivotGridControl1);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(343, 3);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(455, 485);
            this.xtraScrollableControl1.TabIndex = 4;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(455, 485);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // btExport
            // 
            this.btExport.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExport.Appearance.Options.UseFont = true;
            this.btExport.Image = ((System.Drawing.Image)(resources.GetObject("btExport.Image")));
            this.btExport.Location = new System.Drawing.Point(5, 42);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(161, 41);
            this.btExport.TabIndex = 2;
            this.btExport.Text = "Theo báo cáo";
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btExportRawData
            // 
            this.btExportRawData.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportRawData.Appearance.Options.UseFont = true;
            this.btExportRawData.Image = ((System.Drawing.Image)(resources.GetObject("btExportRawData.Image")));
            this.btExportRawData.Location = new System.Drawing.Point(5, 89);
            this.btExportRawData.Name = "btExportRawData";
            this.btExportRawData.Size = new System.Drawing.Size(161, 41);
            this.btExportRawData.TabIndex = 2;
            this.btExportRawData.Text = "Dữ liệu thô";
            this.btExportRawData.Click += new System.EventHandler(this.btExportRawData_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl4.Controls.Add(this.btExportRawData);
            this.groupControl4.Controls.Add(this.btExport);
            this.groupControl4.Location = new System.Drawing.Point(160, 156);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(177, 149);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Xuất ra Excel";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // lbDuration
            // 
            this.lbDuration.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.Location = new System.Drawing.Point(5, 129);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(49, 13);
            this.lbDuration.TabIndex = 4;
            this.lbDuration.Text = "lbDuration";
            // 
            // frmSale_HO_NVBH_BaoCaoTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 495);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmSale_HO_NVBH_BaoCaoTongHop";
            this.Text = "Báo cáo Giờ công & Doanh số";
            this.Load += new System.EventHandler(this.frmSale_HO_NVBH_BaoCaoTongHop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DuLieuTho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DuLieuTho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listCheckKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listCheckCuaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllCuaHang.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btGo;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.CheckedListBoxControl listCheckCuaHang;
        private DevExpress.XtraEditors.CheckEdit chkAllCuaHang;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl listCheckKhuVuc;
        private DevExpress.XtraEditors.SimpleButton btExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btExportRawData;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gridControl_DuLieuTho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DuLieuTho;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private DevExpress.XtraEditors.LabelControl lbDuration;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}