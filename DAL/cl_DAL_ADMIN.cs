using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_ADMIN
    {
        DataTable dt;
        Utilities.SQLCon conn;

        public DataTable GET_DSTinhThanh()
        {
            dt = new DataTable();
            conn = new Utilities.SQLCon();

            string query = "select * from ADMIN.DSTinhThanh order by TenTP_NganGon ASC";
            dt = conn.returnDataTable(query);

            return dt;
        }

        public DataTable GET_NganhNghe()
        {
            dt = new DataTable();
            conn = new Utilities.SQLCon();

            string query = "select * from SUPPLIER.NganhNghe order by TenNganh ASC";
            dt = conn.returnDataTable(query);

            return dt;
        }
    }
}
