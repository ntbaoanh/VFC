using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL.Utilities
{
    public class SQLCon
    {        
        //string _connectionString = ConfigurationManager.ConnectionStrings["DBSQLConnection208"].ConnectionString;
        public static string _sqlStringLocal;
        SqlConnection _conn;
        SqlDataAdapter _adp;
        SqlCommand _cm;
        DataTable _dt;

        public SqlConnection getConnection()
        {
            _conn = new SqlConnection( _sqlStringLocal );
            try
            {
                _conn.Open();
            }
            catch ( Exception ex )
            {
                throw ( new Exception( ex.Message ) );
            }

            return _conn;
        }

        public void closeConnection()
        {
            try
            {
                _conn.Close();
            }
            catch ( Exception ex )
            {
                throw ( new Exception( ex.Message ) );
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataSet getDataSet( SqlCommand sqlCom )
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adt = new SqlDataAdapter( sqlCom );

            try
            {
                adt.Fill( ds );
            }
            catch ( Exception ex )
            {
                throw ( new Exception( ex.Message ) );
            }

            return ds;
        }

        public DataTable getDataTable( SqlCommand sqlCom )
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter( sqlCom );

            try
            {
                adt.Fill( dt );
            }
            catch ( Exception ex )
            {
                throw ( new Exception( ex.Message ) );
            }

            return dt;
        }

        public DataTable returnDataTable( string _querry )
        {
            try
            {
                this.getConnection();
                _cm = new SqlCommand( _querry , _conn );
                _cm.CommandType = CommandType.Text;
                _adp = new SqlDataAdapter();
                _adp.SelectCommand = _cm;
                _dt = new DataTable();
                _adp.Fill( _dt );
            }
            catch ( Exception ex )
            {
                _dt = null;
            }
            finally
            {
                this.closeConnection();
            }

            return _dt;
        }

        public int excuteQuerry( string _querry )
        {
            int count = 0;

            try
            {
                getConnection();
                _cm = new SqlCommand( _querry , _conn );
                count = _cm.ExecuteNonQuery();
            }
            catch ( Exception ex )
            {

            }
            finally
            {
                this.closeConnection();
            }

            return count;
        }

        public bool excuteQuerryBool(string _querry)
        {
            bool flag = false;

            try
            {
                getConnection();
                _cm = new SqlCommand(_querry, _conn);
                _cm.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.closeConnection();
            }

            return flag;
        }

        public bool execStoreProcedure( string spName , string[] parametters , object[] values )
        {
            bool flag = false;
            try
            {
                getConnection();
                _cm = new SqlCommand( spName , _conn );
                _cm.CommandType = CommandType.StoredProcedure;
                for ( int i = 0 ; i < parametters.Length ; i++ )
                {
                    if ( parametters[i] != string.Empty )
                        _cm.Parameters.Add( new SqlParameter( parametters[i] , values[i] ) );
                }
                _cm.ExecuteNonQuery();
                flag = true;
            }
            catch ( Exception ex )
            {
                flag = false;
            }
            finally
            {
                closeConnection();
            }

            return flag;
        }

        public string ConvertDateToSQL(string _date)
        {
            string _rs = "";

            _rs = _date.Substring(3, 2) + "/" + _date.Substring(0, 2) + "/" + _date.Substring(6, 4);

            return _rs;
        }
    }
}
