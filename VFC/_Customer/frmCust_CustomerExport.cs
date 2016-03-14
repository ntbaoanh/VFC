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
using System.Diagnostics;

namespace VFC._Customer
{
    public partial class frmCust_CustomerExport : DevExpress.XtraEditors.XtraForm
    {
        DAL.Utilities.ORACon _oraConn;

        public frmCust_CustomerExport()
        {
            InitializeComponent();
        }

        private void frmCust_CustomerExport_Load( object sender , EventArgs e )
        {
            fromDate.EditValue = new DateTime( 2015 , 04 , 17 );
            toDate.EditValue = DateTime.Now;
            cbbMonth.SelectedIndex = 0;
        }

        private void btRun_Click( object sender , EventArgs e )
        {
            splashScreenManager1.ShowWaitForm();
            Stopwatch sw = Stopwatch.StartNew();  
            try
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();

                _oraConn = new DAL.Utilities.ORACon();
                DataTable _dt = new DataTable();

                _dt = _oraConn.returnDataTable( this.buildSQL() , frmMain._myAppConfig.Ora248IP );

                gridControl1.DataSource = _dt;
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() );
            }
            sw.Stop();
            lbDuration.Text = sw.Elapsed.TotalSeconds + " s";
            splashScreenManager1.CloseWaitForm();
        }

        private void btExport_Click( object sender , EventArgs e )
        {
            saveFileDialog1.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            saveFileDialog1.ShowDialog();       
        }

        private void saveFileDialog1_FileOk( object sender , CancelEventArgs e )
        {
            string fileName = saveFileDialog1.FileName;
            try
            {
                gridView1.BestFitColumns();

                gridControl1.ExportToXlsx( fileName );
            }
            catch ( Exception ex )
            {

            }
        }

        #region Action
        private string buildSQL()
        {
            string _rs = "";


            if ( rdTopAmount.Checked == true || rdTopCountBill.Checked == true )
            {
                _rs += "select * from ( ";
            }

            _rs += "select ";
            _rs += " to_char(cus.cust_sid), ";
            _rs += " to_char(cus.cust_id), ";

            if ( checkStores.CheckState == CheckState.Checked )
            {
                _rs += " cus.home_store_code as CuaHangTao,";
            }

            if ( checkDinhDanh.CheckState == CheckState.Checked )
            {
                _rs += " cus.title as DinhDanh,";
            }

            if ( checkHoVaLot.CheckState == CheckState.Checked )
            {
                _rs += " cus.first_name as HoVaLot,";
            }

            if ( checkTen.CheckState == CheckState.Checked )
            {
                _rs += " cus.last_name as Ten,";
            }

            if ( checkDiaChi.CheckState == CheckState.Checked )
            {
                _rs += " cus.address1 DiaChi,";
            }

            if ( checkPhuongQuan.CheckState == CheckState.Checked )
            {
                _rs += " cus.address2 PhuongQuan,";
            }

            if ( checkThanhPho.CheckState == CheckState.Checked )
            {
                _rs += " cus.address3 ThanhPho,";
            }

            if ( checkPhone1.CheckState == CheckState.Checked )
            {
                _rs += " cus.Phone1, ";
            }

            if ( checkPhone2.CheckState == CheckState.Checked )
            {
                _rs += " cus.Phone2,";
            }

            if ( checkCMND.CheckState == CheckState.Checked )
            {
                _rs += " cus.Info1 as CMND,";
            }

            if ( checkCMNDTemp.CheckState == CheckState.Checked )
            {
                _rs += " cus.Info2 as CMNDTemp,";
            }

            if ( checkEmail.CheckState == CheckState.Checked )
            {
                _rs += " cus.email_addr as Email,";
            }

            if ( checkEmail.CheckState == CheckState.Checked )
            {
                _rs += " cus.udf_5 as NgaySinh,";
            }

            if ( checkThangSinh.CheckState == CheckState.Checked )
            {
                _rs += " cus.udf_6 as ThangSinh,";
            }

            if ( checkNamSinh.CheckState == CheckState.Checked )
            {
                _rs += " cus.udf_7 as NamSinh,";
            }

            _rs += " TO_CHAR(cus.created_date, 'dd/MM/yyyy') As NgayTaoKhachHang,";
            //_rs += " cus.modified_date,";
            _rs += " cou.invc_count AS Total_Bill,";
            _rs += " amou.total_money , cus.store_region AS Khu_Vuc , ct.lst_purch_date AS NgayMuaHangCuoiCung";
            _rs += " from v_HO_Count_Invc_Cust_170415 cou, " +
                   " v_HO_SumMoney_Invc_Cust_170415 amou, " +
                   " vfc_customer_v_S2 cus , customer_v ct" +
                   " where cou.cust_sid = cus.cust_sid " +
                   " and amou.cust_sid = cus.cust_sid " +
                   " and cus.active = 1 " +
                   " and cus.cust_sid = ct.cust_sid " +
                   " and cus.sbs_no in (2,3) ";

            if ( cbbMonth.SelectedIndex != 0 )
            {
                _rs += this.getThangSingString();
            }

            if ( rdCreatedDate.Checked == true )
            {
                if ( DateTime.Compare( (DateTime) fromDate.EditValue , (DateTime) toDate.EditValue ) > 0 )
                {
                    XtraMessageBox.Show( " [Đến ngày] trước [Từ ngày ]" , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
                else
                {
                    string _fromDate = string.Format( "{0:yyyy-MM-dd}" , fromDate.EditValue ).ToString();
                    string _toDate = string.Format( "{0:yyyy-MM-dd}" , toDate.EditValue ).ToString();

                    _rs += " and cus.created_date >= to_date('" + _fromDate + " 00:00:00','yyyy-mm-dd HH24:MI:SS','NLS_DATE_LANGUAGE=AMERICAN') ";
                    _rs += " and cus.created_date <= to_date('" + _toDate + " 23:59:59','yyyy-mm-dd HH24:MI:SS','NLS_DATE_LANGUAGE=AMERICAN') ";
                }
            }

            if ( rdTopCountBill.Checked == true )
            {
                try
                {
                    int _number = Int16.Parse( txtTopCountBill.Text.Trim() );
                    _rs += " Order by cou.invc_count DESC) where rownum <= " + _number;
                }
                catch ( Exception ex )
                {
                    XtraMessageBox.Show( "Vui lòng nhập số tự nhiên !" , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
            }

            if ( rdTopAmount.Checked == true )
            {
                try
                {
                    int _number = Int16.Parse( txtTopAmount.Text.Trim() );
                    _rs += " Order by amou.total_money DESC) where rownum <= " + _number;
                }
                catch ( Exception ex )
                {
                    XtraMessageBox.Show( "Vui lòng nhập số tự nhiên !" , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
            }

            return _rs;
        }

        private string getThangSingString()
        {
            string _rs = "";

            if ( cbbMonth.SelectedIndex == 1 )
            {
                _rs += " and cus.udf_6 in ('1','01') ";
            }
            else if ( cbbMonth.SelectedIndex == 2 )
            {
                _rs += " and cus.udf_6 in ('2','02') ";
            }
            else if ( cbbMonth.SelectedIndex == 3 )
            {
                _rs += " and cus.udf_6 in ('3','03') ";
            }
            else if ( cbbMonth.SelectedIndex == 4 )
            {
                _rs += " and cus.udf_6 in ('4','04') ";
            }
            else if ( cbbMonth.SelectedIndex == 5 )
            {
                _rs += " and cus.udf_6 in ('5','05') ";
            }
            else if ( cbbMonth.SelectedIndex == 6 )
            {
                _rs += " and cus.udf_6 in ('6','06') ";
            }
            else if ( cbbMonth.SelectedIndex == 7 )
            {
                _rs += " and cus.udf_6 in ('7','07') ";
            }
            else if ( cbbMonth.SelectedIndex == 8 )
            {
                _rs += " and cus.udf_6 in ('8','08') ";
            }
            else if ( cbbMonth.SelectedIndex == 9 )
            {
                _rs += " and cus.udf_6 in ('8','08') ";
            }
            else if ( cbbMonth.SelectedIndex == 10 )
            {
                _rs += " and cus.udf_6 in ('10') ";
            }
            else if ( cbbMonth.SelectedIndex == 11 )
            {
                _rs += " and cus.udf_6 in ('11') ";
            }
            else if ( cbbMonth.SelectedIndex == 12 )
            {
                _rs += " and cus.udf_6 in ('12') ";
            }

            return _rs;
        }
        #endregion
    }
}