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

namespace VFC._Admin
{
    public partial class frmManageVersion : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_Version _dalVersion;

        public frmManageVersion()
        {
            InitializeComponent();
        }

        private void frmManageVersion_Load( object sender , EventArgs e )
        {

        }

        private void btLoad_Click( object sender , EventArgs e )
        {
            txtVersion.Text = frmMain._myVersion;
        }

        private void btSave_Click( object sender , EventArgs e )
        {
            _dalVersion = new cl_DAL_Version();

            try
            {
                _dalVersion.WriteVersion( txtVersion.Text , Application.StartupPath.ToString() + @"\xVersion.xml" , frmMain._mySecrect );

                frmMessageBox.Show( "Thông báo" , "Đã cập nhật version thành công."
                    + Environment.NewLine
                    + Environment.NewLine
                    + "  *  Chương trình sẽ tự động tắt. Vui lòng mở lại." , "done" );

                Application.Exit();
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo" , "Ghi XML thất bại."
                    + Environment.NewLine
                    + Environment.NewLine
                    + ex.ToString() , "error" );
            }
        }
    }
}