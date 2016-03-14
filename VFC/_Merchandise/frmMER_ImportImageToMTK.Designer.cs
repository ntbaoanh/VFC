namespace VFC._Merchandise
{
    partial class frmMER_ImportImageToMTK
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbMTK = new DevExpress.XtraEditors.LabelControl();
            this.lbImageURL = new DevExpress.XtraEditors.LabelControl();
            this.btLoadImageURL = new DevExpress.XtraEditors.SimpleButton();
            this.imageBox = new DevExpress.XtraEditors.PictureEdit();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.lbCheck = new DevExpress.XtraEditors.LabelControl();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Thiết Kế :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(84, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Hình :";
            // 
            // lbMTK
            // 
            this.lbMTK.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMTK.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbMTK.Location = new System.Drawing.Point(138, 11);
            this.lbMTK.Name = "lbMTK";
            this.lbMTK.Size = new System.Drawing.Size(92, 35);
            this.lbMTK.TabIndex = 0;
            this.lbMTK.Text = "lbMTK";
            // 
            // lbImageURL
            // 
            this.lbImageURL.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImageURL.Location = new System.Drawing.Point(23, 284);
            this.lbImageURL.Name = "lbImageURL";
            this.lbImageURL.Size = new System.Drawing.Size(100, 19);
            this.lbImageURL.TabIndex = 0;
            this.lbImageURL.Text = "lbImageURL";
            this.lbImageURL.Visible = false;
            // 
            // btLoadImageURL
            // 
            this.btLoadImageURL.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadImageURL.Appearance.Options.UseFont = true;
            this.btLoadImageURL.Location = new System.Drawing.Point(403, 52);
            this.btLoadImageURL.Name = "btLoadImageURL";
            this.btLoadImageURL.Size = new System.Drawing.Size(152, 26);
            this.btLoadImageURL.TabIndex = 2;
            this.btLoadImageURL.Text = "Chọn hình";
            this.btLoadImageURL.Click += new System.EventHandler(this.btLoadImageURL_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(138, 53);
            this.imageBox.Name = "imageBox";
            this.imageBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imageBox.Size = new System.Drawing.Size(250, 250);
            this.imageBox.TabIndex = 3;
            // 
            // btSave
            // 
            this.btSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Appearance.Options.UseFont = true;
            this.btSave.Location = new System.Drawing.Point(404, 84);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(152, 26);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbCheck
            // 
            this.lbCheck.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheck.Location = new System.Drawing.Point(23, 253);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(65, 19);
            this.lbCheck.TabIndex = 0;
            this.lbCheck.Text = "lbCheck";
            this.lbCheck.Visible = false;
            // 
            // btClose
            // 
            this.btClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Appearance.Options.UseFont = true;
            this.btClose.Location = new System.Drawing.Point(404, 116);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(152, 26);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMER_ImportImageToMTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 315);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btLoadImageURL);
            this.Controls.Add(this.lbImageURL);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbMTK);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMER_ImportImageToMTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMTK";
            this.Load += new System.EventHandler(this.frmMER_ImportImageToMTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbMTK;
        private DevExpress.XtraEditors.LabelControl lbImageURL;
        private DevExpress.XtraEditors.SimpleButton btLoadImageURL;
        private DevExpress.XtraEditors.PictureEdit imageBox;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.LabelControl lbCheck;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}