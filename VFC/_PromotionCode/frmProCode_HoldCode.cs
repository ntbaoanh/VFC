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
    public partial class frmProCode_HoldCode : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_Store _dalStore;
        DAL.Utilities.Transaction rd;
        cl_DAL_PromotionCode _dalProcode;

        public frmProCode_HoldCode()
        {
            InitializeComponent();
        }

        private void frmProCode_HoldCode_Load( object sender , EventArgs e )
        {
            this.FillDataToStoreList();
        }

        private void btHoldCode_Click( object sender , EventArgs e )
        {
            string _userLogin = frmHO_Main._userLogin.UserName;
            string _computerName = System.Environment.MachineName.ToString();
            string _error = this.iValidate_HoldCode();

            if ( !_error.Equals( "" ) )
            {
                XtraMessageBox.Show( _error , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
            else
            {
                try
                {
                    _dalProcode = new cl_DAL_PromotionCode();
                    int _invcNo = -1;
                    if ( rdKhongCoNet.Checked == true )
                    {
                        try
                        {
                            _invcNo = int.Parse( txtHoldCode_InvcNo.Text.Trim() );
                        }
                        catch ( Exception ex )
                        {
                            _invcNo = -1;
                        }
                    }
                    if ( _dalProcode.HoldPromotionCode( txtCode.Text.Trim()
                                                , cbbHoldCode_Stores.EditValue.ToString()
                                                , int.Parse( txtHoldCode_Amount.Text.Trim() )
                                                , txtHoldCode_CMND.Text
                                                , txtHoldCode_Phone1.Text
                                                , txtHoldCode_FName.Text
                                                , _userLogin
                                                , _computerName
                                                , _invcNo ) )
                    {
                        XtraMessageBox.Show( "Treo code [ " + txtCode.Text.Trim() + " ] thành công." , "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Information );
                        rd = new DAL.Utilities.Transaction();
                        rd.record( "Hold code [ " + txtCode.Text.Trim() + " ]" , "7" , _userLogin , _computerName );
                    }
                    else
                    {
                        XtraMessageBox.Show( "Treo code không thành công. Vui lòng thử lại." , "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
                catch ( Exception ex )
                {
                    XtraMessageBox.Show( ex.ToString() , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
            }
        }

        private void btCheck_Click( object sender , EventArgs e )
        {
            this.CheckStatus( txtCode.Text.Trim() );
        }

        private void txtCode_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.CheckStatus( txtCode.Text.Trim() );
            }
        }

        #region Action
        private string iValidate_HoldCode()
        {
            string _rs = "";

            if ( txtCode.Text.Trim() == "" )
            {
                _rs += " * Vui lòng nhập mã Code" + Environment.NewLine;
            }

            if ( cbbHoldCode_Stores.EditValue == null )
            {
                _rs += " * Vui lòng chọn cửa hàng." + Environment.NewLine;
            }

            try
            {
                if ( Int64.Parse( txtHoldCode_Amount.Text.Trim() ) <= 0 )
                {
                    _rs += " * Giá trị hóa đơn phải lớn hơn 0." + Environment.NewLine;
                }
            }
            catch ( Exception ex )
            {
                _rs += " * Giá trị hóa đơn phải là số tự nhiên." + Environment.NewLine;
            }

            if ( rdKhongCoNet.Checked == true )
            {
                try
                {
                    if ( Int64.Parse( txtHoldCode_InvcNo.Text.Trim() ) <= 0 )
                    {
                        _rs += " * Số hóa đơn không đúng." + Environment.NewLine;
                    }
                }
                catch ( Exception ex )
                {
                    _rs += " * Số hóa đơn không đúng." + Environment.NewLine;
                }
            }

            if ( txtHoldCode_CMND.Text.Trim().Equals( "" ) )
            {
                _rs += " * Vui lòng nhập số CMND." + Environment.NewLine;
            }

            if ( txtHoldCode_FName.Text.Trim().Equals( "" ) )
            {
                _rs += " * Vui lòng nhập Tên khách hàng." + Environment.NewLine;
            }

            if ( txtHoldCode_Phone1.Text.Trim().Equals( "" ) )
            {
                _rs += " * Vui lòng nhập số số điện thoại." + Environment.NewLine;
            }
            return _rs;
        }

        private void FillDataToStoreList()
        {
            _dalStore = new cl_DAL_Store();
            cbbHoldCode_Stores.Properties.DataSource = _dalStore.returnORA_AllStoreCode();
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
                    btHoldCode.Enabled = true;
                }
                else if ( _status.Equals( 2 ) )
                {
                    lbResult.Text = "Mã code đã được sử dụng !";
                    lbResult.ForeColor = Color.Orange;
                    btHoldCode.Enabled = false;
                }
                else if ( _status.Equals( 3 ) )
                {
                    lbResult.Text = "Mã code đã bị treo !";
                    lbResult.ForeColor = Color.Violet;
                    btHoldCode.Enabled = false;
                }
                else if ( _status.Equals( 4 ) )
                {
                    lbResult.Text = "Mã code đã hết hạn !";
                    lbResult.ForeColor = Color.Purple;
                    btHoldCode.Enabled = false;
                }
                else
                {
                    lbResult.Text = "Mã code không hợp lệ !";
                    lbResult.ForeColor = Color.Red;
                    btHoldCode.Enabled = false;
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