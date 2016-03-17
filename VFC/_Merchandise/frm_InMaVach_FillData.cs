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

namespace VFC._Merchandise
{
    public partial class frm_InMaVach_FillData : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_InMaVach _dalInMV;

        public frm_InMaVach_FillData()
        {
            InitializeComponent();
        }

        #region Action
        private void FillDataToGridView(string _mtk , string _active)
        {
            try
            {
                _dalInMV = new cl_DAL_InMaVach();
                gridControl1.DataSource = _dalInMV.GetDSachMaVach( _mtk , _active);
            }
            catch ( Exception  )
            {

            }
        }

        private void SearchMTK()
        {
            try
            {                
                gridControl1.DataSource = null;
                gridControl1.Refresh();
                _dalInMV = new cl_DAL_InMaVach();
                gridControl1.DataSource = _dalInMV.GetDSachMaVach( txtMTK.Text.Trim() , this.getActiveCondition());
            }
            catch ( Exception  )
            {

            }
        }

        private string getActiveCondition()
        {
            string _rs = "";

            if ( rdActive.Checked == true )
            {
                _rs = "True";
            }
            else if ( rdDeActive.Checked == true )
            {
                _rs = "False";
            }
            else if ( rdAll.Checked == true )
            {
                _rs = "All";
            }

            return _rs;
        }
        #endregion

        private void btSearch_Click( object sender , EventArgs e )
        {
            this.SearchMTK();
        }

        private void frm_InMaVach_FillData_Load( object sender , EventArgs e )
        {
            this.FillDataToGridView(txtMTK.Text.Trim(), this.getActiveCondition());
        }

        private void btFillData_Click( object sender , EventArgs e )
        {
            try
            {
                _dalInMV = new cl_DAL_InMaVach();
                string _rs = _dalInMV.UploadData( lbSid.Text );
                if (_rs.Equals("2"))
                {
                    frmMessageBox.Show( "Thông báo" , "Upload thành công." + Environment.NewLine
                                                    + "Có thể dùng BarTender để in" , "done" );
                    this.FillDataToGridView( txtMTK.Text.Trim() , this.getActiveCondition() );
                }
                else
                {
                    frmMessageBox.Show( "Thông báo" , "Upload không thành công." + Environment.NewLine
                                                    + "Vui lòng thử lại" , "error" );
                }
            }
            catch(Exception ex)
            {
                frmMessageBox.Show( "Thông báo" , "Lỗi - " + Environment.NewLine
                                                    + ex.ToString() , "error" );
            }
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                lbMTK.Text = gridView1.GetFocusedRowCellValue( "MTK" ).ToString();
                lbUPC.Text = gridView1.GetFocusedRowCellValue( "UPC" ).ToString();
                lbSize.Text = gridView1.GetFocusedRowCellValue( "SIZE" ).ToString();
                lbSizeRange.Text = gridView1.GetFocusedRowCellValue( "SIZERANGE" ).ToString();
                lbQty.Text = gridView1.GetFocusedRowCellValue( "QTY" ).ToString();
                lbPrice.Text = gridView1.GetFocusedRowCellValue( "PRICE" ).ToString();
                lbDatePrint.Text = gridView1.GetFocusedRowCellValue( "DATE_PRINT" ).ToString();
                lbDateReturn.Text = gridView1.GetFocusedRowCellValue( "DATE_RETURN" ).ToString();
                lbColor.Text = gridView1.GetFocusedRowCellValue( "COLOR_EN" ).ToString();
                lbKLTNo.Text = gridView1.GetFocusedRowCellValue( "STT" ).ToString();
                lbSid.Text = gridView1.GetFocusedRowCellValue( "SID" ).ToString();
            }
            catch ( Exception  )
            {
                lbMTK.Text = null;
                lbUPC.Text = null;
                lbSize.Text = null;
                lbSizeRange.Text = null;
                lbQty.Text = null;
                lbPrice.Text = null;
                lbDatePrint.Text = null;
                lbDateReturn.Text = null;
                lbColor.Text = null;
                lbSid.Text = null;
                lbKLTNo.Text = null;
            }
        }

        private void btSentMerchandise_Click( object sender , EventArgs e )
        {
            try
            {
                _dalInMV = new cl_DAL_InMaVach();
                string _rs = _dalInMV.SentKLT( lbSid.Text );
                if ( _rs.Equals( "2" ) )
                {
                    frmMessageBox.Show( "Thông báo" , "Cập nhật thành công." , "done" );
                    this.FillDataToGridView( txtMTK.Text.Trim() , this.getActiveCondition() );
                }
                else
                {
                    frmMessageBox.Show( "Thông báo" , "Cập nhật không thành công." , "error" );
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo" , "Lỗi - " + Environment.NewLine
                                                    + ex.ToString() , "error" );
            }
        }

        private void txtMTK_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.SearchMTK();
            }
        }

        private void rdActive_CheckedChanged( object sender , EventArgs e )
        {
            this.FillDataToGridView( txtMTK.Text.Trim() , this.getActiveCondition() );
        }

        private void rdDeActive_CheckedChanged( object sender , EventArgs e )
        {
            this.FillDataToGridView( txtMTK.Text.Trim() , this.getActiveCondition() );
        }

        private void rdAll_CheckedChanged( object sender , EventArgs e )
        {
            this.FillDataToGridView( txtMTK.Text.Trim() , this.getActiveCondition() );
        }

        private void btDeActive_Click( object sender , EventArgs e )
        {
            DialogResult r = XtraMessageBox.Show("Bạn đang de-Active SID " 
                                    + lbSid.Text + "."
                                    + Environment.NewLine
                                    + "Có chắc không men (^_^)?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( r == DialogResult.Yes )
            {
                try
                {
                    _dalInMV = new cl_DAL_InMaVach();
                    string _rs = _dalInMV.DeActive_MTK( lbSid.Text );
                    if ( _rs.Equals( "2" ) )
                    {
                        frmMessageBox.Show( "Thông báo" , "DeActive thành công." , "done" );
                        this.FillDataToGridView( txtMTK.Text.Trim() , this.getActiveCondition() );
                    }
                    else
                    {
                        frmMessageBox.Show( "Thông báo" , "DeActive không thành công." , "error" );
                    }
                }
                catch ( Exception ex )
                {
                    frmMessageBox.Show( "Thông báo" , "Lỗi - " + Environment.NewLine
                                                        + ex.ToString() , "error" );
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn thật nhiều chuyện !!" , "alert" );
            }
        }
    }
}