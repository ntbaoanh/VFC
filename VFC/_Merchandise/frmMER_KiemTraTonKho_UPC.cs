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

namespace VFC._Merchandise
{
    public partial class frmMER_KiemTraTonKho_UPC : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt;
        DAL.Utilities.ORACon oraConn;

        public frmMER_KiemTraTonKho_UPC()
        {
            InitializeComponent();
        }

        private void frmMER_KiemTraTonKho_UPC_Load( object sender , EventArgs e )
        {
            lbMaThietKe.Visible = false;
            lbTenSanPham.Visible = false;

            if ( frmMain._myEnvironment.Equals( "HO" ) )
            {
                rdGroup.SelectedIndex = 2;
                rdGroup.Enabled = false;
                rdLAN.Enabled = false;
            }
            else
            {
                rdGroup.SelectedIndex = 0;
                rdLAN.SelectedIndex = 0;
                rdGroup.Enabled = true;
                rdLAN.Enabled = true;
            }
        }

        private void btFind_Click( object sender , EventArgs e )
        {
            this.LookUp();
        }

        private void chbExactly_CheckedChanged( object sender , EventArgs e )
        {
            this.LookUp();
        }

        private void rdGroup_SelectedIndexChanged( object sender , EventArgs e )
        {            
            this.LookUp();
        }

        private void rdLAN_SelectedIndexChanged( object sender , EventArgs e )
        {
            this.LookUp();
        }


        private void txtUPC_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.LookUp();
            }
        }

        #region LookUp()
        private void LookUp()
        {
            splashScreenManager1.ShowWaitForm();

            lbMaThietKe.Visible = true;
            lbTenSanPham.Visible = true;

            if ( txtUPC.Text.Trim().Equals( "" ) )
            {
                frmMessageBox.Show( "Thông báo" , "Xin nhập vào mã UPC." , "error" );
            }
            else
            {
                string strLookup = "";

                try
                {
                    if ( this.chbExactly.Checked == true )
                    {
                        strLookup = " and UPC = '" + txtUPC.Text.Trim() + "'";
                    }
                    else
                    {
                        strLookup = " and v.Description1 = (select description1 from inventory_v where upc = " + txtUPC.Text.Trim() + " and sbs_no = " + frmMain._myAppConfig.SbsNo + ")";
                    }

                    string SQLFind = "select s.store_code, " +
                                        "v.upc, " +
                                        "a.qty, " +
                                        "v.DESCRIPTION1, " +
                                        "v.DESCRIPTION2, " +
                                        "v.siz, " +
                                        "v.attr, " +
                                        "s.REGION_NAME, " +
                                        "p.price " +
                                    " from " +
                                        "INVN_SBS_QTY a, " +
                                        "inventory_v v, " +
                                        "store_v s, " +
                                        "invn_sbs_price_v p " +
                                    " where p.item_sid = v.item_sid " +
                                        "and p.price_lvl = 1 " +
                                        "and s.store_no = a.store_no " +
                                        "and a.qty <> 0 " +
                                        "and a.sbs_no = " + frmMain._myAppConfig.SbsNo +
                                        strLookup +
                                        "and a.item_sid = v.item_sid " +
                                        "and s.sbs_no in (" + frmMain._myAppConfig.SbsNo + ") and s.store_code <> 'CMP' " +
                                        "and s.active = '1' and v.sbs_no = " + frmMain._myAppConfig.SbsNo + " and p.sbs_no = " + frmMain._myAppConfig.SbsNo;

                    oraConn = new DAL.Utilities.ORACon();
                    dt = new DataTable();

                    if ( rdGroup.SelectedIndex == 0 )
                    {
                        SQLFind += " and s.Store_no = " + frmMain._myAppConfig.StoreNo;
                        SQLFind += " group by s.store_code, v.upc, a.qty, v.DESCRIPTION1, v.DESCRIPTION2, v.siz, v.attr, s.REGION_NAME, p.price ORDER BY ATTR";

                        if ( rdLAN.SelectedIndex == 0 )
                        {
                            dt = oraConn.returnDataTable( SQLFind , frmMain._myAppConfig.OraLocalIP );
                        }
                        else if ( rdLAN.SelectedIndex == 1 )
                        {
                            dt = oraConn.returnDataTable( SQLFind , frmMain._myAppConfig.OraLanIP );
                        }
                    }
                    else if ( rdGroup.SelectedIndex == 1 )
                    {
                        // Bỏ NT8 ra
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%DE%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%ND%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%M-SH%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%M-PO%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%M-SO%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%M-JA%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and a.store_no not in (" + frmMain._myAppConfig.StoreNo + ", 163,237,111,110,109,2,1,307,309) and S.REGION_NAME in (SELECT REGION_NAME FROM STORE_V WHERE STORE_NO = " + frmMain._myAppConfig.StoreNo + " and SBS_NO = " + frmMain._myAppConfig.SbsNo + " )";
                        SQLFind += " group by s.store_code, v.upc, a.qty, v.DESCRIPTION1, v.DESCRIPTION2, v.siz, v.attr, s.REGION_NAME, p.price  ORDER BY ATTR";
                        dt = oraConn.returnDataTable( SQLFind , frmMain._myAppConfig.Ora248IP );
                    }
                    else
                    {
                        // Bỏ NT8 ra
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%DE%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%ND%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%M-SH%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%M-PO%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%M-SO%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and 1 = (case when s.Store_Code = 'NT8' and v.description1 like '%M-JA%' and a.qty <= 5 then 0 else 1 end) ";
                        SQLFind += " and a.store_no not in (" + frmMain._myAppConfig.StoreNo + ", 163,237,111,110,109,2,1,307,309) ";
                        SQLFind += " group by s.store_code, v.upc, a.qty, v.DESCRIPTION1, v.DESCRIPTION2, v.siz, v.attr, s.REGION_NAME, p.price  ORDER BY ATTR";
                        dt = oraConn.returnDataTable( SQLFind , frmMain._myAppConfig.Ora248IP );
                    }

                    if ( dt.Rows.Count == 0 )
                    {
                        frmMessageBox.Show( "Thông báo" , " - Không tồn tại mã hàng này. "
                                            + Environment.NewLine
                                            + " - Mã hàng không có tồn trong kho." , "error" );

                        gridControl1.DataSource = null;
                        lbMaThietKe.Text = "";
                        lbTenSanPham.Text = "";
                    }
                    else
                    {
                        gridControl1.DataSource = dt;
                        lbMaThietKe.Text = dt.Rows[0]["DESCRIPTION1"].ToString();
                        lbTenSanPham.Text = dt.Rows[0]["DESCRIPTION2"].ToString();
                    }
                }
                catch ( Exception ex )
                {
                    frmMessageBox.Show( "Thông báo lỗi" , " - Không tồn tại mã hàng này. "
                                            + Environment.NewLine
                                            + " - Mã hàng không có tồn trong kho." , "error" );

                    gridControl1.DataSource = null;
                }
            }

            splashScreenManager1.CloseWaitForm();
        }
        #endregion
    }
}