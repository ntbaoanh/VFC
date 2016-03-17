using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VFC._PromotionCode
{
    public partial class frmProCode_GenerateProCode : DevExpress.XtraEditors.XtraForm
    {
        DAL.Utilities.GetRandomAlphanumericString randomCode;

        public frmProCode_GenerateProCode()
        {
            InitializeComponent();
        }

        private void frmProCode_GenerateProCode_Load( object sender , EventArgs e )
        {
            txtString.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        }

        private void btGenerate_Click( object sender , EventArgs e )
        {
            randomCode = new DAL.Utilities.GetRandomAlphanumericString();
            DataTable _dt = new DataTable();
            _dt.Columns.Add( "Promotion Code" , typeof( string ) );

            for ( int i = 0 ; i < Int64.Parse( txtQty.Text.Trim() ) ; i++ )
            {
                _dt.Rows.Add( randomCode.FinalRandomString( txtString.Text.Trim() , int.Parse( txtCharCount.Text.Trim() ) ) );
            }

            gridControl1.DataSource = _dt;
        }

        private void btExport_Click( object sender , EventArgs e )
        {
            saveFileDialog1.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk( object sender , CancelEventArgs e )
        {
            string fileName = saveFileDialog1.FileName;
            try
            {
                gridView1.BestFitColumns();

                gridControl1.ExportToXlsx( fileName );
            }
            catch ( Exception  )
            {

            }
        }
    }
}