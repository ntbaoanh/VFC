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
    public partial class frmProCode_UseCode : DevExpress.XtraEditors.XtraForm
    {
        DAL.Utilities.SQLCon _sqlCon;
        cl_DAL_PromotionCode _dalProCode;
        cl_PRO_PromotionCode _proProCode;
        cl_PRO_Invoice _proInvoice;
        cl_DAL_Invoice _dalInvoice;
        cl_DAL_Customer _dalCustomer;
        cl_PRO_Customer _proCustomer;

        DataTable _dt;
        int _tempCheckExists;

        public frmProCode_UseCode()
        {
            InitializeComponent();
        }

        private void frmProCode_UseCode_Load( object sender , EventArgs e )
        {
            groupControl_ThongTinKHDinhKem.Visible = false;
            groupControl_Main.Visible = false;
            txtCode.Focus();

            if ( frmMain._myEnvironment.Equals( "HO" ) )
            {
                xtraTabPage_HO.PageVisible = true;
                xtraTabPage_POS.PageVisible = false;
                this.FillDataToStoreList();
                dateInvoice.EditValue = DateTime.Now;
                this.HO_ClearThongTin();
                txtCode.Properties.PasswordChar = '\0';
            }
            else
            {
                xtraTabPage_HO.PageVisible = false;
                xtraTabPage_POS.PageVisible = true;
                txtCode.Properties.PasswordChar = '*';
            }
        }

        private void btCheck_Click( object sender , EventArgs e )
        {
            this.CheckStatus();
        }

        private void btGetInvoiceInfo_Click( object sender , EventArgs e )
        {
            try
            {
                _proInvoice = new cl_PRO_Invoice();
                _dalInvoice = new cl_DAL_Invoice();
                cl_DAL_Customer _dalCust = new cl_DAL_Customer();
                cl_PRO_Customer _proCust = new cl_PRO_Customer();

                _proInvoice = _dalInvoice.getInvoiceInfoFromInvcSid( lbInvcSid.Text );

                lbInvoiceStoreCode.Text = _proInvoice.StoreCode;
                lbInvoiceNo.Text = _proInvoice.Invc_No;
                lbInvoiceAmount.Text = String.Format( "{0:#,#}" , Convert.ToInt64( _proInvoice.Amount ) );
                lbInvoiceDiscount.Text = String.Format( "{0:#,#}" , Convert.ToInt64( _proInvoice.Discount ) );
                lbInvoiceSumQty.Text = _proInvoice.Qty;
                lbInvoiceDateCreate.Text = _proInvoice.CreatedDate.ToString().Substring( 0 , 10 );
                lbInvoiceTimeCreate.Text = _proInvoice.Time;

                lbCustomerSid.Text = _proInvoice.Cust_sid;

                /*
                 *Lấy dữ liệu khách hàng từ hóa đơn đã có trên hệ thống. Nếu sẽ lấy data từ SQL Server
                 */
                _proCust = _dalCust.getCustomerInfoByCustSid_SQL( _proInvoice.Cust_sid );

                lbInvoiceCustName.Text = _proCust.Ho + " " + _proCust.Ten;
                lbInvoicePhone1.Text = _proCust.Phone1;

                groupControl_ThongTinHoaDon.Visible = true;
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void btRefreshInvoice_Click( object sender , EventArgs e )
        {
            this.UpdateInvoiceList();
        }

        private void invoiceList_EditValueChanged( object sender , EventArgs e )
        {
            try
            {
                DataTable _dt = new DataTable();

                _proInvoice = new cl_PRO_Invoice();
                _proCustomer = new cl_PRO_Customer();
                _dalInvoice = new cl_DAL_Invoice();
                _dalCustomer = new cl_DAL_Customer();
                string _date = string.Format( "{0:dd/MM/yyyy}" , DateTime.Now.ToShortDateString() ).ToString();
                _proInvoice = _dalInvoice.getInvoiceByInvcNo( _date , invoiceList.EditValue.ToString() , frmMain._myAppConfig.StoreNo , frmMain._myAppConfig.OraLocalIP , frmMain._myAppConfig.SbsNo);

                Int64 _tempAmount = Convert.ToInt64( _proInvoice.Amount );
                Int64 _tempDiscount = Convert.ToInt64( _proInvoice.Discount );

                lbAmount.Text = String.Format( "{0:#,#}" , _tempAmount );
                lbCreatedDate.Text = _proInvoice.CreatedDate;
                lbDiscount.Text = String.Format( "{0:#,#}" , _tempDiscount );
                lbInvcNo.Text = invoiceList.EditValue.ToString();
                lbQty.Text = _proInvoice.Qty;
                lbStore.Text = frmMain._myAppConfig.StoreCode;
                lbCustSID.Text = _proInvoice.Cust_sid;
                lbInvcSid.Text = _proInvoice.Invc_sid;

                try
                {
                    /*
                     *Lấy dữ iệu khách hàng từ invoice tại cửa hàng. Nên phải ưu tiên look up trên Oracle Local trước 
                     */
                    _proCustomer = _dalCustomer.getCustomerInfoByCustSid_RPro9( lbCustSID.Text , frmMain._myAppConfig.OraLocalIP );
                    lbCusFName.Text = _proCustomer.Ho + " " + _proCustomer.Ten;
                    lbCusAddress.Text = _proCustomer.DiaChi1 + " " + _proCustomer.DiaChi2 + " " + _proCustomer.ThanhPho;
                    lbCusID.Text = _proCustomer.CustID;
                    lbCusCMND.Text = _proCustomer.Cmnd;
                    lbCusPhone.Text = _proCustomer.Phone1;

                    _tempCheckExists = _dalCustomer.checkExistCustomerByCustSid( _proCustomer );

                    if ( _tempCheckExists == 1 )
                    {
                        lbCheckExitsCustomer.Text = "Exist and Match Phone!";
                    }
                    else if ( _tempCheckExists == 2 )
                    {
                        lbCheckExitsCustomer.Text = "Exist but Not Match Phone!";
                    }
                    else
                    {
                        lbCheckExitsCustomer.Text = "Not Exist !";
                    }
                }
                catch ( Exception ex )
                {
                    lbCusFName.Text = null;
                    lbCusAddress.Text = null;
                    lbCusID.Text = null;
                    lbCusCMND.Text = null;
                    lbCusPhone.Text = null;

                    frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void btInsertPromotionCodeInvoice_Click( object sender , EventArgs e )
        {
            if ( invoiceList.EditValue.ToString().Equals("Chọn Hóa Đơn") )
            {
                frmMessageBox.Show("Thông báo", "Vui lòng chọn hóa đơn !" , "error" );
                invoiceList.Focus();
            }
            else
            {
                if ( lbCustSID.Text.Equals( "" ) )
                {
                    frmMessageBox.Show( "Thông báo" , "Hóa đơn không có thông tin khách hàng. !" + Environment.NewLine + "Vui lòng chọn lại !" , "error" );
                }
                else
                {
                    _dalProCode = new cl_DAL_PromotionCode();
                    if ( _dalProCode.insertPromotionCode_Info_Invoice( _proInvoice , lbProCodeSid.Text , lbCustSID.Text ) )
                    {
                        if ( _tempCheckExists == 0 )
                        {
                            _proCustomer = new cl_PRO_Customer();
                            _proCustomer = _dalCustomer.getCustomerInfoByCustSid_RPro9( lbCustSID.Text , frmMain._myAppConfig.OraLocalIP );
                            try
                            {
                                if ( _dalCustomer.insertCustomer( _proCustomer ) )
                                {
                                    //XtraMessageBox.Show( "Insert customer success !" );
                                }
                                else
                                {
                                    //XtraMessageBox.Show( "Insert customer fail !" );
                                }
                            }
                            catch ( Exception ex )
                            {
                                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                            }
                        }

                        frmMessageBox.Show( "Thông báo" , "Đã cập nhật thông tin hóa đơn thành công. !" , "done" );

                        this.Dispose();
                    }
                    else
                    {
                        frmMessageBox.Show( "Thông báo" , "Cập nhật thông tin hóa đơn KHÔNG thành công. !" , "error" );
                    }
                }
            }
        }

        private void btHO_GetInvoice_Click( object sender , EventArgs e )
        {
            this.HO_UpdateInvoiceList();
        }

        private void btHO_InsertPromotionCodeInvoice_Click( object sender , EventArgs e )
        {
            if ( lbHO_InvcCustSid.Text.Equals( "" ) )
            {
                frmMessageBox.Show("Thông báo" , "Hóa đơn không có thông tin khách hàng. !" + Environment.NewLine + "Vui lòng chọn lại !" , "error" );
            }
            else
            {
                _proCustomer = new cl_PRO_Customer();
                _proCustomer = _dalCustomer.getCustomerInfoByCustSid_RPro9( lbHO_InvcCustSid.Text , "PC-" + cbbStores.EditValue.ToString() );
                _tempCheckExists = _dalCustomer.checkExistCustomerByCustSid( _proCustomer );
                
                _proProCode = new cl_PRO_PromotionCode();
                _dalProCode = new cl_DAL_PromotionCode();
                _dalCustomer = new cl_DAL_Customer();

                if ( _dalProCode.insertPromotionCode_Info_Invoice( _proInvoice , lbProCodeSid.Text , lbHO_InvcCustSid.Text ) )
                {
                    if ( _tempCheckExists == 0 )
                    {
                        try
                        {
                            if ( _dalCustomer.insertCustomer( _proCustomer ) )
                            {
                                //XtraMessageBox.Show( "Insert customer success !" );
                            }
                            else
                            {
                                //XtraMessageBox.Show( "Insert customer fail !" );
                            }
                        }
                        catch ( Exception ex )
                        {
                            frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                        }
                    }

                    frmMessageBox.Show("Thông báo" , "Đã cập nhật thông tin hóa đơn thành công. !" , "done" );
                    this.Dispose();
                }
                else
                {
                    frmMessageBox.Show("Thông báo" , "Cập nhật thông tin hóa đơn KHÔNG thành công. !" , "error" );
                }
            }
        }

        private void cbbInvoices_EditValueChanged( object sender , EventArgs e )
        {
            btHO_InsertPromotionCodeInvoice.Enabled = false;
            lbHO_InvcSid.Text = cbbInvoices.EditValue.ToString();

            try
            {
                _dt = new DataTable();
                _proInvoice = new cl_PRO_Invoice();
                _dalInvoice = new cl_DAL_Invoice();

                _proInvoice = _dalInvoice.getInvoiceInfoFromInvcSid_ORA( lbHO_InvcSid.Text , "PC-" + cbbStores.EditValue , frmMain._myAppConfig.SbsNo);

                lbHO_InvcCustSid.Text = _proInvoice.Cust_sid;
                lbHO_InvcStore.Text = _proInvoice.StoreCode;
                lbHO_InvcMoney.Text = _proInvoice.Amount;
                lbHO_InvcDiscount.Text = _proInvoice.Discount;
                lbHO_InvcQty.Text = _proInvoice.Qty;
                lbHO_InvcDate.Text = _proInvoice.CreatedDate.Substring( 0 , 10 );
                lbHO_InvcNo.Text = _proInvoice.Invc_No;

                if ( lbHO_InvcCustSid.Text == "" )
                {
                    XtraMessageBox.Show( "Hóa đơn không có thông tin khách hàng." + Environment.NewLine
                            + "Vui lòng add thông tin khách hàng vào hóa đơn." , "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
                else
                {
                    _proCustomer = new cl_PRO_Customer();
                    _dalCustomer = new cl_DAL_Customer();

                    _proCustomer = _dalCustomer.getCustomerInfoByCustSid_RPro9( lbHO_InvcCustSid.Text , "PC-" + cbbStores.EditValue );

                    lbHO_InvcCustAddress.Text = _proCustomer.DiaChi1 + " " + _proCustomer.DiaChi2 + " " + _proCustomer.ThanhPho;
                    lbHO_InvcCustCMND.Text = _proCustomer.Cmnd;
                    lbHO_InvcCustFName.Text = _proCustomer.Ho + " " + _proCustomer.Ten;
                    lbHO_InvcCustID.Text = _proCustomer.CustID;
                    lbHO_InvcCustPhone.Text = _proCustomer.Phone1;

                    btHO_InsertPromotionCodeInvoice.Enabled = true;
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void txtCode_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.CheckStatus();
            }
        }

        #region Action
        private void CheckStatus()
        {
            try
            {
                _dalProCode = new cl_DAL_PromotionCode();
                int _status = _dalProCode.checkAvaiableProCode( txtCode.Text.Trim() );

                if ( _status.Equals( 1 ) )
                {
                    lbResult.Text = "Mã code hợp lệ !";
                    lbResult.ForeColor = Color.Blue;
                    lbStatusResult.Text = "1";

                    this.UpdateProCodeInfo( txtCode.Text.Trim() , int.Parse( lbStatusResult.Text ) );
                }
                else if ( _status.Equals( 2 ) )
                {
                    lbResult.Text = "Mã code đã được sử dụng !";
                    lbResult.ForeColor = Color.Orange;
                    lbStatusResult.Text = "2";

                    this.UpdateProCodeInfo( txtCode.Text.Trim() , int.Parse( lbStatusResult.Text ) );
                    lbInvcSid.Text = _dalProCode.getInvcSidFromProCode( txtCode.Text.Trim() );
                }
                else if ( _status.Equals( 3 ) )
                {
                    lbResult.Text = "Mã code đã bị treo !";
                    lbResult.ForeColor = Color.Violet;
                    lbStatusResult.Text = "3";

                    this.UpdateProCodeInfo( txtCode.Text.Trim() , int.Parse( lbStatusResult.Text ) );
                }
                else if ( _status.Equals( 4 ) )
                {
                    lbResult.Text = "Mã code đã hết hạn !";
                    lbResult.ForeColor = Color.Purple;
                    lbStatusResult.Text = "4";

                    this.UpdateProCodeInfo( txtCode.Text.Trim() , int.Parse( lbStatusResult.Text ) );
                }
                else
                {
                    lbResult.Text = "Mã code không hợp lệ !";
                    lbResult.ForeColor = Color.Red;
                    lbStatusResult.Text = "0";
                }

                if ( frmMain._myEnvironment.Equals( "POS" ) )
                {
                    this.POS_UpdateForm();
                }
                else
                {
                    this.HO_UpdateForm();
                }
            }               
            catch ( Exception  )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Không có thông tin khách hàng đính kèm." 
                    + Environment.NewLine
                    + "Vui lòng liên hệ Quản trị Viên. " , "error" );

                lbStatusResult.Text = "0";
            }

            this.POS_ClearDataNhapThongTinHoaDon();
            this.POS_ClearThongTinCode();
        }

        private void HO_UpdateForm()
        {
            try
            {
                this.HO_ClearThongTin();
                groupControl_ThongTinKHDinhKem.Visible = false;
                groupControl_Main.Visible = false;
                groupControl_ThongTinHoaDon.Visible = false;

                btGetInvoiceInfo.Enabled = false;

                if ( lbStatusResult.Text.Equals( "0" ) )
                {
                    lbProCode_CusAddress.Text = null;
                    lbProCode_CusCMND.Text = null;
                    lbProCode_CusFName.Text = null;
                    lbProCode_CusID.Text = null;
                    lbProCode_CusPhone.Text = null;
                    lbProCode_CusBirthday.Text = null;
                }
                else if ( lbStatusResult.Text.Equals( "1" ) )
                {
                    //Hiện Group Chính + Thông Tin đính kèm
                    groupControl_Main.Visible = true;
                    groupControl_ThongTinKHDinhKem.Visible = true;

                    xtraTabPage_HO.PageVisible = true;

                    this.UpdateProCodeCustomer( txtCode.Text.Trim() );
                }
                else if ( lbStatusResult.Text.Equals( "2" ) )
                {
                    //Hiện Group Chính + Thông Tin đính kèm
                    groupControl_Main.Visible = true;
                    groupControl_ThongTinKHDinhKem.Visible = true;

                    btGetInvoiceInfo.Enabled = true;
                    xtraTabPage_HO.PageVisible = false;

                    this.UpdateProCodeCustomer( txtCode.Text.Trim() );
                }
                else if ( lbStatusResult.Text.Equals( "3" ) )
                {
                    //Hiện Group Chính + Thông Tin đính kèm
                    groupControl_Main.Visible = true;
                    groupControl_ThongTinKHDinhKem.Visible = true;

                    xtraTabPage_HO.PageVisible = false;

                    this.UpdateProCodeCustomer( txtCode.Text.Trim() );
                }
                else if ( lbStatusResult.Text.Equals( "4" ) )
                {
                    //Hiện Group Chính + Thông Tin đính kèm
                    groupControl_Main.Visible = true;
                    groupControl_ThongTinKHDinhKem.Visible = true;

                    xtraTabPage_HO.PageVisible = false;

                    this.UpdateProCodeCustomer( txtCode.Text.Trim() );
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void POS_UpdateForm()
        {
            try
            {
                btGetInvoiceInfo.Enabled = false;
                btRefreshInvoice.Enabled = false;
                btInsertPromotionCodeInvoice.Enabled = false;

                groupControl_ThongTinKHDinhKem.Visible = false;
                groupControl_Main.Visible = false;
                groupControl_ThongTinHoaDon.Visible = false;

                if ( lbStatusResult.Text.Equals( "0" ) )
                {
                    lbProCode_CusAddress.Text = null;
                    lbProCode_CusCMND.Text = null;
                    lbProCode_CusFName.Text = null;
                    lbProCode_CusID.Text = null;
                    lbProCode_CusPhone.Text = null;
                    lbProCode_CusBirthday.Text = null;
                }
                else if ( lbStatusResult.Text.Equals( "1" ) )
                {
                    //Hiện Group Chính + Thông Tin đính kèm
                    groupControl_Main.Visible = true;
                    groupControl_ThongTinKHDinhKem.Visible = true;
                    //Hiện page Thông Tin Chung
                    xtraTabPage_ThongTinChung.Select();
                    //Hiện Group Thông Tin Code + Enable Button
                    groupControl_ThongTinCode.Visible = true;
                    btRefreshInvoice.Enabled = true;
                    btInsertPromotionCodeInvoice.Enabled = true;
                    //Enable Tab POS
                    xtraTabPage_POS.PageEnabled = true;

                    this.UpdateInvoiceList();
                    this.UpdateProCodeCustomer( txtCode.Text.Trim() );
                }
                else if ( lbStatusResult.Text.Equals( "2" ) )
                {
                    //Hiện Group Chính + Thông Tin đính kèm
                    groupControl_Main.Visible = true;
                    groupControl_ThongTinKHDinhKem.Visible = true;
                    //Hiện page Thông Tin Chung
                    xtraTabPage_ThongTinChung.Select();
                    //Disable Tab UsedCode
                    xtraTabPage_POS.PageEnabled = false;
                    //Enable button GetInvoiceInfo
                    btGetInvoiceInfo.Enabled = true;

                    this.UpdateProCodeCustomer( txtCode.Text.Trim() );
                }
                else if ( lbStatusResult.Text.Equals( "3" ) )
                {
                    //Hiện Group Chính + Thông Tin đính kèm
                    groupControl_Main.Visible = true;
                    groupControl_ThongTinKHDinhKem.Visible = true;
                    //Hiện page Thông Tin Chung
                    xtraTabPage_ThongTinChung.Select();
                    //Disable Tab UsedCode
                    xtraTabPage_POS.PageEnabled = false;

                    groupControl_ThongTinHoaDon.Visible = false;

                    this.UpdateProCodeCustomer( txtCode.Text.Trim() );
                }
                else if ( lbStatusResult.Text.Equals( "4" ) )
                {
                    //Hiện Group Chính + Thông Tin đính kèm
                    groupControl_Main.Visible = true;
                    groupControl_ThongTinKHDinhKem.Visible = true;
                    //Hiện page Thông Tin Chung
                    xtraTabPage_ThongTinChung.Select();
                    //Disable Tab UsedCode
                    xtraTabPage_POS.PageEnabled = false;

                    groupControl_ThongTinHoaDon.Visible = false;

                    this.UpdateProCodeCustomer( txtCode.Text.Trim() );
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void UpdateProCodeInfo( string _code , int _codeStatus )
        {
            try
            {
                _dalProCode = new cl_DAL_PromotionCode();
                _proProCode = new cl_PRO_PromotionCode();
                _proProCode = _dalProCode.getProCodeInfo( _code , _codeStatus );

                lbProCode_UsedInStore.Text = _proProCode.StoreCode;
                lbProCode_UsedCount.Text = _proProCode.UsedCount.ToString();
                lbProCode_LoaiKM.Text = _proProCode.LoaiKM;
                lbProCode_AmountKM.Text = _proProCode.AmountKM.ToString();
                lbProCode_DateExpire.Text = _proProCode.DateExpire.ToString();
                lbProCodeSid.Text = _proProCode.ProCodeSid.ToString();
            }
            catch ( NullReferenceException  )
            {

            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void UpdateProCodeCustomer( string _code )
        {
            try
            {
                _sqlCon = new DAL.Utilities.SQLCon();
                DataTable _dt = new DataTable();
                string _sql = "SELECT * FROM v_CS_PromotionCode_Customer WHERE ProCode = '" + _code + "'";
                _dt = _sqlCon.returnDataTable( _sql );

                lbProCode_CusAddress.Text = _dt.Rows[0]["DiaChi1"].ToString() + " " + _dt.Rows[0]["DiaChi2"].ToString() + " " + _dt.Rows[0]["ThanhPho"].ToString();
                lbProCode_CusCMND.Text = _dt.Rows[0]["CMND"].ToString();
                lbProCode_CusFName.Text = _dt.Rows[0]["Ho"].ToString() + " " + _dt.Rows[0]["Ten"].ToString();
                lbProCode_CusID.Text = _dt.Rows[0]["CustomerID"].ToString();
                lbProCode_CusPhone.Text = _dt.Rows[0]["Phone1"].ToString();
                lbProCode_CusBirthday.Text = "Ngày " + _dt.Rows[0]["NgaySinh"].ToString() + " Tháng " + _dt.Rows[0]["ThangSinh"].ToString();
            }
            catch ( Exception  )
            {   
                lbProCode_CusAddress.Text = null;
                lbProCode_CusCMND.Text = null;
                lbProCode_CusFName.Text = null;
                lbProCode_CusID.Text = null;
                lbProCode_CusPhone.Text = null;
                lbProCode_CusBirthday.Text = null;

                frmMessageBox.Show("Thông báo lỗi" , "Mã code này không có thông tin khách hàng đính kèm." , "error" );
            }
        }

        private void UpdateInvoiceList()
        {
            try
            {
                cl_DAL_Invoice _invoice = new cl_DAL_Invoice();

                string _date = string.Format( "{0:dd/MM/yyyy}" , DateTime.Now ).ToString();
                
                invoiceList.Properties.DataSource = _invoice.Get_Invoice_ByDate( _date ,
                                                                                     _date ,
                                                                                    frmMain._myAppConfig.StoreCode,
                                                                                    frmMain._myAppConfig.OraLocalIP ,
                                                                                    frmMain._myAppConfig.SbsNo,
                                                                                    10);
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private bool CheckInvoiceInSQLServer( string _invcNo , string _storeNo )
        {
            bool _rsFlag = false;
            DataTable _dt = new DataTable();

            _sqlCon = new DAL.Utilities.SQLCon();

            string sql = "";
            _dt = _sqlCon.returnDataTable( sql );

            if ( _dt.Rows.Count == 1 )
            {

            }

            return _rsFlag;
        }

        private void POS_ClearDataNhapThongTinHoaDon()
        {
            lbStore.Text = null;
            lbInvcNo.Text = null;
            lbCreatedDate.Text = null;
            lbAmount.Text = null;
            lbQty.Text = null;
            lbDiscount.Text = null;

            lbCustSID.Text = null;
            lbCusID.Text = null;
            lbCusFName.Text = null;
            lbCusAddress.Text = null;
            lbCusCMND.Text = null;
            lbCusPhone.Text = null;
        }

        private void POS_ClearThongTinCode()
        {
            lbInvoiceNo.Text = null;
            lbInvoiceSumQty.Text = null;
            lbInvoiceAmount.Text = null;
            lbInvoiceCustName.Text = null;
            lbInvoiceDiscount.Text = null;
            lbInvoicePhone1.Text = null;
            lbInvoiceStoreCode.Text = null;
            lbInvoiceTimeCreate.Text = null;
            lbInvoiceDateCreate.Text = null;
        }

        private void HO_ClearThongTin()
        {
            lbHO_InvcCustAddress.Text = null;
            lbHO_InvcCustCMND.Text = null;
            lbHO_InvcCustFName.Text = null;
            lbHO_InvcCustID.Text = null;
            lbHO_InvcCustPhone.Text = null;
            lbHO_InvcCustSid.Text = null;
            lbHO_InvcDate.Text = null;
            lbHO_InvcDiscount.Text = null;
            lbHO_InvcMoney.Text = null;
            lbHO_InvcNo.Text = null;
            lbHO_InvcQty.Text = null;
            lbHO_InvcSid.Text = null;            
            lbHO_InvcStore.Text = null;
        }

        private void FillDataToStoreList()
        {
            try
            {
                cl_DAL_Store _dalStore = new cl_DAL_Store();
                cbbStores.Properties.DataSource = _dalStore.returnORA_AllStoreCode();
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private string iValidate_UseCode()
        {
            string _rs = "";

            if ( cbbStores.EditValue == null )
            {
                _rs += " * Vui lòng chọn cửa hàng." + Environment.NewLine;
            }

            if ( dateInvoice.EditValue.ToString() == null )
            {
                _rs += " * Vui lòng chọn ngày hóa đơn." + Environment.NewLine;
            }

            return _rs;
        }

        private void HO_UpdateInvoiceList()
        {
            string _ivalidate = this.iValidate_UseCode();
            if ( _ivalidate != "" )
            {
                frmMessageBox.Show( "Thông báo", _ivalidate , "error" );
            }
            else
            {
                try
                {
                    _dalInvoice = new cl_DAL_Invoice();
                    string _date = string.Format( "{0:dd/MM/yyyy}" , dateInvoice.EditValue.ToString() ).ToString();
                    cbbInvoices.Properties.DataSource = _dalInvoice.Get_Invoice_ByDate( _date ,
                                                                                        _date ,
                                                                                        cbbStores.EditValue.ToString() ,
                                                                                        "PC-" + cbbStores.EditValue.ToString() ,
                                                                                        frmMain._myAppConfig.SbsNo,
                                                                                        9999);
                }
                catch ( Exception ex )
                {
                    frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                }
            }
        }
        #endregion  
    }
}