using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DAL;

namespace VFC._IT
{
    public partial class frmIT_HoTroKyThuat_Create : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_Store _dalStore;
        cl_DAL_HoTroKyThuat _dalHoTro;
        DAL.Utilities.Transaction log;

        public frmIT_HoTroKyThuat_Create()
        {
            InitializeComponent();
        }

        private void frmIT_HoTroKyThuat_Create_Load( object sender , EventArgs e )
        {
            this.FillDataToStoreList();
        }

        private void btSave_Click( object sender , EventArgs e )
        {
            if ( this.iValidate().Equals( "" ) )
            {
                string _tempITHa = "";
                string _tempSLCham = "";
                string _tempITNhan = "";
                string _tempIT = "";

                if ( cbHuCPU.Checked == true )
                {
                    this.insertCase( 5 , "HAVM" );
                    _tempITHa += "5";
                }

                if ( cbHuDienThoai.Checked == true )
                {
                    this.insertCase( 2 , "HAVM" );
                    _tempITHa += "2";
                }

                if ( cbHuInternet.Checked == true )
                {
                    this.insertCase( 1 , "HAVM" );
                    _tempITHa += "1";
                }

                if ( cbCaiSoftwares.Checked == true )
                {
                    this.insertCase( 12 , "HAVM" );
                    _tempITHa += "a";
                }

                if ( cbHuMayIn.Checked == true )
                {
                    this.insertCase( 3 , "HAVM" );
                    _tempITHa += "3";
                }

                if ( cbHuRpro9.Checked == true )
                {
                    this.insertCase( 6 , cbbIT.SelectedItem.ToString() );
                    _tempIT += "6";
                }

                if ( cbKhongBanHangDuoc.Checked == true )
                {
                    this.insertCase( 9 , "NHANNT" );
                    _tempITNhan += "9";
                }

                if ( cbKhac.Checked == true )
                {
                    this.insertCase( 10 , "NHANNT" );
                    _tempITNhan += "0";
                }

                if ( cbSoLieuTonKhongDung.Checked == true )
                {
                    this.insertCase( 7 , "CHAMNV" );
                    _tempSLCham += "7";
                }

                if ( cbXoaNhapChinhNgay.Checked == true )
                {
                    this.insertCase( 8 , "NHANNT" );
                    _tempITNhan += "8";
                }

                if ( cbHuBarcode.Checked == true )
                {
                    this.insertCase( 4 , "HAVM" );
                    _tempITHa += "4";
                }

                this.sentSupporterMail( _tempIT , _tempITHa , _tempITNhan , _tempSLCham );
                this.Close();
            }
            else
            {
                XtraMessageBox.Show( this.iValidate() , "Lỗi !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
        }

        private void cbbStores_EditValueChanged( object sender , EventArgs e )
        {
            _dalStore = new cl_DAL_Store();

            try
            {
                string temp = _dalStore.getITFromStore( cbbStores.EditValue.ToString() );

                if ( temp.Equals( "NHANNT" ) )
                {
                    cbbIT.SelectedIndex = 0;
                }
                else if ( temp.Equals( "TAMNT" ) )
                {
                    cbbIT.SelectedIndex = 1;
                }
                else if ( temp.Equals( "NINHTTH" ) )
                {
                    cbbIT.SelectedIndex = 2;
                }
                else if ( temp.Equals( "THIENTC" ) )
                {
                    cbbIT.SelectedIndex = 3;
                }
                else if ( temp.Equals( "HAVM" ) )
                {
                    cbbIT.SelectedIndex = 4;
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        #region Action
        private void sentSupporterMail( string _it , string _ha , string _nhan , string _cham )
        {
            if ( _it.Length != 0 )
            {
                this.sendEmailHuPro9( cbbStores.EditValue.ToString() , cbbIT.SelectedItem.ToString() );
            }

            if ( _ha.Length != 0 )
            {
                string _listTask = "";

                for ( int i = 0 ; i < _ha.Length ; i++ )
                {
                    if ( _ha.Substring( i , 1 ) == "1" )
                    {
                        _listTask += "\t-\tSu co internet".Replace( "\t" , "    " ) + "%0d%0A";
                    }
                    else if ( _ha.Substring( i , 1 ) == "2" )
                    {
                        _listTask += "\t-\tHu dien thoai".Replace( "\t" , "    " ) + "%0d%0A";
                    }
                    else if ( _ha.Substring( i , 1 ) == "3" )
                    {
                        _listTask += "\t-\tHu may in bill".Replace( "\t" , "    " ) + "%0d%0A";
                    }
                    else if ( _ha.Substring( i , 1 ) == "4" )
                    {
                        _listTask += "\t-\tHu barcode scanner".Replace( "\t" , "    " ) + "%0d%0A";
                    }
                    else if ( _ha.Substring( i , 1 ) == "5" )
                    {
                        _listTask += "\t-\tHu CPU".Replace( "\t" , "    " ) + "%0d%0A";
                    }
                    else if ( _ha.Substring( i , 1 ) == "a" )
                    {
                        _listTask += "\t-\tYeu cau cai dat softwares : ".Replace( "\t" , "    " ) + txtCaiDatSoftwares.Text + "%0d%0A";
                    }
                }

                this.sendEmailHuHardware( cbbStores.EditValue.ToString() , "HAVM" , _listTask );
            }

            if ( _nhan.Length != 0 )
            {
                string _listTask = "";

                for ( int i = 0 ; i < _nhan.Length ; i++ )
                {
                    if ( _nhan.Substring( i , 1 ) == "8" )
                    {
                        _listTask += "\t-\tChinh sua chung tu.".Replace( "\t" , "    " ) + "%0d%0A";
                        _listTask += "\t\t-\tNoi dung : ".Replace( "\t" , "    " ) + txtXoaNhapChinhNgay.Text + "%0d%0A%0d%0A";
                    }
                    else if ( _nhan.Substring( i , 1 ) == "9" )
                    {
                        _listTask += "\t-\tKhong ban hang duoc (khong co ton kho)".Replace( "\t" , "    " ) + "%0d%0A";
                        _listTask += "\t\t-\tNoi dung : ".Replace( "\t" , "    " ) + txtKhongBanHangDuoc.Text + "%0d%0A%0d%0A";
                    }
                    else if ( _nhan.Substring( i , 1 ) == "0" )
                    {
                        _listTask += "\t-\tKhac".Replace( "\t" , "    " ) + "%0d%0A";
                        _listTask += "\t\t-\tNoi dung : ".Replace( "\t" , "    " ) + txtKhac.Text + "%0d%0A%0d%0A";
                    }
                }

                this.sendEmailHuNhan( cbbStores.EditValue.ToString() , "NHANNT" , _listTask );
            }

            if ( _cham.Length != 0 )
            {
                this.sendEmailHuTonKhoKhongDung( cbbStores.EditValue.ToString() , "CHAMNV" , txtSoLieuTonKhongDung.Text );
            }
        }

        private void insertCase( int _supportID , string _it )
        {
            log = new DAL.Utilities.Transaction();

            if ( this.iValidate().Equals( "" ) )
            {
                _dalHoTro = new cl_DAL_HoTroKyThuat();
                string _note = "";
                string _reasonSupport = "";

                if ( _supportID == 1 )
                {
                    _reasonSupport = "Hư internet";
                }

                if ( _supportID == 2 )
                {
                    _reasonSupport = "Hư điện thoại";
                }

                if ( _supportID == 3 )
                {
                    _reasonSupport = "Hư máy in";
                }

                if ( _supportID == 4 )
                {
                    _reasonSupport = "Hư barcode scanner";
                }

                if ( _supportID == 5 )
                {
                    _reasonSupport = "Hư CPU";
                }

                if ( _supportID == 6 )
                {
                    _reasonSupport = "Hư RPro9";
                }

                if ( _supportID == 7 )
                {
                    _note = txtSoLieuTonKhongDung.Text;
                    _reasonSupport = "Số tồn không đúng";
                }

                if ( _supportID == 8 )
                {
                    _note = txtXoaNhapChinhNgay.Text;
                    _reasonSupport = "Chỉnh sửa chứng từ";
                }

                if ( _supportID == 9 )
                {
                    _note = txtKhongBanHangDuoc.Text;
                    _reasonSupport = "Không bán hàng được (hàng không tồn trong kho)";
                }

                if ( _supportID == 10 )
                {
                    _note = txtKhac.Text;
                    _reasonSupport = "Khác";
                }

                if ( _supportID == 12 )
                {
                    _note = txtCaiDatSoftwares.Text;
                    _reasonSupport = "Cài đặt softwares";
                }

                if ( _dalHoTro.insert_HoTroKyThuat( cbbStores.EditValue.ToString() ,
                    _note ,
                    frmHO_Main._userLogin.UserName ,
                    _supportID ,
                    _it ) )
                {
                    log.record( "Insert Support ( " + _reasonSupport + " ) - " + cbbStores.EditValue.ToString() , "10" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo lỗi" , this.iValidate() , "error" );
            }
        }

        private string iValidate()
        {
            string rs = "";

            if ( cbbStores.EditValue == null )
            {
                rs += " + Bạn chưa chọn cửa hàng." + Environment.NewLine;
            }

            if ( cbKhongBanHangDuoc.Checked == true )
            {
                if ( txtKhongBanHangDuoc.Text.Equals( "" ) )
                {
                    rs += " + Bạn chưa nhập vào phần Note [Không bán hàng được] " + Environment.NewLine;
                }
            }

            if ( cbSoLieuTonKhongDung.Checked == true )
            {
                if ( txtSoLieuTonKhongDung.Text.Equals( "" ) )
                {
                    rs += " + Bạn chưa nhập vào phần Note [Số liệu tồn không đúng] " + Environment.NewLine;
                }
            }

            if ( cbXoaNhapChinhNgay.Checked == true )
            {
                if ( txtXoaNhapChinhNgay.Text.Equals( "" ) )
                {
                    rs += " + Bạn chưa nhập vào phần Note [Chỉnh sửa chứng từ] " + Environment.NewLine;
                }
            }

            if ( cbCaiSoftwares.Checked == true )
            {
                if ( txtCaiDatSoftwares.Text.Equals( "" ) )
                {
                    rs += " + Bạn chưa nhập vào phần Note [Cài đặt softwares] " + Environment.NewLine;
                }
            }

            if ( cbKhac.Checked == true )
            {
                if ( txtKhac.Text.Equals( "" ) )
                {
                    rs += " + Bạn chưa nhập vào phần Note [Khác] " + Environment.NewLine;
                }
            }

            return rs;
        }

        private void sendEmailHuPro9( string _store , string _it )
        {
            string _cc = _store + ";nhannt";
            string body = "Chao " + _it + "," + "%0d%0A %0d%0A";

            body += "Cua hang " + _store + " da bi hu Rpro9. Vui long kiem tra va xu ly.";
            body += "%0d%0A%0d%0ARegards,";
            Process.Start( "mailto:" + _it + "?subject=Xu ly may hu RPro9 - " + _store + ",&cc=" + _cc + "&body=" + body );
        }

        private void sendEmailHuTonKhoKhongDung( string _store , string _it , string _noidung )
        {
            string _cc = _store + ";nhannt";
            string body = "Chao " + _it + "," + "%0d%0A %0d%0A";

            body += "Cua hang " + _store + " ton kho khong dung. Vui long kiem tra lai so lieu dau ky." + " Noi dung : ".Replace( "\t" , "    " ) + _noidung + "%0d%0A%0d%0A";
            body += "\t-\tNeu ton dau ky da dung. Vui long yeu cau IT Phu Trach cap nhat ton kho.".Replace( "\t" , "    " );

            body += "%0d%0A%0d%0ARegards,";
            Process.Start( "mailto:" + _it + "?subject=Xu ly so ton khong dung - " + _store + ",&cc=" + _cc + "&body=" + body );
        }

        private void sendEmailHuHardware( string _store , string _it , string _body )
        {
            string _cc = _store + ";nhannt";
            string body = "Chao " + _it + "," + "%0d%0A %0d%0A";

            body += "Cua hang " + _store + " da bi cac su co sau : " + "%0d%0A";
            body += _body + "%0d%0A";
            body += "Vui long kiem tra va xu ly cho cua hang.";

            body += "%0d%0A%0d%0ARegards,";
            Process.Start( "mailto:" + _it + "?subject=Xu ly may hu - " + _store + ",&cc=" + _cc + "&body=" + body );
        }

        private void sendEmailHuNhan( string _store , string _it , string _body )
        {
            string _cc = _store;
            string body = "Chao " + _it + "," + "%0d%0A %0d%0A";

            body += "Cua hang " + _store + " co cac su co sau : " + "%0d%0A";
            body += _body;
            body += "Vui long kiem tra va xu ly cho cua hang.";

            body += "%0d%0A%0d%0ARegards,";
            Process.Start( "mailto:" + _it + "?subject=Xu ly su co - " + _store + ",&cc=" + _cc + "&body=" + body );
        }

        private void FillDataToStoreList()
        {
            cl_DAL_Store _dalStore = new cl_DAL_Store();

            cbbStores.Properties.DataSource = _dalStore.returnORA_AllStoreCode();
        }
        #endregion
    }
}