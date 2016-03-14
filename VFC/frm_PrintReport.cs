using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace VFC
{
    public partial class frm_PrintReport : DevExpress.XtraEditors.XtraForm
    {
        public frm_PrintReport()
        {
            InitializeComponent();
        }

        public void printBienNhanDoSua( string _store ,
                                    string _soChungTu ,
                                    string _qtyAo ,
                                    string _qtyQuan ,
                                    string _qtyVay ,
                                    string _qtyDam ,
                                    string _qtyKhac ,
                                    string _createdDate ,
                                    string _qtySum ,
                                    string _condition ,
                                    DataSet _ds ,
                                    DataTable _dt )
        {
            _Report.rp_Rap_BienNhanDoSua rp = new _Report.rp_Rap_BienNhanDoSua();
            rp.DataSource = _dt;
            rp.addSource( _store ,
                            _soChungTu ,
                            _qtyAo ,
                            _qtyQuan ,
                            _qtyVay ,
                            _qtyDam ,
                            _qtyKhac ,
                            _qtySum ,
                            _createdDate ,
                            _condition ,
                            _ds );
            //ReportPrintTool tool = new ReportPrintTool( rp );
            //tool.ShowPreview();
            rp.Print();
            rp.Print();
        }

        public void printCLKK( DataSet _ds , string _date , string _clkkNo )
        {
            _Report.rp_SoLieu_XuLyCLKK rp = new _Report.rp_SoLieu_XuLyCLKK();

            rp.addSource( _ds , _date , _clkkNo );

            ReportPrintTool tool = new ReportPrintTool( rp );
            tool.ShowPreview();
        }

        public void printBarCode( string p )
        {
            zTestBarCode rp = new zTestBarCode( p );
            ReportPrintTool tool = new ReportPrintTool( rp );
            tool.ShowPreview();
        }
    }
}