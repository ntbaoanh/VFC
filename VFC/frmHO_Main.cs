using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DAL;
using PRO;

namespace VFC
{
    public partial class frmHO_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static cl_PRO_User _userLogin;
        public static string _sysadmin;
        public static string _serverImageUrl;
        public static bool _flagOverride;
        cl_DAL_User _dalUser;

        public frmHO_Main()
        {
            InitializeComponent();
        }

        #region Create Form        
        private static _Rap.frm_Rap_NhanDoSua frmNhanDoSua;
        private static _Rap.frm_Rap_TraDoSua frmTraDoSua;
        private static _Rap.frm_Rap_TonKhoDoSua frmTonKhoDoSua;
        private static _Rap.frm_Rap_InLaiChungTu frmRapInLai;
        private static _Rap.frm_Rap_Xem_NXT_TheoThang frmNXTTheoThang;
        private static _Sale.frmSale_XemDoanhThu_Region frmSale_XemDoanhThuRegion;
        private static _Sale.frmSale_XemDoanhThu_Store frmSale_XemDoanhThuStore;
        private static _PromotionCode.frmProCode_UseCode frmProCodeUseCode;
        private static _PromotionCode.frmProCode_Export_UsedCode frmProCode_ExportUsedCode;
        private static _PromotionCode.frmProCode_GenerateProCode frmProCode_GenerateCode;
        private static _PromotionCode.frmProCode_GetCode frmProCode_GetCode;
        private static _PromotionCode.frmProCode_LookUp frmProCode_LookUp;
        private static _PromotionCode.frmProCode_Export_Code frmProCode_ExportCode;
        private static _PromotionCode.frmProCode_PartNumberSummary frmProCode_PartNumberSummary;
        private static _PromotionCode.frmProCode_HoldCode frmProCode_HoldCode;
        private static _PromotionCode.frmProCode_ReleaseCode frmProCode_ReleaseCode;
        private static _IT.frmIT_ViewLogs frmIT_ViewLogs;
        private static _IT.frmIT_HoTroKyThuat_Create frmIT_TaoMoHoTro;
        private static _IT.frmIT_HoTroKyThuat_XuLy frmIT_XuLyHoTro;
        private static _IT.frmIT_ChinhSuaChungTu frmIT_ChinhSuaChungTu;
        private static _IT.frmIT_ChinhSuaChungTu_History frmIT_ChinhSuaChungTu_History;
        private static Encryption frmEncrypt;
        private static _IT.frmIT_CapNhatTonKho frmIT_CapNhatTonKho;
        private static _SoLieu.frmSoLieu_TaoMoiCapNhatTonKho frmSoLieu_TaoMoiCapNhatTonKho;
        private static _SoLieu.frmSoLieu_XuLyCLKK frmSoLieu_XuLyCLKK;
        private static _Customer.frmCust_CustomerExport frmCust_Export;
        private static _Message.frmMessage_Manage frmManageMessage;
        private static _Message.frmMessage_Push frmPushMessage;
        private static _Merchandise.frmMER_MTK_Info frmQuanLyMTK;
        private static _Merchandise.frm_InMaVach_FillData frmInMaVach;
        private static frmPOS_Main frmPOS_Main;
        private static _Admin.ChangePassword frmChangePass;
        private static _CTKM.frm_CTKM_Generate_XXX frmGenerateXXX;
        private static _Vai.frmVai_Manage frmManageVai;
        private static _NhaCungCap.frmNCC_NhaCungCap_Manage frmManage_NCC;
        private static _NhanSu.frmNS_NVBH_QuanLy frmNS_NVBH_Manage;
        #endregion

        public static bool showMenu = false;
        public static DevExpress.XtraBars.Ribbon.RibbonPage rbmenu;
        public static DevExpress.XtraBars.Ribbon.RibbonPage rbActive;

        private void frmHO_Main_FormClosed( object sender , FormClosedEventArgs e )
        {
            Application.Exit();
        }

        private void frmHO_Main_Load( object sender , EventArgs e )
        {
            lbUserLogin.Caption = _userLogin.UserName;
            lbComputerName.Caption = System.Environment.MachineName.ToString();
            _dalUser = new cl_DAL_User();
            _sysadmin = "NHANNT";

            if ( frmHO_Main._userLogin.ForceChangePass.ToString().Trim().Equals( "0" ) )
            {
                frmChangePass = new _Admin.ChangePassword();
                frmChangePass.ShowDialog();
            }
        }

        private void bt_User_LogOut_ItemClick( object sender , ItemClickEventArgs e )
        {
            _Admin.frmLogin frmLogin = new _Admin.frmLogin();
            frmLogin.Show();
            this.Dispose();            
        }

        private void bt_User_Quit_ItemClick( object sender , ItemClickEventArgs e )
        {
            Application.Exit();
        }

        private void bt_ProCode_UseCode_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "20" ) )
            {
                rbActive = ribbonPage_CS;
                if ( frmProCodeUseCode == null || frmProCodeUseCode.IsDisposed )
                {
                    frmProCodeUseCode = new _PromotionCode.frmProCode_UseCode();
                    frmProCodeUseCode.MdiParent = this;
                    frmProCodeUseCode.Show();
                }
                else
                {
                    frmProCodeUseCode.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [20]" , "error" );
            }
        }

        private void bt_Rap_NhanDoSua_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "4" ) )
            {
                rbActive = ribbonPage_Rap;
                if ( frmNhanDoSua == null || frmNhanDoSua.IsDisposed )
                {
                    frmNhanDoSua = new _Rap.frm_Rap_NhanDoSua();
                    frmNhanDoSua.MdiParent = this;
                    frmNhanDoSua.Show();
                }
                else
                {
                    frmNhanDoSua.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [4]" , "error" );
            }
        }

        private void bt_Rap_TraDoSua_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "6" ) )
            {
                rbActive = ribbonPage_Rap;
                if ( frmTraDoSua == null || frmTraDoSua.IsDisposed )
                {
                    frmTraDoSua = new _Rap.frm_Rap_TraDoSua();
                    frmTraDoSua.MdiParent = this;
                    frmTraDoSua.Show();
                }
                else
                {
                    frmTraDoSua.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [6]" , "error" );
            }
        }

        private void bt_RAP_TonKhoDoSua_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "25" ) )
            {
                rbActive = ribbonPage_Rap;
                if ( frmTonKhoDoSua == null || frmTonKhoDoSua.IsDisposed )
                {
                    frmTonKhoDoSua = new _Rap.frm_Rap_TonKhoDoSua();
                    frmTonKhoDoSua.MdiParent = this;
                    frmTonKhoDoSua.Show();
                }
                else
                {
                    frmTonKhoDoSua.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [25]" , "error" );
            }
        }

        private void bt_Rap_InLaiChungTu_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "25" ) )
            {
                rbActive = ribbonPage_Rap;
                if ( frmRapInLai == null || frmRapInLai.IsDisposed )
                {
                    frmRapInLai = new _Rap.frm_Rap_InLaiChungTu();
                    frmRapInLai.MdiParent = this;
                    frmRapInLai.Show();
                }
                else
                {
                    frmRapInLai.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [25]" , "error" );
            }
        }

        private void bt_Sale_XemDoanhThuRegion_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "15" ) )
            {
                rbActive = ribbonPage_Sale;
                if ( frmSale_XemDoanhThuRegion == null || frmSale_XemDoanhThuRegion.IsDisposed )
                {
                    frmSale_XemDoanhThuRegion = new _Sale.frmSale_XemDoanhThu_Region();
                    frmSale_XemDoanhThuRegion.MdiParent = this;
                    frmSale_XemDoanhThuRegion.Show();
                }
                else
                {
                    frmSale_XemDoanhThuRegion.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [15]" , "error" );
            }
        }

        private void bt_Sale_XemDoanhThu_CuaHang_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "14" ) )
            {
                rbActive = ribbonPage_Sale;
                if ( frmSale_XemDoanhThuStore == null || frmSale_XemDoanhThuStore.IsDisposed )
                {
                    frmSale_XemDoanhThuStore = new _Sale.frmSale_XemDoanhThu_Store();
                    frmSale_XemDoanhThuStore.MdiParent = this;
                    frmSale_XemDoanhThuStore.Show();
                }
                else
                {
                    frmSale_XemDoanhThuStore.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [14]" , "error" );
            }
        }

        private void bt_ProCode_GetCode_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "18" ) )
            {
                rbActive = ribbonPage_CS;
                if ( frmProCode_GetCode == null || frmProCode_GetCode.IsDisposed )
                {
                    frmProCode_GetCode = new _PromotionCode.frmProCode_GetCode();
                    frmProCode_GetCode.MdiParent = this;
                    frmProCode_GetCode.Show();
                }
                else
                {
                    frmProCode_GetCode.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [18]" , "error" );
            }
        }

        private void bt_ProCode_ExportUsedCode_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "26" ) )
            {
                rbActive = ribbonPage_CS;
                if ( frmProCode_ExportUsedCode == null || frmProCode_ExportUsedCode.IsDisposed )
                {
                    frmProCode_ExportUsedCode = new _PromotionCode.frmProCode_Export_UsedCode();
                    frmProCode_ExportUsedCode.MdiParent = this;
                    frmProCode_ExportUsedCode.Show();
                }
                else
                {
                    frmProCode_ExportUsedCode.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [26]" , "error" );
            }
        }

        private void bt_IT_GenerateProCode_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "17" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmProCode_GenerateCode == null || frmProCode_GenerateCode.IsDisposed )
                {
                    frmProCode_GenerateCode= new _PromotionCode.frmProCode_GenerateProCode();
                    frmProCode_GenerateCode.MdiParent = this;
                    frmProCode_GenerateCode.Show();
                }
                else
                {
                    frmProCode_GenerateCode.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [17]" , "error" );
            }
        }

        private void bt_ProCode_LookUpCode_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "28" ) )
            {
                rbActive = ribbonPage_CS;
                if ( frmProCode_LookUp == null || frmProCode_LookUp.IsDisposed )
                {
                    frmProCode_LookUp = new _PromotionCode.frmProCode_LookUp();
                    frmProCode_LookUp.MdiParent = this;
                    frmProCode_LookUp.Show();
                }
                else
                {
                    frmProCode_LookUp.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [28]" , "error" );
            }
        }

        private void bt_ProCode_HoldCode_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "21" ) )
            {
                rbActive = ribbonPage_CS;
                if ( frmProCode_HoldCode == null || frmProCode_HoldCode.IsDisposed )
                {
                    frmProCode_HoldCode = new _PromotionCode.frmProCode_HoldCode();
                    frmProCode_HoldCode.MdiParent = this;
                    frmProCode_HoldCode.Show();
                }
                else
                {
                    frmProCode_HoldCode.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [21]" , "error" );
            }
        }

        private void bt_ProCode_ReleaseCode_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "22" ) )
            {
                rbActive = ribbonPage_CS;
                if ( frmProCode_ReleaseCode == null || frmProCode_ReleaseCode.IsDisposed )
                {
                    frmProCode_ReleaseCode = new _PromotionCode.frmProCode_ReleaseCode();
                    frmProCode_ReleaseCode.MdiParent = this;
                    frmProCode_ReleaseCode.Show();
                }
                else
                {
                    frmProCode_ReleaseCode.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [22]" , "error" );
            }
        }

        private void bt_ProCode_ExportCode_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "16" ) )
            {
                rbActive = ribbonPage_CS;
                if ( frmProCode_ExportCode == null || frmProCode_ExportCode.IsDisposed )
                {
                    frmProCode_ExportCode = new _PromotionCode.frmProCode_Export_Code();
                    frmProCode_ExportCode.MdiParent = this;
                    frmProCode_ExportCode.Show();
                }
                else
                {
                    frmProCode_ExportCode.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [16]" , "error" );
            }
        }

        private void bt_IT_PartNumberSummary_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "23" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmProCode_PartNumberSummary == null || frmProCode_PartNumberSummary.IsDisposed )
                {
                    frmProCode_PartNumberSummary = new _PromotionCode.frmProCode_PartNumberSummary();
                    frmProCode_PartNumberSummary.MdiParent = this;
                    frmProCode_PartNumberSummary.Show();
                }
                else
                {
                    frmProCode_PartNumberSummary.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [23]" , "error" );
            }
        }

        private void bt_IT_ViewLogs_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "29" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmIT_ViewLogs == null || frmIT_ViewLogs.IsDisposed )
                {
                    frmIT_ViewLogs = new _IT.frmIT_ViewLogs();
                    frmIT_ViewLogs.MdiParent = this;
                    frmIT_ViewLogs.Show();
                }
                else
                {
                    frmIT_ViewLogs.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [29]" , "error" );
            }
        }

        private void bt_IT_HoTro_Create_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "8" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmIT_TaoMoHoTro == null || frmIT_TaoMoHoTro.IsDisposed )
                {
                    frmIT_TaoMoHoTro = new _IT.frmIT_HoTroKyThuat_Create();
                    frmIT_TaoMoHoTro.MdiParent = this;
                    frmIT_TaoMoHoTro.Show();
                }
                else
                {
                    frmIT_TaoMoHoTro.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [8]" , "error" );
            }
        }

        private void bt_IT_HoTro_XuLy_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "7" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmIT_XuLyHoTro == null || frmIT_XuLyHoTro.IsDisposed )
                {
                    frmIT_XuLyHoTro = new _IT.frmIT_HoTroKyThuat_XuLy();
                    frmIT_XuLyHoTro.MdiParent = this;
                    frmIT_XuLyHoTro.Show();
                }
                else
                {
                    frmIT_XuLyHoTro.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [7]" , "error" );
            }
        }

        private void bt_IT_ChinhSuaChungTu_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "9" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmIT_ChinhSuaChungTu == null || frmIT_ChinhSuaChungTu.IsDisposed )
                {
                    frmIT_ChinhSuaChungTu = new _IT.frmIT_ChinhSuaChungTu();
                    frmIT_ChinhSuaChungTu.MdiParent = this;
                    frmIT_ChinhSuaChungTu.Show();
                }
                else
                {
                    frmIT_ChinhSuaChungTu.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [9]" , "error" );
            }
        }

        private void bt_IT_ChinhSuaChungTu_Edit_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "9" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmIT_ChinhSuaChungTu_History == null || frmIT_ChinhSuaChungTu_History.IsDisposed )
                {
                    frmIT_ChinhSuaChungTu_History = new _IT.frmIT_ChinhSuaChungTu_History();
                    frmIT_ChinhSuaChungTu_History.MdiParent = this;
                    frmIT_ChinhSuaChungTu_History.Show();
                }
                else
                {
                    frmIT_ChinhSuaChungTu_History.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [9]" , "error" );
            }
        }

        private void bt_IT_CapNhatTonKho_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "1" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmIT_CapNhatTonKho == null || frmIT_CapNhatTonKho.IsDisposed )
                {
                    frmIT_CapNhatTonKho = new _IT.frmIT_CapNhatTonKho();
                    frmIT_CapNhatTonKho.MdiParent = this;
                    frmIT_CapNhatTonKho.Show();
                }
                else
                {
                    frmIT_CapNhatTonKho.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [1]" , "error" );
            }
        }

        private void bt_SoLieu_TaoMoiCapNhatTonKho_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "13" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmSoLieu_TaoMoiCapNhatTonKho == null || frmSoLieu_TaoMoiCapNhatTonKho.IsDisposed )
                {
                    frmSoLieu_TaoMoiCapNhatTonKho = new _SoLieu.frmSoLieu_TaoMoiCapNhatTonKho();
                    frmSoLieu_TaoMoiCapNhatTonKho.MdiParent = this;
                    frmSoLieu_TaoMoiCapNhatTonKho.Show();
                }
                else
                {
                    frmSoLieu_TaoMoiCapNhatTonKho.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [13]" , "error" );
            }
        }

        private void bt_SoLieu_XuLyCLKK_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "12" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmSoLieu_XuLyCLKK == null || frmSoLieu_XuLyCLKK.IsDisposed )
                {
                    frmSoLieu_XuLyCLKK = new _SoLieu.frmSoLieu_XuLyCLKK();
                    frmSoLieu_XuLyCLKK.MdiParent = this;
                    frmSoLieu_XuLyCLKK.Show();
                }
                else
                {
                    frmSoLieu_XuLyCLKK.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [12]" , "error" );
            }
        }

        private void bt_CS_Customer_Export_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "19" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmCust_Export == null || frmCust_Export.IsDisposed )
                {
                    frmCust_Export = new _Customer.frmCust_CustomerExport();
                    frmCust_Export.MdiParent = this;
                    frmCust_Export.Show();
                }
                else
                {
                    frmCust_Export.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [19]" , "error" );
            }
        }

        private void bt_VFCPOS_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( frmPOS_Main == null || frmPOS_Main.IsDisposed )
            {
                frmPOS_Main = new frmPOS_Main();
                frmPOS_Main.Show();
            }
            else
            {
                frmPOS_Main.Activate();
            }
        }
        
        private void bt_Admin_SystemMessage_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals(_sysadmin) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "30" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmManageMessage == null || frmManageMessage.IsDisposed )
                {
                    frmManageMessage = new _Message.frmMessage_Manage();
                    frmManageMessage.MdiParent = this;
                    frmManageMessage.Show();
                }
                else
                {
                    frmManageMessage.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [30]" , "error" );
            }
        }

        private void bt_Systen_PushMessage_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "32" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmPushMessage == null || frmPushMessage.IsDisposed )
                {
                    frmPushMessage = new _Message.frmMessage_Push();
                    frmPushMessage.MdiParent = this;
                    frmPushMessage.Show();
                }
                else
                {
                    frmPushMessage.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [32]" , "error" );
            }
        }

        private void bt_Mer_MTK_Manage_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "35" ) )
            {
                rbActive = ribbonPage_Merchandise;
                if ( frmQuanLyMTK == null || frmQuanLyMTK.IsDisposed )
                {
                    frmQuanLyMTK = new _Merchandise.frmMER_MTK_Info();
                    frmQuanLyMTK.MdiParent = this;
                    frmQuanLyMTK.Show();
                }
                else
                {
                    frmQuanLyMTK.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [35]" , "error" );
            }
        }

        private void bt_User_ChangePassword_ItemClick( object sender , ItemClickEventArgs e )
        {
            frmChangePass = new _Admin.ChangePassword();
            frmChangePass.ShowDialog();
        }
        
        private void bt_RAP_NXT_THeoThang_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "37" ) )
            {
                rbActive = ribbonPage_Rap;
                if ( frmNXTTheoThang == null || frmNXTTheoThang.IsDisposed )
                {
                    frmNXTTheoThang = new _Rap.frm_Rap_Xem_NXT_TheoThang();
                    frmNXTTheoThang.MdiParent = this;
                    frmNXTTheoThang.Show();
                }
                else
                {
                    frmNXTTheoThang.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [37]" , "error" );
            }
        }

        private void btEncryption_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "-1" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmEncrypt == null || frmEncrypt.IsDisposed )
                {
                    frmEncrypt = new Encryption();
                    frmEncrypt.MdiParent = this;
                    frmEncrypt.Show();
                }
                else
                {
                    frmEncrypt.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [-1]" , "error" );
            }
        }

        private void bt_MER_InMaVach_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( lbUserLogin.Caption.Equals( _sysadmin ) || _dalUser.checkUserRole( lbUserLogin.Caption.ToString() , "38" ) )
            {
                rbActive = ribbonPage_IT;
                if ( frmInMaVach == null || frmInMaVach.IsDisposed )
                {
                    frmInMaVach = new _Merchandise.frm_InMaVach_FillData();
                    frmInMaVach.MdiParent = this;
                    frmInMaVach.Show();
                }
                else
                {
                    frmInMaVach.Activate();
                }
            }
            else
            {
                frmMessageBox.Show( "Thông báo" , "Bạn chưa có quyền sử dụng module này. [38]" , "error" );
            }
        }

        private void btGenerateXXX_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lbUserLogin.Caption.Equals(_sysadmin) || _dalUser.checkUserRole(lbUserLogin.Caption.ToString(), "-1"))
            {
                rbActive = ribbonPage_IT;
                if (frmGenerateXXX == null || frmGenerateXXX.IsDisposed)
                {
                    frmGenerateXXX = new _CTKM.frm_CTKM_Generate_XXX();
                    frmGenerateXXX.MdiParent = this;
                    frmGenerateXXX.Show();
                }
                else
                {
                    frmGenerateXXX.Activate();
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", "Bạn chưa có quyền sử dụng module này. [-1]", "error");
            }
        }

        private void bt_TK_NhaCungCap_QLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lbUserLogin.Caption.Equals(_sysadmin) || _dalUser.checkUserRole(lbUserLogin.Caption.ToString(), "43"))
            {
                rbActive = ribbonPage_TK;
                if (frmManage_NCC == null || frmManage_NCC.IsDisposed)
                {
                    frmManage_NCC = new _NhaCungCap.frmNCC_NhaCungCap_Manage();
                    frmManage_NCC.MdiParent = this;
                    frmManage_NCC.Show();
                }
                else
                {
                    frmManage_NCC.Activate();
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", "Bạn chưa có quyền sử dụng module này. [43]", "error");
            }
        }

        private void bt_TK_Vai_QLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lbUserLogin.Caption.Equals(_sysadmin) || _dalUser.checkUserRole(lbUserLogin.Caption.ToString(), "42"))
            {
                rbActive = ribbonPage_TK;
                if (frmManageVai == null || frmManageVai.IsDisposed)
                {
                    frmManageVai = new _Vai.frmVai_Manage();
                    frmManageVai.MdiParent = this;
                    frmManageVai.Show();
                }
                else
                {
                    frmManageVai.Activate();
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", "Bạn chưa có quyền sử dụng module này. [42]", "error");
            }
        }

        private void bt_NS_Manage_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lbUserLogin.Caption.Equals(_sysadmin) || _dalUser.checkUserRole(lbUserLogin.Caption.ToString(), "45"))
            {
                rbActive = ribbonPage_NhanSu;
                if (frmNS_NVBH_Manage == null || frmNS_NVBH_Manage.IsDisposed)
                {
                    frmNS_NVBH_Manage = new _NhanSu.frmNS_NVBH_QuanLy();
                    frmNS_NVBH_Manage.MdiParent = this;
                    frmNS_NVBH_Manage.Show();
                }
                else
                {
                    frmNS_NVBH_Manage.Activate();
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", "Bạn chưa có quyền sử dụng module này. [45]", "error");
            }
        }
    }
}