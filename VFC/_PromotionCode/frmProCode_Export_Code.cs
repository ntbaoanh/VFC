using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DAL;

namespace VFC._PromotionCode
{
    public partial class frmProCode_Export_Code : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_PromotionCode _dalProCode;
        DAL.Utilities.SQLCon _conn;

        public frmProCode_Export_Code()
        {
            InitializeComponent();
        }

        private void frmProCode_Export_Code_Load( object sender , EventArgs e )
        {
            _dalProCode = new cl_DAL_PromotionCode();
            gridControl1.DataSource = _dalProCode.GetListPartNumber( "DESC" );
        }

        private void btExport_Click( object sender , EventArgs e )
        {
            saveFileDialog1.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            saveFileDialog1.ShowDialog();
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                string _partNumber = gridView1.GetFocusedRowCellValue( "PartNumber" ).ToString();

                if ( gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Expired" ) )
                {
                    XtraMessageBox.Show( "Part số " + _partNumber + " đã hết hạn sử dụng." , "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Information );
                    btExport.Enabled = false;
                    gridControl2.DataSource = null;
                }
                else
                {
                    btExport.Enabled = true;
                    int selectedPartNumber = int.Parse( _partNumber );

                    _conn = new DAL.Utilities.SQLCon();
                    DataTable _dt = new DataTable();
                    string sql = "SELECT ProcodeSid, ProCode FROM tb_CS_PromotionCode_Info where PartNumber = " + selectedPartNumber;

                    _dt = _conn.returnDataTable( sql );

                    gridControl2.DataSource = _dt;

                    this.FillPartNumberNote( selectedPartNumber );
                }
            }
            catch ( NullReferenceException  )
            {
                gridControl2.DataSource = null;
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                gridControl2.DataSource = null;
            }
        }

        private void saveFileDialog1_FileOk( object sender , CancelEventArgs e )
        {
            string fileName = saveFileDialog1.FileName;
            try
            {
                gridControl2.ExportToXlsx( fileName );
            }
            catch ( Exception ex )
            {
                throw new Exception( ex.ToString() );
            }     
        }

        private void FillPartNumberNote( int _partNumber )
        {
            string _note = _dalProCode.GetPartNumberNotes( _partNumber );

            if ( _note.Equals( "No Record" ) )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Không có PartNumber này." , "error" );
            }
            else if ( _note.Equals( "Exception" ) )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Có lỗi xảy ra. " + Environment.NewLine + " Vui lòng liên hệ Quản Trị Viên." , "error" );
            }
            else
            {
                txtNotes.Text = _note;
            }
        }

        private void gridView1_RowStyle( object sender , DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e )
        {
            GridView View = sender as GridView;
            if ( e.RowHandle >= 0 )
            {
                string dateExpire = View.GetRowCellDisplayText( e.RowHandle , View.Columns["Date_Expire"] );
                DateTime expireDate = new DateTime( int.Parse( dateExpire.Substring( 6 , 4 ) ) ,
                                                    int.Parse( dateExpire.Substring( 3 , 2 ) ) ,
                                                    int.Parse( dateExpire.Substring( 0 , 2 ) ) );
                if ( DateTime.Compare( DateTime.Now , (DateTime) expireDate.AddDays( 1 ) ) > 0 )
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }
    }
}