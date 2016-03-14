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

namespace VFC._Admin
{
    public partial class frmPOS_Welcome : DevExpress.XtraEditors.XtraForm
    {
        DataTable _dt;
        cl_DAL_SystemMessage _dalSystemMessage;
        cl_DAL_Voucher _dalVoucher;
        _Message.frmMessage_ShowMessageInfo frmMessageInfo;


        public frmPOS_Welcome()
        {
            InitializeComponent();
        }

        private void frmPOS_Welcome_Load( object sender , EventArgs e )
        {
            this.FillDataTo_DateString();
            lbStore.Text = frmMain._myAppConfig.StoreCode;

            this.FillDataTo_MessageBoard( lbStore.Text );
            this.FillDataTo_ASNBoard(frmMain._myAppConfig.StoreNo , frmMain._myAppConfig.OraLocalIP);

            timer5mins.Interval = 4 * 43 * 1000;
            timer5mins.Start();
        }
        
        private void timer5mins_Tick( object sender , EventArgs e )
        {
            this.FillDataTo_MessageBoard( lbStore.Text );
            this.FillDataTo_ASNBoard( frmMain._myAppConfig.StoreNo , frmMain._myAppConfig.OraLocalIP );

            //Check new message and pop up >_<"
            try
            {
                DataTable _dtTemp = new DataTable();
                _dtTemp = (DataTable) gridControl_SystemMessage.DataSource;

                for ( int i = 0 ; i < _dtTemp.Rows.Count ; i++ )
                {
                    if ( int.Parse( _dtTemp.Rows[i]["Important"].ToString() ) == 4 && (bool) _dtTemp.Rows[i]["StatusRead"] == false )
                    {
                        if ( frmMessageInfo == null || frmMessageInfo.IsDisposed )
                        {
                            frmMessageInfo = new _Message.frmMessage_ShowMessageInfo( _dtTemp.Rows[i]["No"].ToString() );
                            frmMessageInfo.ShowDialog();
                        }
                        else
                        {
                            frmMessageInfo.Activate();
                        }
                    }
                }
            }
            catch ( NullReferenceException ex )
            {
                lbCountMessage.Text = "Hiện tại chưa có thông báo mới.";
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void btViewMessage_Click( object sender , EventArgs e )
        {
            if ( !this.CheckReadMessage( int.Parse( gridView_SystemMessage.GetFocusedRowCellValue( "No" ).ToString() ) ) )
            {
                try
                {
                    _Message.frmMessage_ShowMessageInfo frmMessage = new _Message.frmMessage_ShowMessageInfo( gridView_SystemMessage.GetFocusedRowCellValue( "No" ).ToString() );
                    frmMessage.ShowDialog();
                }
                catch ( NullReferenceException ex )
                {
                    frmMessageBox.Show( "Thông báo lỗi" , "Bạn chưa chọn thông báo để xem" , "error" );
                }
                catch ( ObjectDisposedException ex )
                {

                }
                catch ( Exception ex )
                {
                    //frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Thông báo này đã được đọc."
                            + Environment.NewLine
                            + " - Muốn xem lại vui lòng xem vào phần danh sách thông báo"
                            , "error" );
                this.FillDataTo_MessageBoard( lbStore.Text );
            }
        }

        private void btRefresh_Click( object sender , EventArgs e )
        {
            this.FillDataTo_MessageBoard( lbStore.Text );
            this.FillDataTo_ASNBoard( frmMain._myAppConfig.StoreNo , frmMain._myAppConfig.OraLocalIP );
        }

        #region Action
        private void FillDataTo_MessageBoard( string _store )
        {
            gridControl_SystemMessage.DataSource = null;
            _dalSystemMessage = new cl_DAL_SystemMessage();
            int _countUnreadMessage = _dalSystemMessage.CountMessageUnread( _store );
            btViewMessage.Visible = false;

            if ( _countUnreadMessage == 0 )
            {
                lbCountMessage.Text = "Hiện tại chưa có thông báo mới.";
            }
            else if ( _countUnreadMessage == -1 )
            {
                lbCountMessage.Text = "Mất kết nối với máy chủ.";
            }
            else if ( _countUnreadMessage == -2 )
            {

            }
            else
            {
                lbCountMessage.Text = "Bạn có " + _countUnreadMessage + " thông báo chưa đọc.";
                _dalSystemMessage = new cl_DAL_SystemMessage();
                gridControl_SystemMessage.DataSource = _dalSystemMessage.GetAllMessageActive_StoreCode( _store );
                btViewMessage.Visible = true;
            }
        }

        private void FillDataTo_ASNBoard( string _store , string _LocalIP )
        {
            gridControl_ASN.DataSource = null;
            _dalVoucher = new cl_DAL_Voucher();
            int _countASN = _dalVoucher.CountASN( _store , _LocalIP );

            if ( _countASN == 0 )
            {
                lbCountASN.Text = "Hiện tại chưa có giấy báo gửi hàng nào.";
            }
            else
            {
                lbCountASN.Text = "Hiện tại cửa hàng có " + _countASN + " giấy báo gửi hàng.";
            }

            gridControl_ASN.DataSource = _dalVoucher.GetASNList( _store , _LocalIP );
        }

        private void FillDataTo_DateString(  )
        {
            string _result = "";
            int day = (int) DateTime.Now.DayOfWeek;

            if ( day == 0 )
            {
                _result = "Chủ Nhật";
            }
            else if ( day == 1 )
            {
                _result = "Thứ Hai";
            }
            else if ( day == 2 )
            {
                _result = "Thứ Ba";
            }
            else if ( day == 3 )
            {
                _result = "Thứ tư";
            }
            else if ( day == 4 )
            {
                _result = "Thứ Năm";
            }
            else if ( day == 5 )
            {
                _result = "Thứ Sáu";
            }
            else if ( day == 6 )
            {
                _result = "Thứ Bảy";
            }

            lbDateString.Text = "Hôm nay là " + _result + ". Ngày " + DateTime.Now.ToShortDateString();
        }

        private bool CheckReadMessage( int _no )
        {
            bool _rsFlag = false;

            _dalSystemMessage = new cl_DAL_SystemMessage();
            cl_PRO_SystemMessage _proMessage = new cl_PRO_SystemMessage();

            _proMessage = _dalSystemMessage.GetMessageInfoByPushMessageNo( _no );

            if ( _proMessage.PushReadStatus == true )
            {
                _rsFlag = true;
            }

            return _rsFlag;
        }
        #endregion

        
    }
}