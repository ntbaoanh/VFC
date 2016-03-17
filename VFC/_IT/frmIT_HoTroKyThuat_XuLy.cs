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
    public partial class frmIT_HoTroKyThuat_XuLy : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_Store _dalStore;
        cl_DAL_HoTroKyThuat _dalHoTro;
        DAL.Utilities.Transaction rd;

        public frmIT_HoTroKyThuat_XuLy()
        {
            InitializeComponent();
        }

        private void frmIT_HoTroKyThuat_XuLy_Load( object sender , EventArgs e )
        {
            this.FillDataToGridView( "Undone" );
            lbNow.Text = DateTime.Now.ToShortDateString();
        }

        private void btGetTicket_Click( object sender , EventArgs e )
        {
            try
            {
                _dalHoTro = new cl_DAL_HoTroKyThuat();
                if ( _dalHoTro.updateGetTicket( lbNo.Text , frmHO_Main._userLogin.UserName , txtITNotes.Text ) )
                {
                    this.sendEmail_GetTicket( lbStore.Text , lbType.Text , frmHO_Main._userLogin.UserName );
                    this.FillDataToGridView( "Undone" );
                    rd = new DAL.Utilities.Transaction();
                    rd.record( "Get Ticket " + lbStore.Text + "-" + lbNo.Text , "7" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                }
                else
                {

                }
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                this.FillDataToGridView( "Undone" );
            }
        }

        private void btDone_Click( object sender , EventArgs e )
        {
            try
            {
                _dalHoTro = new cl_DAL_HoTroKyThuat();
                if ( _dalHoTro.updateDone( lbNo.Text , frmHO_Main._userLogin.UserName , txtITNotes.Text ) )
                {
                    this.sendEmail_Done( lbStore.Text , lbType.Text , frmHO_Main._userLogin.UserName );
                    this.FillDataToGridView( "Undone" );
                    rd = new DAL.Utilities.Transaction();
                    rd.record( "Done " + lbStore.Text + "-" + lbNo.Text , "7" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                }
                else
                {

                }
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                this.FillDataToGridView( "Undone" );
            }
        }

        private void btRefresh_Click( object sender , EventArgs e )
        {
            this.FillDataToGridView( "Undone" );
        }

        private void btViewAll_Click( object sender , EventArgs e )
        {
            this.FillDataToGridView( "All" );
        }

        private void btCapNhatCLKK_Click( object sender , EventArgs e )
        {
            try
            {
                _dalHoTro = new cl_DAL_HoTroKyThuat();
                if ( _dalHoTro.insert_HoTroKyThuat( lbStore.Text , txtNotes.Text , frmHO_Main._userLogin.UserName , 10 , lbITCapNhatCLKK.Text ) )
                {
                    this.sendEmailCapNhatCLKK( lbStore.Text , lbITCapNhatCLKK.Text );
                    rd = new DAL.Utilities.Transaction();
                    rd.record( "Yêu cầu cập nhật số tồn - " + lbStore.Text + " - " + lbITCapNhatCLKK.Text , "11" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                    this.FillDataToGridView( "Undone" );
                }
                else
                {

                }
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                this.FillDataToGridView( "Undone" );
            }
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                _dalStore = new cl_DAL_Store();
                lbCreatedDate.Text = gridView1.GetFocusedRowCellValue( "CreatedDate" ).ToString();
                lbStore.Text = gridView1.GetFocusedRowCellValue( "Store" ).ToString();
                lbITPhuTrach.Text = gridView1.GetFocusedRowCellValue( "ITPhuTrach" ).ToString();
                txtNotes.Text = gridView1.GetFocusedRowCellValue( "Notes" ).ToString();
                lbNo.Text = gridView1.GetFocusedRowCellValue( "No" ).ToString();
                lbType.Text = gridView1.GetFocusedRowCellValue( "Type" ).ToString();
                lbExpireDate.Text = gridView1.GetFocusedRowCellValue( "ExpireDate" ).ToString();
                lbModified_By.Text = gridView1.GetFocusedRowCellValue( "ModifiedBy" ).ToString();
                lbSupportDesc.Text = gridView1.GetFocusedRowCellValue( "SupportDescr" ).ToString();
                lbModified_Date.Text = gridView1.GetFocusedRowCellValue( "ModifiedDate" ).ToString();
                lbITCapNhatCLKK.Text = _dalStore.getITFromStore( lbStore.Text );

                if ( gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Waiting" ) )
                {
                    btDone.Enabled = true;
                    btGetTicket.Enabled = true;
                    picBox.Image = imageList_MessageIcon.Images["waiting.jpg"];
                }
                else if ( gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Processing" ) )
                {
                    btGetTicket.Enabled = false;
                    btDone.Enabled = true;
                    picBox.Image = imageList_MessageIcon.Images["processing.jpg"];
                }
                else
                {
                    btDone.Enabled = false;
                    btGetTicket.Enabled = false;
                    picBox.Image = imageList_MessageIcon.Images["done.jpg"];
                }

                //Show duration
                DateTime test2 = (DateTime) gridView1.GetFocusedRowCellValue( "CreatedDate" );
                DateTime test1 = (DateTime) gridView1.GetFocusedRowCellValue( "ModifiedDate" );

                if ( gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Waiting" ) || gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Processing" ) )
                {
                    lbDuration.Text = this.subtractDate( test2 , DateTime.Now );
                }
                else
                {
                    lbDuration.Text = this.subtractDate( test2 , test1 );
                }
            }
            catch ( NullReferenceException  )
            {

            }
            catch ( InvalidCastException  )
            {

            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        #region Action 
        private void FillDataToGridView( string _type )
        {
            gridControl1.DataSource = null;
            _dalHoTro = new cl_DAL_HoTroKyThuat();
            if ( _type.Equals( "All" ) )
            {
                gridControl1.DataSource = _dalHoTro.GetHoTro_All();
            }
            else
            {
                gridControl1.DataSource = _dalHoTro.GetHoTro_UnDone();
            }
        }

        private void sendEmail_GetTicket( string _store , string _note , string _fnameUserLogin )
        {
            string _cc = "";
            string body = "Chao " + _store + "," + "%0d%0A %0d%0A";

            body += "Minh la " + _fnameUserLogin + " thuoc phong IT." + "%0d%0A%0d%0A";

            body += "Minh da tiep nhan su co cua cua hang va dang xu ly. Vui long cho cho toi khi nhan duoc thong bao moi." + "%0d%0A%0d%0A";
            body += "\t-\tSu co : ".Replace( "\t" , "    " ) + txtNotes.Text + "%0d%0A" + "%0d%0A";
            body += "Regards," + "%0d%0A" + "%0d%0A" + "%0d%0A";
            body += "Phong IT." + "%0d%0A";
            body += "Tel : +84 835262180 - Ext: 307" + "%0d%0A";
            body += "Confidentiality: This e-mail is intended solely for the addressees. If you receive it by mistake, please notify the sender and delete the original e-mail and its attachments, if any, from your system. Any unauthorized use, copy, transmission or dissemination of this e-mail or its attachments to any unauthorized third party is strictly forbidden." + "%0d%0A";

            if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "HO CHI MINH" ) )
            {
                _cc += "; hangnp; danhnt";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN BAC" ) )
            {
                _cc += "; thuypn; anhhdk; quynv";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN DONG" ) )
            {
                _cc += "; tinhht; danhnt";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN TAY" ) )
            {
                _cc += "; loanntb; thienhb; chuchc";
            }
            else
            {
                _cc += "; nhonnth; vuna";
            }

            Process.Start( "mailto:" + _store + "?subject=Tiep nhan va bat dau xu ly su co tai cua hang " + _store + " " + ",&cc=" + _cc + "&body=" + body );
        }

        private void sendEmail_Done( string _store , string _note , string _fnameUserLogin )
        {
            string _cc = "";
            string body = "Chao " + _store + "," + "%0d%0A %0d%0A";

            body += "Minh la " + _fnameUserLogin + " thuoc phong IT." + "%0d%0A%0d%0A";

            body += "Minh da xu ly xong su co tai cua hang. Vui long kiem tra lai." + "%0d%0A%0d%0A";
            body += "\t-\tSu co : ".Replace( "\t" , "    " ) + txtNotes.Text + "%0d%0A" + "%0d%0A";
            body += "Regards," + "%0d%0A" + "%0d%0A" + "%0d%0A";
            body += "Phong IT." + "%0d%0A";
            body += "Tel : +84 835262180 - Ext: 307" + "%0d%0A";
            body += "Confidentiality: This e-mail is intended solely for the addressees. If you receive it by mistake, please notify the sender and delete the original e-mail and its attachments, if any, from your system. Any unauthorized use, copy, transmission or dissemination of this e-mail or its attachments to any unauthorized third party is strictly forbidden." + "%0d%0A";

            if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "HO CHI MINH" ) )
            {
                _cc += "; hangnp; danhnt";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN BAC" ) )
            {
                _cc += "; thuypn; quynvl; tiendtm";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN DONG" ) )
            {
                _cc += "; tinhht; danhnt";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN TAY" ) )
            {
                _cc += "; loanntb; thienhb";
            }
            else
            {
                _cc += "; nhonnth; vuna";
            }

            Process.Start( "mailto:" + _store + "?subject=Xu ly xong su co tai cua hang " + _store + " " + ",&cc=" + _cc + "&body=" + body );
        }

        private void sendEmailCapNhatCLKK( string _store , string _it )
        {
            string _cc = _store;
            string body = "Chao " + _it + "," + "%0d%0A %0d%0A";

            body += "Cua hang " + _store + " so lieu dau ky da dung. " + "%0d%0A";
            body += "Vui long lam cap nhat ton kho cho cua hang." + "%0d%0A%0d%0A";
            body += "Thanks,";

            Process.Start( "mailto:" + _it + "?subject=Yeu cau cap nhat ton kho - " + _store + ",&cc=" + _cc + "&body=" + body );
        }

        private string subtractDate( DateTime de1 , DateTime de2 )
        {
            string rs = "";

            try
            {
                System.TimeSpan diff = de2 - de1;

                rs = string.Format( "{0:D2} d,{1:D2} h,{2:D2} m,{3:D2} s" , diff.Days.ToString() , diff.Hours.ToString() , diff.Minutes.ToString() , diff.Seconds.ToString() );
            }
            catch ( Exception  )
            {
                rs = "";
            }

            return rs;
        }
        #endregion
    }
}