namespace VFC._NhanSu
{
    partial class frmNS_NVBH_QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNS_NVBH_QuanLy));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btDSNV_DeActive = new DevExpress.XtraEditors.SimpleButton();
            this.btDSNV_Moi = new DevExpress.XtraEditors.SimpleButton();
            this.btDSNV_Active = new DevExpress.XtraEditors.SimpleButton();
            this.btDSNV_All = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btDeBat = new DevExpress.XtraEditors.SimpleButton();
            this.btDeActive = new DevExpress.XtraEditors.SimpleButton();
            this.btChinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.btTaoMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btThuyenChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(624, 166);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cửa hàng";
            this.gridColumn1.FieldName = "Store_Code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ";
            this.gridColumn2.FieldName = "Ho";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên";
            this.gridColumn3.FieldName = "Ten";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giới tính";
            this.gridColumn4.FieldName = "GioiTinh";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Chức vụ";
            this.gridColumn5.FieldName = "ChucVu";
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
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btDSNV_DeActive);
            this.groupControl1.Controls.Add(this.btDSNV_Moi);
            this.groupControl1.Controls.Add(this.btDSNV_Active);
            this.groupControl1.Controls.Add(this.btDSNV_All);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(307, 149);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Trích lọc";
            // 
            // btDSNV_DeActive
            // 
            this.btDSNV_DeActive.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSNV_DeActive.Appearance.Options.UseFont = true;
            this.btDSNV_DeActive.Image = ((System.Drawing.Image)(resources.GetObject("btDSNV_DeActive.Image")));
            this.btDSNV_DeActive.Location = new System.Drawing.Point(5, 68);
            this.btDSNV_DeActive.Name = "btDSNV_DeActive";
            this.btDSNV_DeActive.Size = new System.Drawing.Size(145, 35);
            this.btDSNV_DeActive.TabIndex = 0;
            this.btDSNV_DeActive.Text = "NV Nghỉ việc";
            this.btDSNV_DeActive.Click += new System.EventHandler(this.btDSNV_DeActive_Click);
            // 
            // btDSNV_Moi
            // 
            this.btDSNV_Moi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSNV_Moi.Appearance.Options.UseFont = true;
            this.btDSNV_Moi.Image = ((System.Drawing.Image)(resources.GetObject("btDSNV_Moi.Image")));
            this.btDSNV_Moi.Location = new System.Drawing.Point(5, 27);
            this.btDSNV_Moi.Name = "btDSNV_Moi";
            this.btDSNV_Moi.Size = new System.Drawing.Size(145, 35);
            this.btDSNV_Moi.TabIndex = 0;
            this.btDSNV_Moi.Text = "NV Mới";
            this.btDSNV_Moi.Click += new System.EventHandler(this.btDSNV_Moi_Click);
            // 
            // btDSNV_Active
            // 
            this.btDSNV_Active.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSNV_Active.Appearance.Options.UseFont = true;
            this.btDSNV_Active.Image = ((System.Drawing.Image)(resources.GetObject("btDSNV_Active.Image")));
            this.btDSNV_Active.Location = new System.Drawing.Point(5, 109);
            this.btDSNV_Active.Name = "btDSNV_Active";
            this.btDSNV_Active.Size = new System.Drawing.Size(145, 35);
            this.btDSNV_Active.TabIndex = 0;
            this.btDSNV_Active.Text = "Active NV";
            this.btDSNV_Active.Click += new System.EventHandler(this.btDSNV_Active_Click);
            // 
            // btDSNV_All
            // 
            this.btDSNV_All.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSNV_All.Appearance.Options.UseFont = true;
            this.btDSNV_All.Image = ((System.Drawing.Image)(resources.GetObject("btDSNV_All.Image")));
            this.btDSNV_All.Location = new System.Drawing.Point(156, 109);
            this.btDSNV_All.Name = "btDSNV_All";
            this.btDSNV_All.Size = new System.Drawing.Size(145, 35);
            this.btDSNV_All.TabIndex = 0;
            this.btDSNV_All.Text = "Tất cả NV";
            this.btDSNV_All.Click += new System.EventHandler(this.btDSNV_All_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(3, 166);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(628, 192);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh sách nhân viên";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.btDeBat);
            this.groupControl3.Controls.Add(this.btDeActive);
            this.groupControl3.Controls.Add(this.btChinhSua);
            this.groupControl3.Controls.Add(this.btTaoMoi);
            this.groupControl3.Controls.Add(this.btThuyenChuyen);
            this.groupControl3.Location = new System.Drawing.Point(318, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(307, 149);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Tác vụ";
            // 
            // btDeBat
            // 
            this.btDeBat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeBat.Appearance.Options.UseFont = true;
            this.btDeBat.Image = ((System.Drawing.Image)(resources.GetObject("btDeBat.Image")));
            this.btDeBat.Location = new System.Drawing.Point(5, 109);
            this.btDeBat.Name = "btDeBat";
            this.btDeBat.Size = new System.Drawing.Size(145, 35);
            this.btDeBat.TabIndex = 0;
            this.btDeBat.Text = "Đề bạt";
            this.btDeBat.Click += new System.EventHandler(this.btDeBat_Click);
            // 
            // btDeActive
            // 
            this.btDeActive.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeActive.Appearance.Options.UseFont = true;
            this.btDeActive.Image = ((System.Drawing.Image)(resources.GetObject("btDeActive.Image")));
            this.btDeActive.Location = new System.Drawing.Point(5, 68);
            this.btDeActive.Name = "btDeActive";
            this.btDeActive.Size = new System.Drawing.Size(145, 35);
            this.btDeActive.TabIndex = 0;
            this.btDeActive.Text = "Nghỉ việc";
            this.btDeActive.Click += new System.EventHandler(this.btDeActive_Click);
            // 
            // btChinhSua
            // 
            this.btChinhSua.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChinhSua.Appearance.Options.UseFont = true;
            this.btChinhSua.Image = ((System.Drawing.Image)(resources.GetObject("btChinhSua.Image")));
            this.btChinhSua.Location = new System.Drawing.Point(156, 109);
            this.btChinhSua.Name = "btChinhSua";
            this.btChinhSua.Size = new System.Drawing.Size(145, 35);
            this.btChinhSua.TabIndex = 0;
            this.btChinhSua.Text = "Chỉnh sửa";
            this.btChinhSua.Click += new System.EventHandler(this.btChinhSua_Click);
            // 
            // btTaoMoi
            // 
            this.btTaoMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoMoi.Appearance.Options.UseFont = true;
            this.btTaoMoi.Image = ((System.Drawing.Image)(resources.GetObject("btTaoMoi.Image")));
            this.btTaoMoi.Location = new System.Drawing.Point(156, 68);
            this.btTaoMoi.Name = "btTaoMoi";
            this.btTaoMoi.Size = new System.Drawing.Size(145, 35);
            this.btTaoMoi.TabIndex = 0;
            this.btTaoMoi.Text = "Tại mới";
            this.btTaoMoi.Click += new System.EventHandler(this.btTaoMoi_Click);
            // 
            // btThuyenChuyen
            // 
            this.btThuyenChuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThuyenChuyen.Appearance.Options.UseFont = true;
            this.btThuyenChuyen.Image = ((System.Drawing.Image)(resources.GetObject("btThuyenChuyen.Image")));
            this.btThuyenChuyen.Location = new System.Drawing.Point(5, 27);
            this.btThuyenChuyen.Name = "btThuyenChuyen";
            this.btThuyenChuyen.Size = new System.Drawing.Size(145, 35);
            this.btThuyenChuyen.TabIndex = 0;
            this.btThuyenChuyen.Text = "Thuyên chuyển";
            this.btThuyenChuyen.Click += new System.EventHandler(this.btThuyenChuyen_Click);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Approve";
            this.gridColumn7.FieldName = "Approve";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // frmNS_NVBH_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 361);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmNS_NVBH_QuanLy";
            this.Text = "Danh sách Nhân Viên bán hàng";
            this.Load += new System.EventHandler(this.frmNS_NVBH_QuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btThuyenChuyen;
        private DevExpress.XtraEditors.SimpleButton btDSNV_DeActive;
        private DevExpress.XtraEditors.SimpleButton btDSNV_Moi;
        private DevExpress.XtraEditors.SimpleButton btDSNV_All;
        private DevExpress.XtraEditors.SimpleButton btDeActive;
        private DevExpress.XtraEditors.SimpleButton btChinhSua;
        private DevExpress.XtraEditors.SimpleButton btTaoMoi;
        private DevExpress.XtraEditors.SimpleButton btDSNV_Active;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btDeBat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;

    }
}