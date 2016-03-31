using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PRO;
using DAL;
using System.IO;
using System.Xml;

namespace VFC
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public static string _mySecrect;
        public static cl_PRO_AppConfig _myAppConfig;
        public static string _myVersion;
        public static string _myEnvironment;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load( object sender , EventArgs e )
        {
            DAL.Utilities.VFCEncryption _myEncrypt = new DAL.Utilities.VFCEncryption();
            DAL.Utilities.WorkingWithXML _myXml = new DAL.Utilities.WorkingWithXML();
            
            //Get Local Version
            string _versionUrl = Application.StartupPath.ToString() + @"\xVersion.xml";
            _myVersion = _myXml.readXML( _versionUrl , "version" );
            _myVersion = _myEncrypt.DecryptStringAES( _myVersion , _mySecrect );
            lbVersion.Text = "v." + _myVersion;

            //Get all config
            try
            {
                string _appConfigUrl = Application.StartupPath.ToString() + @"\xConfig.xml";
                _myAppConfig = new cl_PRO_AppConfig();
                cl_DAL_AppConfig _dalAppConfig = new cl_DAL_AppConfig();
                _myAppConfig = _dalAppConfig.readAllConfig( _appConfigUrl , _mySecrect );
            }
            catch ( Exception  )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Có vấn đề trong khi mở chương trình VFC."
                                + Environment.NewLine
                                + " - Vui lòng mở lại" , "error" );
            }

            timer_Update.Interval = 5 * 60 * 1000;
            timer_Update.Start();
        }

        private void btStore_Click( object sender , EventArgs e )
        {
            _myEnvironment = "POS";
            this.Hide();
            frmPOS_Main frmPOS_Main = new frmPOS_Main();
            frmPOS_Main.Show();            
        }

        private void btHO_Click( object sender , EventArgs e )
        {
            _myEnvironment = "HO";
            this.Hide();
            _Admin.frmLogin frmLogin = new _Admin.frmLogin();
            frmLogin.Show();
        }

        private void lbVersion_DoubleClick( object sender , EventArgs e )
        {
            _Admin.frmUnlockForm frmOpen = new _Admin.frmUnlockForm( "ManageVersion" );
            frmOpen.Show(); 
        }

        private void lbDelevelopedBy_DoubleClick( object sender , EventArgs e )
        {
            _Admin.frmUnlockForm frmOpen = new _Admin.frmUnlockForm( "ManageAppConfig" );
            frmOpen.Show(); 
        }

        private void timer_Update_Tick( object sender , EventArgs e )
        {            
            string _mySecrect = "P@SSw0rd";
            string _targetUrl = Application.StartupPath.ToString();
            DAL.Utilities.VFCEncryption myEncrypt;

            try
            {
                myEncrypt = new DAL.Utilities.VFCEncryption();
                string linkXML = Application.StartupPath.ToString() + @"\xConfig.xml";

                string _sourceUrl = this.readXML( linkXML , "sourceUrl" );
                _sourceUrl = myEncrypt.DecryptStringAES( _sourceUrl , _mySecrect );

                string linkLocalVersion = Application.StartupPath.ToString() + @"\xVersion.xml";
                string linkServerVersion = _sourceUrl + @"\xVersion.xml";

                string _versionLocal = this.readXML( linkLocalVersion , "version" );
                _versionLocal = myEncrypt.DecryptStringAES( _versionLocal , _mySecrect );

                string _versionUpdate = this.readXML( linkServerVersion , "version" );
                _versionUpdate = myEncrypt.DecryptStringAES( _versionUpdate , _mySecrect );

                if ( Double.Parse( _versionUpdate ) > Double.Parse( _versionLocal ) )
                {
                    timer_Update.Stop();

                    frmMessageBox.Show( "Thông báo" , "Đã có bản cập nhật mới."
                        + Environment.NewLine
                        + " - Hệ thống sẽ tự động tắt."
                        + Environment.NewLine
                        + " - Vui lòng mở lại." , "alert" );
                    
                    Application.Exit();
                }
            }
            catch ( System.IO.IOException ex )
            {
                frmMessageBox.Show("Thông báo lỗi", "Không kết nối được với máy chủ."
                    + Environment.NewLine
                    + " - Vui lòng kết nối VPN và thử lại.", "error"
                    + Environment.NewLine
                    + ex.ToString());
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string readXML( string _url , string _name )
        {
            string _result = "";
            string fileName = _url;
            FileStream fs = new FileStream( fileName , FileMode.Open );
            XmlTextReader xtr = new XmlTextReader( fs );
            try
            {
                while ( !xtr.EOF )
                {
                    if ( xtr.MoveToContent() == XmlNodeType.Element && xtr.Name == _name )
                    {
                        _result = xtr.ReadElementString();
                    }
                    else
                    {
                        xtr.Read();
                    }
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.ToString() );
            }

            xtr.Close();

            return _result;
        }
    }
}
