using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class cl_DAL_Store
    {
        Utilities.ORACon _conn248;
        Utilities.SQLCon _connSQL;
        DataTable dt;

        public DataTable returnORA_AllStoreCode()
        {
            dt = new DataTable();
            _conn248 = new Utilities.ORACon();

            string querry = "SELECT * FROM CUAHANG_V WHERE ACTIVE = 1 AND SBS_NO = 2 AND STORE_NO NOT IN (163,111,110,109,2,307,309) ORDER BY STORE_CODE";

            dt = _conn248.returnDataTable( querry , "192.168.9.248" );
            return dt;
        }

        public DataTable returnORA_AllStoreCodeHCM()
        {
            dt = new DataTable();
            _conn248 = new Utilities.ORACon();
            string querry = "SELECT * FROM CUAHANG_V WHERE ACTIVE = 1 AND SBS_NO = 2 AND REGION_NAME = 'HO CHI MINH' AND STORE_NO NOT IN (163,111,110,109,2,307,309) ORDER BY STORE_CODE";

            dt = _conn248.returnDataTable( querry , "192.168.9.248" );
            return dt;
        }

        public DataTable returnORA_StoreCodeFromRegion( string _region )
        {
            dt = new DataTable();
            _conn248 = new Utilities.ORACon();
            string querry = "SELECT * FROM CUAHANG_V WHERE ACTIVE = 1 AND SBS_NO = 2 AND REGION_NAME IN (" + _region + ") AND STORE_NO NOT IN (163,111,110,109,2,307,309) ORDER BY STORE_CODE";

            dt = _conn248.returnDataTable( querry , "192.168.9.248");
            return dt;
        }

        public DataTable returnSQL_AllStoreCodeHCM()
        {
            dt = new DataTable();
            _connSQL = new Utilities.SQLCon();
            string querry = "select * from tb_Stores where Region = 'HO CHI MINH' and active = 1 order by Store_Code";

            dt = _connSQL.returnDataTable(querry);
            return dt;
        }

        public string getITFromStore( string _store )
        {
            string _rs;

            DataTable dt = new DataTable();
            _connSQL = new Utilities.SQLCon();
            string querry = "SELECT IT FROM tb_stores WHERE STORE_CODE = '" + _store + "'";

            dt = _connSQL.returnDataTable( querry );
            _rs = dt.Rows[0][0].ToString();

            return _rs;
        }
    }
}