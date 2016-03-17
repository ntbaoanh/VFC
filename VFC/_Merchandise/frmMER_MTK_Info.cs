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
using PRO;

namespace VFC._Merchandise
{
    public partial class frmMER_MTK_Info : DevExpress.XtraEditors.XtraForm
    {
        Image img;
        cl_DAL_Inventory _dalInventory;
        cl_PRO_Inventory _proInventory;
        string _tempMTK;

        public frmMER_MTK_Info()
        {
            InitializeComponent();
        }

        private void frmMER_MTK_Info_Load( object sender , EventArgs e )
        {
            img = Image.FromFile( frmHO_Main._serverImageUrl + "no_images.jpg" );
            imageBox.Image = img;
            txtMTK.Focus();
            this.ClearLabel();
        }

        private void btSearch_Click( object sender , EventArgs e )
        {
            this.FillDataToGirdViewColor(txtMTK.Text.Trim());
            this.FillDataToLabel( txtMTK.Text.Trim() );
            this.FillImage();
        }

        private void btThemHinh_Click( object sender , EventArgs e )
        {

            imageBox.Image.Dispose();
            imageBox.Image = null;
            imageBox.Refresh();
            if ( imageBox.Image != null)
            {
                imageBox.Image.Dispose();
                imageBox.Image = null;
                imageBox.Refresh();
            }            

            _tempMTK = txtMTK.Text.Trim();            
            
            _Merchandise.frmMER_ImportImageToMTK frmThemHinh = new frmMER_ImportImageToMTK(_tempMTK);
            frmThemHinh.ShowDialog();            
        }

        private void imageBox_DoubleClick( object sender , EventArgs e )
        {
            try
            {
                frmMER_ShowImage frmShowImage = new frmMER_ShowImage( imageBox.Image , txtMTK.Text.Trim() );
                frmShowImage.ShowDialog();
            }
            catch ( Exception  )
            {

            }
        }

        #region Action
        private void FillDataToGirdViewColor( string _mtk )
        {
            try
            {
                _dalInventory = new cl_DAL_Inventory();
                gridControl_Color.DataSource = _dalInventory.GetColorListByMTK( _mtk );
            }
            catch ( Exception  )
            {

            }
        }

        private void FillDataToLabel( string _mtk )
        {
            _proInventory = new cl_PRO_Inventory();
            _dalInventory = new cl_DAL_Inventory();

            try
            {
                _proInventory = _dalInventory.GetMTKInfo( txtMTK.Text.Trim() , frmMain._myAppConfig.Ora248IP );

                lbChatLieu.Text = _proInventory.ChatLieu;
                lbColorCount.Text = _proInventory.ColorCount;
                lbKetCau.Text = _proInventory.UDF10;
                lbMTK.Text = _proInventory.MaThietKe;
                lbPriceList.Text = _proInventory.PriceList;
                lbPriceRetail.Text = _proInventory.PriceRetail;
                lbSeason.Text = _proInventory.Season;
                lbSizeRange.Text = _proInventory.SizeRange;
                lbTenSanPham.Text = _proInventory.Desc2;
                lbUDF7.Text = _proInventory.UDF7;
                lbUDF8.Text = _proInventory.UDF8;
                lbVendor.Text = _proInventory.NhaCungCap;
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                this.ClearLabel();
            }
        }

        private void FillImage()
        {
            try
            {
                string _urlIma = frmHO_Main._serverImageUrl + txtMTK.Text.Trim() + ".jpg";
                img = Image.FromFile( _urlIma );
                imageBox.Image = img;
            }
            catch ( NullReferenceException  )
            {
                img = Image.FromFile( frmHO_Main._serverImageUrl + "no_images.jpg" );
                imageBox.Image = img;
            }
            catch ( Exception  )
            {
                img = Image.FromFile( frmHO_Main._serverImageUrl + "no_images.jpg" );
                imageBox.Image = img;
            }
        }

        private void ClearLabel()
        {
            lbChatLieu.Text = "";
            lbColorCount.Text = "";
            lbKetCau.Text = "";
            lbMTK.Text = "";
            lbPriceList.Text = "";
            lbPriceRetail.Text = "";
            lbSeason.Text = "";
            lbSizeRange.Text = "";
            lbTenSanPham.Text = "";
            lbUDF7.Text = "";
            lbUDF8.Text = "";
            lbVendor.Text = "";
        }

        private void UpdateImageFromColor()
        {
            try
            {
                string _urlIma = frmHO_Main._serverImageUrl + txtMTK.Text.Trim() + "_" + gridView_Color.GetFocusedRowCellValue( "ATTR" ).ToString() + ".jpg";
                img = Image.FromFile( _urlIma );
                imageBox.Image = img;
            }
            catch ( NullReferenceException  )
            {
                img = Image.FromFile( frmHO_Main._serverImageUrl + "no_images.jpg" );
                imageBox.Image = img;
            }
            catch ( Exception  )
            {
                img = Image.FromFile( frmHO_Main._serverImageUrl + "no_images.jpg" );
                imageBox.Image = img;
            }
        }
        #endregion    
    }
}