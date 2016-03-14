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
    public partial class frmIT_ChinhSuaChungTu : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_HoTroKyThuat _dalHoTro;
        cl_DAL_Store _dalStore;
        DAL.Utilities.Transaction log;

        public frmIT_ChinhSuaChungTu()
        {
            InitializeComponent();
        }

        private void frmIT_ChinhSuaChungTu_Load( object sender , EventArgs e )
        {
            this.FillDataToStore();
        }

        private void cbbStores_EditValueChanged( object sender , EventArgs e )
        {
            lbFrom.Text = cbbStores.EditValue.ToString();
        }

        private void btSave_Click( object sender , EventArgs e )
        {
            log = new DAL.Utilities.Transaction();

            if ( this.iValidate().Equals( "" ) )
            {
                if ( rdNhap.Checked == true )
                {
                    if ( this.updateEditDocument( "Nhap" ) )
                    {
                        XtraMessageBox.Show( "Lưu thành công." , "Thông báo," , MessageBoxButtons.OK , MessageBoxIcon.Information );

                        log.record( "Nhập phiếu ( " + this.getDocType() + " ) - " + cbbStores.EditValue.ToString() + " -"
                            + " SP : " + txtInfoSoPhieu.Text + " -"
                            + " SLg : " + txtInfoSoLuong.Text + " -"
                            + " Old_Date : " + this.makeDateString( dateInfo.EditValue.ToString() ) + " -"
                            + " New_Date : " + this.makeDateString( dateNhap.EditValue.ToString() ) , "9" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                        this.AfterSave();
                    }
                    else
                    {
                        XtraMessageBox.Show( "Lưu thất bại. Xin vui lòng thử lại." , "Thông báo," , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
                else if ( rdXoa.Checked == true )
                {
                    if ( this.updateEditDocument( "Xoa" ) )
                    {
                        XtraMessageBox.Show( "Lưu thành công." , "Thông báo," , MessageBoxButtons.OK , MessageBoxIcon.Information );

                        log.record( "Xóa phiếu ( " + this.getDocType() + " ) - " + cbbStores.EditValue.ToString() + " -"
                            + " SP : " + txtInfoSoPhieu.Text + " -"
                            + " SLg : " + txtInfoSoLuong.Text + " -"
                            + " Old_Date : " + this.makeDateString( dateInfo.EditValue.ToString() ) + " -"
                            + " New_Date : " + this.makeDateString( dateXoa.EditValue.ToString() ) , "9" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                        this.AfterSave();
                    }
                    else
                    {
                        XtraMessageBox.Show( "Lưu thất bại. Xin vui lòng thử lại." , "Thông báo," , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
                else if ( rdEdit.Checked == true )
                {
                    if ( this.updateEditDocument( "Chinh" ) )
                    {
                        XtraMessageBox.Show( "Lưu thành công." , "Thông báo," , MessageBoxButtons.OK , MessageBoxIcon.Information );

                        log.record( "Chỉnh ngày nhập " + this.getDocType() + "- " + cbbStores.EditValue.ToString() + " -"
                            + " SP : " + txtInfoSoPhieu.Text + " -"
                            + " SLg : " + txtInfoSoLuong.Text + " -"
                            + " Old_Date : " + this.makeDateString( dateInfo.EditValue.ToString() ) + " -"
                            + " New_Date : " + this.makeDateString( dateChinhNgayMoi.EditValue.ToString() ) , "9" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                        this.AfterSave();
                    }
                    else
                    {
                        XtraMessageBox.Show( "Lưu thất bại. Xin vui lòng thử lại." , "Thông báo," , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
                else
                {
                    if ( this.updateEditDocument( "XoaXuatLai" ) )
                    {
                        XtraMessageBox.Show( "Lưu thành công." , "Thông báo," , MessageBoxButtons.OK , MessageBoxIcon.Information );

                        log.record( "Xóa - Xuất lại ( " + this.getDocType() + " ) - " + cbbStores.EditValue.ToString() + " -"
                            + " OLD_SP : " + txtInfoSoPhieu.Text + " -"
                            + " OLD_SLg : " + txtInfoSoLuong.Text + " -"
                            + " Old_Date : " + this.makeDateString( dateInfo.EditValue.ToString() ) + " -"
                            + " NEW_SP : " + txtNewSoPhieu.Text + " -"
                            + " NEW_SLg : " + txtNewSoLuong.Text + " -"
                            + " NEW_Store : " + cbbNewToStore.EditValue.ToString() + " -"
                            + " New_Date : " + this.makeDateString( dateNew.EditValue.ToString() ) , "9" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                        this.AfterSave();
                    }
                    else
                    {
                        XtraMessageBox.Show( "Lưu thất bại. Xin vui lòng thử lại." , "Thông báo," , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
            }
            else
            {
                XtraMessageBox.Show( this.iValidate() , "Thông báo," , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
        }

        private void rdNhap_CheckedChanged( object sender , EventArgs e )
        {
            if ( rdNhap.Checked == true )
            {
                xTabNhap.Show();
                rdSlip.Enabled = true;
                rdInvoice.Enabled = false;
                rdSlip.Checked = true;
                rdVoucher.Enabled = false;
            }
            else
            {

            }
        }

        private void rdXoa_CheckedChanged( object sender , EventArgs e )
        {
            if ( rdXoa.Checked == true )
            {
                xTabXoa.Show();
                rdInvoice.Enabled = true;
                rdSlip.Enabled = true;
                rdVoucher.Enabled = false;
                rdSlip.Checked = true;
            }
            else
            {

            }
        }

        private void rdEdit_CheckedChanged( object sender , EventArgs e )
        {
            if ( rdEdit.Checked == true )
            {
                xTabEdit.Show();
                rdInvoice.Enabled = true;
                rdSlip.Enabled = true;
                rdVoucher.Enabled = true;
                rdSlip.Checked = true;
            }
            else
            {

            }
        }

        private void rdXoaXuatLai_CheckedChanged( object sender , EventArgs e )
        {
            if ( rdXoaXuatLai.Checked == true )
            {
                xTabXoaXuatLai.Show();
                rdInvoice.Enabled = false;
                rdSlip.Enabled = true;
                rdVoucher.Enabled = false;
                rdSlip.Checked = true;
            }
            else
            {

            }
        }

        #region Action
        private void AfterSave()
        {
            txtNotes.Text = "";
            txtInfoSoLuong.Text = "";
            txtInfoSoPhieu.Text = "";
            dateInfo.EditValue = "";
            dateNew.EditValue = "";
            dateXoa.EditValue = "";
            dateChinhNgayMoi.EditValue = "";
            dateNhap.EditValue = "";
            txtNewSoLuong.Text = "";
            txtNewSoPhieu.Text = "";
        }

        private void FillDataToStore()
        {
            _dalStore = new cl_DAL_Store();
            cbbStores.Properties.DataSource = _dalStore.returnORA_AllStoreCode();
            cbbNewToStore.Properties.DataSource = _dalStore.returnORA_AllStoreCode();
        }

        private string iValidate()
        {
            string rs = "";

            if ( cbbStores.EditValue == null )
            {
                rs += " + Bạn chưa chọn cửa hàng." + Environment.NewLine;
            }
            if ( txtInfoSoPhieu.Text.Equals( "" ) )
            {
                rs += " + Chưa nhập số phiếu." + Environment.NewLine;
            }
            if ( txtInfoSoLuong.Text.Equals( "" ) )
            {
                rs += " + Chưa nhập số lượng." + Environment.NewLine;
            }
            if ( dateInfo.EditValue == null )
            {
                rs += " + Chưa chọn ngày chứng từ." + Environment.NewLine;
            }

            if ( rdNhap.Checked == true )
            {
                if ( dateNhap.EditValue == null )
                {
                    rs += " + Chưa chọn ngày nhập mới." + Environment.NewLine;
                }
            }
            else if ( rdXoa.Checked == true )
            {
                if ( dateXoa.EditValue == null )
                {
                    rs += " + Chưa chọn ngày xóa." + Environment.NewLine;
                }
            }
            else if ( rdEdit.Checked == true )
            {
                if ( dateChinhNgayMoi.EditValue == null )
                {
                    rs += " + Chưa chọn ngày chỉnh sửa mới." + Environment.NewLine;
                }
            }
            else
            {
                if ( dateNew.EditValue == null )
                {
                    rs += " + Chưa chọn ngày xuất mới." + Environment.NewLine;
                }
                if ( txtNewSoLuong.Text.Equals( "" ) )
                {
                    rs += " + Chưa nhập số lượng mới." + Environment.NewLine;
                }
                if ( txtNewSoPhieu.Text.Equals( "" ) )
                {
                    rs += " + Chưa nhập số phiếu mới." + Environment.NewLine;
                }
                if ( dateNew.EditValue == null )
                {
                    rs += " + Chưa nhập ngày xuất mới." + Environment.NewLine;
                }
            }

            return rs;
        }

        private bool updateEditDocument( string _status )
        {
            bool flag = false;
            _dalHoTro = new cl_DAL_HoTroKyThuat();

            try
            {
                if ( _status.Equals( "Nhap" ) )
                {
                    if ( _dalHoTro.insert_NhapXoaPhieu_Nhap( cbbStores.EditValue.ToString() ,
                        this.makeDateString( dateInfo.EditValue.ToString() ) ,
                        int.Parse( txtInfoSoLuong.Text ) ,
                        int.Parse( txtInfoSoPhieu.Text ) ,
                        frmHO_Main._userLogin.UserName ,
                        "Nhập phiếu" ,
                        this.makeDateString( dateNhap.EditValue.ToString() ) ,
                        txtNotes.Text ,
                        this.getDocType() ) )
                    {
                        return flag = true;
                    }
                    else
                    {
                        return flag = false;
                    }
                }
                else if ( _status.Equals( "Xoa" ) )
                {
                    if ( _dalHoTro.insert_NhapXoaPhieu_Xoa( cbbStores.EditValue.ToString() ,
                        this.makeDateString( dateInfo.EditValue.ToString() ) ,
                        int.Parse( txtInfoSoLuong.Text ) ,
                        int.Parse( txtInfoSoPhieu.Text ) ,
                        frmHO_Main._userLogin.UserName ,
                        this.getDocType() ,
                        this.makeDateString( dateXoa.EditValue.ToString() ) ,
                        txtNotes.Text ,
                        "Xóa phiếu" ) )
                    {
                        return flag = true;
                    }
                    else
                    {
                        return flag = false;
                    }
                }
                else if ( _status.Equals( "Chinh" ) )
                {
                    if ( _dalHoTro.insert_NhapXoaPhieu_Chinh( cbbStores.EditValue.ToString() ,
                        this.makeDateString( dateInfo.EditValue.ToString() ) ,
                        int.Parse( txtInfoSoLuong.Text ) ,
                        int.Parse( txtInfoSoPhieu.Text ) ,
                        frmHO_Main._userLogin.UserName ,
                        this.getDocType() ,
                        this.makeDateString( dateChinhNgayMoi.EditValue.ToString() ) ,
                        txtNotes.Text ,
                        "Chỉnh ngày nhập" ) )
                    {
                        return flag = true;
                    }
                    else
                    {
                        return flag = false;
                    }
                }
                else if ( _status.Equals( "XoaXuatLai" ) )
                {
                    if ( _dalHoTro.insert_NhapXoaPhieu_XoaXuatLai( cbbStores.EditValue.ToString() ,
                        this.makeDateString( dateInfo.EditValue.ToString() ) ,
                        int.Parse( txtInfoSoLuong.Text ) ,
                        int.Parse( txtInfoSoPhieu.Text ) ,
                        frmHO_Main._userLogin.UserName ,
                        "Xóa - Xuất lại" ,
                        this.makeDateString( dateNew.EditValue.ToString() ) ,
                        txtNotes.Text ,
                        int.Parse( txtNewSoPhieu.Text ) ,
                        int.Parse( txtNewSoLuong.Text ) ,
                        cbbNewToStore.EditValue.ToString() ,
                        this.getDocType() ) )
                    {
                        return flag = true;
                    }
                    else
                    {
                        return flag = false;
                    }
                }
            }
            catch ( Exception ex )
            {
                return flag = false;
            }

            return flag;
        }

        private string makeDateString( string _date )
        {
            string _rs = _date.Substring( 6 , 4 ) + "/" + _date.Substring( 3 , 2 ) + "/" + _date.Substring( 0 , 2 );

            return _rs;
        }

        private string getDocType()
        {
            string _rs = "";

            if ( rdVoucher.Checked == true )
            {
                _rs = "Phiếu Nhập";
            }
            else if ( rdInvoice.Checked == true )
            {
                _rs = "Hóa đơn";
            }
            else
            {
                _rs = "Phiếu xuất";
            }

            return _rs;
        }
        #endregion

        private void cbbNewToStore_EditValueChanged( object sender , EventArgs e )
        {

        }
    }
}