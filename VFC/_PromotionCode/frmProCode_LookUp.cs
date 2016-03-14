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
    public partial class frmProCode_LookUp : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_PromotionCode _proCode;
        _Customer.frmCust_CustomerInfo frmCustInfo;

        public frmProCode_LookUp()
        {
            InitializeComponent();
        }

        private void frmProCode_LookUp_Load( object sender , EventArgs e )
        {
            txtPhone1.Focus();
            this.ClearLabel();
        }

        private void btLookUp_Click( object sender , EventArgs e )
        {
            this.LookupCodeByPhone( txtPhone1.Text.Trim() );
        }

        private void gridView_ProCode_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                lbCode.Text = gridView_ProCode.GetFocusedRowCellValue( "ProCode" ).ToString();
                lbCMND.Text = gridView_ProCode.GetFocusedRowCellValue( "CMND" ).ToString();
                txtDiaChi.Text = gridView_ProCode.GetFocusedRowCellValue( "DiaChi" ).ToString();
                lbDinhDanh.Text = gridView_ProCode.GetFocusedRowCellValue( "GioiTinh" ).ToString();
                lbExpireDate.Text = gridView_ProCode.GetFocusedRowCellValue( "Date_Expire" ).ToString();
                lbGTriKM.Text = gridView_ProCode.GetFocusedRowCellValue( "AmountKM" ).ToString();
                lbLoaiKM.Text = gridView_ProCode.GetFocusedRowCellValue( "LoaiKMDescription" ).ToString();
                lbNgaySinh.Text = gridView_ProCode.GetFocusedRowCellValue( "NgaySinh" ).ToString();
                lbSdt.Text = gridView_ProCode.GetFocusedRowCellValue( "Phone1" ).ToString();
                lbTen.Text = gridView_ProCode.GetFocusedRowCellValue( "HoTen" ).ToString();
                lbCustSid.Text = gridView_ProCode.GetFocusedRowCellValue( "CustSid" ).ToString();
                int _tempStatus = int.Parse( gridView_ProCode.GetFocusedRowCellValue( "Status" ).ToString() );

                switch (_tempStatus)
                {
                    case 1:
                        lbStatus.Text = "Mã code có thể sử dụng.";
                        lbStatus.ForeColor = Color.FromArgb( 0x00 , 0x00 , 0xFF );
                        break;
                    case 2:
                        lbStatus.Text = "Mã code đã được sử dụng.";
                        lbStatus.ForeColor = Color.FromArgb( 0xFF , 0x33 , 0x00 );
                        break;
                    case 3:
                        lbStatus.Text = "Mã code đã bị treo.";
                        lbStatus.ForeColor = Color.FromArgb( 0x99 , 0x33 , 0xCC );
                        break;
                    case 4:
                        lbStatus.Text = "Mã code đã hết hạn sử dụng.";
                        lbStatus.ForeColor = Color.FromArgb( 0xCC , 0x66 , 0x00 );
                        break;
                }                  
            }
            catch ( NullReferenceException ex )
            {
                this.ClearLabel();
            }
            catch ( Exception ex )
            {

            }
        }

        private void btViewCustomer_Click( object sender , EventArgs e )
        {
            if ( frmCustInfo == null || frmCustInfo.IsDisposed )
            {
                frmCustInfo = new _Customer.frmCust_CustomerInfo( lbCustSid.Text );
                frmCustInfo.ShowDialog();
            }
            else
            {
                frmCustInfo.Activate();
            }
        }

        #region Action
        private void LookupCodeByPhone( string _phone )
        {
            _proCode = new cl_DAL_PromotionCode();
            gridControl_ProCode.DataSource = null;

            try
            {
                DataTable _dt = new DataTable();
                _dt = _proCode.GetProCodeByPhone(_phone);

                if ( _dt.Rows.Count == 0 )
                {
                    frmMessageBox.Show( "Thông báo" , "Khách hàng không có mã code." , "alert" );
                }
                else
                {
                    gridControl_ProCode.DataSource = _dt;
                    txtPhone1.Focus();
                }
            }
            catch ( NullReferenceException ex )
            {
            }
            catch ( Exception ex )
            {
            }
        }

        private void ClearLabel()
        {
            lbCode.Text = null;
            lbCMND.Text = null;
            txtDiaChi.Text = null;
            lbDinhDanh.Text = null;
            lbExpireDate.Text = null;
            lbGTriKM.Text = null;
            lbLoaiKM.Text = null;
            lbNgaySinh.Text = null;
            lbSdt.Text = null;
            lbTen.Text = null;
            lbStatus.Text = null;            
        }
        #endregion
    }
}