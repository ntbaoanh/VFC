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
using System.IO;

namespace VFC._Merchandise
{
    public partial class frmMER_DeleteImageToMTK : DevExpress.XtraEditors.XtraForm
    {
        string _mathietke;
        cl_DAL_Inventory _dalInventory;

        public frmMER_DeleteImageToMTK(string _mtk)
        {
            InitializeComponent();
            _mathietke = _mtk;
        }

        private void frmMER_DeleteImageToMTK_Load( object sender , EventArgs e )
        {
            this.Text = "Xóa hình " + _mathietke;
            this.FillDataToCbbAttr( _mathietke );
            lbMTK.Text = _mathietke;
        }
        
        private void btDeleteImage_Click( object sender , EventArgs e )
        {
            DialogResult dialogResult = MessageBox.Show( "Bạn có muốn xóa hình ?" , "Xóa hình?" , MessageBoxButtons.YesNo );
            if ( dialogResult == DialogResult.Yes )
            {
                if ( cbbAttr.EditValue != null )
                {
                    if ( this.DeletePicture( lbMTK.Text + "_" + cbbAttr.EditValue.ToString() + ".jpg" ) )
                    {
                        frmMessageBox.Show( "Thông báo" , "Đã xóa hình thành công" , "done" );
                        this.Dispose();
                        //frmThemHinh = new frmMER_ImportImageToMTK( _mathietke );
                        //frmThemHinh.ShowDialog();
                    }
                    else
                    {
                        frmMessageBox.Show( "Thông báo lỗi" , "Xóa hình thất bại" , "error" );
                    }
                }
                else
                {
                    frmMessageBox.Show( "Thông báo lỗi" , "Vui lòng chọn màu cần xóa hình" , "error" );
                }
            }
            else if ( dialogResult == DialogResult.No )
            {
                //do something else
            }
        }
        #region Action
        private void FillDataToCbbAttr( string _mtk )
        {
            try
            {
                _dalInventory = new cl_DAL_Inventory();
                cbbAttr.Properties.DataSource = _dalInventory.GetColorListByMTK( _mtk );
            }
            catch ( Exception  )
            {

            }
        }

        private bool DeletePicture( string _imageName )
        {
            bool _rsFlag = false;

            string sourceDir = frmHO_Main._serverImageUrl + "\\" + _imageName;
            string backupDir = frmHO_Main._serverImageUrl + "\\Deleted" + "\\" + _imageName;

            try
            {
                File.Copy( sourceDir , backupDir , true );
                //Image _tempImage = Image.FromFile
                //imageBox.Image
                File.Delete( sourceDir );

                _rsFlag = true;
            }
            catch ( DirectoryNotFoundException  )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Không tìm thấy thư mục gốc" , "error" );
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }

            return _rsFlag;
        }
        #endregion
    }
}