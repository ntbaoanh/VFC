using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace VFC._Report
{
    public partial class rp_Rap_BienNhanDoSua : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_Rap_BienNhanDoSua()
        {
            InitializeComponent();
        }

        public void addSource( string _store , 
            string _soChungTu,
            string _qtyAo,
            string _qtyQuan,
            string _qtyVay,
            string _qtyDam,
            string _qtyKhac,
            string _createdDate,
            string _qtySum,
            string _condition,
            DataSet _ds)
        {
            lbStore.Text = _store;
            lbDatePrint.Text = DateTime.Now.ToString();
            lbDateCreate.Text = _createdDate;
            lbSoChungTu.Text = _soChungTu;
            lbQuan.Text = _qtyQuan + " sp";
            lbAo.Text = _qtyAo + " sp";
            lbVay.Text = _qtyVay + " sp";
            lbDam.Text = _qtyDam + " sp";
            lbKhac.Text = _qtyKhac + " sp";
            lbSum.Text = _qtySum + " sp";
            if ( _condition.Equals( "IN" ) )
            {
                lbLoaiBienNhan.Text = "PHIẾU NHẬN ĐỒ SỬA";
            }
            else
            {
                lbLoaiBienNhan.Text = "PHIẾU TRẢ ĐỒ SỬA";
            }

            DataTable _dt = _ds.Tables[0];

            this.xrTableCell4.DataBindings.AddRange( new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "UPC")} );

            this.xrTableCell6.DataBindings.AddRange( new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "UDF10")} );

            this.xrTableCell5.DataBindings.AddRange( new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "QTY")} );
        }
    }
}
