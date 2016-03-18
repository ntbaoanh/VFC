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

        public bool MadeByMe(string listInvoice)
        {
            bool flag = true;

            try
            {
                string temp = "select InvoiceSid"
                            + " from SALES.v_NVBH_Invoice iv"
                            + " where iv.InvoiceSid not in (" + listInvoice + ")"
                            + " and iv.StoreNo = 238";

                DataTable _dt = new DataTable();
                conn = new Utilities.SQLCon();
                _dt = conn.returnDataTable(temp);

                if (_dt.Rows.Count > 0)
                {
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        string _query = "delete from SALES.NVBH_Invoice where InvoiceSid in (" + _dt.Rows[i]["InvoiceSid"] + ") and NVSID in (select NVSID from SALES.v_NVBH_Invoice where StoreNo = 238 group by NVSID)";

                        conn = new Utilities.SQLCon();

                        if (conn.excuteQuerry(_query) != 1)
                        {
                            flag = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                flag = false;
            }

            return flag;
        }
    }
}
