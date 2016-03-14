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

namespace VFC._Customer
{
    public partial class frmCust_CustomerInfo : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_Customer _dalCust;
        cl_PRO_Customer _proCust;
        cl_DAL_Invoice _dalInvc;
        DataTable _dt;
        string _customerSid;
        string _fromDate;
        string _toDate;

        public frmCust_CustomerInfo(string _custSid)
        {
            InitializeComponent();
            _customerSid = _custSid;
        }

        private void frmCust_CustomerInfo_Load( object sender , EventArgs e )
        {
            dateFrom.EditValue = new DateTime( 2015 , 4 , 17 );
            dateTo.EditValue = DateTime.Now;

            this.FillDataToLabel( _customerSid );
        }

        private void btFilter_Click( object sender , EventArgs e )
        {
            _fromDate = string.Format( "{0:dd/MM/yyyy}" , dateFrom.EditValue ).ToString();
            _toDate = string.Format( "{0:dd/MM/yyyy}" , dateTo.EditValue ).ToString();

            this.GetInvoiceList(_fromDate , _toDate);
        }

        private void frmCust_CustomerInfo_FormClosed( object sender , FormClosedEventArgs e )
        {
            this.Dispose();
        }

        private void gridView_Invoice_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                this.GetInvoiceDetailByInvoiceNoStoreNo( gridView_Invoice.GetFocusedRowCellValue( "INVC_NO" ).ToString()
                                                , gridView_Invoice.GetFocusedRowCellValue( "STORE_NO" ).ToString()
                                                , gridView_Invoice.GetFocusedRowCellValue( "CREATED_DATE" ).ToString().Substring(0,10) );
            }
            catch ( NullReferenceException ex )
            {

            }
        }

        #region Action
        private void FillDataToLabel( string _custSid )
        {
            _proCust = new cl_PRO_Customer();
            _dalCust = new cl_DAL_Customer();

            try
            {
                _proCust = _dalCust.getCustomerInfoByCustSid_RPro9( _custSid , frmMain._myAppConfig.Ora248IP );

                lbStoreCode.Text = _proCust.Store;
                lbCMND.Text = _proCust.Cmnd;
                lbDinhDanh.Text = _proCust.GioiTinh;
                lbNgaySinh.Text = _proCust.NgaySinh + "/" + _proCust.ThangSinh + "/" + _proCust.NamSinh;
                lbSdt.Text = _proCust.Phone1;
                lbTen.Text = _proCust.Ho + " " + _proCust.Ten;
                txtDiaChi.Text = _proCust.DiaChi1 + " " + _proCust.DiaChi2 + " " + _proCust.ThanhPho;

                this.Text = "Thông tin khách hàng " + lbTen.Text;
            }
            catch ( NullReferenceException ex )
            {

            }
            catch ( Exception ex )
            {

            }
        }

        private void GetInvoiceList( string _fromDate , string _toDate )
        {
            _dt = new DataTable();

            _dalInvc = new cl_DAL_Invoice();
            _dt = _dalInvc.getInvoiceByDateWithCustomer( _fromDate , _toDate , frmMain._myAppConfig.OraLocalIP , _customerSid , frmMain._myAppConfig.SbsNo);

            gridControl_Invoice.DataSource = _dt;
        }

        private void GetInvoiceDetailByInvoiceNoStoreNo( string _invcNo , string _storeNo , string _date )
        {
            _dt = new DataTable();

            _dalInvc = new cl_DAL_Invoice();
            _dt = _dalInvc.getInvoiceDetailByInvcNo( _date , _invcNo , _storeNo , frmMain._myAppConfig.Ora248IP );

            gridControl_InvcDetail.DataSource = _dt;
        }
        #endregion
    }
}