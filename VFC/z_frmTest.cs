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
using PRO;
using System.Data.SqlClient;

namespace VFC
{
    public partial class z_frmTest : DevExpress.XtraEditors.XtraForm
    {
        public z_frmTest()
        {
            InitializeComponent();
        }

        private void z_frmTest_Load( object sender , EventArgs e )
        {
            lookUpEdit1.Properties.DataSource = this.GetStore( "ALL" );
            gridControl1.DataSource = this.GetStore( "a" );
        }

        private DataTable GetStore( string _region )
        {
            DataTable dt = new System.Data.DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "p_Stores_GetStores";
                cmd.Parameters.AddWithValue( "@Region" , _region );

                SqlDataAdapter adp = new SqlDataAdapter( cmd );

                adp.Fill( dt );
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() );
            }

            return dt;
        }
    }
}