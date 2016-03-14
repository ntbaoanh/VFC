using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VFC._Admin
{
    public partial class frmUnlockForm : DevExpress.XtraEditors.XtraForm
    {
        public frmUnlockForm()
        {
            InitializeComponent();
        }

        public frmUnlockForm(string _openForm)
        {
            InitializeComponent();

            if ( _openForm.Equals( "ManageAppConfig" ) )
            {
                Random rd = new Random();
                this.Text = "1";
                this.Text += rd.Next(1,1000000).ToString();
            }
            else if ( _openForm.Equals( "ManageVersion" ) )
            {
                Random rd = new Random();
                this.Text = "2";
                this.Text += rd.Next( 1 , 1000000 ).ToString();
            }
        }

        private void btUnlock_Click( object sender , EventArgs e )
        {
            
            this.Unlock();
        }

        private void Unlock()
        {
            if ( txtPassword.Text.Trim().Equals( frmMain._mySecrect + "1" + this.Text.Substring(1,this.Text.Length-1) ) )
            {
                this.Dispose();                
                frmManageAppConfig _frmManageConfig = new frmManageAppConfig();
                _frmManageConfig.Show();
            }
            else if ( txtPassword.Text.Trim().Equals( frmMain._mySecrect + "2" + this.Text.Substring( 1 , this.Text.Length - 1 ) ) )
            {
                this.Dispose();
                frmManageVersion _frmVersion = new frmManageVersion();
                _frmVersion.Show();
            }
            else
            {
                XtraMessageBox.Show( "Có cố gắng. Nhưng thiếu may mắn."
                    + Environment.NewLine
                    + Environment.NewLine
                    + "  *  Vui lòng thứ lại" , "" , MessageBoxButtons.OK , MessageBoxIcon.Error );

                txtPassword.Text = null;
                txtPassword.Focus();
            }
        }

        private void frmOpenManageConfigForm_Load( object sender , EventArgs e )
        {
            txtPassword.Focus();
        }

        private void txtPassword_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                this.Unlock();
            }
        }
    }
}