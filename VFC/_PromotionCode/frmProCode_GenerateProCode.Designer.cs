namespace VFC._PromotionCode
{
    partial class frmProCode_GenerateProCode
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCharCount = new DevExpress.XtraEditors.TextEdit();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.txtString = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btExport = new DevExpress.XtraEditors.SimpleButton();
            this.btGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtCharCount.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtQty.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtString.Properties ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl2.Location = new System.Drawing.Point( 12 , 47 );
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size( 133 , 19 );
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Character Count";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl3.Location = new System.Drawing.Point( 96 , 79 );
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size( 49 , 19 );
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "String";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.labelControl1.Location = new System.Drawing.Point( 117 , 15 );
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size( 28 , 19 );
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Qty";
            // 
            // txtCharCount
            // 
            this.txtCharCount.Location = new System.Drawing.Point( 151 , 44 );
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtCharCount.Properties.Appearance.Options.UseFont = true;
            this.txtCharCount.Size = new System.Drawing.Size( 115 , 26 );
            this.txtCharCount.TabIndex = 9;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point( 151 , 12 );
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtQty.Properties.Appearance.Options.UseFont = true;
            this.txtQty.Size = new System.Drawing.Size( 115 , 26 );
            this.txtQty.TabIndex = 8;
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point( 151 , 76 );
            this.txtString.Name = "txtString";
            this.txtString.Properties.Appearance.Font = new System.Drawing.Font( "Tahoma" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.txtString.Properties.Appearance.Options.UseFont = true;
            this.txtString.Size = new System.Drawing.Size( 323 , 26 );
            this.txtString.TabIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.gridControl1.Location = new System.Drawing.Point( 12 , 108 );
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size( 828 , 299 );
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1} );
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // btExport
            // 
            this.btExport.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btExport.Appearance.Options.UseFont = true;
            this.btExport.Location = new System.Drawing.Point( 272 , 47 );
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size( 75 , 23 );
            this.btExport.TabIndex = 4;
            this.btExport.Text = "Export";
            this.btExport.Click += new System.EventHandler( this.btExport_Click );
            // 
            // btGenerate
            // 
            this.btGenerate.Appearance.Font = new System.Drawing.Font( "Tahoma" , 9.75F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.btGenerate.Appearance.Options.UseFont = true;
            this.btGenerate.Location = new System.Drawing.Point( 272 , 15 );
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size( 75 , 23 );
            this.btGenerate.TabIndex = 5;
            this.btGenerate.Text = "Generate";
            this.btGenerate.Click += new System.EventHandler( this.btGenerate_Click );
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler( this.saveFileDialog1_FileOk );
            // 
            // frmProCode_GenerateProCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 852 , 419 );
            this.Controls.Add( this.labelControl2 );
            this.Controls.Add( this.labelControl3 );
            this.Controls.Add( this.labelControl1 );
            this.Controls.Add( this.txtCharCount );
            this.Controls.Add( this.txtQty );
            this.Controls.Add( this.txtString );
            this.Controls.Add( this.gridControl1 );
            this.Controls.Add( this.btExport );
            this.Controls.Add( this.btGenerate );
            this.Name = "frmProCode_GenerateProCode";
            this.Text = "frmProCode_GenerateProCode";
            this.Load += new System.EventHandler( this.frmProCode_GenerateProCode_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.txtCharCount.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtQty.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.txtString.Properties ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridControl1 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize) ( this.gridView1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCharCount;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private DevExpress.XtraEditors.TextEdit txtString;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btExport;
        private DevExpress.XtraEditors.SimpleButton btGenerate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}