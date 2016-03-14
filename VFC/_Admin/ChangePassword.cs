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
    public partial class ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        string _error;
        cl_DAL_User execUser;
        DAL.Utilities.Transaction rd;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load( object sender , EventArgs e )
        {
            lbUserID.Text = frmHO_Main._userLogin.UserName;
            txtOld.Focus();

        }

        private void btSave_Click( object sender , EventArgs e )
        {
            
            if ( this.validatePassword() == false )
            {
                XtraMessageBox.Show( _error , "Thông báo lỗi !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
            else
            {
                try
                {
                    rd = new DAL.Utilities.Transaction();
                    execUser = new cl_DAL_User();
                    execUser.updatePassword( txtNew2.Text.Trim() , lbUserID.Text );
                    XtraMessageBox.Show( "Đổi mật khẩu thành công." , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                    rd.record( "User changed password." , "0" , frmHO_Main._userLogin.UserName , System.Environment.MachineName.ToString() );
                    this.Dispose();
                }
                catch ( Exception ex )
                {
                    XtraMessageBox.Show( "Đổi mật khẩu không thành công." , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    this.Dispose();
                }
            }
        }

        private void btCancel_Click( object sender , EventArgs e )
        {
            this.Dispose();
        }

        private bool validatePassword()
        {
            bool flag = true;
            _error = "";

            if ( !txtNew2.Text.Equals( txtNew1.Text ) )
            {
                _error += " - Mật khẩu mới nhập lại không giống. Vui lòng nhập lại. ";
                flag = false;
            }
            else
            {
                execUser = new cl_DAL_User();
                if ( !execUser.CheckUserLogin( lbUserID.Text , txtOld.Text.Trim() ) )
                {
                    _error += " - Mật khẩu cũ không đúng. Vui lòng nhập lại. ";
                    flag = false;
                }
            }

            return flag;
        }
    }
}