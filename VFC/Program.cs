using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace VFC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Static Variable
            string _sysadmin = "NHANNT";
            frmMain._mySecrect = "P@SSw0rd";
            frmHO_Main._serverImageUrl = "\\\\192.168.9.208\\Softwares\\VFC_Update\\VFCImages\\";
            string _appConfigUrl = Application.StartupPath.ToString() + @"\xConfig.xml";
            PRO.cl_PRO_AppConfig _myAppConfig = new PRO.cl_PRO_AppConfig();
            DAL.cl_DAL_AppConfig _dalAppConfig = new DAL.cl_DAL_AppConfig();
            _myAppConfig = _dalAppConfig.readAllConfig( _appConfigUrl , frmMain._mySecrect );

            //string serverOnline = myConfig.ora248IP;
            //string serverSQL = "192.168.9.208";
            //string serverSQL = @"112.78.1.236\SQL2014";
            string serverSQLUser = "sa";
            string serverSQLPass = "P@SSw0rd";
            string serverSQLDatabase = "VFC";
            //string database = "RPROODS";
            //string uid = "reportuser";
            //string pwd = "report";

            //ORACon248._oracleStringOnline = "Data Source=(DESCRIPTION="
            //        + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + serverOnline + ")(PORT=1521)))"
            //        + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=" + database + ")));"
            //        + "User Id=" + uid + ";Password=" + pwd + ";";

            //DAL.Utilities.SQLCon._sqlStringLocal = @"Data Source=" + serverSQL + ";Network Library=DBMSSOCN;"
            //        + "Initial Catalog=" + serverSQLDatabase + ";"
            //        + "User Id=" + serverSQLUser + "; Password=" + serverSQLPass;

            DAL.Utilities.SQLCon._sqlStringLocal = @"Data Source=112.78.1.236\SQL2014;Network Library=DBMSSOCN;"
                    + "Initial Catalog=" + serverSQLDatabase + ";"
                    + "User Id=" + serverSQLUser + "; Password=" + serverSQLPass;
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle( "DevExpress Style" );
            //Application.Run( new _Merchandise.frm_InMaVach_Parse_Excel() );
            Application.Run( new frmMain() );
            //Application.Run(new _NhanSu.frmNS_NVBH_Update()) ;
        }
    }
}