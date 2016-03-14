namespace VFC
{
    partial class frmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBox));
            this.picMessageIcon = new DevExpress.XtraEditors.PictureEdit();
            this.btLeft = new DevExpress.XtraEditors.SimpleButton();
            this.imageList_Button = new System.Windows.Forms.ImageList(this.components);
            this.imageList_MessageIcon = new System.Windows.Forms.ImageList(this.components);
            this.txtMessage = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picMessageIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picMessageIcon
            // 
            this.picMessageIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMessageIcon.Location = new System.Drawing.Point(25, 25);
            this.picMessageIcon.Name = "picMessageIcon";
            this.picMessageIcon.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picMessageIcon.Properties.Appearance.Options.UseBackColor = true;
            this.picMessageIcon.Size = new System.Drawing.Size(96, 96);
            this.picMessageIcon.TabIndex = 0;
            // 
            // btLeft
            // 
            this.btLeft.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeft.Appearance.Options.UseFont = true;
            this.btLeft.Location = new System.Drawing.Point(252, 131);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(83, 35);
            this.btLeft.TabIndex = 2;
            this.btLeft.Text = "btLeft";
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // imageList_Button
            // 
            this.imageList_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Button.ImageStream")));
            this.imageList_Button.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Button.Images.SetKeyName(0, "Check.ico");
            // 
            // imageList_MessageIcon
            // 
            this.imageList_MessageIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_MessageIcon.ImageStream")));
            this.imageList_MessageIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_MessageIcon.Images.SetKeyName(0, "Information.ico");
            this.imageList_MessageIcon.Images.SetKeyName(1, "Cancel.ico");
            this.imageList_MessageIcon.Images.SetKeyName(2, "Check.ico");
            this.imageList_MessageIcon.Images.SetKeyName(3, "close.ico");
            this.imageList_MessageIcon.Images.SetKeyName(4, "error.jpg");
            this.imageList_MessageIcon.Images.SetKeyName(5, "alert.png");
            this.imageList_MessageIcon.Images.SetKeyName(6, "done.jpg");
            this.imageList_MessageIcon.Images.SetKeyName(7, "image.gif");
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(131, 25);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txtMessage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Properties.Appearance.Options.UseBackColor = true;
            this.txtMessage.Properties.Appearance.Options.UseFont = true;
            this.txtMessage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMessage.Properties.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(432, 96);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.UseOptimizedRendering = true;
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 178);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.picMessageIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_caption";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMessageIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picMessageIcon;
        private DevExpress.XtraEditors.SimpleButton btLeft;
        private System.Windows.Forms.ImageList imageList_Button;
        private System.Windows.Forms.ImageList imageList_MessageIcon;
        private DevExpress.XtraEditors.MemoEdit txtMessage;
    }
}