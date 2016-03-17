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

namespace VFC._Rap
{
    public partial class frm_Rap_TraDoSua : DevExpress.XtraEditors.XtraForm
    {
        int qtyAo , qtyDam , qtyVay , qtyQuan , qtyKhac;
        DAL.Utilities.Transaction rd;
        cl_DAL_RAP_DoSua doSua;
        cl_DAL_Inventory ivt;
        cl_PRO_Inventory _proInventory;
        cl_DAL_Store _store;

        public frm_Rap_TraDoSua()
        {
            InitializeComponent();
        }


        private void frm_Rap_TraDoSua_Load( object sender , EventArgs e )
        {
            this.FillDataToStoreList();
            lbCreatedDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btPickStore_Click( object sender , EventArgs e )
        {
            doSua = new cl_DAL_RAP_DoSua();
            try
            {
                lbStore.Text = cbbStores.EditValue.ToString();
                txtUPC.Enabled = true;
                cbbStores.Enabled = false;
                btPickStore.Enabled = false;
                btInsertUPC.Enabled = true;
                lbSoChungTu.Text = doSua.GetDocSid( "OUT" , cbbStores.EditValue.ToString() );
                gridControl1.DataSource = doSua.GetTonKho_Details( cbbStores.EditValue.ToString() );
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void btInsertUPC_Click( object sender , EventArgs e )
        {
            this.InsertUPC();
        }

        private void btRePick_Click( object sender , EventArgs e )
        {
            this.Dispose();
        }

        private void btPrintUpdate_Click( object sender , EventArgs e )
        {
            try
            {
                doSua = new cl_DAL_RAP_DoSua();
                if ( doSua.insertData( (DataTable) gridControl2.DataSource , lbSoChungTu.Text , lbCreatedDate.Text , lbStore.Text , int.Parse( lbSum.Text ) , "OUT" ) )
                {
                    doSua.updateDoSua_Qty( (DataTable) gridControl2.DataSource , lbStore.Text , "OUT" , lbSoChungTu.Text );
                    rd = new DAL.Utilities.Transaction();
                    rd.record( "Trả đồ sửa " + lbStore.Text + "-" + lbSoChungTu.Text + "-" + lbSum.Text + "sp-" + lbCreatedDate.Text , "4" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );

                    frm_PrintReport printForm = new frm_PrintReport();

                    DataTable _dt = new DataTable();
                    DataSet _ds = new DataSet();

                    _dt = _ds.Tables.Add();
                    _dt = (DataTable) gridControl2.DataSource;

                    printForm.printBienNhanDoSua( cbbStores.EditValue.ToString() ,
                                    lbSoChungTu.Text ,
                                    lbAo.Text ,
                                    lbQuan.Text ,
                                    lbVay.Text ,
                                    lbDam.Text ,
                                    lbKhac.Text ,
                                    lbSum.Text ,
                                    lbCreatedDate.Text ,
                                    "OUT" ,
                                    _ds ,
                                    _dt );
                }
                else
                {                    
                    frmMessageBox.Show( "Thông báo lỗi" , "+ Có lỗi khi thực hiện thao tác này." 
                                            + Environment.NewLine
                                            + "+ Vui lòng liên hệ Quản Trị Viên" 
                                            + Environment.NewLine
                                            + "+ Hoặc vui lòng thử lại." , "error" );
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }

            this.Dispose();
        }

        private void txtUPC_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.InsertUPC();
            }
        }

        #region ACTION
        private void RePick()
        {
            lbCreatedDate.Text = DateTime.Now.ToShortDateString();

            lbSum.Text = "0";
            lbAo.Text = "0";
            lbDam.Text = "0";
            lbQuan.Text = "0";
            lbVay.Text = "0";
            lbKhac.Text = "0";
            qtyAo = 0;
            qtyDam = 0;
            qtyQuan = 0;
            qtyVay = 0;
            qtyKhac = 0;

            cbbStores.Enabled = true;
            txtUPC.Enabled = false;
            btInsertUPC.Enabled = false;
            btPickStore.Enabled = true;
            lbStore.Text = "";
            txtUPC.Text = "";
            lbSoChungTu.Text = "";

            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
        }

        public void CountUDF( string _udf , string _cal )
        {
            if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "sh" ) ||
                _udf.Substring( 0 , 2 ).ToLower().Equals( "ts" ) ||
                _udf.Substring( 0 , 2 ).ToLower().Equals( "ja" ) ||
                _udf.Substring( 0 , 2 ).ToLower().Equals( "ju" ) ||
                _udf.Substring( 0 , 2 ).ToLower().Equals( "po" ) )
            {
                if ( _cal.Equals( "Plus" ) )
                {
                    qtyAo++;
                }
                else
                {
                    qtyAo--;
                }
            }
            else if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "nd" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "de" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "so" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "ca" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "dn" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "le" ) )
            {
                if ( _cal.Equals( "Plus" ) )
                {
                    qtyQuan++;
                }
                else
                {
                    qtyQuan--;
                }
            }
            else if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "dr" ) )
            {
                if ( _cal.Equals( "Plus" ) )
                {
                    qtyDam++;
                }
                else
                {
                    qtyDam--;
                }
            }
            else if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "sk" ) )
            {
                if ( _cal.Equals( "Plus" ) )
                {
                    qtyVay++;
                }
                else
                {
                    qtyVay--;
                }
            }
            else
            {
                if ( _cal.Equals( "Plus" ) )
                {
                    qtyKhac++;
                }
                else
                {
                    qtyKhac--;
                }
            }

            lbAo.Text = qtyAo.ToString();
            lbQuan.Text = qtyQuan.ToString();
            lbDam.Text = qtyDam.ToString();
            lbVay.Text = qtyVay.ToString();
            lbKhac.Text = qtyKhac.ToString();
            int _tempSum = qtyAo + qtyDam + qtyKhac + qtyQuan + qtyVay;
            lbSum.Text = _tempSum.ToString();
        }

        public void InsertUPC()
        {
            ivt = new DAL.cl_DAL_Inventory();
            _proInventory = ivt.getUPCInfo( txtUPC.Text , frmMain._myAppConfig.Ora248IP);
            cl_DAL_RAP_DoSua doSua = new cl_DAL_RAP_DoSua();
            string _udf10 = _proInventory.UDF10;

            if ( !ivt.checkValidUPC( txtUPC.Text.Trim() , frmMain._myAppConfig.Ora248IP ) )
            {
                XtraMessageBox.Show( "Mã UPC này không có trong danh mục." + Environment.NewLine + "Xin vui lòng nhập lại" , "Lỗi" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
            else
            {
                if ( !doSua.checkUpdate_DoSua_Qty( lbStore.Text , txtUPC.Text.Trim() ) )
                {
                    XtraMessageBox.Show( "Mã hàng này không có tồn không kho." , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
                else
                {
                    try
                    {
                        //Created Table
                        DataTable _dtCart = new DataTable();
                        _dtCart.Columns.Add( "UPC" , typeof( string ) );
                        _dtCart.Columns.Add( "UDF10" , typeof( string ) );
                        _dtCart.Columns.Add( "QTY" , typeof( int ) );

                        if ( gridControl2.DataSource == null )
                        {
                            //Add Row
                            _dtCart.Rows.Add( txtUPC.Text , _udf10 , 1 );
                            this.CountUDF( _udf10 , "Plus" );
                        }
                        else
                        {
                            _dtCart = this.AddToCart( (DataTable) gridControl1.DataSource , (DataTable) gridControl2.DataSource , txtUPC.Text.Trim() , _udf10 );
                        }

                        gridControl2.DataSource = _dtCart;
                        txtUPC.Text = null;
                        //lbSum.Text = "" + int.Parse( _dtCart.Rows.Count.ToString() );
                    }
                    catch ( Exception ex )
                    {
                        XtraMessageBox.Show( ex.ToString() );
                    }
                }
            }
        }

        private DataTable AddToCart( DataTable tonkhoDatatable , DataTable inputDatatable , string _upc , string _udf )
        {
            //Thêm vào giỏ hàng trước để chuẩn bị kiểm tra với tồn kho            
            for ( int i = 0 ; i < inputDatatable.Rows.Count ; i++ )
            {
                if ( inputDatatable.Rows[i][0].ToString().Equals( _upc ) )
                {
                    inputDatatable.Rows.Add( inputDatatable.Rows[i][0].ToString() , inputDatatable.Rows[i][1].ToString() , int.Parse( inputDatatable.Rows[i][2].ToString() ) + 1 );
                    inputDatatable.Rows.RemoveAt( i );
                    this.CountUDF( _udf , "Plus" );
                    goto StepB;
                }
            }

            inputDatatable.Rows.Add( _upc , _udf , 1 );
            this.CountUDF( _udf , "Plus" );

        StepB:
            for ( int i = 0 ; i < inputDatatable.Rows.Count ; i++ )
            {
                for ( int j = 0 ; j < tonkhoDatatable.Rows.Count ; j++ )
                {
                    if ( inputDatatable.Rows[i]["UPC"].ToString().Equals( tonkhoDatatable.Rows[j]["UPC"].ToString() ) )
                    {
                        if ( int.Parse( inputDatatable.Rows[i]["QTY"].ToString() ) > ( int.Parse( tonkhoDatatable.Rows[j]["QTY"].ToString() ) ) )
                        {
                            XtraMessageBox.Show( "Mã hàng này không còn tồn đế trả !" , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                            inputDatatable.Rows.Add( inputDatatable.Rows[i][0].ToString() , inputDatatable.Rows[i][1].ToString() , int.Parse( inputDatatable.Rows[i][2].ToString() ) - 1 );
                            inputDatatable.Rows.RemoveAt( i );
                            this.CountUDF( _udf , "Minus" );
                            goto Finish;
                        }
                    }
                }
            }

        Finish:
            return inputDatatable;
        }

        private void FillDataToStoreList()
        {
            try
            {
                _store = new cl_DAL_Store();
                cbbStores.Properties.DataSource = _store.returnSQL_AllStoreCodeHCM();
            }
            catch (Exception )
            {
                frmMessageBox.Show("Thông báo lỗi", "Không có kết nối với máy chủ."
                            + Environment.NewLine
                            + "  *  Vui lòng liên hệ quản trị viên."
                            + Environment.NewLine
                            + "[ FillDataToStoreListHCM ]", "error");
                //frmMessageBox.Show( "Thông báo" , ex.ToString() , "error" );
            }
        }
        #endregion

    }
}