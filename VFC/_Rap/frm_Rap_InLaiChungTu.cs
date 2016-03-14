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
    public partial class frm_Rap_InLaiChungTu : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_RAP_DoSua _doSua;
        cl_DAL_Store _store;

        public frm_Rap_InLaiChungTu()
        {
            InitializeComponent();
        }

        private void frm_Rap_InLaiChungTu_Load( object sender , EventArgs e )
        {
            dateCreate.EditValue = DateTime.Now;
            this.FillDataToStore();
        }

        private void btGetData_Click( object sender , EventArgs e )
        {
            string _validate = this.iValidate();
            _doSua = new cl_DAL_RAP_DoSua();

            gridControl2.DataSource = null;
            lbAo.Text = "0";
            lbQuan.Text = "0";
            lbDam.Text = "0";
            lbVay.Text = "0";
            lbKhac.Text = "0";
            lbSum.Text = "0";
            lbDocSid.Text = "0";
            lbStore.Text = "0";

            if ( _validate != "" )
            {
                frmMessageBox.Show( "Thông báo lỗi" , _validate , "error" );
            }
            else
            {
                string _type = "";
                if ( rdNhap.Checked == true )
                {
                    _type = "IN";
                }
                else
                {
                    _type = "OUT";
                }

                gridControl1.DataSource = _doSua.GetDanhSachInLai( dateCreate.EditValue.ToString() , cbbStores.EditValue.ToString() , _type );
            }
        }

        private void btPrint_Click( object sender , EventArgs e )
        {
            try
            {
                frm_PrintReport printForm = new frm_PrintReport();

                DataTable _dt = new DataTable();
                DataSet _ds = new DataSet();

                _dt = _ds.Tables.Add();
                _dt = (DataTable) gridControl2.DataSource;

                string _type = "";
                if ( lbDocSid.Text.Substring( 4 , 1 ).Equals( "I" ) )
                {
                    _type = "IN";
                }
                else
                {
                    _type = "OUT";
                }

                printForm.printBienNhanDoSua( cbbStores.EditValue.ToString() ,
                                lbDocSid.Text ,
                                lbAo.Text ,
                                lbQuan.Text ,
                                lbVay.Text ,
                                lbDam.Text ,
                                lbKhac.Text ,
                                lbSum.Text ,
                                lbCreateDate.Text ,
                                _type ,
                                _ds ,
                                _dt );
            }
            catch ( ArgumentOutOfRangeException ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Bạn chưa chọn chứng từ." , "error" );
            }
            catch ( NullReferenceException ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Bạn chưa chọn chứng từ." , "error" );
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            this.doMyJob();
        }

        private void gridView1_RowCellClick( object sender , DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e )
        {
            this.doMyJob();
        }

        #region Action
        private void FillDataToStore()
        {
            try
            {
                _store = new cl_DAL_Store();
                cbbStores.Properties.DataSource = _store.returnSQL_AllStoreCodeHCM();
            }
            catch (Exception ex)
            {
                frmMessageBox.Show("Thông báo lỗi", "Không có kết nối với máy chủ."
                            + Environment.NewLine
                            + "  *  Vui lòng liên hệ quản trị viên."
                            + Environment.NewLine
                            + "[ FillDataToStoreListHCM ]", "error");
                //frmMessageBox.Show( "Thông báo" , ex.ToString() , "error" );
            }
        }

        private string iValidate()
        {
            string _rs = "";

            if ( dateCreate.EditValue == null )
            {
                _rs += " * Vui lòng chọn ngày." + Environment.NewLine;
            }

            if ( cbbStores.EditValue == null )
            {
                _rs += " * Vui lòng chọn cửa hàng." + Environment.NewLine;
            }

            return _rs;
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
                    qtyAo += int.Parse(_dt.Rows[i]["QTY"].ToString()) ;
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

        private void FillDataToDetail( string _docSID )
        {
            _doSua = new cl_DAL_RAP_DoSua();
            gridControl2.DataSource = _doSua.GetDetailByDocSID( lbDocSid.Text );
        }

        private void doMyJob()
        {
            try
            {
                lbDocSid.Text = gridView1.GetFocusedRowCellValue( "Doc_SID" ).ToString();
                this.FillDataToDetail( lbDocSid.Text );
                this.countUDF();
                lbStore.Text = cbbStores.EditValue.ToString();
                lbCreateDate.Text = gridView1.GetFocusedRowCellValue( "Created_Date" ).ToString().Substring( 0 , 10 );
            }
            catch ( NullReferenceException ex )
            {

            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }
        #endregion
    }
}