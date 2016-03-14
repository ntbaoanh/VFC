using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VFC._Merchandise
{
    public partial class frmMER_ShowImage : DevExpress.XtraEditors.XtraForm
    {
        Image _img;
        string _mathietke;
        bool _flag = false;
        Size originalSize;

        public frmMER_ShowImage(Image _image, string _mtk)
        {
            InitializeComponent();
            _img = _image;
            _mathietke = _mtk;
        }

        private void frmMER_ShowImage_Load( object sender , EventArgs e )
        {
            this.Text = _mathietke;
            imageBox.Image = _img;
            originalSize = imageBox.Size;
        }

        private void imageBox_Click( object sender , EventArgs e )
        {
            if ( _flag == false )
            {
                imageBox.Height = originalSize.Height + 300;
                imageBox.Width = originalSize.Width + 300;                
                _flag = true;
            }
            else
            {
                imageBox.Height = originalSize.Height;
                imageBox.Width = originalSize.Width;
                _flag = false;
            }

            this.Height = imageBox.Height;
            this.Width = imageBox.Width;
        }
    }
}