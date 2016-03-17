using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using PRO;

namespace DAL
{
    public class cl_DAL_Customer
    {
        Utilities.ORACon _oraCon;
        Utilities.SQLCon _sqlCon;
        DataTable _dt;

        /*
         * sử dụng table vfcho_Customers để truy xuất cho nhanh
         * kiểm tra xem có view vfc_customers_v_s2 chưa? Nếu chưa thì tạo view
         * sau khi tạo view thì tạo table vfcho_Customers
         */
        public bool createViewCustomer()
        {
            bool _rsFlag = false;

            try
            {

            }
            catch ( Exception  )
            {

            }

            return _rsFlag;
        }

        public int checkExistCustomerByCustSid( cl_PRO_Customer _cust )
        {
            int _rsFlag = 0;
            /*
             *   0 = Not exist.
             *   1 = Exist and Match Phone1
             *   2 = Exist but Not Match Phone1
             */
            try
            {
                _sqlCon = new Utilities.SQLCon();
                string sql = "SELECT * FROM tb_Customers WHERE CustSid = '" + _cust.CustSid + "'";
                DataTable _dt = new DataTable();
                _dt = _sqlCon.returnDataTable( sql );

                if ( _dt.Rows.Count == 1 )
                {
                    if ( _cust.Phone1.Equals( _dt.Rows[0]["Phone1"] ) )
                    {
                        _rsFlag = 1;
                    }
                    else
                    {
                        _rsFlag = 2;
                    }
                }
                else
                {
                    _rsFlag = 0;
                }
            }
            catch ( Exception  )
            {
                _rsFlag = 0;
            }

            return _rsFlag;
        }

        public bool CHECK_Exists_Customer_By_CustSid(string custSID)
        {
            bool flag = false;

            string query = "select * from tb_customers where custsid = '" + custSID + "'";
            _dt = new DataTable();
            _sqlCon = new Utilities.SQLCon();

            _dt = _sqlCon.returnDataTable(query);

            if (_dt.Rows.Count == 1)
            {
                flag = true;
            }

            return flag;
        }

        public bool insertCustomer( cl_PRO_Customer _cust )
        {
            bool _rsFlag = false;

            try
            {
                _sqlCon = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pCustomer_Insert";
                command.Parameters.AddWithValue( "@CustSid" , _cust.CustSid );
                command.Parameters.AddWithValue( "@CustomerID" , _cust.CustID );
                command.Parameters.AddWithValue( "@Ten" , _cust.Ten );
                command.Parameters.AddWithValue( "@Ho" , _cust.Ho );
                command.Parameters.AddWithValue( "@CMND" , _cust.Cmnd );
                command.Parameters.AddWithValue( "@DiaChi1" , _cust.DiaChi1 );
                command.Parameters.AddWithValue( "@DiaChi2" , _cust.DiaChi2 );
                command.Parameters.AddWithValue( "@ThanhPho" , _cust.ThanhPho );
                command.Parameters.AddWithValue( "@NgaySinh" , _cust.NgaySinh );
                command.Parameters.AddWithValue( "@ThangSinh" , _cust.ThangSinh );
                command.Parameters.AddWithValue( "@NamSinh" , _cust.NamSinh );
                command.Parameters.AddWithValue( "@GioiTinh" , _cust.GioiTinh );
                command.Parameters.AddWithValue( "@CusStatusID" , 1 );
                command.Parameters.AddWithValue( "@Phone1" , _cust.Phone1 );
                command.Parameters.AddWithValue( "@Phone2" , _cust.Phone2 );

                command.Connection = _sqlCon.getConnection();

                int effect = command.ExecuteNonQuery();
                if ( effect > 0 )
                {
                    _rsFlag = true;
                }
                else
                {
                    _rsFlag = false;
                }
            }
            catch ( Exception ex )
            {
                _rsFlag = false;
                throw new Exception( ex.Message );
            }

            _sqlCon.closeConnection();

            return _rsFlag;
        }

        public cl_PRO_Customer getCustomerInfoByCustSid_SQL( string _custSid )
        {
            cl_PRO_Customer _myCustomer = new cl_PRO_Customer();

            try
            {
                DataTable _dt = new DataTable();

                _sqlCon = new Utilities.SQLCon();
                string _sql = "SELECT * FROM tb_Customers WHERE CustSid = N'" + _custSid + "'";

                _dt = _sqlCon.returnDataTable( _sql );

                if ( _dt.Rows.Count != 1 )
                {
                    _myCustomer = null;
                }
                else
                {
                    _myCustomer.CustSid = _dt.Rows[0]["CUSTSID"].ToString();
                    _myCustomer.CustID = _dt.Rows[0]["CustomerID"].ToString();
                    _myCustomer.Cmnd = _dt.Rows[0]["CMND"].ToString();
                    _myCustomer.DiaChi1 = _dt.Rows[0]["DiaChi1"].ToString();
                    _myCustomer.DiaChi2 = _dt.Rows[0]["DiaChi2"].ToString();
                    _myCustomer.ThanhPho = _dt.Rows[0]["ThanhPho"].ToString();
                    _myCustomer.Ten = _dt.Rows[0]["Ten"].ToString();
                    _myCustomer.Ho = _dt.Rows[0]["Ho"].ToString();
                    _myCustomer.GioiTinh = _dt.Rows[0]["GioiTinh"].ToString();
                    _myCustomer.Phone1 = _dt.Rows[0]["PHONE1"].ToString();
                    _myCustomer.Phone2 = _dt.Rows[0]["PHONE2"].ToString();

                    try
                    {
                        int ngaySinh = int.Parse( _dt.Rows[0]["NgaySinh"].ToString() );
                        _myCustomer.NgaySinh = ngaySinh;
                    }
                    catch ( Exception  )
                    {
                        _myCustomer.NgaySinh = 0;
                    }

                    try
                    {
                        int thangSinh = int.Parse( _dt.Rows[0]["ThangSinh"].ToString() );
                        _myCustomer.ThangSinh = thangSinh;
                    }
                    catch ( Exception  )
                    {
                        _myCustomer.ThangSinh = 0;
                    }

                    try
                    {
                        int namSinh = int.Parse( _dt.Rows[0]["NamSinh"].ToString() );
                        _myCustomer.NamSinh = namSinh;
                    }
                    catch ( Exception  )
                    {
                        _myCustomer.NamSinh = 0;
                    }
                }
            }
            catch ( Exception ex )
            {
                throw new Exception( "[SQL-getCustomerInfoByCustSid_SQL]" + ex.Message );
            }

            return _myCustomer;
        }

        public cl_PRO_Customer getCustomerInfoByCustSid_RPro9( string _custSid , string _ip )
        {
            cl_PRO_Customer _myCustomer = new cl_PRO_Customer();

            try
            {
                DataTable _dt = new DataTable();

                _oraCon = new Utilities.ORACon();
                string _sql = "select * from vfc_customer_v "
                                   +" where created_date >= TO_DATE('2015-04-17 00:00:00','yyyy-mm-dd HH24:MI:SS','NLS_DATE_LANGUAGE=AMERICAN') "
                                    +"  and active = 1 "
                                    +"  and cust_sid = '" + _custSid + "'";

                _dt = _oraCon.returnDataTable( _sql , _ip );

                if ( _dt.Rows.Count != 1 )
                {
                    _myCustomer = null;
                }
                else
                {
                    _myCustomer.CustSid = _dt.Rows[0]["CUST_SID"].ToString();
                    _myCustomer.CustID = _dt.Rows[0]["CUST_ID"].ToString();
                    _myCustomer.Cmnd = _dt.Rows[0]["INFO1"].ToString();
                    _myCustomer.DiaChi1 = _dt.Rows[0]["ADDRESS1"].ToString();
                    _myCustomer.DiaChi2 = _dt.Rows[0]["ADDRESS2"].ToString();
                    _myCustomer.ThanhPho = _dt.Rows[0]["ADDRESS3"].ToString();
                    _myCustomer.Ho = _dt.Rows[0]["FIRST_NAME"].ToString();
                    _myCustomer.Ten = _dt.Rows[0]["LAST_NAME"].ToString();
                    _myCustomer.GioiTinh = _dt.Rows[0]["TITLE"].ToString();
                    _myCustomer.Phone1 = _dt.Rows[0]["PHONE1"].ToString();
                    _myCustomer.Phone2 = _dt.Rows[0]["PHONE2"].ToString();
                    _myCustomer.Store = _dt.Rows[0]["STORE_CODE"].ToString();

                    try
                    {
                        int ngaySinh = int.Parse( _dt.Rows[0]["UDF_5"].ToString() );
                        _myCustomer.NgaySinh = ngaySinh;
                    }
                    catch ( Exception  )
                    {
                        _myCustomer.NgaySinh = 0;
                    }

                    try
                    {
                        int thangSinh = int.Parse( _dt.Rows[0]["UDF_6"].ToString() );
                        _myCustomer.ThangSinh = thangSinh;
                    }
                    catch ( Exception  )
                    {
                        _myCustomer.ThangSinh = 0;
                    }

                    try
                    {
                        int namSinh = int.Parse( _dt.Rows[0]["UDF_7"].ToString() );
                        _myCustomer.NamSinh = namSinh;
                    }
                    catch ( Exception  )
                    {
                        _myCustomer.NamSinh = 0;
                    }
                }
            }
            catch ( Exception ex )
            {
                throw new Exception( "[ORA-cls_DAL_Customers_getCustomerInfoByCustSid]" + ex.Message );
            }

            return _myCustomer;
        }

        public DataTable ReturnCustomerByPhone( string _phone )
        {
            _dt = new DataTable();

            try
            {
                _sqlCon = new Utilities.SQLCon();
                string _sql = "select * from tb_Customers where Phone1 = '" + _phone + "'";

                _dt = _sqlCon.returnDataTable( _sql );
            }
            catch ( NullReferenceException  )
            {
            }
            catch ( Exception  )
            {
            }

            return _dt;
        }
    }
}
