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

namespace VFC._Rap
{
    public partial class frm_Rap_TonKhoDoSua : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_RAP_DoSua _doSua;
        public frm_Rap_TonKhoDoSua()
        {
            InitializeComponent();
        }

        private void frm_Rap_TonKhoDoSua_Load( object sender , EventArgs e )
        {
            this.FillDataToDanhSach();
            timer.Interval = 1000*60*2;
            timer.Enabled = true;
            timer.Start();
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                lbStore.Text = gridView1.GetFocusedRowCellValue( "Store" ).ToString();
                this.FillDataToDetail( lbStore.Text );
                this.countUDF();
            }
            catch ( Exception ex )
            {

            }
        }

        private void timer_Tick( object sender , EventArgs e )
        {
            this.FillDataToDanhSach();
        }

        private void btRefresh_Click( object sender , EventArgs e )
        {
            this.FillDataToDanhSach();
        }

        #region Action
        private void FillDataToDanhSach()
        {
            _doSua = new cl_DAL_RAP_DoSua();
            gridControl1.DataSource = _doSua.GetTonKho_Sum();
        }

        private void FillDataToDetail( string _store )
        {
            _doSua = new cl_DAL_RAP_DoSua();
            gridControl2.DataSource = _doSua.GetTonKho_Details( _store );
        }

        private void countUDF()
        {
            DataTable _dt = new DataTable();
            _dt = (DataTable) gridControl2.DataSource;
            int qtyAo = 0;
            int qtyQuan = 0;
            int qtyDam = 0;
            int qtyVay = 0;
            int qtyKhac = 0;

            for ( int i = 0 ; i < _dt.Rows.Count ; i++ )
            {
                string _udf = _dt.Rows[i]["UDF10"].ToString();

                if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "sh" ) ||
                    _udf.Substring( 0 , 2 ).ToLower().Equals( "ts" ) ||
                    _udf.Substring( 0 , 2 ).ToLower().Equals( "ja" ) ||
                    _udf.Substring( 0 , 2 ).ToLower().Equals( "ju" ) ||
                    _udf.Substring( 0 , 2 ).ToLower().Equals( "po" ) )
                {
                    qtyAo += int.Parse( _dt.Rows[i]["QTY"].ToString() );
                }
                else if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "nd" ) ||
                        _udf.Substring( 0 , 2 ).ToLower().Equals( "de" ) ||
                        _udf.Substring( 0 , 2 ).ToLower().Equals( "so" ) ||
                        _udf.Substring( 0 , 2 ).ToLower().Equals( "ca" ) ||
                        _udf.Substring( 0 , 2 ).ToLower().Equals( "dn" ) ||
                        _udf.Substring( 0 , 2 ).ToLower().Equals( "le" ) )
                {
                    qtyQuan += int.Parse( _dt.Rows[i]["QTY"].ToString() );
                }
                else if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "dr" ) )
                {
                    qtyDam += int.Parse( _dt.Rows[i]["QTY"].ToString() );
                }
                else if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "sk" ) )
                {
                    qtyVay += int.Parse( _dt.Rows[i]["QTY"].ToString() );
                }
                else
                {
                    qtyKhac += int.Parse( _dt.Rows[i]["QTY"].ToString() );
                }

                lbAo.Text = qtyAo + " sp";
                lbQuan.Text = qtyQuan + " sp";
                lbDam.Text = qtyDam + " sp";
                lbVay.Text = qtyVay + " sp";
                lbKhac.Text = qtyKhac + " sp";
                int _tempSum = qtyAo + qtyDam + qtyKhac + qtyQuan + qtyVay;
                lbSum.Text = _tempSum + " sp";
            }
        }
        #endregion
    }
}