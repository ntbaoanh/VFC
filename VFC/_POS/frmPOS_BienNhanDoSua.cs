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

namespace VFC._POS
{
    public partial class frmPOS_BienNhanDoSua : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_Invoice _dalInvc;
        cl_PRO_Customer _proCust;
        cl_DAL_Customer _dalCust;

        public frmPOS_BienNhanDoSua()
        {
            InitializeComponent();
        }

        #region Action
        private void FillDataToDateControl()
        {
            dateNgayNhan.EditValue = DateTime.Now;

            int day = (int)DateTime.Now.DayOfWeek;

            if ( day == 0 )//Sunday
            {
                dateNgayGiao.EditValue = DateTime.Now.AddDays(4);
            }
            else if ( day == 5 )//Friday
            {
                dateNgayGiao.EditValue = DateTime.Now.AddDays( 6 );
            }
            else if ( day == 6 )//Saturday
            {
                dateNgayGiao.EditValue = DateTime.Now.AddDays( 5 );
            }
            else if ( day == 4 )//Thursday
            {
                dateNgayGiao.EditValue = DateTime.Now.AddDays( 1 );
            }
            else
            {
                dateNgayGiao.EditValue = DateTime.Now.AddDays( 2 );
            }
        }

        private void SetDayToLabelDayOfWeek(DateEdit date, LabelControl lb)
        {
            int day = (int)((DateTime)date.EditValue).DayOfWeek;
            if ( day == 0 )
            {
                lb.Text = "Chủ nhật";
                lb.ForeColor = Color.Red;
            }
            else if ( day == 6 )
            {
                lb.Text = "Thứ Bảy";
                lb.ForeColor = Color.Red;
            }
            else if ( day == 5 )
            {
                lb.Text = "Thứ Sáu";
                lb.ForeColor = Color.Red;
            }
            else if ( day == 4 )
            {
                lb.Text = "Thứ Năm";
                lb.ForeColor = Color.Blue;
            }
            else if ( day == 3 )
            {
                lb.Text = "Thứ Tư";
                lb.ForeColor = Color.Blue;
            }
            else if ( day == 2 )
            {
                lb.Text = "Thứ Ba";
                lb.ForeColor = Color.Blue;
            }
            else if ( day == 1 )
            {
                lb.Text = "Thứ Hai";
                lb.ForeColor = Color.Blue;
            }
        }

        private void FillDataToListInvoice()
        {
            _dalInvc = new cl_DAL_Invoice();
            //listInvoice.Properties.DataSource = _dalInvc.GET_DoanhThu_TheoNgay(DateTime.Now.ToShortDateString()
            //                                , DateTime.Now.ToShortDateString()
            //                                , lbStoreNo.Text
            //                                , frmMain._myAppConfig.OraLocalIP
            //                                , frmMain._myAppConfig.SbsNo);
        }

        private void ClearData()
        {
            txtCustAddress.Text = "";
            txtCustName.Text = "";
            txtCustPhone.Text = "";
            lbUPC.Text = "";
            gridControl1.DataSource = null;
            listInvoice.Properties.DataSource = null;
            lbCustSid.Text = "";
            lbSoHoaDon.Text = "";
            dateNgayNhan.EditValue = DateTime.Now;
        }
        #endregion

        private void frmPOS_BienNhanDoSua_Load( object sender , EventArgs e )
        {
            //lbStoreCode.Text = frmMain._myAppConfig.StoreCode;
            //lbStoreNo.Text = frmMain._myAppConfig.StoreNo;
            lbStoreCode.Text = "NT8";
            lbStoreNo.Text = "238";
            this.FillDataToDateControl();
        }

        private void dateNgayNhan_EditValueChanged( object sender , EventArgs e )
        {
            this.SetDayToLabelDayOfWeek( dateNgayNhan , lbDateNgayNhan );
        }

        private void dateNgayGiao_EditValueChanged( object sender , EventArgs e )
        {
            this.SetDayToLabelDayOfWeek( dateNgayGiao , lbDateNgayGiao );
        }

        private void btGetInvoice_Click( object sender , EventArgs e )
        {
            this.FillDataToListInvoice();
        }

        private void btPrintUpdate_Click( object sender , EventArgs e )
        {

        }

        private void btNew_Click( object sender , EventArgs e )
        {
            this.ClearData();
        }

        private void listInvoice_EditValueChanged( object sender , EventArgs e )
        {
            lbCustSid.Text = listInvoice.EditValue.ToString();
            lbSoHoaDon.Text = listInvoice.Text;
        }

        private void lbCustSid_TextChanged( object sender , EventArgs e )
        {
            txtCustAddress.Enabled = false;
            txtCustName.Enabled = false;
            txtCustPhone.Enabled = false;

            if ( lbCustSid.Text.Equals( "lbCustSid" ) || lbCustSid.Text.Equals( "" ) )
            {
                txtCustAddress.Enabled = true;
                txtCustName.Enabled = true;
                txtCustPhone.Enabled = true;

                txtCustAddress.Text = "";
                txtCustName.Text = "";
                txtCustPhone.Text = "";
            }
            else
            {
                try
                {
                    _proCust = new cl_PRO_Customer();
                    _dalCust = new cl_DAL_Customer();

                    _proCust = _dalCust.getCustomerInfoByCustSid_RPro9( lbCustSid.Text , frmMain._myAppConfig.OraLocalIP );

                    txtCustAddress.Text = _proCust.DiaChi1 + " " + _proCust.DiaChi2 + " " + _proCust.ThanhPho;
                    txtCustName.Text = _proCust.Ho + " " + _proCust.Ten;
                    txtCustPhone.Text = _proCust.Phone1;
                }
                catch ( Exception ex )
                {
                    frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "Error" );
                }
            }
        }
    }
}