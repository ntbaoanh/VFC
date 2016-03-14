using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class cl_DAL_KiemKe
    {
        Utilities.SQLCon _conn;
        DataTable _dt;

        public DataTable GetData_All()
        {
            _dt = new DataTable();
            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "SELECT * FROM tb_IT_CLKK ORDER BY NO DESC";

                _dt = _conn.returnDataTable( _sql );
            }
            catch ( NullReferenceException ex )
            {
                _dt = null;
            }
            catch ( Exception ex )
            {
                _dt = null;
            }

            return _dt;
        }

        public DataTable GetData_ByType( bool _flag )
        {
            _dt = new DataTable();
            try
            {
                _conn = new Utilities.SQLCon();
                int _bool = 0;

                if ( _flag == true )
                {
                    _bool = 1;
                }
                else
                {
                    _bool = 0;
                }

                string _sql = "SELECT * FROM tb_IT_CLKK WHERE Status = " + _bool + " ORDER BY NO DESC";

                _dt = _conn.returnDataTable( _sql );
            }
            catch ( NullReferenceException ex )
            {
                _dt = null;
            }
            catch ( Exception ex )
            {
                _dt = null;
            }

            return _dt;
        }

        public bool UpdateKiemKe( string _kkID , string _modifiedBy )
        {
            bool check = true;
            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pKiemKe_Update";
                command.Parameters.AddWithValue( "@No" , _kkID );
                command.Parameters.AddWithValue( "@UserID" , _modifiedBy );
                command.Connection = _conn.getConnection();

                int effect = command.ExecuteNonQuery();
                if ( effect > 0 )
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch ( Exception ex )
            {
                throw new Exception( ex.Message );
            }
            return check;
        }

        public int CountKiemKe( string _user )
        {
            int _result = 0;

            try
            {
                _conn = new Utilities.SQLCon();
                _conn.getConnection();
                _dt = _conn.returnDataTable( "SELECT COUNT(*) FROM tb_IT_CLKK WHERE UserGetTicket = N'" + _user + "' and STATUS = 0" );

                if ( _dt.Rows.Count == 1 )
                {
                    _result = int.Parse( _dt.Rows[0][0].ToString() );
                }
            }
            catch ( Exception ex )
            {

            }

            return _result;
        }

        public int CountAllKiemKe( string _user )
        {
            int _result = 0;

            try
            {
                _conn = new Utilities.SQLCon();
                _conn.getConnection();
                _dt = _conn.returnDataTable( "SELECT COUNT(*) FROM tb_IT_CLKK WHERE STATUS = 0" );

                if ( _dt.Rows.Count == 1 )
                {
                    _result = int.Parse( _dt.Rows[0][0].ToString() );
                }
            }
            catch ( Exception ex )
            {

            }

            return _result;
        }

        public string getITFromStoreCode( string _store )
        {
            string _result = "";

            try
            {
                _conn = new Utilities.SQLCon();
                _conn.getConnection();
                _dt = _conn.returnDataTable( "SELECT IT FROM Stores WHERE STORE_CODE = N'" + _store + "'" );

                if ( _dt.Rows.Count == 1 )
                {
                    _result = _dt.Rows[0][0].ToString();
                }
            }
            catch ( Exception ex )
            {

            }

            return _result;
        }

        public bool insertKiemKe( string _store , string _it , int _qty , string _dateKK , string _modifiedBy )
        {
            bool check = true;
            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pKiemKe_Insert";
                command.Parameters.AddWithValue( "@Store_Code" , _store );
                command.Parameters.AddWithValue( "@IT" , _it );
                command.Parameters.AddWithValue( "@Qty" , _qty );
                command.Parameters.AddWithValue( "@KKDate" , _dateKK );
                command.Parameters.AddWithValue( "@Modified_By" , _modifiedBy );
                command.Connection = _conn.getConnection();

                int effect = command.ExecuteNonQuery();
                if ( effect > 0 )
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch ( Exception ex )
            {
                check = false;
                throw new Exception( ex.Message );
            }
            return check;
        }
    }
}
