namespace VFC._NhanSu
{
    partial class frmNS_NVBH_CheckInOut_QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNS_NVBH_CheckInOut_QuanLy));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl_DSNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_ListCheckInOut = new DevExpress.XtraGrid.GridControl();
            this.gridView_ListCheckInOut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btIn = new DevExpress.XtraEditors.SimpleButton();
            this.btOut = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.date = new DevExpress.XtraEditors.DateEdit();
            this.btBoth = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSNhanVien)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ListCheckInOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ListCheckInOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl_DSNhanVien);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraScrollableControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(793, 394);
            this.splitContainerControl1.SplitterPosition = 367;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl_DSNhanVien
            // 
            this.gridControl_DSNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_DSNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridControl_DSNhanVien.MainView = this.gridView_DSNhanVien;
            this.gridControl_DSNhanVien.Name = "gridControl_DSNhanVien";
            this.gridControl_DSNhanVien.Size = new System.Drawing.Size(367, 394);
            this.gridControl_DSNhanVien.TabIndex = 0;
            this.gridControl_DSNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSNhanVien});
            // 
            // gridView_DSNhanVien
            // 
            this.gridView_DSNhanVien.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView_DSNhanVien.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView_DSNhanVien.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_DSNhanVien.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_DSNhanVien.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView_DSNhanVien.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView_DSNhanVien.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView_DSNhanVien.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_DSNhanVien.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_DSNhanVien.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_DSNhanVien.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_DSNhanVien.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DSNhanVien.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_DSNhanVien.Appearance.Row.Options.UseFont = true;
            this.gridView_DSNhanVien.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView_DSNhanVien.GridControl = this.gridControl_DSNhanVien;
            this.gridView_DSNhanVien.Name = "gridView_DSNhanVien";
            this.gridView_DSNhanVien.OptionsBehavior.Editable = false;
            this.gridView_DSNhanVien.OptionsBehavior.ReadOnly = true;
            this.gridView_DSNhanVien.OptionsView.ShowAutoFilterRow = true;
            this.gridView_DSNhanVien.OptionsView.ShowFooter = true;
            this.gridView_DSNhanVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_DSNhanVien_FocusedRowChanged);
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
            this.gridColumn4.Caption = "StoreNo";
            this.gridColumn4.FieldName = "StoreNo";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "NVSID";
            this.gridColumn5.FieldName = "NVSID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupControl2);
            this.xtraScrollableControl1.Controls.Add(this.groupControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(421, 394);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gridControl_ListCheckInOut);
            this.groupControl2.Location = new System.Drawing.Point(3, 163);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(406, 231);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Tình trạng check In - Out";
            // 
            // gridControl_ListCheckInOut
            // 
            this.gridControl_ListCheckInOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ListCheckInOut.Location = new System.Drawing.Point(2, 27);
            this.gridControl_ListCheckInOut.MainView = this.gridView_ListCheckInOut;
            this.gridControl_ListCheckInOut.Name = "gridControl_ListCheckInOut";
            this.gridControl_ListCheckInOut.Size = new System.Drawing.Size(402, 202);
            this.gridControl_ListCheckInOut.TabIndex = 0;
            this.gridControl_ListCheckInOut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ListCheckInOut});
            // 
            // gridView_ListCheckInOut
            // 
            this.gridView_ListCheckInOut.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_ListCheckInOut.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_ListCheckInOut.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_ListCheckInOut.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ListCheckInOut.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_ListCheckInOut.Appearance.Row.Options.UseFont = true;
            this.gridView_ListCheckInOut.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_ListCheckInOut.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ListCheckInOut.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7});
            this.gridView_ListCheckInOut.GridControl = this.gridControl_ListCheckInOut;
            this.gridView_ListCheckInOut.Name = "gridView_ListCheckInOut";
            this.gridView_ListCheckInOut.OptionsBehavior.Editable = false;
            this.gridView_ListCheckInOut.OptionsBehavior.ReadOnly = true;
            this.gridView_ListCheckInOut.OptionsView.ShowAutoFilterRow = true;
            this.gridView_ListCheckInOut.OptionsView.ShowFooter = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Giờ";
            this.gridColumn6.DisplayFormat.FormatString = "{0:HH:mm}";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "TimeOnly";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "In / Out";
            this.gridColumn7.FieldName = "Status";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btBoth);
            this.groupControl1.Controls.Add(this.btIn);
            this.groupControl1.Controls.Add(this.btOut);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.date);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(406, 154);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin trích lọc";
            // 
            // btIn
            // 
            this.btIn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Appearance.Options.UseFont = true;
            this.btIn.Image = ((System.Drawing.Image)(resources.GetObject("btIn.Image")));
            this.btIn.Location = new System.Drawing.Point(82, 59);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(117, 40);
            this.btIn.TabIndex = 5;
            this.btIn.Text = "Vào";
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btOut
            // 
            this.btOut.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.Appearance.Options.UseFont = true;
            this.btOut.Image = ((System.Drawing.Image)(resources.GetObject("btOut.Image")));
            this.btOut.Location = new System.Drawing.Point(205, 59);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(117, 40);
            this.btOut.TabIndex = 4;
            this.btOut.Text = "Ra";
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(19, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ngày : ";
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Location = new System.Drawing.Point(82, 33);
            this.date.Name = "date";
            this.date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Properties.Appearance.Options.UseFont = true;
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Size = new System.Drawing.Size(177, 20);
            this.date.TabIndex = 0;
            // 
            // btBoth
            // 
            this.btBoth.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBoth.Appearance.Options.UseFont = true;
            this.btBoth.Image = ((System.Drawing.Image)(resources.GetObject("btBoth.Image")));
            this.btBoth.Location = new System.Drawing.Point(82, 105);
            this.btBoth.Name = "btBoth";
            this.btBoth.Size = new System.Drawing.Size(240, 40);
            this.btBoth.TabIndex = 5;
            this.btBoth.Text = "Vào + Ra";
            this.btBoth.Click += new System.EventHandler(this.btBoth_Click);
            // 
            // frmNS_NVBH_CheckInOut_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 394);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmNS_NVBH_CheckInOut_QuanLy";
            this.Text = "Thêm giờ Ra Vào";
            this.Load += new System.EventHandler(this.frmNS_NVBH_CheckInOut_QuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSNhanVien)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ListCheckInOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ListCheckInOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl_DSNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DSNhanVien;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit date;
        private DevExpress.XtraEditors.SimpleButton btIn;
        private DevExpress.XtraEditors.SimpleButton btOut;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl_ListCheckInOut;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ListCheckInOut;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SimpleButton btBoth;
    }
}