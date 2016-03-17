using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VFC._Merchandise
{
    public partial class frm_InMaVach_Parse_Excel : Form
    {
        public frm_InMaVach_Parse_Excel()
        {
            InitializeComponent();
        }

        #region Action
        public DataTable ImportExcelXLS( string FileName , bool hasHeaders )
        {
            DataSet output = new DataSet();
            DataTable outputTable = null;

            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;

            if ( FileName.Substring( FileName.LastIndexOf( '.' ) ).ToLower() == ".xlsx" )
            {
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            }
            else
            {
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
            }

            OleDbConnection connExcel = new OleDbConnection( strConn );
            OleDbCommand cmdExcel = new OleDbCommand();
            OleDbDataAdapter oda = new OleDbDataAdapter();
            outputTable = new DataTable();
            cmdExcel.Connection = connExcel;

            //Get the name of First Sheet
            connExcel.Open();
            DataTable dtExcelSchema;
            dtExcelSchema = connExcel.GetOleDbSchemaTable( OleDbSchemaGuid.Tables , null );
            string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
            connExcel.Close();

            //Read Data from First Sheet
            connExcel.Open();
            cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";
            oda.SelectCommand = cmdExcel;
            oda.Fill( outputTable );
            connExcel.Close();

            return outputTable;
        }
        #endregion

        private void btnChooseFile_Click( object sender , EventArgs e )
        {
            try
            {
                OpenFileDialog chooseFile = new OpenFileDialog();
                chooseFile.ShowDialog();
                txtLink.Text = chooseFile.FileName;

                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo !" , ex.ToString(), "error" );
            }
        }

        private void btnImportToGrid_Click( object sender , EventArgs e )
        {
            DataTable newDt = new DataTable();
            DataTable exportDt = new DataTable();
            newDt = this.ImportExcelXLS( txtLink.Text , true );

            exportDt.Columns.Add( "No" , typeof( int ) );
            exportDt.Columns.Add( "UPC" , typeof( string ) );
            exportDt.Columns.Add( "MTK" , typeof( string ) );
            exportDt.Columns.Add( "SIZE" , typeof( string ) );
            exportDt.Columns.Add( "SIZERANGE" , typeof( string ) );
            exportDt.Columns.Add( "PRICE" , typeof( string ) );
            exportDt.Columns.Add( "COLOR" , typeof( string ) );

            try
            {
                int _no = 1;
                for ( int i = 0 ; i < newDt.Rows.Count ; i++ )
                {
                    for ( int j = 0 ; j < int.Parse( newDt.Rows[i]["QTY"].ToString() ) ; j++ )
                    {
                        try
                        {
                            int currentPrice = int.Parse( newDt.Rows[i]["PRICE"].ToString() );
                            string _price;
                            if ( currentPrice > 1000 )
                            {
                                _price = currentPrice.ToString().Substring( 0 , 1 ) + "," + currentPrice.ToString().Substring( 1 , 3 ) + " k";
                            }
                            else
                            {
                                _price = currentPrice + ",000";
                            }

                            exportDt.Rows.Add( _no 
                                                , newDt.Rows[i]["UPC"].ToString()
                                                , newDt.Rows[i]["MTK"].ToString()
                                                , newDt.Rows[i]["SIZE"].ToString()
                                                , newDt.Rows[i]["SIZERANGE"].ToString()
                                                , _price
                                                , newDt.Rows[i]["COLOR2"].ToString()
                                                    );
                            _no++;
                        }
                        catch ( Exception  )
                        {

                        }
                    }
                }
            }
            catch ( Exception  )
            {

            }

            gridControl1.DataSource = exportDt;
        }

        private void btExport_Click( object sender , EventArgs e )
        {
            saveFileDialog1.Filter = "Excel 97-2000 Documents (*.xls)|*.xls";
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
