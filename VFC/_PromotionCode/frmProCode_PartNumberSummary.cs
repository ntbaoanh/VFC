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
    public partial class frmProCode_PartNumberSummary : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_PromotionCode _dalProCode;

        public frmProCode_PartNumberSummary()
        {
            InitializeComponent();
        }

        private void frmProCode_PartNumberSummary_Load( object sender , EventArgs e )
        {
            this.FillDateToDanhSach();
        }

        private void btRefresh_Click( object sender , EventArgs e )
        {
            this.FillDateToDanhSach();
        }

        private void btDeActive_Click( object sender , EventArgs e )
        {            
            DialogResult dialogResult = XtraMessageBox.Show( "Bạn có chắc chắn muốn De-Active partnumber này ?" , "Chú ý" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);

            if ( dialogResult == DialogResult.Yes )
            {
                _dalProCode = new cl_DAL_PromotionCode();
                if ( _dalProCode.DeActiveCode( int.Parse( lbPartNumber.Text ) ) )
                {
                    frmMessageBox.Show( "Thông báo" , "Đã De-Active partnumer số " + lbPartNumber.Text + " thành công" , "done" );
                    this.FillDateToDanhSach();
                }
                else
                {
                    frmMessageBox.Show( "Thông báo lỗi" , "De-Active partnumer số " + lbPartNumber.Text + " KHÔNG thành công" , "error" );
                }
            }
        }

        private void FillDateToDanhSach()
        {
            try
            {
                gridControl1.DataSource = null;
                _dalProCode = new cl_DAL_PromotionCode();
                gridControl1.DataSource = _dalProCode.GetListPartNumber( "DESC" );
            }
            catch ( Exception ex)
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            _dalProCode = new cl_DAL_PromotionCode();

            try
            {
                string _partNumber = gridView1.GetFocusedRowCellValue( "PartNumber" ).ToString();
                lbPartNumber.Text = _partNumber.ToString();

                if ( gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Expired" ) )
                {
                    btDeActive.Enabled = false;
                    lbStatus.ForeColor = Color.Red;
                }
                else
                {
                    btDeActive.Enabled = true;
                    lbStatus.ForeColor = Color.Blue;
                }

                lbStatus.Text = gridView1.GetFocusedRowCellValue( "Status" ).ToString();
                lbAvailable.Text = _dalProCode.CountAvailableCode( int.Parse( _partNumber ) ).ToString();
                lbUsed.Text = _dalProCode.CountUsedCode( int.Parse( _partNumber ) ).ToString();
                lbHold.Text = _dalProCode.CountHoldCode( int.Parse( _partNumber ) ).ToString();
                lbExpired.Text = _dalProCode.CountExpiredCode( int.Parse( _partNumber ) ).ToString();
                lbTotal.Text = gridView1.GetFocusedRowCellValue( "QTY" ).ToString();

                int percentComplete = (int) Math.Round( (double) ( 100 * int.Parse( lbUsed.Text ) ) / int.Parse( lbTotal.Text ) );

                lbEffective.Text = percentComplete + "%";

                this.FillPartNumberNote( int.Parse( _partNumber ) );
            }
            catch ( NullReferenceException ex )
            {
                this.ClearLabelData();
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                this.ClearLabelData();
            }
        }

        private void ClearLabelData()
        {
            lbStatus.Text = null;
            lbAvailable.Text = null;
            lbEffective.Text = null;
            lbExpired.Text = null;
            lbHold.Text = null;
            lbPartNumber.Text = null;
            lbTotal.Text = null;
            lbUsed.Text = null;
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
                if ( DateTime.Compare( DateTime.Now , (DateTime) expireDate.AddDays(1) ) > 0 )
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
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
    }
}