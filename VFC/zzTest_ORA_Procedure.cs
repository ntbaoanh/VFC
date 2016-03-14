using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;

namespace VFC
{
    public partial class zzTest_ORA_Procedure : DevExpress.XtraEditors.XtraForm
    {
        public zzTest_ORA_Procedure()
        {
            InitializeComponent();
        }

        private void zzTest_ORA_Procedure_Load( object sender , EventArgs e )
        {
            DAL.cl_zzTest_Procedure dalTest = new cl_zzTest_Procedure();
            gridControl1.DataSource = dalTest.GetStores( 2 );
        }
    }
}