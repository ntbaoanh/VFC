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
    public partial class frmIT_CapNhatTonKho : DevExpress.XtraEditors.XtraForm
    {
        DAL.Utilities.Transaction rd;
        cl_DAL_KiemKe _dalKiemKe;

        public frmIT_CapNhatTonKho()
        {
            InitializeComponent();
        }

        private void btDone_Click( object sender , EventArgs e )
        {
            string _userGetTicket = gridView1.GetFocusedRowCellValue( "UserGetTicket" ).ToString();
            if ( _userGetTicket == frmHO_Main._userLogin.UserName )
            {
                this.updateKiemKe();
                rd = new DAL.Utilities.Transaction();
                rd.record( "Updated CLKK " + lbStore.Text + "-" + lbSTT.Text , "3" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
            }
            else
            {
                DialogResult r = XtraMessageBox.Show( "Bạn đang update 1 cửa hàng [ " + lbStore.Text + " ] của [ " + _userGetTicket + " ]" + Environment.NewLine + "Bạn có chắn chắn vẫn muốn cập nhật?" , "Thông báo" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning );
                if ( r == DialogResult.Yes )
                {

                    this.updateKiemKe();
                    rd = new DAL.Utilities.Transaction();
                    rd.record( "Updated CLKK " + lbStore.Text + "-" + lbSTT.Text , "3" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                    this.FillDateToGrid( "UnDone" );
                }
                else
                {
                    XtraMessageBox.Show( "Nope !!!!" );
                }
            }
        }

        private void btAll_Click( object sender , EventArgs e )
        {
            this.FillDateToGrid( "All" );
        }

        private void btFalse_Click( object sender , EventArgs e )
        {
            this.FillDateToGrid( "UnDone" );
        }

        private void btRefresh_Click( object sender , EventArgs e )
        {
            this.FillDateToGrid( "UnDone" );
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                lbSTT.Text = gridView1.GetFocusedRowCellValue( "No" ).ToString();
                lbStore.Text = gridView1.GetFocusedRowCellValue( "Store_Code" ).ToString();
                lbQty.Text = gridView1.GetFocusedRowCellValue( "KKQty" ).ToString();
                lbDate.Text = gridView1.GetFocusedRowCellValue( "KKDate" ).ToString();

                if ( gridView1.GetFocusedRowCellValue( "Status" ).ToString() == "True" )
                {
                    btDone.Enabled = false;
                }
                else
                {
                    btDone.Enabled = true;
                }
            }
            catch ( NullReferenceException  )
            {
                
                lbSTT.Text = "";
                lbStore.Text = "";
                lbQty.Text = "";
                lbDate.Text = "";
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void frmIT_CapNhatTonKho_Load( object sender , EventArgs e )
        {
            this.FillDateToGrid( "UnDone" );
        }

        #region Action
        public void FillDateToGrid( string _type )
        {
            _dalKiemKe = new cl_DAL_KiemKe();
            gridControl1.DataSource = null;

            if ( _type.Equals( "All" ) )
            {
                gridControl1.DataSource = _dalKiemKe.GetData_All();
            }
            else if(_type.Equals("Done"))
            {
                gridControl1.DataSource = _dalKiemKe.GetData_ByType( true );
            }            
            else if ( _type.Equals( "UnDone" ) )
            {
                gridControl1.DataSource = _dalKiemKe.GetData_ByType( false );
            }
        }

        private void sendEmail( string _store , string _date , string _qty , string _it )
        {
            string body = "Chao " + _store + "," + "%0d%0A %0d%0A";
            body += "IT da cap nhat kiem ke cho cua hang. So ton ngay " + _date + " la " + _qty + " san pham." + "%0d%0A";
            body += "Vui long kiem tra va phan hoi neu so lieu co van de." + "%0d%0A %0d%0A";
            body += "Regards," + "%0d%0A";
            body += frmHO_Main._userLogin.UserName;

            Process.Start( "mailto:" + _store + "?subject=Đa cap nhat kiem ke " + _store + ".,&body=" + body );
        }

        private void updateKiemKe()
        {
            cl_DAL_KiemKe kk = new cl_DAL_KiemKe();
            if ( kk.UpdateKiemKe( lbSTT.Text , frmHO_Main._userLogin.UserName ) )
            {
                this.sendEmail( lbStore.Text , lbDate.Text , lbQty.Text , frmHO_Main._userLogin.UserName );
            }
            else
            {

            }
        }
        #endregion
    }
}