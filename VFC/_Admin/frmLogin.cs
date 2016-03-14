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

namespace VFC._Admin
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        string _result;
        cl_DAL_User _dalUser;
        cl_PRO_User _proUser;
        DAL.Utilities.Transaction rd;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosed( object sender , FormClosedEventArgs e )
        {
            Application.Exit();
        }

        private void frmLogin_Load( object sender , EventArgs e )
        {
            txtUser.Text = System.IO.File.ReadAllText( Application.StartupPath.ToString() + @"\lastUser.txt" );
            txtPass.Focus();
        }

        private void btLogin_Click( object sender , EventArgs e )
        {
            this.Login();
        }

        private void btExit_Click( object sender , EventArgs e )
        {
            Application.Exit();
        }

        private void txtPass_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.Login();
            }
        }

        private void txtUser_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.Login();
            }
        }

        #region Action
        private bool iValidate()
        {
            bool flag = true;
            _result = "";

            if ( txtUser.Text == "" )
            {
                _result += " Xin nhập vào [Tên đăng nhập]" + Environment.NewLine;
                flag = false;
            }

            if ( txtPass.Text == "" )
            {
                _result += " Xin nhập vào [Mật khẩu]" + Environment.NewLine;
                flag = false;
            }
            return flag;
        }

        private void Login()
        {
            try
            {
                if ( !iValidate() )
                {                    
                    frmMessageBox.Show( "Thông báo" , _result , "error" );
                }
                else
                {
                    _dalUser = new cl_DAL_User();
                    _proUser = new cl_PRO_User();

                    if ( _dalUser.CheckUserLogin( txtUser.Text , txtPass.Text ) )
                    {
                        try
                        {
                            _proUser = _dalUser.getUserLogin( txtUser.Text );
                            rd = new DAL.Utilities.Transaction();
                            rd.record( "User Login" , "" , _proUser.UserName , System.Environment.MachineName.ToString() );

                            this.Hide();
                            VFC.frmHO_Main mainHO = new frmHO_Main();
                            System.IO.File.WriteAllText( Application.StartupPath.ToString() + @"\lastUser.txt" , txtUser.Text );
                            frmHO_Main._userLogin = _proUser;
                            mainHO.Show();
                        }
                        catch ( Exception ex )
                        {
                            frmMessageBox.Show( "Thông báo" , "Đăng nhập thất bại."
                                + Environment.NewLine
                                + "Xin vui lòng thử lại."
                                + Environment.NewLine
                                + Environment.NewLine
                                + ex.ToString() , "error" );
                        }
                    }
                    else
                    {                        
                        frmMessageBox.Show( "Thông báo" , "Tên đăng nhập hoặc Mật khẩu không đúng." + Environment.NewLine + "Xin vui lòng thử lại." , "error" );
                    }
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo" , ex.ToString() , "error" );
            }
        }
        #endregion

        private void checkShowPass_CheckedChanged( object sender , EventArgs e )
        {
            if ( checkShowPass.CheckState == CheckState.Checked )
            {
                txtPass.Properties.PasswordChar = '\0';                
            }
            else
            {
                txtPass.Properties.PasswordChar = '*';
            }
        }
    }
}