namespace VFC
{
    partial class zzTeste_Barcode
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
            DevExpress.XtraPrinting.BarCode.Code39Generator code39Generator4 = new DevExpress.XtraPrinting.BarCode.Code39Generator();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.AutoModule = true;
            this.barCodeControl1.Location = new System.Drawing.Point(12, 12);
            this.barCodeControl1.Module = 0D;
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(135, 82);
            code39Generator4.WideNarrowRatio = 3F;
            this.barCodeControl1.Symbology = code39Generator4;
            this.barCodeControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(41, 142);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // zzTeste_Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 261);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.barCodeControl1);
            this.Name = "zzTeste_Barcode";
            this.Load += new System.EventHandler(this.zzTeste_Barcode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}