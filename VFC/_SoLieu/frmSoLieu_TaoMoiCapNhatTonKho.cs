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

namespace VFC._SoLieu
{
    public partial class frmSoLieu_TaoMoiCapNhatTonKho : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_Store _store;
        cl_DAL_HoTroKyThuat _dalHoTro;
        DAL.Utilities.Transaction rd;

        public frmSoLieu_TaoMoiCapNhatTonKho()
        {
            InitializeComponent();
        }

        private void frmSoLieu_TaoMoiCapNhatTonKho_Load( object sender , EventArgs e )
        {
            this.FillDataToStoreList();
        }

        private void cbbStores_EditValueChanged( object sender , EventArgs e )
        {
            _store = new cl_DAL_Store();
            try
            {
                lbITPhuTrach.Text = _store.getITFromStore( cbbStores.EditValue.ToString() );
            }
            catch ( Exception  )
            {

            }
        }

        private void btCreate_Click( object sender , EventArgs e )
        {
            if ( this.iValidate().Equals( "" ) )
            {
                try
                {
                    _dalHoTro = new cl_DAL_HoTroKyThuat();
                    if ( _dalHoTro.insert_YeuCauCapNhatKiemKe( cbbStores.EditValue.ToString() , dateDateKK.EditValue.ToString() , Int16.Parse( txtKKQty.Text ) , lbITPhuTrach.Text ) )
                    {
                        rd = new DAL.Utilities.Transaction();
                        rd.record( "Yêu cầu cập nhật tồn kho - " + cbbStores.EditValue.ToString() + " - " + lbITPhuTrach.Text , "11" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                        this.sendEmail( cbbStores.EditValue.ToString() , lbITPhuTrach.Text );
                    }
                    else
                    {

                    }

                    this.Dispose();
                }
                catch ( Exception ex )
                {
                    XtraMessageBox.Show( ex.ToString() , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
            }
            else
            {
                XtraMessageBox.Show( this.iValidate() , "Lỗi !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
        }

        private void btClose_Click( object sender , EventArgs e )
        {
            this.Dispose();
        }

        #region Action
        private void FillDataToStoreList()
        {
            _store = new cl_DAL_Store();
            cbbStores.Properties.DataSource = _store.returnORA_AllStoreCode();
        }

        private string iValidate()
        {
            string rs = "";

            if ( cbbStores.EditValue == null )
            {
                rs += " + Bạn chưa chọn cửa hàng." + Environment.NewLine;
            }

            if ( lbITPhuTrach.Text.Equals( "" ) )
            {
                rs += " + Cửa hàng này đã đóng cửa. " + Environment.NewLine;
            }

            try
            {
                if ( DateTime.Compare( (DateTime) dateDateKK.EditValue , DateTime.Now ) > 0 )
                {
                    rs += " + Bạn chọn ngày ở tương lai " + Environment.NewLine;
                }
            }
            catch ( NullReferenceException  )
            {
                rs += " + Bạn chưa chọn ngày." + Environment.NewLine;
            }
            catch ( Exception ex )
            {
                rs += " + " + ex.ToString() + Environment.NewLine;
            }

            try
            {
                int temp = Int16.Parse( txtKKQty.Text );
                if ( temp < 0 )
                {
                    rs += " + Số lượng kiểm kê không được âm " + Environment.NewLine;
                }
            }
            catch ( Exception  )
            {
                rs += " + Số lượng kiểm kê phải là số tự nhiên" + Environment.NewLine;
            }

            return rs;
        }

        private void sendEmail( string _store , string _it )
        {
            string _cc = _store + ";nhannt";
            string body = "Chao " + _it + "," + "%0d%0A %0d%0A";

            body += "Vui long cap nhat ton kho cho cua hang " + _store + " ." + "%0d%0A%0d%0A";

            body += "\t-\tNgay kiem ke : ".Replace( "\t" , "    " ) + dateDateKK.EditValue.ToString() + "%0d%0A";
            body += "\t-\tTon kho dau ky : ".Replace( "\t" , "    " ) + txtKKQty.Text + "%0d%0A%0d%0A";

            body += "P/S : " + "%0d%0A";
            body += "\t-\tBan co 30ph de cap nhat doi voi cuahang thuoc khu vuc HCM ".Replace( "\t" , "    " ) + "%0d%0A";
            body += "\t-\tban co 24h de cap nhat doi voi cuahang ngoai khu vuc HCM ".Replace( "\t" , "    " );
            body += "%0d%0A%0d%0ARegards,";
            Process.Start( "mailto:" + _it + "?subject=Yeu cau cap nhat ton kho cua hang - " + _store + ",&cc=" + _cc + "&body=" + body );
        }
        #endregion
    }
}