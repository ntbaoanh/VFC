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

namespace VFC._Sale
{
    public partial class frmSale_DoanhSo_NV : DevExpress.XtraEditors.XtraForm
    {
        DAL.Utilities.SQLCon _sqlCon;
        DAL.Utilities.ORACon _oraCon;
        cl_PRO_Invoice _proInvoice;
        cl_DAL_Invoice _dalInvoice;
        cl_DAL_Customer _dalCustomer;
        cl_PRO_Customer _proCustomer;
        cl_DAL_Sales_NVBH _dalNVBH;
        cl_PRO_Sales_NVBH _proNVBH;

        public frmSale_DoanhSo_NV()
        {
            InitializeComponent();
        }

        #region Action
        private void UpdateInvoiceList()
        {
            try
            {
                cl_DAL_Invoice _invoice = new cl_DAL_Invoice();

                string _date = string.Format("{0:dd/MM/yyyy}", DateTime.Now).ToString();

                invoiceList.Properties.DataSource = _invoice.NVBH_Get_Invoice_ByDate(_date,
                                                                                     _date,
                                                                                    frmMain._myAppConfig.StoreNo,
                                                                                    frmMain._myAppConfig.OraLocalIP,
                                                                                    frmMain._myAppConfig.SbsNo,
                                                                                    999);
            }
            catch (Exception ex)
            {
                frmMessageBox.Show("Thông báo lỗi", "Không thể lấy danh sách hóa đơn.", "error");
            }
        }

        private void LoadDSNhanVien()
        {
            try
            {
                _dalNVBH = new cl_DAL_Sales_NVBH();

                listNVBH.Properties.DataSource = _dalNVBH.GET_NVBH_By_Store_Working(frmMain._myAppConfig.StoreCode);
            }
            catch
            {
                frmMessageBox.Show("Thông báo lỗi", "Không thể lấy danh sách nhân viên.", "error");
            }
        }

        private bool CheckInvoiceInSQLServer(string _invcNo, string _storeNo)
        {
            bool _rsFlag = false;
            DataTable _dt = new DataTable();

            _sqlCon = new DAL.Utilities.SQLCon();

            string sql = "";
            _dt = _sqlCon.returnDataTable(sql);

            if (_dt.Rows.Count == 1)
            {

            }

            return _rsFlag;
        }
        #endregion

        private void frmSale_DoanhSo_NV_Load(object sender, EventArgs e)
        {
            this.UpdateInvoiceList();
            this.LoadDSNhanVien();
        }

        private void btRefreshInvoice_Click(object sender, EventArgs e)
        {
            this.UpdateInvoiceList();
        }

        private void invoiceList_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable _dt = new DataTable();

                _proInvoice = new cl_PRO_Invoice();
                _proCustomer = new cl_PRO_Customer();
                _dalInvoice = new cl_DAL_Invoice();
                _dalCustomer = new cl_DAL_Customer();
                string _date = string.Format("{0:dd/MM/yyyy}", DateTime.Now.ToShortDateString()).ToString();
                _proInvoice = _dalInvoice.getInvoiceByInvcNo(_date, invoiceList.EditValue.ToString(), frmMain._myAppConfig.StoreNo, frmMain._myAppConfig.OraLocalIP, frmMain._myAppConfig.SbsNo);

                Int64 _tempAmount = Convert.ToInt64(_proInvoice.Amount);
                Int64 _tempDiscount = Convert.ToInt64(_proInvoice.Discount);

                lbAmount.Text = String.Format("{0:#,#}", _tempAmount);
                lbCreatedDate.Text = _proInvoice.CreatedDate;
                lbDiscount.Text = String.Format("{0:#,#}", _tempDiscount);
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
                    _proCustomer = _dalCustomer.getCustomerInfoByCustSid_RPro9(lbCustSID.Text, frmMain._myAppConfig.OraLocalIP);
                    lbCusFName.Text = _proCustomer.Ho + " " + _proCustomer.Ten;
                    lbCusAddress.Text = _proCustomer.DiaChi1 + " " + _proCustomer.DiaChi2 + " " + _proCustomer.ThanhPho;
                    lbCusID.Text = _proCustomer.CustID;
                    lbCusCMND.Text = _proCustomer.Cmnd;
                    lbCusPhone.Text = _proCustomer.Phone1;
                }
                catch (Exception ex)
                {
                    lbCusFName.Text = null;
                    lbCusAddress.Text = null;
                    lbCusID.Text = null;
                    lbCusCMND.Text = null;
                    lbCusPhone.Text = null;
                }
            }
            catch (Exception ex)
            {
                //frmMessageBox.Show("Thông báo lỗi", ex.ToString(), "error");
            }
        }

        private void btInsertPromotionCodeInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                _dalNVBH = new cl_DAL_Sales_NVBH();

                if(!_dalNVBH.GET_NVBH_WorkingStatus(int.Parse(lbNVID.Text)))
                {
                    frmMessageBox.Show("Thông báo", "Nhân viên không có trong ca làm việc." + Environment.NewLine + "Vui lòng thử lại nhân viên khác hoặc Check In nhân viên.", "error");
                    this.ClearData();
                }
                else
                {
                
                        if (invoiceList.EditValue.ToString().Equals("Chọn Hóa Đơn"))
                        {
                            frmMessageBox.Show("Thông báo", "Vui lòng chọn hóa đơn !", "error");
                            invoiceList.Focus();
                        }
                        else
                        {
                            if (Int32.Parse(lbNVID.Text) <= 0)
                            {
                                frmMessageBox.Show("Thông báo", "Vui lòng chọn nhân viên !", "error");
                                listNVBH.Focus();
                            }
                            else
                            {
                                _dalNVBH = new cl_DAL_Sales_NVBH();
                                //Check Exists Invoice
                                if (!_dalNVBH.CHECK_Exists_InvcSid(_proInvoice.Invc_sid))
                                {
                                    //Insert NVBH_Invoice               
                                    if (_dalNVBH.INSERT_Invoice(_proInvoice))
                                    {
                                        this.LOCAL_Insert_NVBH_Invoice(lbInvcSid.Text, lbNVID.Text, lbCustSID.Text);
                                    }
                                    else
                                    {
                                        frmMessageBox.Show("Lỗi !", "Nhập hóa đơn thất bại. Vui lòng thử lại.", "error");
                                    }
                                }
                                else
                                {
                                    this.LOCAL_Insert_NVBH_Invoice(lbInvcSid.Text, lbNVID.Text, lbCustSID.Text);
                                }
                            }
                        }
                
                }
            }
            catch (NullReferenceException ex)
            {
                frmMessageBox.Show("Lỗi !", "Vui lòng chọn hóa đơn.", "error");
            }
            catch (FormatException ex)
            {
                frmMessageBox.Show("Lỗi !", "Vui lòng chọn nhân viên.", "error");
            }
        }

        private void LOCAL_Insert_NVBH_Invoice(string invcSid, string idnv, string custsid)
        {
            if (_dalNVBH.INSERT_NVBH_Invoice(invcSid, idnv))
            {
                //Insert Customer IF EXISTS
                try
                {
                    _dalCustomer = new cl_DAL_Customer();
                    if (!_dalCustomer.CHECK_Exists_Customer_By_CustSid(custsid))
                    {
                        _proCustomer = new cl_PRO_Customer();
                        _proCustomer = _dalCustomer.getCustomerInfoByCustSid_RPro9(custsid, frmMain._myAppConfig.OraLocalIP);
                        _dalCustomer.insertCustomer(_proCustomer);
                    }                              
                }
                catch (Exception ex)
                {
                    //frmMessageBox.Show("Thông báo lỗi", ex.ToString(), "error");
                }

                frmMessageBox.Show("Thông báo", "Nhập thông tin thành công.", "done");         
                this.ClearData();
            }
            else
            {
                frmMessageBox.Show("Lỗi !", "Nhập NVBH - Hóa đơn thất bại. Vui lòng thử lại.", "error");
            }
        }

        private void listNVBH_EditValueChanged(object sender, EventArgs e)
        {
            _proNVBH = new cl_PRO_Sales_NVBH();
            _dalNVBH = new cl_DAL_Sales_NVBH();

            try
            {
                _proNVBH = _dalNVBH.GET_NVBH_ByID(listNVBH.EditValue.ToString());

                lbNVID.Text = listNVBH.EditValue.ToString();
                lbNV_Ten.Text = _proNVBH.Ho + " " + _proNVBH.Ten;
                lbNV_Store.Text = _proNVBH.StoreCode;
            }
            catch (Exception ex)
            {
                lbNVID.Text = null;
                lbNV_Ten.Text = null;
                lbNV_Store.Text = null;
            }
        }

        private void ClearData()
        {
            lbAmount.Text = null;
            lbCreatedDate.Text = null;
            lbDiscount.Text = null;
            lbInvcNo.Text = null;
            lbQty.Text = null;
            lbStore.Text = null;
            lbCustSID.Text = null;
            lbInvcSid.Text = null;

            lbCusFName.Text = null;
            lbCusAddress.Text = null;
            lbCusID.Text = null;
            lbCusCMND.Text = null;
            lbCusPhone.Text = null;

            lbNV_Store.Text = null;
            lbNV_Ten.Text = null;

            this.LoadDSNhanVien();
            this.UpdateInvoiceList();

            listNVBH.EditValue = null;
            invoiceList.EditValue = null;
        }
    }
}