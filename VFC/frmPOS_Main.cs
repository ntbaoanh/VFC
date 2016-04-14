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

namespace VFC
{
    public partial class frmPOS_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Create Form
        private static _Merchandise.frmMER_KiemTraTonKho_UPC frmKiemTraTonKho;
        private static _Sale.frmSale_XemDoanhThu_Store frmXemDoanhThu;
        private static _PromotionCode.frmProCode_UseCode frmProCodeUseCode;
        private static _Merchandise.frmMER_KiemTraASN frmMER_CheckASN;
        private static _Admin.frmPOS_Welcome frmPOS_Welcome;
        private static _Admin.frmLogin frmLogin;
        private static _POS.frmPOS_BienNhanDoSua frmBNDoSua;
        private static _CTKM.frm_CTKM_TriAnKH_112015 frmCTKM112015;
        public static _Sale.frmSale_NVBH_DoanhSo_NV frmDSNVBH;
        private static _Sale.frmSale_NVBH_CheckInOut frmChamCong;
        private static _Sale.frmSale_NVBH_BaoCaoTongHop frmBCTongHop;
        private static _IT.frm_IT_DoanhSo_TheoKetCau frmDS_KetCau;
        #endregion

        #region static variable
        public static bool forceRestart;
        public static bool updateDoanhThu;     
        #endregion

        public static bool showMenu = false;
        public static DevExpress.XtraBars.Ribbon.RibbonPage rbmenu;
        public static DevExpress.XtraBars.Ribbon.RibbonPage rbActive;

        #region Action
        private void Check_UpdateDoanhThu()
        {
            if (lbCheckPOS.Caption.Equals(""))
            {
                try
                {
                    cl_DAL_ADMIN_POS_ForceUpdate _dalPOS = new cl_DAL_ADMIN_POS_ForceUpdate();
                    if (_dalPOS.Check_Update_DoanhThu(lbStoreCode.Caption) == 1)
                    {
                        timer_Admin_POS_ForceUpdate.Enabled = true;
                        timer_Admin_POS_ForceUpdate.Start();
                        //frmMessageBox.Show( "Thông báo" , "Timer Start" , "done" );
                    }
                    else
                    {
                        timer_Admin_POS_ForceUpdate.Stop();
                        timer_Admin_POS_ForceUpdate.Enabled = false;
                        //frmMessageBox.Show( "Thông báo" , "Timer Stop" , "done" );
                    }
                }
                catch (Exception ex)
                {
                    frmMessageBox.Show("Thông báo", ex.ToString(), "error");
                }
            }
        }

        
        #endregion

        public frmPOS_Main()
        {
            InitializeComponent();
        }

        private void frmPOS_Main_FormClosed( object sender , FormClosedEventArgs e )
        {
            frmMessageBox.Show("Thông báo", "Nhớ check out nhân viên.", "alert");
            Application.Exit();
        }

        private void frmPOS_Main_Load( object sender , EventArgs e )
        {
            

            lbComputerName.Caption = System.Environment.MachineName.ToString();
            lbStoreCode.Caption = frmMain._myAppConfig.StoreCode;
            lbStoreNo.Caption = frmMain._myAppConfig.StoreNo;            

            if ( lbComputerName.Caption.Substring( lbComputerName.Caption.Length - 3 , 3 ).Equals( frmMain._myAppConfig.StoreCode ) )
            {
                lbCheckPOS.Caption = "";
            }
            else
            {
                lbCheckPOS.Caption = "Store_Code hiện tại chưa đúng.";
            }

            this.Check_UpdateDoanhThu();

            timer_10mins.Enabled = true;
            timer_10mins.Start();

            if ( frmPOS_Welcome == null || frmPOS_Welcome.IsDisposed )
            {
                frmPOS_Welcome = new _Admin.frmPOS_Welcome();
                frmPOS_Welcome.MdiParent = this;
                frmPOS_Welcome.Show();
            }
            else
            {
                frmPOS_Welcome.Activate();
            }

            cl_DAL_CTKM_TriAnKH_112015 _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();
            if (_myCTKM.CTKM_TriAnKH_112015_Check_Run(frmMain._myAppConfig.StoreNo))
            {
                bt_CTKM_TriAnKH_112015.Enabled = true;
            }

            if (lbStoreCode.Caption.Equals("NT8"))
            {
                ribbonPageGroup_DS_TheoKetCau.Visible = true;
            }
        }

        private void bt_MER_InventoryLookUp_ItemClick( object sender , ItemClickEventArgs e )
        {
            rbActive = ribbonPage_LookUp;
            if ( frmKiemTraTonKho == null || frmKiemTraTonKho.IsDisposed )
            {
                frmKiemTraTonKho = new _Merchandise.frmMER_KiemTraTonKho_UPC();
                frmKiemTraTonKho.MdiParent = this;
                frmKiemTraTonKho.Show();
            }
            else
            {
                frmKiemTraTonKho.Activate();
            }
        }

        private void bt_SALE_XemDoanhThu_Store_ItemClick( object sender , ItemClickEventArgs e )
        {
            rbActive = ribbonPage_LookUp;
            if ( frmXemDoanhThu == null || frmXemDoanhThu.IsDisposed )
            {
                frmXemDoanhThu = new _Sale.frmSale_XemDoanhThu_Store();
                frmXemDoanhThu.MdiParent = this;
                frmXemDoanhThu.Show();
            }
            else
            {
                frmXemDoanhThu.Activate();
            }
        }

        private void bt_ProCode_UseCode_ItemClick( object sender , ItemClickEventArgs e )
        {
            rbActive = ribbonPage_Promotion;
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

        private void bt_TOOLS_CheckASN_ItemClick( object sender , ItemClickEventArgs e )
        {
            rbActive = ribbonPage_Tools;
            if ( frmMER_CheckASN == null || frmMER_CheckASN.IsDisposed )
            {
                frmMER_CheckASN = new _Merchandise.frmMER_KiemTraASN();
                frmMER_CheckASN.MdiParent = this;
                frmMER_CheckASN.Show();
            }
            else
            {
                frmMER_CheckASN.Activate();
            }
        }

        private void bt_VFCHO_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( frmLogin == null || frmLogin.IsDisposed )
            {
                frmLogin = new _Admin.frmLogin();
                frmLogin.MdiParent = this;
                frmLogin.Show();
            }
            else
            {
                frmLogin.Activate();
            }
        }

        private void btBNDoSua_ItemClick( object sender , ItemClickEventArgs e )
        {
            if ( frmBNDoSua == null || frmBNDoSua.IsDisposed )
            {
                frmBNDoSua = new _POS.frmPOS_BienNhanDoSua();
                frmBNDoSua.MdiParent = this;
                frmBNDoSua.Show();
            }
            else
            {
                frmBNDoSua.Activate();
            }
        }

        private void timer_Admin_POS_ForceUpdate_Tick( object sender , EventArgs e )
        {
            if (lbCheckPOS.Caption.Equals(""))
            {
                try
                {
                    DataTable _tempTable = new DataTable();
                    cl_DAL_Invoice _dalInvoice = new cl_DAL_Invoice();
                    _tempTable = _dalInvoice.GET_Sum_DoanhThu_By_StoreCode(String.Format(DateTime.Now.ToShortDateString(), "dd/MM/yyyy")
                                                                , String.Format(DateTime.Now.ToShortDateString(), "dd/MM/yyyy")
                                                                , lbStoreCode.Caption
                                                                , frmMain._myAppConfig.SbsNo
                                                                , false);
                    if (_tempTable.Rows.Count == 0)
                    {
                        //frmMessageBox.Show("Thông báo", "Datarow = 0", "done");
                    }
                    else
                    {
                        cl_DAL_ADMIN_POS_ForceUpdate _dalUpdateDoanhThu = new cl_DAL_ADMIN_POS_ForceUpdate();
                        if (_dalUpdateDoanhThu.POS_UpdateDoanhThu_Insert(_tempTable.Rows[0]["STORE_CODE"].ToString()
                                                                , _tempTable.Rows[0]["REGION_NAME"].ToString()
                                                                , int.Parse(_tempTable.Rows[0]["TOTAL_MONEY"].ToString())
                                                                , int.Parse(_tempTable.Rows[0]["TOTAL_DISCOUNT"].ToString())
                                                                , int.Parse(_tempTable.Rows[0]["TOTAL_QTY"].ToString())))
                        {
                            //frmMessageBox.Show( "Thông báo" , "Cập nhật doanh thu thành công" , "done" );
                        }
                        else
                        {
                            frmMessageBox.Show("Thông báo", "Cập nhật doanh thu không thành công", "error");
                        }
                    }
                }
                catch (Exception )
                {
                    frmMessageBox.Show("Thông báo", "Có lỗi trong quá trình cập nhật.", "error");
                }
            }
        }

        private void timer_10mins_Tick( object sender , EventArgs e )
        {
            try
            {
                if (lbCheckPOS.Caption.Equals(""))
                {
                    this.Check_UpdateDoanhThu();
                }
                else
                {
                    timer_10mins.Enabled = false;
                    timer_Admin_POS_ForceUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                frmMessageBox.Show("Thông báo", ex.ToString(), "error");
            }
        }

        private void bt_CTKM_TriAnKH_112015_ItemClick(object sender, ItemClickEventArgs e)
        {
            rbActive = ribbonPage_Promotion;
            if (frmCTKM112015 == null || frmCTKM112015.IsDisposed)
            {
                frmCTKM112015 = new _CTKM.frm_CTKM_TriAnKH_112015();
                frmCTKM112015.MdiParent = this;
                frmCTKM112015.Show();
            }
            else
            {
                frmCTKM112015.Activate();
            }
        }

        private void bt_Insert_DS_NVBH_ItemClick(object sender, ItemClickEventArgs e)
        {
            rbActive = ribbonPage_POS;
            if (frmDSNVBH == null || frmDSNVBH.IsDisposed)
            {
                frmDSNVBH = new _Sale.frmSale_NVBH_DoanhSo_NV();
                frmDSNVBH.MdiParent = this;
                frmDSNVBH.Show();
            }
            else
            {
                frmDSNVBH.Activate();
            }
        }

        private void bt_NVBH_CheckInOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            rbActive = ribbonPage_POS;
            if (frmChamCong == null || frmChamCong.IsDisposed)
            {
                frmChamCong = new _Sale.frmSale_NVBH_CheckInOut();
                frmChamCong.MdiParent = this;
                frmChamCong.Show();
            }
            else
            {
                frmChamCong.Activate();
            }
        }

        private void bt_NVBH_Insert_ItemClick(object sender, ItemClickEventArgs e)
        {
            DAL.cl_DAL_User user = new cl_DAL_User();
            frmHO_Main._flagOverride = false;
            _Admin.frmOverrideLogin overrideLogin = new _Admin.frmOverrideLogin();
            overrideLogin.ShowDialog();
            try
            {
                if (frmHO_Main._flagOverride == true)
                {
                    if (user.checkUserRole(overrideLogin.UserNameOverride, "44"))
                    {
                        _NhanSu.frmNS_NVBH_Insert posNVBH_Insert = new _NhanSu.frmNS_NVBH_Insert();
                        posNVBH_Insert.ShowDialog();
                    }
                    else
                    {
                        frmMessageBox.Show("Thông báo", "Bạn không có quyền ghi đè.", "error");
                    }
                }
                else
                {
                    frmMessageBox.Show("Thông báo", "Đăng nhập thất bại.", "error");
                }
            }
            catch (Exception ex)
            {
                frmMessageBox.Show("Thông báo", ex.ToString(), "error");
            }
        }

        private void bt_NVBH_BaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            rbActive = ribbonPage_POS;
            if (frmBCTongHop == null || frmBCTongHop.IsDisposed)
            {
                frmBCTongHop = new _Sale.frmSale_NVBH_BaoCaoTongHop();
                frmBCTongHop.MdiParent = this;
                frmBCTongHop.Show();
            }
            else
            {
                frmBCTongHop.Activate();
            }
        }

        private void bt_BC_DSo_Theo_KetCau_ItemClick(object sender, ItemClickEventArgs e)
        {
            rbActive = ribbonPage_POS;
            if (frmDS_KetCau == null || frmDS_KetCau.IsDisposed)
            {
                frmDS_KetCau = new _IT.frm_IT_DoanhSo_TheoKetCau();
                frmDS_KetCau.MdiParent = this;
                frmDS_KetCau.Show();
            }
            else
            {
                frmDS_KetCau.Activate();
            }
        }
    }
}