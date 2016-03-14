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

namespace VFC._CTKM
{
    public partial class frm_CTKM_TriAnKH_112015 : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_Invoice _dalInvoice;
        cl_PRO_Invoice _proInvoice;
        cl_PRO_Customer _proCustomer;
        cl_DAL_Customer _dalCustomer;
        cl_DAL_CTKM_TriAnKH_112015 _myCTKM;

        public frm_CTKM_TriAnKH_112015()
        {
            InitializeComponent();
        }

        #region Action
        private void LoadDataToControl()
        {
            _dalInvoice = new cl_DAL_Invoice();
            cl_DAL_CTKM_TriAnKH_112015 _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();
            cbbInvoiceList.Properties.DataSource = _dalInvoice.GET_Invoice_CTKM_TriAnKH_112015(_myCTKM.CTKM_TriAnKH_112015_GiaTriHoaDon_Min(int.Parse(frmMain._myAppConfig.StoreNo))
                                                                                , Int32.Parse(frmMain._myAppConfig.StoreNo)
                                                                                , Int32.Parse(frmMain._myAppConfig.SbsNo)
                                                                                , frmMain._myAppConfig.OraLocalIP
                                                                                , _myCTKM.CTKM_TriAnKH_112015_Get_RunDate(int.Parse(frmMain._myAppConfig.StoreNo)));

            _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();
            gridControl1.DataSource = _myCTKM.CTKM_TriAnKH_112015_DSKHTrungThuong(frmMain._myAppConfig.StoreNo);
        }

        private void ClearLabel()
        {
            lbCusFName.Text = null;
            txtAddress.Text = null;
            lbCusID.Text = null;
            lbCusCMND.Text = null;
            lbCusPhone.Text = null;
            lbAmount.Text = null;
            lbCreatedDate.Text = null;
            lbDiscount.Text = null; ;
            lbInvcNo.Text = null;
            lbQty.Text = null;
            lbStore.Text = null;
            lbCustSID.Text = null;
            lbInvcSid.Text = null;
        }
        #endregion  

        private void frm_CTKM_TriAnKH_112015_Load(object sender, EventArgs e)
        {
            this.LoadDataToControl();
            this.ClearLabel();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDataToControl();
        }

        private void cbbInvoiceList_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable _dt = new DataTable();
                _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();
                _proInvoice = new cl_PRO_Invoice();
                _dalInvoice = new cl_DAL_Invoice();
                _proInvoice = _dalInvoice.getInvoiceByInvcNo(_myCTKM.CTKM_TriAnKH_112015_Get_RunDate(int.Parse(frmMain._myAppConfig.StoreNo)), cbbInvoiceList.EditValue.ToString(), frmMain._myAppConfig.StoreNo, frmMain._myAppConfig.OraLocalIP, frmMain._myAppConfig.SbsNo);

                Int64 _tempAmount = Convert.ToInt64(_proInvoice.Amount);
                Int64 _tempDiscount = Convert.ToInt64(_proInvoice.Discount);

                lbAmount.Text = String.Format("{0:#,#}", _tempAmount);
                lbCreatedDate.Text = _proInvoice.CreatedDate;
                lbDiscount.Text = String.Format("{0:#,#}", _tempDiscount);
                lbInvcNo.Text = cbbInvoiceList.EditValue.ToString();
                lbQty.Text = _proInvoice.Qty;
                lbStore.Text = frmMain._myAppConfig.StoreCode;
                lbCustSID.Text = _proInvoice.Cust_sid;
                lbInvcSid.Text = _proInvoice.Invc_sid;

                try
                {
                    _proCustomer = new cl_PRO_Customer();
                    _dalCustomer = new cl_DAL_Customer();
                    _proCustomer = _dalCustomer.getCustomerInfoByCustSid_RPro9(lbCustSID.Text, frmMain._myAppConfig.OraLocalIP);
                    lbCusFName.Text = _proCustomer.Ho + " " + _proCustomer.Ten;
                    txtAddress.Text = _proCustomer.DiaChi1 + " " + _proCustomer.DiaChi2 + " " + _proCustomer.ThanhPho;
                    lbCusID.Text = _proCustomer.CustID;
                    lbCusCMND.Text = _proCustomer.Cmnd;
                    lbCusPhone.Text = _proCustomer.Phone1;
                }
                catch (Exception ex)
                {
                    frmMessageBox.Show("Thông báo", "Hóa đơn không có thông tin khách hàng.", "error");
                    this.ClearLabel();
                }
            }
            catch (Exception ex)
            {
                this.ClearLabel();
            }
        }

        private void btQuaySo_Click(object sender, EventArgs e)
        {
            if (lbInvcSid.Text.Equals(""))
            {
                frmMessageBox.Show("Thông báo", "Vui lòng chọn hóa đơn", "error");
            }
            else
            {
                DialogResult r = XtraMessageBox.Show(lbCusFName.Text + " có chắc chắn muốn quay may mắn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    bool flag = true;

                    try
                    {
                        cl_DAL_CTKM_TriAnKH_112015 _myCheck = new cl_DAL_CTKM_TriAnKH_112015();

                        if (_myCheck.CTKM_TriAnKH_112015_CheckInvoice(lbInvcSid.Text))
                        {
                            _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();
                            _myCTKM.CTKM_TriAnKH_112015_Invoice_Insert(_proInvoice);
                        }

                        if (_myCheck.CTKM_TriAnKH_112015_CheckICustomer(lbCustSID.Text))
                        {
                            _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();
                            _myCTKM.CTKM_TriAnKH_112015_Customer_Insert(_proCustomer);
                        }
                    }
                    catch (Exception ex)
                    {
                        flag = false;
                    }

                    if (flag)
                    {
                        frm_CTKM_TriAnKH_112015_QuaySo frmQuaySo = new frm_CTKM_TriAnKH_112015_QuaySo(_proInvoice, _proCustomer);
                        frmQuaySo.ShowDialog();
                        this.LoadDataToControl();
                        this.ClearLabel();
                    }
                    else
                    {
                        frmMessageBox.Show("Thông báo", "Có lỗi phát sinh. Vui lòng liên hệ quản trị viên", "error");
                    }
                }
                else
                {
                    frmMessageBox.Show("Thông báo", "Xin cám ơn quý khách. Hạn quý khách lần sau.", "done");
                }
            }
        }
    }
}