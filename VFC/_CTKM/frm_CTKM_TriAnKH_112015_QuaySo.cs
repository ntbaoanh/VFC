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
    public partial class frm_CTKM_TriAnKH_112015_QuaySo : DevExpress.XtraEditors.XtraForm
    {
        int clickCount;
        int billCount;
        cl_PRO_Invoice proInvoice;
        cl_PRO_Customer proCust;

        cl_DAL_CTKM_TriAnKH_112015 _myCTKM;

        string[] listQuaTang;
        string[] listGiaTriQuaTang;

        public frm_CTKM_TriAnKH_112015_QuaySo()
        {
            InitializeComponent();
        }

        public frm_CTKM_TriAnKH_112015_QuaySo(cl_PRO_Invoice _proInvoice, cl_PRO_Customer _proCust)
        {
            InitializeComponent();
            proInvoice = _proInvoice;
            proCust = _proCust;
        }

        #region Action
        private void UpdateLabelLanQuay()
        {
            lbSoLanDuocQuay.Text = _myCTKM.CTKM_TriAnKH_112015_Get_SoLanQuay(proInvoice.StoreNo, proInvoice.Invc_No);
            lbSoLanDaQuay.Text = _myCTKM.CTKM_TriAnKH_112015_Get_SoLanDaQuay(proInvoice.StoreNo, proInvoice.Invc_No);
            lbStop.Visible = false;

            if (Int16.Parse(lbSoLanDuocQuay.Text) == Int16.Parse(lbSoLanDaQuay.Text))
            {
                this.Dispose();
            }
        }
        #endregion

        private void frm_CTKM_TriAnKH_112015_QuaySo_Load(object sender, EventArgs e)
        {
            _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();

            clickCount = -1;

            labelControl1.Text = billCount.ToString();

            _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();
            listQuaTang = _myCTKM.CTKM_TriAnKH_112015_Get_LoaiQT();

            lbInvcNo.Text = proInvoice.Invc_No;
            lbInvcAmount.Text = string.Format("{0:#,#}", Convert.ToInt64(proInvoice.Amount)) + " vnđ";
            lbTenKH.Text = proCust.Ho + " " + proCust.Ten;
            lbPhone.Text = proCust.Phone1;
            this.UpdateLabelLanQuay();

            lbLoaiQT.Text = "";
            lbLoaiGT.Text = "";
            lbStop.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            Random r = new Random();
            if (frmMain._myAppConfig.StoreCode.Equals("NT8")
                    || frmMain._myAppConfig.StoreCode.Equals("BTC")
                    || frmMain._myAppConfig.StoreCode.Equals("NT6")
                    || frmMain._myAppConfig.StoreCode.Equals("NT9")
                    || frmMain._myAppConfig.StoreCode.Equals("HBT")
                    || frmMain._myAppConfig.StoreCode.Equals("HG1")
                    || frmMain._myAppConfig.StoreCode.Equals("QT2")
                    || frmMain._myAppConfig.StoreCode.Equals("C83"))
            {
                lbLoaiQT.Text = listQuaTang[r.Next(0, listQuaTang.Length)];
            }
            else
            {
                lbLoaiQT.Text = listQuaTang[r.Next(0, listQuaTang.Length - 1)];
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            lbLoaiGT.Text = listGiaTriQuaTang[r.Next(0, listGiaTriQuaTang.Length)];
        }

        private void lbStart_Click(object sender, EventArgs e)
        {
            clickCount = -1;
            timer1.Enabled = true;
            timer1.Start();
            labelControl1.Text = billCount.ToString();
            lbLoaiGT.Text = "";
            lbStop.Visible = true;
        }

        private void lbStop_Click(object sender, EventArgs e)
        {
            _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();
            
            billCount = _myCTKM.CTKM_TriAnKH_112015_Count_SoLanQuay(frmMain._myAppConfig.StoreNo) + 1;            

            if (clickCount == -1)
            {
                timer1.Stop();
                clickCount++;
                
                lbLoaiQT.Text = listQuaTang[_myCTKM.CTKM_TriAnKH_112015_Quay_Get_LoaiQT(proInvoice.StoreNo, billCount.ToString()) - 1];
                listGiaTriQuaTang = _myCTKM.CTKM_TriAnKH_112015_Get_GiaTriQT(lbLoaiQT.Text);
                //billCount = _myCTKM.CTKM_TriAnKH_112015_Count_SoLanQuay(frmMain._myAppConfig.StoreNo);
                timer2.Enabled = true;
                timer2.Start();
                //billCount++;
            }
            else
            {
                try
                {
                    timer2.Stop();

                    lbLoaiGT.Text = listGiaTriQuaTang[_myCTKM.CTKM_TriAnKH_112015_Quay_Get_GiaTriQT(proInvoice.StoreNo, billCount.ToString()) - 1];

                    //Insert vào table Trúng thưởng
                    if (_myCTKM.CTKM_TriAnKH_112015_DSTrungThuong_Insert(proInvoice.StoreNo
                                                    , proInvoice.Invc_sid
                                                    , proInvoice.Cust_sid
                                                    , lbLoaiQT.Text
                                                    , lbLoaiGT.Text
                                                    , System.Environment.MachineName.ToString()))
                    {
                        frmMessageBox.Show("Chúc mừng quý khách","-- Chúc mừng quý khách "
                                    + Environment.NewLine
                                    + "-- Quý khách đã nhận được " + lbLoaiQT.Text + " " + lbLoaiGT.Text
                                    + Environment.NewLine
                                    + "-- Hệ thống sẽ gửi tin nhắn cho quý khách sau khi chương trình kết thúc", "done");

                        billCount = _myCTKM.CTKM_TriAnKH_112015_Count_SoLanQuay(frmMain._myAppConfig.StoreNo);
                        labelControl1.Text = billCount.ToString();
                        this.UpdateLabelLanQuay();
                    }

                    clickCount = -1;
                }
                catch (Exception ex)
                { 
                    
                }
            }
        }
    }
}