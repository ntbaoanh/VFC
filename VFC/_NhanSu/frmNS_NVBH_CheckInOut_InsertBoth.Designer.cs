namespace VFC._NhanSu
{
    partial class frmNS_NVBH_CheckInOut_InsertBoth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNS_NVBH_CheckInOut_InsertBoth));
            this.timeCheckIn = new DevExpress.XtraEditors.TimeEdit();
            this.dateCheckInOut = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbNVSID = new DevExpress.XtraEditors.LabelControl();
            this.lbCuaHang = new DevExpress.XtraEditors.LabelControl();
            this.lbTen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.timeCheckOut = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.timeCheckIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckInOut.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckInOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeCheckOut.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timeCheckIn
            // 
            this.timeCheckIn.EditValue = new System.DateTime(2016, 3, 23, 0, 0, 0, 0);
            this.timeCheckIn.Location = new System.Drawing.Point(198, 131);
            this.timeCheckIn.Name = "timeCheckIn";
            this.timeCheckIn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheckIn.Properties.Appearance.Options.UseFont = true;
            this.timeCheckIn.Properties.Appearance.Options.UseTextOptions = true;
            this.timeCheckIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.timeCheckIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeCheckIn.Size = new System.Drawing.Size(178, 26);
            this.timeCheckIn.TabIndex = 13;
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
            this.dateCheckInOut.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(115, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 19);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Giờ vào : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(135, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 19);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Ngày : ";
            // 
            // lbNVSID
            // 
            this.lbNVSID.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNVSID.Location = new System.Drawing.Point(3, 3);
            this.lbNVSID.Name = "lbNVSID";
            this.lbNVSID.Size = new System.Drawing.Size(38, 13);
            this.lbNVSID.TabIndex = 6;
            this.lbNVSID.Text = "lbNVSID";
            // 
            // lbCuaHang
            // 
            this.lbCuaHang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuaHang.Location = new System.Drawing.Point(198, 74);
            this.lbCuaHang.Name = "lbCuaHang";
            this.lbCuaHang.Size = new System.Drawing.Size(88, 19);
            this.lbCuaHang.TabIndex = 5;
            this.lbCuaHang.Text = "lbCuaHang";
            // 
            // lbTen
            // 
            this.lbTen.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(198, 47);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(46, 19);
            this.lbTen.TabIndex = 8;
            this.lbTen.Text = "lbTen";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(99, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Cửa hàng : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(145, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 19);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên : ";
            // 
            // btSave
            // 
            this.btSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Appearance.Options.UseFont = true;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(198, 195);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(117, 40);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(127, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 19);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Giờ ra : ";
            // 
            // timeCheckOut
            // 
            this.timeCheckOut.EditValue = new System.DateTime(2016, 3, 23, 0, 0, 0, 0);
            this.timeCheckOut.Location = new System.Drawing.Point(198, 163);
            this.timeCheckOut.Name = "timeCheckOut";
            this.timeCheckOut.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheckOut.Properties.Appearance.Options.UseFont = true;
            this.timeCheckOut.Properties.Appearance.Options.UseTextOptions = true;
            this.timeCheckOut.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.timeCheckOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeCheckOut.Size = new System.Drawing.Size(178, 26);
            this.timeCheckOut.TabIndex = 13;
            // 
            // frmNS_NVBH_CheckInOut_InsertBoth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.timeCheckOut);
            this.Controls.Add(this.timeCheckIn);
            this.Controls.Add(this.labelControl5);
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
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "frmNS_NVBH_CheckInOut_InsertBoth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm giờ Và + Ra của Nhân Viên";
            this.Load += new System.EventHandler(this.frmNS_NVBH_CheckInOut_InsertBoth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeCheckIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckInOut.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCheckInOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeCheckOut.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.TimeEdit timeCheckIn;
        private DevExpress.XtraEditors.DateEdit dateCheckInOut;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbNVSID;
        private DevExpress.XtraEditors.LabelControl lbCuaHang;
        private DevExpress.XtraEditors.LabelControl lbTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TimeEdit timeCheckOut;
    }
}