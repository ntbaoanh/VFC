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

namespace VFC._IT
{
    public partial class frmIT_ChinhSuaChungTu_History : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_HoTroKyThuat _dalHoTroKyThuat;

        public frmIT_ChinhSuaChungTu_History()
        {
            InitializeComponent();
        }

        private void frmIT_ChinhSuaChungTu_History_Load( object sender , EventArgs e )
        {
            dateFrom.EditValue = DateTime.Now;
            dateTo.EditValue = DateTime.Now;
            this.ClearLabel();
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {            
            try
            {
                lbNhap_NgayNhap.Text = gridView1.GetFocusedRowCellValue( "NewDocDate" ).ToString();
                lbXoa_NgayXoa.Text = gridView1.GetFocusedRowCellValue( "NewDocDate" ).ToString();
                lbMoi_NgayMoi.Text = gridView1.GetFocusedRowCellValue( "NewDocDate" ).ToString();
                lbXoaXuatLai_NewFrom.Text = gridView1.GetFocusedRowCellValue( "NewFromStore" ).ToString();
                lbXoaXuatLai_NewTo.Text = gridView1.GetFocusedRowCellValue( "NewToStore" ).ToString();
                lbXoaXuatLai_NgayChungTu.Text = gridView1.GetFocusedRowCellValue( "NewDocDate" ).ToString();
                lbXoaXuatLai_SoLuong.Text = gridView1.GetFocusedRowCellValue( "NewDocQty" ).ToString();
                lbXoaXuatLai_SoPhieu.Text = gridView1.GetFocusedRowCellValue( "NewDocNo" ).ToString();
                lbAction.Text = gridView1.GetFocusedRowCellValue( "Job" ).ToString();
                lbCreatedBy.Text = gridView1.GetFocusedRowCellValue( "CreatedBy" ).ToString();
                lbCuaHang.Text = gridView1.GetFocusedRowCellValue( "Store" ).ToString();
                lbNgayChungTu.Text = gridView1.GetFocusedRowCellValue( "DocDate" ).ToString();
                lbSoChungTu.Text = gridView1.GetFocusedRowCellValue( "DocNo" ).ToString();
                lbSoLuong.Text = gridView1.GetFocusedRowCellValue( "DocQty" ).ToString();
                lbType.Text = gridView1.GetFocusedRowCellValue( "DocType" ).ToString();
                txtNotes.Text = gridView1.GetFocusedRowCellValue( "Notes" ).ToString();
            }
            catch ( NullReferenceException ex )
            {

            }
            catch ( Exception ex )
            {

            }
        }

        private void btSearch_Click( object sender , EventArgs e )
        {
            try
            {
                string _type = "";

                if ( checkHoaDon.Checked == true )
                {
                    _type += "N'Hóa đơn',";
                }

                if ( checkPhieuNhap.Checked == true )
                {
                    _type += "N'Phiếu Nhập',";
                }

                if ( checkPhieuXuat.Checked == true )
                {
                    _type += "N'Phiếu xuất',";
                }

                string _fromDate = string.Format( "{0:dd/MM/yyyy}" , dateFrom.EditValue ).ToString();
                string _toDate = string.Format( "{0:dd/MM/yyyy}" , dateTo.EditValue ).ToString();

                _dalHoTroKyThuat = new cl_DAL_HoTroKyThuat();
                gridControl1.DataSource = _dalHoTroKyThuat.GetChinhSuaChungTuListByCondition( _fromDate , _toDate , _type.Substring(0, _type.Length -1) );
            }
            catch ( NullReferenceException ex )
            {

            }
            catch ( Exception ex )
            {

            }
        }

        #region Action
        private void ClearLabel()
        {
            lbNhap_NgayNhap.Text = "";
            lbXoa_NgayXoa.Text = "";
            lbMoi_NgayMoi.Text = "";
            lbXoaXuatLai_NewFrom.Text = "";
            lbXoaXuatLai_NewTo.Text = "";
            lbXoaXuatLai_NgayChungTu.Text = "";
            lbXoaXuatLai_SoLuong.Text = "";
            lbXoaXuatLai_SoPhieu.Text = "";
            lbAction.Text = "";
            lbCreatedBy.Text = "";
            lbCuaHang.Text = "";
            lbNgayChungTu.Text = "";
            lbSoChungTu.Text = "";
            lbSoLuong.Text = "";
            lbType.Text = "";
            txtNotes.Text = "";
        }
        #endregion
    }
}