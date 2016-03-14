namespace VFC._Admin
{
    partial class frmManageVersion
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
            this.txtVersion = new DevExpress.XtraEditors.TextEdit();
            this.btLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtVersion.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , ( (System.Drawing.FontStyle) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ) , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 13 , 15 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 72 , 19 );
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Version :";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point( 91 , 12 );
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtVersion.Properties.Appearance.Options.UseFont = true;
            this.txtVersion.Size = new System.Drawing.Size( 205 , 26 );
            this.txtVersion.TabIndex = 1;
            // 
            // btLoad
            // 
            this.btLoad.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btLoad.Appearance.Options.UseFont = true;
            this.btLoad.Location = new System.Drawing.Point( 302 , 12 );
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size( 75 , 26 );
            this.btLoad.TabIndex = 2;
            this.btLoad.Text = "Load";
            this.btLoad.Click += new System.EventHandler( this.btLoad_Click );
            // 
            // btSave
            // 
            this.btSave.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btSave.Appearance.Options.UseFont = true;
            this.btSave.Location = new System.Drawing.Point( 383 , 12 );
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size( 75 , 26 );
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler( this.btSave_Click );
            // 
            // frmManageVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 469 , 51 );
            this.Controls.Add( this.btSave );
            this.Controls.Add( this.btLoad );
            this.Controls.Add( this.txtVersion );
            this.Controls.Add( this.labelControl1 );
            this.Name = "frmManageVersion";
            this.Text = "Manage Version";
            this.Load += new System.EventHandler( this.frmManageVersion_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtVersion.Properties ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtVersion;
        private DevExpress.XtraEditors.SimpleButton btLoad;
        private DevExpress.XtraEditors.SimpleButton btSave;
    }
}