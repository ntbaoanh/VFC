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

namespace VFC._PromotionCode
{
    public partial class frmProCode_Export_UsedCode : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_PromotionCode _dalProCode;

        public frmProCode_Export_UsedCode()
        {
            InitializeComponent();
        }

        private void frmProCode_Export_UsedCode_Load( object sender , EventArgs e )
        {
            this.updateThongTinPhu();
            _dalProCode = new cl_DAL_PromotionCode();

            listPartNumber.Items.Clear();
            foreach ( DataRow dataRow in _dalProCode.GetListPartNumber( "ASC" ).Rows )
            {
                listPartNumber.Items.Add( dataRow["PartNumber"] );
            }

            fromDate.EditValue = DateTime.Now;
            toDate.EditValue = DateTime.Now;
        }

        private void btRun_Click( object sender , EventArgs e )
        {
            this.updateThongTinPhu();
            _dalProCode = new cl_DAL_PromotionCode();
            DataTable _dt;
            string _iValidate = this.iValidateDate();

            if ( rdAllPart.Checked == true )
            {
                if ( cbNgaySuDung.CheckState == CheckState.Checked )
                {
                    if ( _iValidate.Equals( "" ) )
                    {
                        _dt = new DataTable();
                        _dt = _dalProCode.GetPromotionCode_Used_All_ByDate( fromDate.EditValue.ToString().Substring( 0 , 10 ) , toDate.EditValue.ToString().Substring( 0 , 10 ) );
                        gridControl1.DataSource = _dt;
                        gridControl2.DataSource = _dt;
                    }
                    else
                    {
                        XtraMessageBox.Show( _iValidate , "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
                else
                {
                    _dt = new DataTable();
                    _dt = _dalProCode.GetPromotionCode_Used_All();
                    gridControl1.DataSource = _dt;
                    gridControl2.DataSource = _dt;
                }
            }
            else if ( rdSome.Checked == true )
            {
                string _listPartNumber = this.getListPartnumber();

                if ( _listPartNumber.Equals( "" ) )
                {
                    XtraMessageBox.Show( "Xin vui lòng chọn PartNumber" , "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
                else
                {
                    _listPartNumber = _listPartNumber.Substring( 0 , _listPartNumber.Length - 1 );

                    if ( cbNgaySuDung.CheckState == CheckState.Checked )
                    {
                        if ( _iValidate.Equals( "" ) )
                        {
                            _dt = new DataTable();
                            _dt = _dalProCode.GetPromotionCode_Used_PartNumber_ByDate( _listPartNumber , fromDate.EditValue.ToString().Substring( 0 , 10 ) , toDate.EditValue.ToString().Substring( 0 , 10 ) );
                            gridControl1.DataSource = _dt;
                            gridControl2.DataSource = _dt;
                        }
                        else
                        {
                            XtraMessageBox.Show( _iValidate , "Thông báo." , MessageBoxButtons.OK , MessageBoxIcon.Error );
                        }
                    }
                    else
                    {
                        _dt = new DataTable();
                        _dt = _dalProCode.GetPromotionCode_Used_PartNumber( _listPartNumber );
                        gridControl1.DataSource = _dt;
                        gridControl2.DataSource = _dt;
                    }
                }
            }
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
                gridView2.BestFitColumns();
                gridControl2.ExportToXlsx( fileName );
            }
            catch ( Exception ex )
            {

            }
        }

        private void timer1_Tick( object sender , EventArgs e )
        {
            this.updateThongTinPhu();
        }

        #region Action
        private string getListPartnumber()
        {
            string _rs = "";

            try
            {
                for ( int i = 0 ; i < listPartNumber.ItemCount ; i++ )
                {
                    if ( listPartNumber.Items[i].CheckState == CheckState.Checked )
                    {
                        _rs += listPartNumber.Items[i].Value.ToString() + ",";
                    }
                }
            }
            catch ( Exception ex )
            {
                _rs = "";
            }

            return _rs;
        }

        private string iValidateDate()
        {
            string _rs = "";

            try
            {
                if ( DateTime.Compare( (DateTime) fromDate.EditValue , (DateTime) toDate.EditValue ) > 0 )
                {
                    _rs += " * [Đến ngày] trước [Từ ngày]" + Environment.NewLine;
                }
            }
            catch ( NullReferenceException ex )
            {
                if ( fromDate.EditValue == null )
                {
                    _rs += " * Vui lòng nhập [Từ ngày]" + Environment.NewLine;
                }

                if ( toDate.EditValue == null )
                {
                    _rs += " * Vui lòng nhập [Đến ngày]" + Environment.NewLine;
                }
            }

            return _rs;
        }

        private void updateThongTinPhu()
        {
            _dalProCode = new cl_DAL_PromotionCode();
            lbUsedCodes.Text = _dalProCode.CountUsedCode().ToString();
            lbHoldCode.Text = _dalProCode.CountHoldCode().ToString();
            lbAvailCode.Text = _dalProCode.CountAvailableCode().ToString();
        }
        #endregion
    }
}