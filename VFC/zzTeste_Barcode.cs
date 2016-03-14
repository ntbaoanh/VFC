using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VFC
{
    public partial class zzTeste_Barcode : DevExpress.XtraEditors.XtraForm
    {
        public zzTeste_Barcode()
        {
            InitializeComponent();
        }

        private void zzTeste_Barcode_Load( object sender , EventArgs e )
        {
            barCodeControl1.Text = "201512238001";
        }

        private void simpleButton1_Click( object sender , EventArgs e )
        {
            frm_PrintReport rpt = new frm_PrintReport();
            rpt.printBarCode( barCodeControl1.Text );
        }
    }
}