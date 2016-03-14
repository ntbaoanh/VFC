namespace VFC._Merchandise
{
    partial class frmMER_ShowImage
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
            this.imageBox = new DevExpress.XtraEditors.PictureEdit();
            ( (System.ComponentModel.ISupportInitialize) ( this.imageBox.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point( 0 , 0 );
            this.imageBox.Name = "imageBox";
            this.imageBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imageBox.Size = new System.Drawing.Size( 684 , 661 );
            this.imageBox.TabIndex = 0;
            this.imageBox.Click += new System.EventHandler( this.imageBox_Click );
            // 
            // frmMER_ShowImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size( 684 , 661 );
            this.Controls.Add( this.imageBox );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMER_ShowImage";
            this.Text = "frmMER_ShowImage";
            this.Load += new System.EventHandler( this.frmMER_ShowImage_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.imageBox.Properties ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit imageBox;


    }
}