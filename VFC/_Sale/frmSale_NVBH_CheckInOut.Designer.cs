namespace VFC._Sale
{
    partial class frmSale_NVBH_CheckInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale_NVBH_CheckInOut));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btIn = new DevExpress.XtraEditors.SimpleButton();
            this.btOut = new DevExpress.XtraEditors.SimpleButton();
            this.lbLastOut = new DevExpress.XtraEditors.LabelControl();
            this.lbLastIn = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.lbPhone = new DevExpress.XtraEditors.LabelControl();
            this.lbTen = new DevExpress.XtraEditors.LabelControl();
            this.lbNVID = new DevExpress.XtraEditors.LabelControl();
            this.lbHo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraScrollableControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(733, 418);
            this.splitContainerControl1.SplitterPosition = 396;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(396, 418);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Họ NV";
            this.gridColumn1.FieldName = "Ho";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Tên NV";
            this.gridColumn2.FieldName = "Ten";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Số điện thoại";
            this.gridColumn3.FieldName = "Phone";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Working";
            this.gridColumn4.FieldName = "Working";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupControl2);
            this.xtraScrollableControl1.Controls.Add(this.groupControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(332, 418);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btIn);
            this.groupControl2.Controls.Add(this.btOut);
            this.groupControl2.Controls.Add(this.lbLastOut);
            this.groupControl2.Controls.Add(this.lbLastIn);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Location = new System.Drawing.Point(0, 178);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(308, 174);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin chấm công";
            // 
            // btIn
            // 
            this.btIn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Appearance.Options.UseFont = true;
            this.btIn.Image = ((System.Drawing.Image)(resources.GetObject("btIn.Image")));
            this.btIn.Location = new System.Drawing.Point(5, 80);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(298, 40);
            this.btIn.TabIndex = 2;
            this.btIn.Text = "Vào";
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btOut
            // 
            this.btOut.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.Appearance.Options.UseFont = true;
            this.btOut.Image = ((System.Drawing.Image)(resources.GetObject("btOut.Image")));
            this.btOut.Location = new System.Drawing.Point(5, 126);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(298, 40);
            this.btOut.TabIndex = 2;
            this.btOut.Text = "Ra";
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // lbLastOut
            // 
            this.lbLastOut.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastOut.Location = new System.Drawing.Point(135, 58);
            this.lbLastOut.Name = "lbLastOut";
            this.lbLastOut.Size = new System.Drawing.Size(53, 16);
            this.lbLastOut.TabIndex = 1;
            this.lbLastOut.Text = "lbLastOut";
            // 
            // lbLastIn
            // 
            this.lbLastIn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastIn.Location = new System.Drawing.Point(135, 36);
            this.lbLastIn.Name = "lbLastIn";
            this.lbLastIn.Size = new System.Drawing.Size(44, 16);
            this.lbLastIn.TabIndex = 1;
            this.lbLastIn.Text = "lbLastIn";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(21, 58);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(108, 16);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "Giờ ra gần nhất :";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(11, 36);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(118, 16);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "Giờ vào gần nhất :";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btRefresh);
            this.groupControl1.Controls.Add(this.lbGioiTinh);
            this.groupControl1.Controls.Add(this.lbPhone);
            this.groupControl1.Controls.Add(this.lbTen);
            this.groupControl1.Controls.Add(this.lbNVID);
            this.groupControl1.Controls.Add(this.lbHo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(308, 169);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin Nhân viên";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(111, 100);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(56, 16);
            this.lbGioiTinh.TabIndex = 1;
            this.lbGioiTinh.Text = "lbGioiTinh";
            // 
            // lbPhone
            // 
            this.lbPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(111, 78);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(45, 16);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "lbPhone";
            // 
            // lbTen
            // 
            this.lbTen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(111, 56);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(32, 16);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "lbTen";
            // 
            // lbNVID
            // 
            this.lbNVID.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNVID.Location = new System.Drawing.Point(5, 30);
            this.lbNVID.Name = "lbNVID";
            this.lbNVID.Size = new System.Drawing.Size(38, 16);
            this.lbNVID.TabIndex = 1;
            this.lbNVID.Text = "lbNVID";
            // 
            // lbHo
            // 
            this.lbHo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHo.Location = new System.Drawing.Point(111, 34);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(25, 16);
            this.lbHo.TabIndex = 1;
            this.lbHo.Text = "lbHo";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(45, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Giới tính :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Số điện thoại :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(73, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(79, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ :";
            // 
            // btRefresh
            // 
            this.btRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Appearance.Options.UseFont = true;
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.Location = new System.Drawing.Point(5, 122);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(298, 40);
            this.btRefresh.TabIndex = 2;
            this.btRefresh.Text = "Làm mới danh sách";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // frmSale_NVBH_CheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 418);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmSale_NVBH_CheckInOut";
            this.Text = "frmSale_NVBH_CheckInOut";
            this.Load += new System.EventHandler(this.frmSale_NVBH_CheckInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbGioiTinh;
        private DevExpress.XtraEditors.LabelControl lbPhone;
        private DevExpress.XtraEditors.LabelControl lbTen;
        private DevExpress.XtraEditors.LabelControl lbHo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btIn;
        private DevExpress.XtraEditors.SimpleButton btOut;
        private DevExpress.XtraEditors.LabelControl lbLastOut;
        private DevExpress.XtraEditors.LabelControl lbLastIn;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl lbNVID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
    }
}