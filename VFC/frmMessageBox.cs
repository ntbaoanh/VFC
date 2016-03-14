using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VFC
{
    public partial class frmMessageBox : DevExpress.XtraEditors.XtraForm
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        public frmMessageBox(string _caption, 
                                    string _message, 
                                    string _typeIcon )
        {
            InitializeComponent();

            this.Text = _caption;
            txtMessage.Text = _message;
            btLeft.Text = "OK";
            btLeft.Image = imageList_Button.Images["Check.ico"];

            if ( _typeIcon.Equals( "alert" ) )  
            {
                picMessageIcon.Image = imageList_MessageIcon.Images["alert.png"];
            }
            else if ( _typeIcon.Equals( "error" ) )
            {
                picMessageIcon.Image = imageList_MessageIcon.Images["error.jpg"];
            }
            else if ( _typeIcon.Equals( "done" ) )
            {
                picMessageIcon.Image = imageList_MessageIcon.Images["image.gif"];
            }
        }

        public static void Show( string _caption ,
                                    string _message ,
                                    string _type )
        {
            frmMessageBox myBox = new frmMessageBox( _caption , _message , _type );
            myBox.ShowDialog();
        } 

        private void frmMessageBox_Load( object sender , EventArgs e )
        {

        }

        private void btLeft_Click( object sender , EventArgs e )
        {
            this.Dispose();
        }
    }
}