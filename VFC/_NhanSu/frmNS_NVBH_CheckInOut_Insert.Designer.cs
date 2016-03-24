namespace VFC._NhanSu
{
    partial class frmNS_NVBH_CheckInOut_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNS_NVBH_CheckInOut_Insert));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbTen = new DevExpress.XtraEditors.LabelControl();
            this.lbCuaHang = new DevExpress.XtraEditors.LabelControl();
            this.lbNVSID = new DevExpress.XtraEditors.LabelControl();
            this.dateCheckInOut = new DevExpress.XtraEditors.DateEdit();
            this.timeCheckInOut = new DevExpress.XtraEditors.TimeEdit();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckInOut.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckInOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeCheckInOut.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(145, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(99, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cửa hàng : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(135, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(149, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Giờ : ";
            // 
            // lbTen
            // 
            this.lbTen.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(198, 47);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 19);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "lbTen";
            // 
            // lbCuaHang
            // 
            this.lbCuaHang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuaHang.Location = new System.Drawing.Point(198, 74);
            this.lbCuaHang.Name = "lbCuaHang";
            this.lbCuaHang.Size = new System.Drawing.Size(88, 19);
            this.lbCuaHang.TabIndex = 0;
            this.lbCuaHang.Text = "lbCuaHang";
            // 
            // lbNVSID
            // 
            this.lbNVSID.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNVSID.Location = new System.Drawing.Point(3, 3);
            this.lbNVSID.Name = "lbNVSID";
            this.lbNVSID.Size = new System.Drawing.Size(38, 13);
            this.lbNVSID.TabIndex = 0;
            this.lbNVSID.Text = "lbNVSID";
            // 
            // dateCheckInOut
            // 
            this.dateCheckInOut.EditValue = null;
            this.dateCheckInOut.Location = new System.Drawing.Point(198, 99);
            this.dateCheckInOut.Name = "dateCheckInOut";
            this.dateCheckInOut.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCheckInOut.Properties.Appearance.Options.UseFont = true;
            this.dateCheckInOut.Properties.Appearance.Options.UseTextOptions = true;
            this.dateCheckInOut.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateCheckInOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCheckInOut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCheckInOut.Size = new System.Drawing.Size(178, 26);
            this.dateCheckInOut.TabIndex = 1;
            // 
            // timeCheckInOut
            // 
            this.timeCheckInOut.EditValue = new System.DateTime(2016, 3, 23, 0, 0, 0, 0);
            this.timeCheckInOut.Location = new System.Drawing.Point(198, 131);
            this.timeCheckInOut.Name = "timeCheckInOut";
            this.timeCheckInOut.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheckInOut.Properties.Appearance.Options.UseFont = true;
            this.timeCheckInOut.Properties.Appearance.Options.UseTextOptions = true;
            this.timeCheckInOut.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.timeCheckInOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeCheckInOut.Size = new System.Drawing.Size(178, 26);
            this.timeCheckInOut.TabIndex = 2;
            // 
            // btSave
            // 
            this.btSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Appearance.Options.UseFont = true;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(198, 163);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(117, 40);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmNS_NVBH_CheckInOut_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.timeCheckInOut);
            this.Controls.Add(this.dateCheckInOut);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbNVSID);
            this.Controls.Add(this.lbCuaHang);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(337, 218);
            this.Name = "frmNS_NVBH_CheckInOut_Insert";
            this.Text = "frmNS_NVBH_CheckInOut_Insert";
            this.Load += new System.EventHandler(this.frmNS_NVBH_CheckInOut_Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckInOut.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckInOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeCheckInOut.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lbTen;
        private DevExpress.XtraEditors.LabelControl lbCuaHang;
        private DevExpress.XtraEditors.LabelControl lbNVSID;
        private DevExpress.XtraEditors.DateEdit dateCheckInOut;
        private DevExpress.XtraEditors.TimeEdit timeCheckInOut;
        private DevExpress.XtraEditors.SimpleButton btSave;
    }
}