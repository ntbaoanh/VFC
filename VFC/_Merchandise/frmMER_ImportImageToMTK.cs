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
    public partial class frmMER_ImportImageToMTK : DevExpress.XtraEditors.XtraForm
    {
        string _mtk;
        cl_DAL_Inventory _dalInventory;

        public frmMER_ImportImageToMTK( string _mathietke )
        {
            InitializeComponent();
            //_mathietke = "NI-FA-M-TSB-SS-1204032";
            _mtk = _mathietke;
        }

        private void frmMER_ImportImageToMTK_Load( object sender , EventArgs e )
        {
            //_mtk = "NI-FA-M-TSB-SS-1204032";
            this.Text = _mtk;
            lbMTK.Text = _mtk;
        }

        private void btLoadImageURL_Click( object sender , EventArgs e )
        {
            try
            {
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    Image img = Image.FromFile( openFileDialog1.FileName );
                    lbImageURL.Text = openFileDialog1.FileName;
                    imageBox.Image = img;
                }
            }
            catch ( Exception ex )
            {

            }
        }

        private void btSave_Click( object sender , EventArgs e )
        {
            if ( lbImageURL.Text.Equals( "" ) )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Bạn chưa chọn hình" , "error" );
            }
            else
            {
                try
                {
                    this.DisposeImageFromImageBox();

                    string _destDir = frmHO_Main._serverImageUrl;
                        //@"\\192.168.9.208\Softwares\VFC_Update\VFCImages";
                    File.Copy( lbImageURL.Text , Path.Combine( _destDir , lbMTK.Text + ".jpg" ) , true );
                    frmMessageBox.Show( "Thông báo" , "Lưu thành công" , "done" );
                }
                catch ( Exception ex )
                {
                    frmMessageBox.Show( "Thông báo lỗi" , "Lưu thất bại. Vui lòng chọn lại hình." , "error" );
                    this.DisposeImageFromImageBox();
                }
            }
        }

        private void btClose_Click( object sender , EventArgs e )
        {
            this.Dispose();
        }

        #region Action
        private void DisposeImageFromImageBox()
        {
            if ( imageBox.Image != null )
            {
                imageBox.Image.Dispose();
                imageBox.Image = null;
                imageBox.Update();
                imageBox.Refresh();
            }
        }
        #endregion
    }
}