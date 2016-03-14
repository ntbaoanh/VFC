using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class cl_DAL_CLKK
    {
        Utilities.SQLCon _conn;
        DataTable _dt;

        public DataTable GetData_All()
        {
            _dt = new DataTable();

            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "SELECT * FROM v_CLKK_DanhSach WHERE CLKK_NO > 10273 ORDER BY CLKK_NO DESC";

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

        public DataTable GetData_UnDone()
        {
            _dt = new DataTable();

            try
            {
                _conn = new Utilities.SQLCon();

                string _sql = "SELECT * FROM v_CLKK_DanhSach WHERE CLKK_NO > 10273 and Status NOT IN ('Canceled','Finished') ORDER BY CLKK_NO DESC";

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

        public bool UpdateGuiPhongNhanSu( string _kkID , string _flag )
        {
            bool check = true;
            if ( _flag.Equals( "CHT Ký" ) )
            {
                try
                {
                    _conn = new Utilities.SQLCon();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pCLKK_GuiNhanSu";
                    command.Parameters.AddWithValue( "@No" , _kkID );
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
            }
            else
            {
                try
                {
                    _conn = new Utilities.SQLCon();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pCLKK_GuiNhanSu_Auto";
                    command.Parameters.AddWithValue( "@No" , _kkID );
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
            }

            return check;
        }

        public bool UpdatePrint( string _kkID )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pCLKK_Print";
                command.Parameters.AddWithValue( "@No" , _kkID );
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

        public bool UpdateGuiPOS( string _kkID )
        {
            bool check = true;
            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pCLKK_GuiPOS";
                command.Parameters.AddWithValue( "@No" , _kkID );
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

        public bool DeActiveCLKK( int _soCLKK )
        {
            bool flag = false;

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();

                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.Connection = _conn.getConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SOLIEU.spud_DeActiveKetQuaCLKK";
                command.Parameters.AddWithValue( "@SoCLKK" , _soCLKK );

                int effect = command.ExecuteNonQuery();
                if ( effect > 0 )
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch ( SqlException ex )
            {
                throw new Exception( ex.Message );
            }
            catch ( Exception ex )
            {
                throw new Exception( ex.Message );
            }

            _conn.closeConnection();
            return flag;
        }
    }
}
