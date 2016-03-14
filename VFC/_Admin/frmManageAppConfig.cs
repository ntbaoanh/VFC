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
    public partial class frmManageAppConfig : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_AppConfig _dalConfig;
        string _error;

        public frmManageAppConfig()
        {
            InitializeComponent();
        }

        private void frmManageAppConfig_Load( object sender , EventArgs e )
        {

        }

        private void btLoad_Click( object sender , EventArgs e )
        {
            txtRunFile.Text = frmMain._myAppConfig.AfterUpdateRunFile;
            txtUpdateURL.Text = frmMain._myAppConfig.SourceUpdate;
            txtOra248.Text = frmMain._myAppConfig.Ora248IP;
            txtOraLan.Text = frmMain._myAppConfig.OraLanIP;
            txtOraLocal.Text = frmMain._myAppConfig.OraLocalIP;
            txtSqlIP.Text = frmMain._myAppConfig.SqlIP;
            txtStoreCode.Text = frmMain._myAppConfig.StoreCode;
            txtStoreNo.Text = frmMain._myAppConfig.StoreNo;
            txtSbsNo.Text = frmMain._myAppConfig.SbsNo;
        }

        private void btSave_Click( object sender , EventArgs e )
        {
            try
            {
                if ( this.iValidate())
                {
                    _dalConfig = new cl_DAL_AppConfig();

                    frmMain._myAppConfig.SourceUpdate = txtUpdateURL.Text.Trim();
                    frmMain._myAppConfig.AfterUpdateRunFile = txtRunFile.Text.Trim();
                    frmMain._myAppConfig.SqlIP = txtSqlIP.Text.Trim();
                    frmMain._myAppConfig.Ora248IP = txtOra248.Text.Trim();
                    frmMain._myAppConfig.OraLocalIP = txtOraLocal.Text.Trim();
                    frmMain._myAppConfig.OraLanIP = txtOraLan.Text.Trim();
                    frmMain._myAppConfig.StoreCode = txtStoreCode.Text.Trim();
                    frmMain._myAppConfig.StoreNo = txtStoreNo.Text.Trim();
                    frmMain._myAppConfig.SbsNo = txtSbsNo.Text.Trim();

                    _dalConfig.writeConfigurationXML( frmMain._myAppConfig , Application.StartupPath.ToString() + @"\xConfig.xml" , frmMain._mySecrect );

                    frmMessageBox.Show( "Thông báo" , "Đã cập nhật cấu hình thành công."
                        + Environment.NewLine
                        + Environment.NewLine
                        + "  *  Chương trình sẽ tự động tắt. Vui lòng mở lại." , "done" );

                    Application.Exit();
                }
                else
                {
                    frmMessageBox.Show( "Thông báo lỗi" , _error , "error" );
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo" , "Ghi XML thất bại."
                    + Environment.NewLine
                    + Environment.NewLine
                    + ex.ToString() , "error" );
            }
        }

        private bool iValidate()
        {
            bool _rs = true;
            _error = "";

            if ( txtOra248.Text.Trim().Equals( "" ) )
            {
                _error += " * Đường dẫn [Oracle 248] không được để trống." + Environment.NewLine;
                _rs = false;
            }

            if ( txtOraLan.Text.Trim().Equals( "" ) )
            {
                _error += " * Đường dẫn [Oracle LAN] không được để trống." + Environment.NewLine;
                _rs = false;
            }

            if ( txtOraLocal.Text.Trim().Equals( "" ) )
            {
                _error += " * Đường dẫn [Oracle Local] không được để trống." + Environment.NewLine;
                _rs = false;
            }

            if ( txtRunFile.Text.Trim().Equals( "" ) )
            {
                _error += " * Đường dẫn [Run File] không được để trống." + Environment.NewLine;
                _rs = false;
            }

            if ( txtSqlIP.Text.Trim().Equals( "" ) )
            {
                _error += " * Đường dẫn [SQL IP]không được để trống." + Environment.NewLine;
                _rs = false;
            }

            if ( txtStoreCode.Text.Trim().Equals( "" ) )
            {
                _error += " * [Cửa hàng] không được để trống." + Environment.NewLine;
                _rs = false;
            }

            if ( txtStoreNo.Text.Trim().Equals( "" ) )
            {
                _error += " * [Store No] không được để trống." + Environment.NewLine;
                _rs = false;
            }

            if ( txtUpdateURL.Text.Trim().Equals( "" ) )
            {
                _error += " * Đường dẫn [Update URL] không được để trống." + Environment.NewLine;
                _rs = false;
            }

            if ( txtSbsNo.Text.Trim().Equals( "" ) )
            {
                _error += " * Đường dẫn [Sbs No] không được để trống." + Environment.NewLine;
                _rs = false;
            }

            return _rs;
        }
    }
}