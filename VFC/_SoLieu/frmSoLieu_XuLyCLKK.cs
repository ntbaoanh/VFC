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
using System.Diagnostics;

namespace VFC._SoLieu
{
    public partial class frmSoLieu_XuLyCLKK : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_CLKK clkk;
        DAL.Utilities.Transaction rd;

        public frmSoLieu_XuLyCLKK()
        {
            InitializeComponent();
        }

        private void frmSoLieu_XuLyCLKK_Load( object sender , EventArgs e )
        {
            this.FillDataToGrid( "UnDone" );
            txtPrintNo.Text = "1";
            dateChungTu.EditValue = DateTime.Now;
        }

        private void btPrint_Click( object sender , EventArgs e )
        {
            this.printBienBanCLKK();

            try
            {
                if ( gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Sent" ) )
                {
                    clkk.UpdatePrint( lbSoCLKK.Text );
                }
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() );
            }

            this.FillDataToGrid( "UnDone" );
        }

        private void btViewAll_Click( object sender , EventArgs e )
        {
            this.FillDataToGrid( "All" );
        }

        private void btRefresh_Click( object sender , EventArgs e )
        {
            this.FillDataToGrid( "UnDone" );
        }

        private void btMailResult_Click( object sender , EventArgs e )
        {
            try
            {
                DialogResult _result = MessageBox.Show( "Bạn có chắc chắn muốn gửi mail cho " +
                                        gridView1.GetFocusedRowCellValue( "Store_Code" ).ToString() , "Thông báo !" , MessageBoxButtons.YesNo , MessageBoxIcon.Question );

                if ( _result == DialogResult.Yes )
                {
                    if ( gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Inserted" ) )
                    {
                        if ( clkk.UpdateGuiPOS( lbSoCLKK.Text ) )
                        {
                            //XtraMessageBox.Show("Đã cập nhật thành công.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rd = new DAL.Utilities.Transaction();
                            rd.record( "Update Sent Mail KiemKeResult to POS " + lbStore.Text + "-" + lbSoCLKK.Text , "3" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                        }
                        else
                        {
                            XtraMessageBox.Show( "Cập nhật không thành công." , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                        }
                    }

                    this.sendEmail( gridView1.GetFocusedRowCellValue( "Store_Code" ).ToString() , Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "ToDate" ).ToString() ).ToShortDateString() );

                    rd = new DAL.Utilities.Transaction();
                    rd.record( "Send mail KiemKeResult to POS " + lbStore.Text + "-" + lbSoCLKK.Text , "3" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                }
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() );
            }

            this.FillDataToGrid( "UnDone" );
        }

        private void btMailBBCLKK_Click( object sender , EventArgs e )
        {
            try
            {
                this.sendCLKK( gridView1.GetFocusedRowCellValue( "Store_Code" ).ToString() , Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "ToDate" ).ToString() ).ToShortDateString() );
                rd = new DAL.Utilities.Transaction();
                rd.record( "Send BienBan CLKK to POS " + lbStore.Text + "-" + lbSoCLKK.Text , "3" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() );
            }
        }

        private void btCHTSign_Click( object sender , EventArgs e )
        {
            try
            {
                DialogResult _result = MessageBox.Show( "Cửa hàng trưởng đã ký CLKK ?" , "Thông báo !" , MessageBoxButtons.YesNo , MessageBoxIcon.Question );

                if ( _result == DialogResult.Yes )
                {
                    if ( clkk.UpdateGuiPhongNhanSu( lbSoCLKK.Text , "CHT Ký" ) )
                    {
                        //XtraMessageBox.Show("Đã cập nhật thành công.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rd = new DAL.Utilities.Transaction();
                        rd.record( "StoreLeader Accepted CLKK - " + lbStore.Text + "-" + lbSoCLKK.Text , "3" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                    }
                    else
                    {
                        XtraMessageBox.Show( "Cập nhật không thành công." , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
                else
                {

                }
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() );
            }

            this.FillDataToGrid( "UnDone" );
        }

        private void btAutoSign_Click( object sender , EventArgs e )
        {
            try
            {
                DialogResult _result = MessageBox.Show( "Cửa hàng trưởng không ký CLKK ? Tự động ký ?" , "Thông báo !" , MessageBoxButtons.YesNo , MessageBoxIcon.Question );

                if ( _result == DialogResult.Yes )
                {
                    if ( clkk.UpdateGuiPhongNhanSu( lbSoCLKK.Text , "Số liệu Ký" ) )
                    {
                        //XtraMessageBox.Show("Đã cập nhật thành công.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rd = new DAL.Utilities.Transaction();
                        rd.record( "SoLieu Accepted CLKK - " + lbStore.Text + "-" + lbSoCLKK.Text , "3" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                    }
                    else
                    {
                        XtraMessageBox.Show( "Cập nhật không thành công." , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                }
                else
                {

                }
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() );
            }

            this.FillDataToGrid( "UnDone" );
        }

        private void rdOld_CheckedChanged( object sender , EventArgs e )
        {
            if ( rdOld.Checked == true )
            {
                xtraTabThuong.SelectedTabPage = xtraTabPage1;
            }
            else
                xtraTabThuong.SelectedTabPage = xtraTabPage2;
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                lbSoCLKK.Text = gridView1.GetFocusedRowCellValue( "CLKK_No" ).ToString();
                lbStore.Text = gridView1.GetFocusedRowCellValue( "Store_Code" ).ToString();
                lbTenCHT.Text = gridView1.GetFocusedRowCellValue( "Store_Leader" ).ToString();
                lbFromDate.Text = Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "FromDate" ).ToString() ).ToShortDateString();
                lbToDate.Text = Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "ToDate" ).ToString() ).ToShortDateString();
                lbDateSendPOS.Text = Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "Date_SendCLKK" ).ToString() ).ToShortDateString();

                if ( gridView1.GetFocusedRowCellValue( "Date_SignCLKK" ).ToString().Equals( "" ) )
                {
                    lbDateSendPNS.Text = null;
                }
                else
                    lbDateSendPNS.Text = Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "Date_SignCLKK" ).ToString() ).ToShortDateString();

                lbDateExpire.Text = Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "Date_ExpireCLKK" ).ToString() ).ToShortDateString();
                lbDauKy.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "DauKy" ).ToString() ) );
                lbTongNhap.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Nhap" ).ToString() ) );
                lbTongXuat.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Xuat" ).ToString() ) );
                lbTongBan.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Ban" ).ToString() ) );
                lbCuoiKy.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "CuoiKy" ).ToString() ) );
                lbKiemKe.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "KiemKe" ).ToString() ) );

                lbSlgDu.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "HangDu_Qty" ).ToString() ) );
                lbGTriDu.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "HangDu_Amount" ).ToString() ) );
                lbSlgThieu.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "HangThieu_Qty" ).ToString() ) );
                lbGTriThieu.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "HangThieu_Amount" ).ToString() ) );
                lbSlgChenhLech.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Qty" ).ToString() ) );
                lbGTriChenhLech.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Amount" ).ToString() ) );
                lbTongDoanhThu.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "TongDoanhThu" ).ToString() ) );
                lbThatThoat.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriThatThoat" ).ToString() ) );
                lbDenBu.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu" ).ToString() ) );
                lbThuong.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "ThuongDoanhThu" ).ToString() ) );

                lbSlgDuNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "HangDu_Qty_New" ).ToString() ) );
                lbGTriDuNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "HangDu_Amount_New" ).ToString() ) );
                lbSlgThieuNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "HangThieu_Qty_New" ).ToString() ) );
                lbGTriThieuNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "HangThieu_Amount_New" ).ToString() ) );
                lbSlgChenhLechNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Qty_New" ).ToString() ) );
                lbGTriChenhLechNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Amount_New" ).ToString() ) );
                lbDenBuNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu_New" ).ToString() ) );
                lbThuongNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "ThuongDoanhThu_New" ).ToString() ) );
                lbTongDoanhThuNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "TongDoanhThu" ).ToString() ) );
                lbThatThoatNew.Text = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriThatThoat" ).ToString() ) );

                if ( checkNew( lbToDate.Text , gridView1.GetFocusedRowCellValue( "Region" ).ToString() ) == false )
                {
                    rdOld.Checked = true;
                    rdNew.Checked = false;
                }
                else
                {
                    rdNew.Checked = true;
                    rdOld.Checked = false;
                }
            }
            catch ( Exception  )
            {
                lbSoCLKK.Text = "";
                lbStore.Text = "";
                lbTenCHT.Text = "";
                lbFromDate.Text = "";
                lbToDate.Text = "";
                lbDateSendPOS.Text = "";
                lbDateSendPNS.Text = "";
                lbDateExpire.Text = "";
                lbDauKy.Text = "";
                lbTongNhap.Text = "";
                lbTongXuat.Text = "";
                lbTongBan.Text = "";
                lbCuoiKy.Text = "";
                lbKiemKe.Text = "";
                lbSlgDu.Text = "";
                lbGTriDu.Text = "";
                lbSlgThieu.Text = "";
                lbGTriThieu.Text = "";
                lbSlgChenhLech.Text = "";
                lbGTriChenhLech.Text = "";
                lbTongDoanhThu.Text = "";
                lbThatThoat.Text = "";
                lbDenBu.Text = "";
            }

            try
            {
                if ( gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Finished" ) || gridView1.GetFocusedRowCellValue( "Status" ).ToString().Equals( "Canceleded" ) )
                {
                    btAutoSign.Enabled = false;
                    btCHTSign.Enabled = false;
                    btMailBBCLKK.Enabled = true;
                    btMailResult.Enabled = true;
                }
                else
                {
                    btAutoSign.Enabled = true;
                    btCHTSign.Enabled = true;
                    btMailBBCLKK.Enabled = true;
                    btMailResult.Enabled = true;
                }
            }
            catch ( Exception  )
            {

            }
        }

        private void btHuyCLKK_Click( object sender , EventArgs e )
        {
            DialogResult result = MessageBox.Show( "Bạn có chắc muốn de-Active CLKK số " + lbSoCLKK.Text ,
                        "Bạn si nghĩ kỹ chưa?" ,
                        MessageBoxButtons.YesNoCancel ,
                        MessageBoxIcon.Question ,
                        MessageBoxDefaultButton.Button2 );

            if ( result == DialogResult.Yes )
            {
                clkk = new cl_DAL_CLKK();

                if ( clkk.DeActiveCLKK( int.Parse( lbSoCLKK.Text ) ) )
                    frmMessageBox.Show( "Thông báo" , "De-Active " + lbSoCLKK.Text + " thành công" , "done" );
                else
                    frmMessageBox.Show( "Thông báo" , "De-Active " + lbSoCLKK.Text + " không thành công" , "done" );

            }
        }

        #region Action
        private void FillDataToGrid( string _type )
        {
            gridControl1.DataSource = null;
            clkk = new cl_DAL_CLKK();
            if ( _type.Equals( "All" ) )
            {
                gridControl1.DataSource = clkk.GetData_All();
            }
            else
            {
                gridControl1.DataSource = clkk.GetData_UnDone();
            }
        }
        private void sendEmail( string _store , string _date )
        {
            string _cc = null;
            string body = "Chào " + _store + "," + "%0d%0A %0d%0A";

            body += "Vui lòng đối chiếu số liệu và phản hồi về cho Bộ Phận Số liệu. " + "%0d%0A%0d%0A";

            if ( String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Qty" ).ToString() ) ).Equals( "" ) )
            {
                body += "\t-\tSố lượng thất thoát : ".Replace( "\t" , "    " ) + "0 sản phẩm" + "%0d%0A";
            }
            else
                body += "\t-\tSố lượng thất thoát : ".Replace( "\t" , "    " ) + String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Qty" ).ToString() ) ) + " sản phẩm" + "%0d%0A";

            //Kiểm tra giá trị đền bù MỚI hay CŨ
            string _gtdd = "\t-\tGiá trị đền bù : ".Replace( "\t" , "    " );

            if ( checkNew( lbFromDate.Text , gridView1.GetFocusedRowCellValue( "Region" ).ToString() ) == false )
            {
                if ( String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu" ).ToString() ) ).Equals( "" ) )
                {
                    body += _gtdd + "0 vnđ" + "%0d%0A" + "%0d%0A";
                }
                else
                {
                    body += _gtdd + String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu" ).ToString() ) ) + " vnđ" + "%0d%0A" + "%0d%0A";
                }
            }
            else
            {
                if ( String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu_New" ).ToString() ) ).Equals( "" ) )
                {
                    body += _gtdd + "0 vnđ" + "%0d%0A" + "%0d%0A";
                }
                else
                {
                    body += _gtdd + String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu_New" ).ToString() ) ) + " vnđ" + "%0d%0A" + "%0d%0A";
                }
            }

            body += "\t-\tTrong trường hợp sau 7 ngày từ ngày gửi số liệu mà không có phản hồi của cửa hàng trưởng. Mặc nhiên cửa hàng trưởng chấp nhận số liệu chênh lệch kiểm kê là đúng, phòng Số liệu sẽ chuyển biên bản Chênh lệch Kiểm Kê cho phòng Nhân sự. Điều này đồng nghĩa với việc phòng Số Liệu sẽ không giải quyết kỳ thắc mắc phát sinh sau khi chuyển biên bản cho phòng Nhân sự.".Replace( "\t" , "    " ) + "%0d%0A" + "%0d%0A";
            body += "\t-\tTrong trường hợp cửa hàng đóng cửa, số liệu đối chiếu đã được gửi cho Sale Admin vùng miền. Các cửa hàng trưởng nghỉ việc vui lòng liên hệ Sale Admin vùng miền để đối chiếu Số liệu.".Replace( "\t" , "    " ) + "%0d%0A" + "%0d%0A";
            body += "Regards," + "%0d%0A" + "%0d%0A" + "%0d%0A";
            body += "Phòng Số Liệu." + "%0d%0A";
            body += "Tel : +84 839258115 - Ext: 603" + "%0d%0A";
            body += "Fax : +84 839258117" + "%0d%0A" + "%0d%0A";
            body += "Confidentiality: This e-mail is intended solely for the addressees. If you receive it by mistake, please notify the sender and delete the original e-mail and its attachments, if any, from your system. Any unauthorized use, copy, transmission or dissemination of this e-mail or its attachments to any unauthorized third party is strictly forbidden." + "%0d%0A";

            if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "HO CHI MINH" ) )
            {
                _cc = "hangnp; danhnt; vula";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN BAC" ) )
            {
                _cc = "thuypn; tiendtm; quynv";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN DONG" ) )
            {
                _cc = "tinhht; danhnt";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN TAY" ) )
            {
                _cc = "loanntb; dunglt";
            }
            else
            {
                _cc = "nhonnth; vuna";
            }

            Process.Start( "mailto:" + _store + "?subject=DOI CHIEU CLKK " + _store + " " + Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "ToDate" ).ToString() ).ToShortDateString() + ",&cc=" + _cc + "&body=" + body );
        }

        private void sendCLKK( string _store , string _date )
        {
            string _cc = null;
            string body = "Chào " + _store + "," + "%0d%0A %0d%0A";

            body += "Vui lòng kiểm và và ký vào biên bạn Đối Chiếu Chênh Lệch Kiểm Kê và gửi về cho Bộ Phận Số liệu. " + "%0d%0A%0d%0A";

            if ( String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Qty" ).ToString() ) ).Equals( "" ) )
            {
                body += "\t-\tSố lượng thất thoát : ".Replace( "\t" , "    " ) + "0 sản phẩm" + "%0d%0A";
            }
            else
                body += "\t-\tSố lượng thất thoát : ".Replace( "\t" , "    " ) + String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Qty" ).ToString() ) ) + " sản phẩm" + "%0d%0A";

            if ( checkNew( lbFromDate.Text , gridView1.GetFocusedRowCellValue( "Region" ).ToString() ) == false )
            {
                if ( String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu" ).ToString() ) ).Equals( "" ) )
                {
                    body += "\t-\tGiá trị đền bù : ".Replace( "\t" , "    " ) + "0 vnđ" + "%0d%0A" + "%0d%0A";
                }
                else
                    body += "\t-\tGiá trị đền bù : ".Replace( "\t" , "    " ) + String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu" ).ToString() ) ) + " vnđ" + "%0d%0A" + "%0d%0A";
            }
            else
            {
                if ( String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu_New" ).ToString() ) ).Equals( "" ) )
                {
                    body += "\t-\tGiá trị đền bù : ".Replace( "\t" , "    " ) + "0 vnđ" + "%0d%0A" + "%0d%0A";
                }
                else
                    body += "\t-\tGiá trị đền bù : ".Replace( "\t" , "    " ) + String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu_New" ).ToString() ) ) + " vnđ" + "%0d%0A" + "%0d%0A";
            }

            body += "\t-\tVui lòng ký biên bản Đối chiếu Chênh Lệch Kiểm Kê và gửi về cho phòng Số liệu (Fax hoặc Scan và gửi mail về địa chỉ chamnv@ninomaxx.com.vn)".Replace( "\t" , "    " ) + "%0d%0A" + "%0d%0A";
            body += "\t-\tTrong trường hợp cửa hàng đóng cửa, số liệu đối chiếu đã được gửi cho Sale Admin vùng miền. Các cửa hàng trưởng nghỉ việc vui lòng liên hệ Sale Admin vùng miền để ký.".Replace( "\t" , "    " ) + "%0d%0A" + "%0d%0A";
            body += "\t-\tThời hạn ký là 24h từ lúc nhận được email này.".Replace( "\t" , "    " ) + "%0d%0A" + "%0d%0A";
            body += "Regards," + "%0d%0A" + "%0d%0A" + "%0d%0A";
            body += "Phòng Số Liệu." + "%0d%0A";
            body += "Tel : +84 839258115 - Ext: 603" + "%0d%0A";
            body += "Fax : +84 839258117" + "%0d%0A" + "%0d%0A";
            body += "Confidentiality: This e-mail is intended solely for the addressees. If you receive it by mistake, please notify the sender and delete the original e-mail and its attachments, if any, from your system. Any unauthorized use, copy, transmission or dissemination of this e-mail or its attachments to any unauthorized third party is strictly forbidden." + "%0d%0A";

            if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "HO CHI MINH" ) )
            {
                _cc = "hangnp; danhnt; vuna";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN BAC" ) )
            {
                _cc = "thuypn; tiendtm; quynv";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN DONG" ) )
            {
                _cc = "tinhht; danhnt";
            }
            else if ( gridView1.GetFocusedRowCellValue( "Region" ).ToString().Equals( "MIEN TAY" ) )
            {
                _cc = "loanntb; thienhb";
            }
            else
            {
                _cc = "nhonnth; vuna";
            }

            Process.Start( "mailto:" + _store + "?subject=KY BIEN BAN DOI CHIEU CLKK " + _store + " " + Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "ToDate" ).ToString() ).ToShortDateString() + ",&cc=" + _cc + "&body=" + body );
        }

        private void printBienBanCLKK()
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = ds.Tables.Add();

                // Add columns to the data table
                dt.Columns.Add( "STORE" , typeof( string ) );
                dt.Columns.Add( "NGAYCHUNGTU" , typeof( string ) );
                dt.Columns.Add( "CUAHANGTRUONG" , typeof( string ) );
                dt.Columns.Add( "DAIDIENSOLIEU" , typeof( string ) );
                dt.Columns.Add( "TUNGAY" , typeof( string ) );
                dt.Columns.Add( "DENNGAY" , typeof( string ) );
                dt.Columns.Add( "DAUKY" , typeof( string ) );
                dt.Columns.Add( "NHAP" , typeof( string ) );
                dt.Columns.Add( "XUAT" , typeof( string ) );
                dt.Columns.Add( "BAN" , typeof( string ) );
                dt.Columns.Add( "KIEMKE" , typeof( string ) );
                dt.Columns.Add( "SLGCLKK" , typeof( string ) );
                dt.Columns.Add( "GIATRICLKK" , typeof( string ) );
                dt.Columns.Add( "TONGDOANHTHU" , typeof( string ) );
                dt.Columns.Add( "GIATRITHATTHOAT" , typeof( string ) );
                dt.Columns.Add( "GIATRIDENBU" , typeof( string ) );
                dt.Columns.Add( "SLGTHUHOI" , typeof( string ) );
                dt.Columns.Add( "GIATRITHUHOI" , typeof( string ) );
                dt.Columns.Add( "SOCLKK" , typeof( string ) );
                dt.Columns.Add( "GIATRITHUONG" , typeof( string ) );
                dt.Columns.Add( "CUOIKY" , typeof( string ) );

                string _dauky;
                if ( gridView1.GetFocusedRowCellValue( "DauKy" ).ToString().Equals( "" ) )
                    _dauky = " - ";
                else
                    _dauky = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "DauKy" ).ToString() ) );

                string _nhap;
                if ( gridView1.GetFocusedRowCellValue( "Nhap" ).ToString().Equals( "" ) )
                    _nhap = " - ";
                else
                    _nhap = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Nhap" ).ToString() ) );

                string _xuat;
                if ( gridView1.GetFocusedRowCellValue( "Xuat" ).ToString().Equals( "" ) )
                    _xuat = " - ";
                else
                    _xuat = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Xuat" ).ToString() ) );

                string _ban;
                if ( gridView1.GetFocusedRowCellValue( "Ban" ).ToString().Equals( "" ) )
                    _ban = " - ";
                else
                    _ban = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Ban" ).ToString() ) );

                string _kiemke;
                if ( gridView1.GetFocusedRowCellValue( "KiemKe" ).ToString().Equals( "" ) )
                    _kiemke = " - ";
                else
                    _kiemke = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "KiemKe" ).ToString() ) );

                string _cuoiky;
                if ( gridView1.GetFocusedRowCellValue( "CuoiKy" ).ToString().Equals( "" ) )
                    _cuoiky = " - ";
                else
                    _cuoiky = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "CuoiKy" ).ToString() ) );

                string _tongDoanhThu;
                if ( gridView1.GetFocusedRowCellValue( "TongDoanhThu" ).ToString().Equals( "" ) )
                    _tongDoanhThu = " - ";
                else
                    _tongDoanhThu = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "TongDoanhThu" ).ToString() ) );

                //***********************
                string _thuong;
                if ( checkNew( lbFromDate.Text , gridView1.GetFocusedRowCellValue( "Region" ).ToString() ) == false )
                {
                    if ( gridView1.GetFocusedRowCellValue( "ThuongDoanhThu" ).ToString().Equals( "" ) )
                        _thuong = " - ";
                    else
                        _thuong = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "ThuongDoanhThu" ).ToString() ) );
                }
                else
                {
                    if ( gridView1.GetFocusedRowCellValue( "ThuongDoanhThu_New" ).ToString().Equals( "" ) )
                        _thuong = " - ";
                    else
                        _thuong = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "ThuongDoanhThu_New" ).ToString() ) );
                }

                string _hangMatMa;
                if ( gridView1.GetFocusedRowCellValue( "HangMatMa_Qty" ).ToString().Equals( "" ) )
                    _hangMatMa = " - ";
                else
                    _hangMatMa = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "HangMatMa_Qty" ).ToString() ) );

                string _giatridenbu;
                if ( checkNew( lbFromDate.Text , gridView1.GetFocusedRowCellValue( "Region" ).ToString() ) == false )
                {
                    if ( gridView1.GetFocusedRowCellValue( "GiaTriDenBu" ).ToString().Equals( "" ) )
                        _giatridenbu = " - ";
                    else
                        _giatridenbu = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu" ).ToString() ) );

                }
                else
                {
                    if ( gridView1.GetFocusedRowCellValue( "GiaTriDenBu_New" ).ToString().Equals( "" ) )
                        _giatridenbu = " - ";
                    else
                        _giatridenbu = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriDenBu_New" ).ToString() ) );
                }

                string _slgChenhLech;
                if ( checkNew( lbFromDate.Text , gridView1.GetFocusedRowCellValue( "Region" ).ToString() ) == false )
                {
                    if ( gridView1.GetFocusedRowCellValue( "Sum_Qty" ).ToString().Equals( "" ) )
                        _slgChenhLech = " - ";
                    else
                        _slgChenhLech = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Qty" ).ToString() ) );

                }
                else
                {
                    if ( gridView1.GetFocusedRowCellValue( "Sum_Qty_New" ).ToString().Equals( "" ) )
                        _slgChenhLech = " - ";
                    else
                        _slgChenhLech = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Qty_New" ).ToString() ) );
                }

                string _giatriChenhLech;
                if ( checkNew( lbFromDate.Text , gridView1.GetFocusedRowCellValue( "Region" ).ToString() ) == false )
                {
                    if ( gridView1.GetFocusedRowCellValue( "Sum_Amount" ).ToString().Equals( "" ) )
                        _giatriChenhLech = " - ";
                    else
                        _giatriChenhLech = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Amount" ).ToString() ) );

                }
                else
                {
                    if ( gridView1.GetFocusedRowCellValue( "Sum_Amount_New" ).ToString().Equals( "" ) )
                        _giatriChenhLech = " - ";
                    else
                        _giatriChenhLech = String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "Sum_Amount_New" ).ToString() ) );
                }

                dt.Rows.Add( gridView1.GetFocusedRowCellValue( "Store_Code" ).ToString() ,
                            DateTime.Now.ToShortDateString() ,
                            gridView1.GetFocusedRowCellValue( "Store_Leader" ).ToString() ,
                            "Nguyễn Văn Châm" ,
                            Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "FromDate" ).ToString() ).ToShortDateString() ,
                            Convert.ToDateTime( gridView1.GetFocusedRowCellValue( "ToDate" ).ToString() ).ToShortDateString() ,
                            _dauky + " sản phẩm" ,
                            _nhap + " sản phẩm" ,
                            _xuat + " sản phẩm" ,
                            _ban + " sản phẩm" ,
                            _kiemke + " sản phẩm" ,
                            _slgChenhLech + " sản phẩm" ,
                            _giatriChenhLech + " vnđ" ,
                            _tongDoanhThu + " vnđ" ,
                            String.Format( "{0:#,#}" , Convert.ToInt64( gridView1.GetFocusedRowCellValue( "GiaTriThatThoat" ).ToString() ) ) + " vnđ" ,
                            _giatridenbu + " vnđ" ,
                            _hangMatMa + " sản phẩm" ,
                    //String.Format("{0:#,#}", Convert.ToInt64(gridView1.GetFocusedRowCellValue("TotalThuHoiMoney").ToString())) + " vnđ",
                            "" ,
                            gridView1.GetFocusedRowCellValue( "CLKK_No" ).ToString() ,
                            String.Format( "{0:#,#}" , _thuong ) + " vnđ" ,
                            _cuoiky + " sản phẩm" );

                string _date = dateChungTu.EditValue.ToString().Substring( 0 , 10 );

                frm_PrintReport viewrp = new frm_PrintReport();
                viewrp.printCLKK( ds , _date , txtPrintNo.Text );
            }
            catch ( Exception ex )
            {
                XtraMessageBox.Show( ex.ToString() );
            }
        }

        private bool checkNew( string _dateTime , string _region )
        {
            bool flag = false;

            //DateTime date = new DateTime(int.Parse(_dateTime.Substring(6,4)), int.Parse(_dateTime.Substring(3,2)), int.Parse(_dateTime.Substring(0,2)));

            //if (date >= new DateTime(2014, 07, 29) && _region.Equals("HO CHI MINH"))
            //{
            //    flag = true;
            //}

            if ( _region.Equals( "HO CHI MINH" ) )
            {
                flag = true;
                goto Finish;
            }

        Finish:
            return flag;
        }
        #endregion
    }
}