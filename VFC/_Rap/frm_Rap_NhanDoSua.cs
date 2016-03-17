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
    public partial class frm_Rap_NhanDoSua : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_RAP_DoSua doSua;
        DAL.Utilities.Transaction rd;
        int qtyAo , qtyDam , qtyVay , qtyQuan , qtyKhac;
        string _udf10;
        cl_DAL_Inventory _dalInventory;
        cl_PRO_Inventory _proInventory;

        public frm_Rap_NhanDoSua()
        {
            InitializeComponent();
        }

        private void frmRAP_NhanDoSua_Load( object sender , EventArgs e )
        {
            this.FillDataToStoreListHCM();
            this.RePick();
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
                lbSoChungTu.Text = doSua.GetDocSid( "IN" , cbbStores.EditValue.ToString() );
            }
            catch ( NullReferenceException  )
            {
                frmMessageBox.Show("Thông báo." , "Xin chọn cửa hàng." , "error" );
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() );
            }
            txtUPC.Focus();
        }

        private void btInsertUPC_Click( object sender , EventArgs e )
        {
            this.insertUPC();
        }

        private void txtUPC_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.insertUPC();
            }
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
                if ( doSua.insertData( (DataTable) gridControl1.DataSource , lbSoChungTu.Text , lbCreatedDate.Text , lbStore.Text , int.Parse( lbSum.Text ) , "IN" ) )
                {
                    doSua.updateDoSua_Qty( (DataTable) gridControl1.DataSource , lbStore.Text , "IN" , lbSoChungTu.Text );
                    
                    rd = new DAL.Utilities.Transaction();
                    rd.record( "Nhận đồ sửa " + lbStore.Text + "-" + lbSoChungTu.Text + "-" + lbSum.Text + "sp-" + lbCreatedDate.Text , "4" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );

                    frm_PrintReport printForm = new frm_PrintReport();

                    DataTable _dt = new DataTable();
                    DataSet _ds = new DataSet();

                    _dt = _ds.Tables.Add();
                    _dt = (DataTable) gridControl1.DataSource;

                    printForm.printBienNhanDoSua( cbbStores.EditValue.ToString() ,
                                    lbSoChungTu.Text ,
                                    lbAo.Text ,
                                    lbQuan.Text ,
                                    lbVay.Text ,
                                    lbDam.Text ,
                                    lbKhac.Text ,
                                    lbSum.Text ,
                                    lbCreatedDate.Text ,
                                    "IN" ,
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
                frmMessageBox.Show( "Thông báo" , ex.ToString() , "error" );
            }

            this.Dispose();
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
        }

        public void countUDF( string _udf )
        {
            if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "sh" ) ||
                _udf.Substring( 0 , 2 ).ToLower().Equals( "ts" ) ||
                _udf.Substring( 0 , 2 ).ToLower().Equals( "ja" ) ||
                _udf.Substring( 0 , 2 ).ToLower().Equals( "ju" ) ||
                _udf.Substring( 0 , 2 ).ToLower().Equals( "po" ) )
            {
                qtyAo++;
            }
            else if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "nd" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "de" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "so" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "ca" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "dn" ) ||
                 _udf.Substring( 0 , 2 ).ToLower().Equals( "le" ) )
            {
                qtyQuan++;
            }
            else if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "dr" ) )
            {
                qtyDam++;
            }
            else if ( _udf.Substring( 0 , 2 ).ToLower().Equals( "sk" ) )
            {
                qtyVay++;
            }
            else
            {
                qtyKhac++;
            }

            lbAo.Text = qtyAo + "";
            lbQuan.Text = qtyQuan + "";
            lbDam.Text = qtyDam + "";
            lbVay.Text = qtyVay + "";
            lbKhac.Text = qtyKhac + "";
            int _tempSum = qtyAo + qtyDam + qtyKhac + qtyQuan + qtyVay;
            lbSum.Text = _tempSum + "";
        }

        public void insertUPC()
        {
            _dalInventory = new DAL.cl_DAL_Inventory();
            _proInventory = new cl_PRO_Inventory();

            _proInventory = _dalInventory.getUPCInfo( txtUPC.Text.Trim() , frmMain._myAppConfig.Ora248IP );

            _udf10 = _proInventory.UDF10;

            if ( !_dalInventory.checkValidUPC( txtUPC.Text.Trim() , frmMain._myAppConfig.Ora248IP ) )
            {
                //XtraMessageBox.Show( "Mã UPC này không có trong danh mục." + Environment.NewLine + "Xin vui lòng nhập lại" , "Lỗi" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                frmMessageBox.Show( "Thông báo lỗi" , "Mã UPC này không có trong danh mục." 
                    + Environment.NewLine 
                    + "Xin vui lòng nhập lại" , "error" );
            }
            else
            {
                string _lbSale = "";

                if ( _dalInventory.checkSaleUPC( txtUPC.Text , frmMain._myAppConfig.Ora248IP ) )
                {

                    _lbSale = "Hàng Sale";

                    DialogResult dialogResult = MessageBox.Show( "Hàng SALE !!!!" + Environment.NewLine + "Bạn có chắc muốn nhận sửa ?" , "Thông báo," , MessageBoxButtons.YesNo , MessageBoxIcon.Question );

                    if ( dialogResult == DialogResult.Yes )
                    {
                        try
                        {
                            //Created Table
                            DataTable _dtCart = new DataTable();
                            _dtCart.Columns.Add( "UPC" , typeof( string ) );
                            _dtCart.Columns.Add( "Status" , typeof( string ) );
                            _dtCart.Columns.Add( "UDF10" , typeof( string ) );
                            _dtCart.Columns.Add( "price_retail" , typeof( int ) );
                            _dtCart.Columns.Add( "description2" , typeof( string ) );
                            _dtCart.Columns.Add( "QTY" , typeof( int ) );

                            if ( gridControl1.DataSource == null )
                            {
                                //Add Row
                                _dtCart.Rows.Add( txtUPC.Text , _lbSale , _udf10 , _proInventory.PriceRetail , _proInventory.Desc2 , 1 );
                                this.countUDF( _udf10 );
                            }
                            else
                            {
                                _dtCart = (DataTable) gridControl1.DataSource;

                                _dtCart.Rows.Add( txtUPC.Text , _lbSale , _udf10 , _proInventory.PriceRetail , _proInventory.Desc2 , 1 );
                                this.countUDF( _udf10 );
                            }

                            gridControl1.DataSource = _dtCart;
                            txtUPC.Text = null;
                            lbSum.Text = "" + int.Parse( _dtCart.Rows.Count.ToString() );
                        }
                        catch ( Exception ex )
                        {
                            XtraMessageBox.Show( ex.ToString() );
                        }
                    }
                    else if ( dialogResult == DialogResult.No )
                    {
                        txtUPC.Text = "";
                        txtUPC.Focus();
                    }
                }
                else
                {
                    _lbSale = "";

                    try
                    {
                        //Created Table
                        DataTable _dtCart = new DataTable();
                        _dtCart.Columns.Add( "UPC" , typeof( string ) );
                        _dtCart.Columns.Add( "Status" , typeof( string ) );
                        _dtCart.Columns.Add( "UDF10" , typeof( string ) );
                        _dtCart.Columns.Add( "price_retail" , typeof( string ) );
                        _dtCart.Columns.Add( "description2" , typeof( string ) );
                        _dtCart.Columns.Add( "QTY" , typeof( int ) );

                        if ( gridControl1.DataSource == null )
                        {
                            //Add Row
                            _dtCart.Rows.Add( txtUPC.Text , _lbSale , _proInventory.UDF10 , _proInventory.PriceRetail , _proInventory.Desc2 , 1 );
                            this.countUDF( _udf10 );
                        }
                        else
                        {
                            _dtCart = (DataTable) gridControl1.DataSource;

                            _dtCart.Rows.Add( txtUPC.Text , _lbSale , _proInventory.UDF10 , _proInventory.PriceRetail , _proInventory.Desc2 , 1 );
                            this.countUDF( _udf10 );
                        }

                        gridControl1.DataSource = _dtCart;
                        txtUPC.Text = null;
                    }
                    catch ( Exception ex )
                    {
                        frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                    }
                }
            }
        }

        private void FillDataToStoreListHCM()
        {
            try
            {
                cl_DAL_Store _dalStore = new cl_DAL_Store();
                cbbStores.Properties.DataSource = _dalStore.returnSQL_AllStoreCodeHCM();
            }
            catch ( Exception  )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Không có kết nối với máy chủ."                             
                            + Environment.NewLine
                            + "  *  Vui lòng liên hệ quản trị viên."
                            + Environment.NewLine
                            + "[ FillDataToStoreListHCM ]" , "error" );
                //frmMessageBox.Show( "Thông báo" , ex.ToString() , "error" );
            }
        }
        #endregion
    }
}