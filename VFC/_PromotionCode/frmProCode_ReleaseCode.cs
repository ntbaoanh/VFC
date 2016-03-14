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

namespace VFC._PromotionCode
{
    public partial class frmProCode_ReleaseCode : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_Store _dalStore;
        cl_DAL_PromotionCode _dalProcode;
        DAL.Utilities.Transaction rd;

        public frmProCode_ReleaseCode()
        {
            InitializeComponent();
        }

        private void frmProCode_ReleaseCode_Load( object sender , EventArgs e )
        {

        }

        private void btCheck_Click( object sender , EventArgs e )
        {

        }

        private void txtCode_KeyDown( object sender , KeyEventArgs e )
        {

        }

        private void btReleaseCode_Click( object sender , EventArgs e )
        {
            string _error = this.iValidate_ReleaseCode();
            string _userLogin = frmHO_Main._userLogin.UserName;
            string _computerName =  System.Environment.MachineName.ToString();
            if ( !_error.Equals( "" ) )
            {
                XtraMessageBox.Show( _error , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
            else
            {
                try
                {
                    int _invcNo = 0;
                    _dalProcode = new cl_DAL_PromotionCode();
                    if ( txtReleaseCode_InvcNo.Text.Trim() == "" )
                    {
                        _invcNo = -1;
                    }
                    else
                    {
                        _invcNo = Int16.Parse(txtReleaseCode_InvcNo.Text.Trim());
                    }

                    if ( _dalProcode.ReleasePromotionCode( txtCode.Text.Trim()
                                                , cbbReleaseCode_Stores.EditValue.ToString()
                                                , Int32.Parse( txtReleaseCode_Amount.Text.Trim() )
                                                , txtReleaseCode_CMND.Text
                                                , txtReleaseCode_Phone1.Text
                                                , _userLogin
                                                , _computerName
                                                ,_invcNo ) )
                    {
                        XtraMessageBox.Show( "Thả treo code [ " + txtCode.Text.Trim() + " ] thành công." , "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Information );
                        rd = new DAL.Utilities.Transaction();
                        rd.record( "Release code [ " + txtCode.Text.Trim() + " ]" , "7" , _userLogin , _computerName );
                    }
                    else
                    {
                        XtraMessageBox.Show( "Thả treo code không thành công." + Environment.NewLine
                                            + "  -  Một số thông tin không chính xác." + Environment.NewLine
                                            + "  -  Vui lòng thừ lại.", "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
                catch ( Exception ex )
                {
                    XtraMessageBox.Show( ex.ToString() , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
            }  
        }

        #region Action
        private string iValidate_ReleaseCode()
        {
            string _rs = "";

            if ( txtCode.Text.Trim() == "" )
            {
                _rs += " * Vui lòng nhập mã Code" + Environment.NewLine;
            }

            if ( cbbReleaseCode_Stores.EditValue == null )
            {
                _rs += " * Vui lòng chọn cửa hàng." + Environment.NewLine;
            }

            try
            {
                if ( Int64.Parse( txtReleaseCode_Amount.Text.Trim() ) <= 0 )
                {
                    _rs += " * Giá trị hóa đơn phải lớn hơn 0." + Environment.NewLine;
                }
            }
            catch ( Exception ex )
            {
                _rs += " * Giá trị hóa đơn phải là số tự nhiên." + Environment.NewLine;
            }
            
            try
            {
                if ( txtReleaseCode_InvcNo.Text.Trim() == "")
                {
                    //_rs += " * Số hóa đơn không đúng." + Environment.NewLine;
                }
                else if ( Int64.Parse( txtReleaseCode_InvcNo.Text.Trim() ) == 0 )
                {
                    _rs += " * Số hóa đơn không đúng." + Environment.NewLine;
                }
                else if ( Int64.Parse( txtReleaseCode_InvcNo.Text.Trim() ) < -1 )
                {
                    _rs += " * Số hóa đơn không đúng." + Environment.NewLine;
                }
            }
            catch ( Exception ex )
            {
                _rs += " * Số hóa đơn không đúng." + Environment.NewLine;
            }

            if ( txtReleaseCode_CMND.Text.Trim().Equals( "" ) )
            {
                _rs += " * Vui lòng nhập số CMND." + Environment.NewLine;
            }

            if ( txtReleaseCode_Phone1.Text.Trim().Equals( "" ) )
            {
                _rs += " * Vui lòng nhập số số điện thoại." + Environment.NewLine;
            }
            return _rs;
        }

        private void CheckStatus( string _code )
        {
            try
            {
                _dalProcode = new cl_DAL_PromotionCode();
                int _status = _dalProcode.checkAvaiableProCode( _code );

                if ( _status.Equals( 1 ) )
                {
                    lbResult.Text = "Mã code hợp lệ !";
                    lbResult.ForeColor = Color.Blue;
                    btReleaseCode.Enabled = true;
                }
                else if ( _status.Equals( 2 ) )
                {
                    lbResult.Text = "Mã code đã được sử dụng !";
                    lbResult.ForeColor = Color.Orange;
                    btReleaseCode.Enabled = false;
                }
                else if ( _status.Equals( 3 ) )
                {
                    lbResult.Text = "Mã code đã bị treo !";
                    lbResult.ForeColor = Color.Violet;
                    btReleaseCode.Enabled = false;
                }
                else if ( _status.Equals( 4 ) )
                {
                    lbResult.Text = "Mã code đã hết hạn !";
                    lbResult.ForeColor = Color.Purple;
                    btReleaseCode.Enabled = false;
                }
                else
                {
                    lbResult.Text = "Mã code không hợp lệ !";
                    lbResult.ForeColor = Color.Red;
                    btReleaseCode.Enabled = false;
                }
            }               
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Không có thông tin khách hàng đính kèm." 
                    + Environment.NewLine
                    + "Vui lòng liên hệ Quản trị Viên. " , "error" );
            }
        }
        #endregion
    }
}