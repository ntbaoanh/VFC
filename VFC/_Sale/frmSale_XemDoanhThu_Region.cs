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

namespace VFC._Sale
{
    public partial class frmSale_XemDoanhThu_Region : DevExpress.XtraEditors.XtraForm
    {
        string _result, _region;
        cl_DAL_User _userLogin;
        cl_DAL_Invoice _invoice;
        cl_DAL_Store _stores;
        DAL.Utilities.Transaction rd;

        public frmSale_XemDoanhThu_Region()
        {
            InitializeComponent();
        }

        private void frmSale_XemDoanhSo_Region_Load( object sender , EventArgs e )
        {
            _userLogin = new cl_DAL_User();

            for ( int i = 0 ; i < listRegion.ItemCount ; i++ )
            {
                if ( _userLogin.checkUserRegion( frmHO_Main._userLogin.UserName , listRegion.Items[i].Value.ToString() ) )
                {
                    listRegion.Items[i].Enabled = true;
                }
                else
                {
                    listRegion.Items[i].Enabled = false;
                }
            }

            dateFrom.EditValue = DateTime.Now;
            dateTo.EditValue = DateTime.Now;
        }

        private void btLookUp_Click( object sender , EventArgs e )
        {
            gridControl1.DataSource = null;

            splashScreenManager1.ShowWaitForm();

            txtProcess.Text = "";

            Stopwatch sw = Stopwatch.StartNew();

            if ( this.iValidate() )
            {
                gridControl1.DataSource = null;
                _invoice = new cl_DAL_Invoice();

                string _fromDate = string.Format( "{0:dd/MM/yyyy}" , dateFrom.EditValue ).ToString();
                string _toDate = string.Format( "{0:dd/MM/yyyy}" , dateTo.EditValue ).ToString();

                DataTable _dt = new DataTable();

                _dt.Columns.Add( "REGION_NAME" , typeof( string ) );
                _dt.Columns.Add( "STORE_CODE" , typeof( string ) );
                _dt.Columns.Add( "TOTAL_MONEY" , typeof( int ) );
                _dt.Columns.Add( "TOTAL_DISCOUNT" , typeof( int ) );
                _dt.Columns.Add( "TOTAL_QTY" , typeof( int ) );
                _dt.Columns.Add( "NOTES" , typeof( string ) );

                try
                {
                    for ( int i = 0 ; i < listStores.ItemCount ; i++ )
                    {
                        DataTable _tempDt = new DataTable();

                        try
                        {
                            if ( listStores.Items[i].CheckState == CheckState.Checked )
                            {
                                bool _server;

                                if ( chkServer.CheckState == CheckState.Checked )
                                {
                                    _server = true;
                                }
                                else
                                {
                                    _server = false;
                                }

                                _tempDt = _invoice.GET_Sum_DoanhThu_By_StoreCode( _fromDate , _toDate , listStores.Items[i].Value.ToString() , frmMain._myAppConfig.SbsNo , _server);

                                _dt.Rows.Add( _tempDt.Rows[0]["REGION_NAME"].ToString() ,
                                              _tempDt.Rows[0]["STORE_CODE"].ToString() ,
                                              int.Parse( _tempDt.Rows[0]["TOTAL_MONEY"].ToString() ) ,
                                              int.Parse( _tempDt.Rows[0]["TOTAL_DISCOUNT"].ToString() ) ,
                                              int.Parse( _tempDt.Rows[0]["TOTAL_QTY"].ToString() )) ;

                                txtProcess.Text += listStores.Items[i].Value.ToString() + " : Done !" + Environment.NewLine;
                            }
                        }
                        catch ( Exception ex )
                        {
                            txtProcess.Text += listStores.Items[i].Value.ToString() + " : Lost Connection !" + Environment.NewLine;
                        }
                    }
                }
                catch ( Exception ex )
                {
                    frmMessageBox.Show( "Thông báo lỗi", ex.ToString() , "error" );
                }

                gridControl1.DataSource = _dt;
                gridControl1.RefreshDataSource();
            }
            else
            {
                gridControl1.DataSource = null;
                frmMessageBox.Show( "Thông báo lỗi",  _result , "error" );
            }

            sw.Stop();

            txtProcess.Text += "Thời gian chạy : " + sw.Elapsed.TotalSeconds + " giây" + Environment.NewLine;

            rd = new DAL.Utilities.Transaction();
            rd.record( "Xem doanh thu" , "0" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );

            splashScreenManager1.CloseWaitForm();
        }

        private void checkAllRegion_CheckedChanged( object sender , EventArgs e )
        {
            if ( checkAllRegion.CheckState == CheckState.Checked )
            {
                for ( int i = 0 ; i < listRegion.ItemCount ; i++ )
                {
                    if ( listRegion.Items[i].Enabled == true )
                    {
                        listRegion.Items[i].CheckState = CheckState.Checked;
                    }
                    else
                    {
                        listRegion.Items[i].CheckState = CheckState.Unchecked;
                    }
                }
            }
            else
            {
                for ( int i = 0 ; i < listRegion.ItemCount ; i++ )
                {
                    listRegion.Items[i].CheckState = CheckState.Unchecked;
                }
            }
        }

        private void checkAllStores_CheckedChanged( object sender , EventArgs e )
        {
            if ( checkAllStores.CheckState == CheckState.Checked )
            {
                for ( int i = 0 ; i < listStores.ItemCount ; i++ )
                {
                    listStores.Items[i].CheckState = CheckState.Checked;
                }
            }
            else
            {
                for ( int i = 0 ; i < listStores.ItemCount ; i++ )
                {
                    listStores.Items[i].CheckState = CheckState.Unchecked;
                }
            }
        }

        private void listRegion_ItemCheck( object sender , DevExpress.XtraEditors.Controls.ItemCheckEventArgs e )
        {
            try
            {
                DataSet ds = new DataSet();
                string _region = this.getRegionCheck();

                if ( _region.Equals( ",'" ) )
                {
                    listStores.Items.Clear();
                    checkAllStores.CheckState = CheckState.Unchecked;
                    checkAllRegion.CheckState = CheckState.Unchecked;
                }
                else
                {
                    _stores = new cl_DAL_Store();
                    DataTable _dt = new DataTable();

                    _dt = _stores.returnORA_StoreCodeFromRegion( _region.Substring( 2 , _region.Length - 3 ) );

                    listStores.Items.Clear();
                    foreach ( DataRow dataRow in _dt.Rows )
                    {
                        listStores.Items.Add( dataRow["STORE_CODE"] );
                    }
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        #region Action
        private string getRegionCheck()
        {
            _region = ",'";

            for ( int i = 0 ; i < listRegion.ItemCount ; i++ )
            {
                if ( listRegion.Items[i].CheckState == CheckState.Checked )
                {
                    _region += "'" + listRegion.Items[i].Value + "',";
                }
            }

            return _region;
        }

        private bool iValidate()
        {
            bool flag = true;
            _result = "";

            try
            {
                if ( DateTime.Compare( (DateTime) dateFrom.EditValue , (DateTime) dateTo.EditValue ) > 0 )
                {
                    _result += " * [Đến ngày] trước [Từ ngày]" + Environment.NewLine;
                    flag = false;
                }
            }
            catch ( NullReferenceException ex )
            {
                _result += " * Chọn [Từ ngày] / [Đến ngày] " + Environment.NewLine;
                flag = false;
            }

            //Validate Stores
            try
            {
                if ( this.getStores().Equals( ",'" ) )
                {
                    _result += " * Vui lòng chọn cửa hàng." + Environment.NewLine;
                    flag = false;
                }
            }
            catch ( Exception ex )
            {
                _result += " * Vui lòng chọn cửa hàng." + Environment.NewLine;
                flag = false;
            }

            return flag;
        }

        private string getStores()
        {
            string _stores = ",'";

            for ( int i = 0 ; i < listStores.ItemCount ; i++ )
            {
                _stores += "'" + listStores.Items[i].Value.ToString() + "',";
            }

            return _stores;
        }
        #endregion        
    }
}