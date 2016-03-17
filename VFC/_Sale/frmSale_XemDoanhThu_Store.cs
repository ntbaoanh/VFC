using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRO;
using DAL;

namespace VFC._Sale
{
    public partial class frmSale_XemDoanhThu_Store : DevExpress.XtraEditors.XtraForm
    {
        string _result;
        cl_DAL_Invoice _dalInvoice;
        cl_DAL_Store _dalStore;
        DataTable _dt;

        public frmSale_XemDoanhThu_Store()
        {
            InitializeComponent();
        }

        private void dateFrom_EditValueChanged( object sender , EventArgs e )
        {
            try
            {
                lbFromDate.Text = this.getDayOfWeekDay( (DateTime) dateFrom.EditValue );

                if ( lbFromDate.Text.Equals( "Thứ Bảy" ) || lbFromDate.Text.Equals( "Chủ Nhật" ) )
                {
                    lbFromDate.ForeColor = Color.Red;
                }
                else
                {
                    lbFromDate.ForeColor = Color.Blue;
                }
            }
            catch ( Exception  )
            {

            }
        }

        private void dateTo_EditValueChanged( object sender , EventArgs e )
        {
            try
            {
                lbToDate.Text = this.getDayOfWeekDay( (DateTime) dateTo.EditValue );

                if ( lbToDate.Text.Equals( "Thứ Bảy" ) || lbToDate.Text.Equals( "Chủ Nhật" ) )
                {
                    lbToDate.ForeColor = Color.Red;
                }
                else
                {
                    lbToDate.ForeColor = Color.Blue;
                }
            }
            catch ( Exception  )
            {

            }
        }

        private void frmSale_XemDoanhThu_Store_Load( object sender , EventArgs e )
        {
            dateFrom.EditValue = DateTime.Now;
            dateTo.EditValue = DateTime.Now;

            if ( frmMain._myEnvironment.Equals( "HO" ) )
            {
                groupControl_NangCao.Visible = true;
                this.FillDataToStoreList();
            }
            else
            {
                groupControl_NangCao.Visible = false;
            }
        }

        private void cbbStores_EditValueChanged( object sender , EventArgs e )
        {
            lbStoreNo.Text = cbbStores.EditValue.ToString();
        }

        private void btFind1_Click( object sender , EventArgs e )
        {
            lbFlagWhere.Text = "Local";
            this.LookUp( lbFlagWhere.Text );
        }

        private void btFind2_Click( object sender , EventArgs e )
        {
            lbFlagWhere.Text = "Remote";
            this.LookUp( lbFlagWhere.Text );
        }

        #region Action
        private string getDayOfWeekDay( DateTime date )
        {
            string _result = "";
            int day = (int) date.DayOfWeek;

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

            return _result;
        }

        private bool iValidate( string _type )
        {
            bool flag = true;
            _result = "";
            try
            {
                if ( DateTime.Compare( (DateTime) dateFrom.EditValue , (DateTime) dateTo.EditValue ) > 0 )
                {
                    _result += " * [Đến ngày] trước [Từ ngày]" + Environment.NewLine;
                    flag = false;
                }
            }
            catch ( NullReferenceException  )
            {
                _result += " * Chọn [Từ ngày] / [Đến ngày] " + Environment.NewLine;
                flag = false;
            }

            try
            {
                if ( cbbStores.EditValue.ToString().Equals( "" ) )
                {
                    _result += " * Xin vui lòng chọn cửa hàng." + Environment.NewLine;
                    flag = false;
                }
            }
            catch ( Exception  )
            {
                if ( _type.Equals( "Local" ) )
                {

                }
                else
                {
                    _result += " * Xin vui lòng chọn cửa hàng." + Environment.NewLine;
                    flag = false;
                }
            }

            return flag;
        }

        private void LookUp( string _type )
        {
            splashScreenManager1.ShowWaitForm();

            try
            {
                string _fromDate = string.Format( "{0:dd/MM/yyyy}" , dateFrom.EditValue ).ToString();
                string _toDate = string.Format( "{0:dd/MM/yyyy}" , dateTo.EditValue ).ToString();
                string _storeCode = "";
                
                _dalInvoice = new cl_DAL_Invoice();

                if ( _type.Equals( "Local" ) )
                {
                    _storeCode = frmMain._myAppConfig.StoreCode;

                    gridControl1.DataSource = _dalInvoice.GET_DoanhThu_TheoNgay( _fromDate
                                                    , _toDate
                                                    , _storeCode
                                                    , frmMain._myAppConfig.OraLocalIP
                                                    , frmMain._myAppConfig.SbsNo );
                }
                else
                {
                    _storeCode = cbbStores.EditValue.ToString();

                    gridControl1.DataSource = _dalInvoice.GET_DoanhThu_TheoNgay( _fromDate
                                                    , _toDate
                                                    , _storeCode
                                                    , "PC-" + _storeCode
                                                    , frmMain._myAppConfig.SbsNo );
                }

                
             
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }

            splashScreenManager1.CloseWaitForm();
        }

        private void FillDataToStoreList()
        {
            _dt = new DataTable();
            _dalStore = new cl_DAL_Store();

            _dt = _dalStore.returnORA_AllStoreCode();

            cbbStores.Properties.DataSource = _dt;
        }
        #endregion
    }
}