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

namespace VFC._PromotionCode
{
    public partial class frmProCode_GetCode : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_PromotionCode dalProCode;

        int timer1_60sCountdown;

        public frmProCode_GetCode()
        {
            InitializeComponent();
        }

        private void btCreate_Click( object sender , EventArgs e )
        {
            if ( this.checkFirst().Equals( "" ) )
            {
                int _request = int.Parse( txtQty.Text.Trim() );
                int _available = int.Parse( lbTotalWaitingHide.Text );

                if ( _request > _available )
                {
                    frmMessageBox.Show( "Thông báo lỗi" 
                        , "Số lượng cần tạo vượt quá số lượng cho phép" 
                            + Environment.NewLine 
                            + "Vui lòng liên hệ IT để yêu cầu tạo thêm."
                        , "error" );
                }
                else
                {
                    try
                    {
                        dalProCode = new cl_DAL_PromotionCode();
                        if ( dalProCode.ActivePromotionCode( int.Parse( txtQty.Text.Trim() ) ,
                                                        dateExpire.EditValue.ToString().Substring( 0 , 10 ) ,
                                                        dateCreate.EditValue.ToString().Substring( 0 , 10 ) ,
                                                        frmHO_Main._userLogin.UserName ,
                                                        frmHO_Main._userLogin.UserName ,
                                                        int.Parse( listLoaiKM.EditValue.ToString() ) ,
                                                        int.Parse( txtAmountKM.Text.Trim() ) ,
                                                        txtNote.Text.Trim() ) )
                        {
                            frmMessageBox.Show( "Thông báo", "Tạo code thành công." , "done" );
                        }
                        else
                        {
                            frmMessageBox.Show( "Thông báo" , "Tạo code thành công." , "error" );
                        }

                        this.Dispose();
                    }
                    catch ( Exception ex )
                    {
                        frmMessageBox.Show( "Thông báo lỗi" , ex.ToString(), "error" );
                    }
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo lỗi" , this.checkFirst() , "error" );
            }
        }

        private void btCancel_Click( object sender , EventArgs e )
        {
            this.Dispose();
        }

        private void frmProCode_GetCode_Load( object sender , EventArgs e )
        {
            dateCreate.EditValue = DateTime.Now;

            timer1_60sCountdown = 60;
            timer1.Interval = 1 * 1 * 1000;
            timer1.Start();
            this.FillDataToListKM();
            this.fillDataToLabel();
        }

        private void timer1_Tick( object sender , EventArgs e )
        {
            timer1_60sCountdown--;

            if ( timer1_60sCountdown < 0 )
            {
                timer1_60sCountdown = 60;
                this.fillDataToLabel();
            }

            lbCountDown.Text = timer1_60sCountdown.ToString();
        }

        private void frmProCode_GetCode_FormClosed( object sender , FormClosedEventArgs e )
        {
            this.Dispose();
        }


        private void txtSlgNgayHetHan_EditValueChanged( object sender , EventArgs e )
        {
            try
            {
                dateExpire.EditValue = DateTime.Now.AddDays( int.Parse( txtSlgNgayHetHan.Text.Trim() ) );
            }
            catch ( Exception  )
            {
                frmMessageBox.Show("Thông báo lỗi" , "Số ngày phải nhỏ hơn 9999 ngày !" , "error" );
            }
        }

        #region Action
        private string checkFirst()
        {
            string _rsString = "";

            try
            {
                if ( Int64.Parse( txtQty.Text.Trim() ) < 0 )
                {
                    _rsString += " * Số lượng mã cần lấy phải lớn hơn 0 !" + Environment.NewLine;
                }
            }
            catch ( Exception  )
            {
                _rsString += " * Số lượng mã cần lấy phải là số tự nhiên !" + Environment.NewLine;
            }

            try
            {
                if ( Int64.Parse( txtSlgNgayHetHan.Text.Trim() ) < 0 )
                {
                    _rsString += " * Số lượng ngày hết hạn phải lớn hơn 0 !" + Environment.NewLine;
                }
            }
            catch ( Exception  )
            {
                _rsString += " * Số lượng ngày hết hạn phải là số tự nhiến !" + Environment.NewLine;
            }

            try
            {
                if ( listLoaiKM.EditValue.Equals( 2 ) )
                {
                    try
                    {
                        if ( Int64.Parse( txtAmountKM.Text.Trim() ) > 100 || Int64.Parse( txtAmountKM.Text.Trim() ) < 0 )
                        {
                            _rsString += " * Giảm giá % phải từ 0 đến 100 !" + Environment.NewLine;
                        }
                    }
                    catch ( Exception  )
                    {
                        _rsString += " * Nhập vào số % giảm giá !" + Environment.NewLine;
                    }
                }
                else if ( listLoaiKM.EditValue.Equals( 1 ) )
                {
                    try
                    {
                        if ( Int64.Parse( txtAmountKM.Text.Trim() ) < 0 )
                        {
                            _rsString += " * Số tiền khuyến mãi phải lớn hơn 0 !" + Environment.NewLine;
                        }
                    }
                    catch ( Exception ex )
                    {
                        if ( ex.ToString().Equals( "System.OverflowException: Value was either too large or too small for an Int64" ) )
                        {
                            _rsString += " * Số tiền giảm giá quá lớn !" + Environment.NewLine;
                        }
                        else
                        {
                            _rsString += " * Nhập vào số tiền giảm giá !" + Environment.NewLine;
                        }
                    }
                }
                else if ( listLoaiKM.EditValue == null )
                {
                    _rsString += " * Xin chọn loại khuyến mãi !" + Environment.NewLine;
                }
            }
            catch ( Exception  )
            {
                _rsString += " * Xin chọn loại khuyến mãi !" + Environment.NewLine;
            }

            return _rsString;
        }

        private string getCountFromStatus( int _statusID )
        {
            string _rs = "";
            DAL.Utilities.SQLCon _conn;
            DataTable _dt;
            try
            {
                _conn = new DAL.Utilities.SQLCon();
                _dt = new DataTable();
                string _sql = "SELECT COUNT(*) from tb_CS_PromotionCode_Info WHERE STATUS = " + _statusID;
                _dt = _conn.returnDataTable( _sql );

                if ( _dt.Rows.Count == 0 )
                {
                    _rs = "";
                }
                else
                {
                    _rs = _dt.Rows[0][0].ToString();
                }
            }
            catch ( Exception  )
            {
                _rs = "";
            }

            return _rs;
        }

        private void fillDataToLabel()
        {
            int _totalAvailable = Convert.ToInt32( this.getCountFromStatus( 1 ) );
            int _totalExpired = Convert.ToInt32( this.getCountFromStatus( 4 ) );
            int _totalUsed = Convert.ToInt32( this.getCountFromStatus( 2 ) );
            int _totalWaiting = Convert.ToInt32( this.getCountFromStatus( 0 ) );
            int _totalGet = _totalAvailable + _totalExpired + _totalUsed;

            lbTotalAvailable.Text = String.Format( "{0:#,#}" , _totalAvailable );
            lbTotalExpire.Text = String.Format( "{0:#,#}" , _totalExpired );
            lbTotalUsed.Text = String.Format( "{0:#,#}" , _totalUsed );
            lbTotalWaiting.Text = String.Format( "{0:#,#}" , _totalWaiting );
            lbTotalGet.Text = String.Format( "{0:#,#}" , _totalGet );
            lbTotalWaitingHide.Text = _totalWaiting.ToString();

            if ( _totalWaiting < 10000 )
            {
                lbInfo.Text = "Code dự trữ sắp hết. " + Environment.NewLine + "Vui lòng liên hệ IT để tạo thêm.";
            }
            else
            {
                lbInfo.Text = "";
            }
        }

        private void FillDataToListKM()
        {            
            dalProCode = new cl_DAL_PromotionCode();
            listLoaiKM.Properties.DataSource = dalProCode.GetListLoaiKM();
        }
        #endregion
    }
}