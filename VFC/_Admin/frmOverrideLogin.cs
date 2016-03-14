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
    public partial class frmOverrideLogin : DevExpress.XtraEditors.XtraForm
    {
        string _result;
        cl_DAL_User _dalUser;
        cl_PRO_User _proUser;
        DAL.Utilities.Transaction rd;
        public string UserNameOverride;

        public frmOverrideLogin()
        {
            InitializeComponent();
        }

        #region Action
        private bool iValidate()
        {
            bool flag = true;
            _result = "";

            if (txtUser.Text == "")
            {
                _result += " Xin nhập vào [Tên đăng nhập]" + Environment.NewLine;
                flag = false;
            }

            if (txtPass.Text == "")
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
                if (!iValidate())
                {
                    frmMessageBox.Show("Thông báo", _result, "error");
                }
                else
                {
                    _dalUser = new cl_DAL_User();
                    _proUser = new cl_PRO_User();

                    if (_dalUser.CheckUserLogin(txtUser.Text, txtPass.Text))
                    {
                        try
                        {
                            _proUser = _dalUser.getUserLogin(txtUser.Text);
                            rd = new DAL.Utilities.Transaction();
                            rd.record("User override 43", "", _proUser.UserName, System.Environment.MachineName.ToString());

                            frmHO_Main._flagOverride = true;
                            this.UserNameOverride = _proUser.UserName;
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            frmMessageBox.Show("Thông báo", "Lỗi không xác định. Vui lòng liên hệ quản trị viên."
                                + Environment.NewLine
                                + "Xin vui lòng thử lại."
                                + Environment.NewLine
                                + Environment.NewLine
                                + ex.ToString(), "error");
                        }
                    }
                    else
                    {
                        frmMessageBox.Show("Thông báo", "Tên đăng nhập hoặc Mật khẩu không đúng." + Environment.NewLine + "Xin vui lòng thử lại.", "error");
                    }
                }
            }
            catch (Exception ex)
            {
                frmMessageBox.Show("Thông báo", ex.ToString(), "error");
            }
        }
        #endregion

        private void frmOverrideLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.CheckState == CheckState.Checked)
            {
                txtPass.Properties.PasswordChar = '\0';
            }
            else
            {
                txtPass.Properties.PasswordChar = '*';
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login();
            }
        }
    }
}