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
using DevExpress.XtraGrid.Views.Grid;

namespace VFC._Message
{
    public partial class frmMessage_Manage : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_SystemMessage _dalMessage;

        public frmMessage_Manage()
        {
            InitializeComponent();
        }

        private void frmMessage_Create_Load( object sender , EventArgs e )
        {
            trackBarControl.Value = 0;
            dateFrom.EditValue = DateTime.Now;
            dateTo.EditValue = DateTime.Now;
            this.ClearData();
            btSave.Enabled = false;
        }

        private void trackBarControl_EditValueChanged( object sender , EventArgs e )
        {
            if ( trackBarControl.EditValue.ToString().Equals("0") )
            {
                lbUuTien.Text = "Hướng dẫn";
                lbUuTien.ForeColor = Color.Black;
            }
            else if ( trackBarControl.EditValue.ToString().Equals( "1" ) )
            {
                lbUuTien.Text = "Thông báo (30ph)";
                lbUuTien.ForeColor = Color.Blue;
            }
            else if ( trackBarControl.EditValue.ToString().Equals( "2" ) )
            {
                lbUuTien.Text = "Thông báo (20ph)";
                lbUuTien.ForeColor = Color.Orange;
            }
            else if ( trackBarControl.EditValue.ToString().Equals( "3" ) )
            {
                lbUuTien.Text = "Thông báo (10ph)";
                lbUuTien.ForeColor = Color.Brown;
            }
            else if ( trackBarControl.EditValue.ToString().Equals( "4" ) )
            {
                lbUuTien.Text = "Thông báo - Quan trọng (5ph)";
                lbUuTien.ForeColor = Color.Red;
            }
        }

        private void btCreateMessage_Click( object sender , EventArgs e )
        {
            string _validate = this.iValidateCreate();
            if ( _validate.Equals( "" ) )
            {
                _dalMessage = new cl_DAL_SystemMessage();

                if ( _dalMessage.InsertMessage( txtTitle.Text.Trim()
                                                 , txtBody.Text.Trim()
                                                 , frmHO_Main._userLogin.UserName
                                                 , int.Parse( trackBarControl.EditValue.ToString() ) ) )
                {
                    frmMessageBox.Show( "Thông báo" , "Thêm thông báo thành công." , "done" );
                }
                else
                {
                    frmMessageBox.Show( "Thông báo" , "Thêm thông báo thất bại." , "error" );
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo lỗi" , _validate , "error" );
            }

            this.ClearData();
        }

        private void btActive_Click( object sender , EventArgs e )
        {
            string _validate = this.iValidateEdit();

            if ( _validate.Equals( "" ) )
            {
                _dalMessage = new cl_DAL_SystemMessage();

                if ( _dalMessage.ActiveMessage( frmHO_Main._userLogin.UserName
                                                 , int.Parse( lbMessageID.Text ) ) )
                {
                    frmMessageBox.Show( "Thông báo" , "Kích hoạt thông báo thành công." , "done" );
                }
                else
                {
                    frmMessageBox.Show( "Thông báo" , "Kích hoạt thông báo thất bại." , "error" );
                }
                
            }
            else
            {
                frmMessageBox.Show( "Thông báo lỗi" , _validate , "error" );
            }

            this.ClearData();
        }

        private void btDeActive_Click( object sender , EventArgs e )
        {
            string _validate = this.iValidateEdit();

            if ( _validate.Equals( "" ) )
            {
                _dalMessage = new cl_DAL_SystemMessage();

                if ( _dalMessage.DeActiveMessage( frmHO_Main._userLogin.UserName
                                                 , int.Parse( lbMessageID.Text ) ) )
                {
                    frmMessageBox.Show( "Thông báo" , "Vô hiệu hóa thông báo thành công." , "done" );
                }
                else
                {
                    frmMessageBox.Show( "Thông báo" , "Vô hiệu hóa thông báo thất bại." , "error" );
                }

            }
            else
            {
                frmMessageBox.Show( "Thông báo lỗi" , _validate , "error" );
            }

            this.ClearData();
        }

        private void btFilter_Click( object sender , EventArgs e )
        {
            string _fromDate = string.Format( "{0:dd/MM/yyyy}" , dateFrom.EditValue ).ToString();
            string _toDate = string.Format( "{0:dd/MM/yyyy}" , dateTo.EditValue ).ToString();
            this.FillDataToGridMessage( _fromDate, _toDate );
            this.ClearDataWithOutFillData();
        }

        private void btEdit_Click( object sender , EventArgs e )
        {
            try
            {
                txtTitle.Text = gridView1.GetFocusedRowCellValue( "Title" ).ToString();
                txtBody.Text = gridView1.GetFocusedRowCellValue( "Message" ).ToString();
                lbMessageID.Text = gridView1.GetFocusedRowCellValue( "MessageID" ).ToString();
                lbCreatedDate.Text = gridView1.GetFocusedRowCellValue( "CreatedDate" ).ToString();
                lbCreatedBy.Text = gridView1.GetFocusedRowCellValue( "CreatedBy" ).ToString();
                lbModifiedBy.Text = gridView1.GetFocusedRowCellValue( "ModifiedBy" ).ToString();
                lbModifiedDate.Text = gridView1.GetFocusedRowCellValue( "ModifiedDate" ).ToString();
                trackBarControl.Value = int.Parse( gridView1.GetFocusedRowCellValue( "Important" ).ToString() );
                btSave.Enabled = true;
            }
            catch ( NullReferenceException ex )
            {
                this.ClearData();
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                this.ClearData();
            }
        }

        private void btSave_Click( object sender , EventArgs e )
        {
            string _validate = this.iValidateEdit();

            if ( _validate.Equals( "" ) )
            {
                if ( frmHO_Main._userLogin.UserName.Equals( lbCreatedBy.Text ) 
                            || frmHO_Main._userLogin.UserName.Equals(frmHO_Main._sysadmin) )
                {
                    _dalMessage = new cl_DAL_SystemMessage();
                    if ( _dalMessage.UpdateMessage( int.Parse( lbMessageID.Text )
                                                    , txtTitle.Text
                                                    , txtBody.Text
                                                    , frmHO_Main._userLogin.UserName
                                                    , (int) trackBarControl.EditValue ) )
                    {
                        frmMessageBox.Show( "Thông báo" , "Chỉnh sửa thông báo thành công." , "done" );
                    }
                    else
                    {
                        frmMessageBox.Show( "Thông báo" , "Chỉnh sửa thông báo thất bại." , "error" );
                    }
                }
                else
                {
                    frmMessageBox.Show( "Thông báo" , "Thông báo này của nhân viên khác."
                                        + Environment.NewLine
                                        + "Bạn không được chỉnh sửa thông báo này." , "error" );
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo lỗi" , _validate , "error" );
            }

            this.ClearData();
        }

        private void btPushMessage_Click( object sender , EventArgs e )
        {
            try
            {
                _Message.frmMessage_Push frmPush = new frmMessage_Push( gridView1.GetFocusedRowCellValue( "MessageID" ).ToString() );
                frmPush.ShowDialog();
            }
            catch ( NullReferenceException ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Vui lòng chọn Thông báo." , "error" );
            }
        }

        private void btMakeNew_Click( object sender , EventArgs e )
        {
            this.ClearData();
        }
        
        private void gridView1_RowStyle( object sender , DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e )
        {
            GridView View = sender as GridView;
            if ( e.RowHandle >= 0 )
            {
                if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals("0" ))
                {
                    e.Appearance.ForeColor = Color.Black;
                }
                else if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals( "1" ) )
                {
                    e.Appearance.ForeColor = Color.Blue;
                }
                else if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals( "2" ) )
                {
                    e.Appearance.ForeColor = Color.Orange;
                }
                else if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals( "3" ) )
                {
                    e.Appearance.ForeColor = Color.Brown;
                }
                else if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals( "4" ) )
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                if ( (bool) gridView1.GetFocusedRowCellValue( "Active" ) == false )
                {
                    btPushMessage.Enabled = false;
                }
                else
                {
                    btPushMessage.Enabled = true;
                }
            }
            catch ( NullReferenceException ex )
            {

            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void btViewAll_Click( object sender , EventArgs e )
        {
            this.ClearData();
        }
        #region Action
        private void FillDataToGridMessage()
        {
            try
            {
                _dalMessage = new cl_DAL_SystemMessage();
                gridControl1.DataSource = _dalMessage.GetAllMessage();
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void FillDataToGridMessage(string _fromDate, string _toDate)
        {
            try
            {
                _dalMessage = new cl_DAL_SystemMessage();
                gridControl1.DataSource = _dalMessage.GetMessageByDate( _fromDate , _toDate );
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private string iValidateCreate()
        {
            string _rs = "";

            if ( txtTitle.Text.Trim().Equals( "" ) )
            {
                _rs += " * Tiêu đề không được trống." + Environment.NewLine;
            }

            if ( txtBody.Text.Trim().Equals( "" ) )
            {
                _rs += " * Nội dung không được trống." + Environment.NewLine;
            }

            return _rs;
        }

        private string iValidateEdit()
        {
            string _rs = "";

            if ( lbMessageID.Text.Trim().Equals( "" ) )
            {
                _rs += " * Bạn chưa chọn thông báo để chỉnh sửa." + Environment.NewLine;
            }

            if ( txtTitle.Text.Trim().Equals( "" ) )
            {
                _rs += " * Tiêu đề không được trống." + Environment.NewLine;
            }

            if ( txtBody.Text.Trim().Equals( "" ) )
            {
                _rs += " * Nội dung không được trống." + Environment.NewLine;
            }

            return _rs;
        }

        private void ClearData()
        {
            txtTitle.Text = "";
            txtBody.Text = "";
            lbMessageID.Text = "";
            lbCreatedDate.Text = "";
            lbCreatedBy.Text = "";
            lbModifiedBy.Text = "";
            lbModifiedDate.Text = "";
            trackBarControl.Value = 0;
            txtTitle.Focus();
            this.FillDataToGridMessage();
            btSave.Enabled = false;
        }

        private void ClearDataWithOutFillData()
        {
            txtTitle.Text = "";
            txtBody.Text = "";
            lbMessageID.Text = "";
            lbCreatedDate.Text = "";
            lbCreatedBy.Text = "";
            lbModifiedBy.Text = "";
            lbModifiedDate.Text = "";
            trackBarControl.Value = 0;
            txtTitle.Focus();
            btSave.Enabled = false;
        }
        #endregion
    }
}