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
using DevExpress.XtraGrid.Views.Grid;

namespace VFC._Merchandise
{
    public partial class frmMER_KiemTraASN : DevExpress.XtraEditors.XtraForm
    {
        cl_PRO_Voucher _proVoucher;
        cl_DAL_Voucher _dalVoucher;
        cl_DAL_Voucher _dalVou;

        public frmMER_KiemTraASN()
        {
            InitializeComponent();
        }

        private void frmMER_KiemTraASN_Load( object sender , EventArgs e )
        {
            txtInputQty.Text = "1";            
            this.MakeNew();
        }

        private void btGetASNList_Click( object sender , EventArgs e )
        {
            this.MakeNew();
        }

        private void btLoadASN_Click( object sender , EventArgs e )
        {
            if ( lbVouSid.Text.Equals( "lbVouSid" ) )
            {
                XtraMessageBox.Show( "Vui lòng chọn ASN." , "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
            else
            {
                gridControl_ASN.DataSource = null;
                this.FillDataToGridASN( lbVouSid.Text , frmMain._myAppConfig.OraLocalIP );
                txtInputQty.Enabled = true;
                txtInputUPC.Enabled = true;
            }
        }

        private void btNewAction_Click( object sender , EventArgs e )
        {
            this.MakeNew();
        }

        private void txtInputUPC_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.DoCompare();
            }
        }

        private void simpleButton1_Click( object sender , EventArgs e )
        {
            this.DoCompare();
        }

        private void cbbListASN_EditValueChanged( object sender , EventArgs e )
        {
            lbVouSid.Text = cbbListASN.EditValue.ToString();
            _proVoucher = new cl_PRO_Voucher();
            _dalVoucher = new cl_DAL_Voucher();

            _proVoucher = _dalVoucher.GetVoucherByVouSid( lbVouSid.Text , frmMain._myAppConfig.OraLocalIP );
            lbSlipSid.Text = _proVoucher.SlipSid;
            lbSlipNo.Text = _proVoucher.SlipNo;
            lbFromStore.Text = _proVoucher.SlipOutStoreCode;
            lbCreatedDate.Text = _proVoucher.SlipCreatedDate;
            lbSumQty.Text = _proVoucher.SumQty.ToString();
            btLoadASN.Enabled = true;
        }

        #region Action
        private void DoCompare()
        {
            try
            {
                //Add data into Input GridControl
                gridControl_Input.DataSource = this.InsertUpcToGridInput( (DataTable) gridControl_Input.DataSource , txtInputUPC.Text.Trim() , int.Parse( txtInputQty.Text.Trim() ) );

                txtInputUPC.Text = "";
                txtInputUPC.Focus();

                //Compare Data and Return Result
                DataTable _inputDt = (DataTable)gridControl_Input.DataSource;
                DataTable _sourceDt = (DataTable)gridControl_ASN.DataSource;
                DataTable _compareDt = new DataTable();

                bool _flag = false;

                _compareDt.Columns.Add( "UPC" , typeof( string ) );                
                _compareDt.Columns.Add( "SlgGoc" , typeof( int ) );
                _compareDt.Columns.Add( "SlgQuet" , typeof( int ) );
                _compareDt.Columns.Add( "SlgLech" , typeof( int ) );

                for ( int i = 0 ; i < _inputDt.Rows.Count ; i++)
                {
                    string _upc = _inputDt.Rows[i]["UPC"].ToString();;
                    int _slgQuet = int.Parse( _inputDt.Rows[i]["QTY"].ToString() );

                    for ( int j = 0 ; j < _sourceDt.Rows.Count ; j++ )
                    {
                        string _upcSource = _sourceDt.Rows[j]["UPC"].ToString();
                        int _slgSource = int.Parse( _sourceDt.Rows[j]["SUMQTY"].ToString() );

                        if ( _upcSource.Equals( _upc ) )
                        {
                            int _slgGoc = _slgSource;

                            if ( _slgGoc != _slgQuet )
                            {
                                _compareDt.Rows.Add( _upc
                                                        , _slgGoc
                                                        , _slgQuet
                                                        , _slgQuet - _slgGoc );
                                _flag = true;
                            }
                            else
                            {
                                _flag = true;
                            }
                            goto StepB;
                        }
                        else
                        {
                            _flag = false;
                        }
                    }

                StepB:
                    if ( _flag == false )
                    {
                        _compareDt.Rows.Add( _upc
                                           , 0
                                           , _slgQuet
                                           , _slgQuet );
                    }
                }               
                
                gridControl_Compare.DataSource = _compareDt;
            }
            catch ( Exception  )
            {

            }
        }

        private DataTable MergeGrid( DataTable _dt )
        {
            DataTable _rs = new DataTable();
            _rs.Columns.Add( "UPC" , typeof( string ) );
            _rs.Columns.Add( "SlgGoc" , typeof( int ) );
            _rs.Columns.Add( "SlgQuet" , typeof( int ) );
            _rs.Columns.Add( "SlgLech" , typeof( int ) );

            for ( int i = 0 ; i < _dt.Rows.Count ; i++ )
            {

            }

            return _dt;
        }

        private DataTable InsertUpcToGridInput(DataTable _dtInput, string _upc, int _qty)
        {
            try
            {
                if ( _dtInput == null || _dtInput.Rows.Count == 0 )
                {
                    _dtInput = new DataTable();
                    _dtInput.Columns.Add( "UPC" , typeof( string ) );
                    _dtInput.Columns.Add( "QTY" , typeof( int ) );
                    _dtInput.Rows.Add( _upc , _qty );
                    goto Finish;
                }
                else
                {
                    for ( int i = 0 ; i < _dtInput.Rows.Count ; i++ )
                    {                       
                        if ( _dtInput.Rows[i]["UPC"].ToString().Equals( txtInputUPC.Text ) )
                        {
                            int _tempQty = int.Parse( _dtInput.Rows[i]["QTY"].ToString() ) + _qty;
                            _dtInput.Rows.RemoveAt( i );
                            _dtInput.Rows.Add( _upc , _tempQty );
                            goto StepB;
                        }
                    }

                    _dtInput.Rows.Add( _upc , _qty );
                    goto StepB;
                }                
            }
            catch ( Exception  )
            {

            }

            StepB:
            for ( int i = 0 ; i < _dtInput.Rows.Count ; i++ )
            {
                if ( int.Parse( _dtInput.Rows[i]["QTY"].ToString() ) == 0 )
                {
                    _dtInput.Rows.RemoveAt( i );
                }
            }

            Finish:
            return _dtInput;
        }

        private void FillDataToListASN()
        {
            cbbListASN.Properties.DataSource = null;
            _dalVou = new cl_DAL_Voucher();
            cbbListASN.Properties.DataSource = _dalVou.GetASNList( frmMain._myAppConfig.StoreNo , frmMain._myAppConfig.OraLocalIP );
        }

        private void FillDataToGridASN( string _vouSid , string _ip )
        {
            gridControl_ASN.DataSource = null;
            _dalVou = new cl_DAL_Voucher();
            gridControl_ASN.DataSource = _dalVou.GetASNDetail( _vouSid , _ip );
        }

        private void gridView_Compare_RowStyle( object sender , DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e )
        {
            GridView View = sender as GridView;
            if ( e.RowHandle >= 0 )
            {
                int slgLech = int.Parse( View.GetRowCellDisplayText( e.RowHandle , View.Columns["SlgLech"] ) );

                if ( slgLech < 0 )
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }

                if ( slgLech > 0 )
                {
                    e.Appearance.BackColor = Color.GreenYellow;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }

        private void MakeNew()
        {
            txtInputQty.Enabled = false;
            txtInputUPC.Enabled = false;
            btLoadASN.Enabled = false;
            gridControl_ASN.DataSource = null;
            gridControl_Compare.DataSource = null;
            gridControl_Input.DataSource = null;

            lbVouSid.Text = null;
            lbCreatedDate.Text = null;
            lbFromStore.Text = null;
            lbSlipNo.Text = null;
            lbSlipSid.Text = null;
            lbSumQty.Text = null;

            cbbListASN.SelectedText = "Vui lòng chọn ASN";

            this.FillDataToListASN();
        }
        #endregion

        
    }
}