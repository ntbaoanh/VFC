using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace DAL.Utilities
{
    public class ORACon
    {
        OracleConnection _conn;
        OracleDataAdapter _adp;
        OracleCommand _cm;
        DataTable _dt;

        public OracleConnection GetConnection( string _ipConfigName )
        {
            string _oraString = "";

            _oraString = "Data Source=(DESCRIPTION="
                    + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + _ipConfigName + ")(PORT=1521)))"
                    + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=RPROODS)));"
                    + "User Id=reportuser;Password=report;";

            _conn = new OracleConnection( _oraString );

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

        public DataSet getDataSet( OracleCommand oraCom )
        {
            DataSet ds = new DataSet();
            OracleDataAdapter adt = new OracleDataAdapter( oraCom );

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

        public DataTable returnDataTable( String _querry , string _ipConfigName )
        {
            try
            {
                this.GetConnection( _ipConfigName );
                _cm = new OracleCommand( _querry , _conn );
                _cm.CommandType = CommandType.Text;
                _adp = new OracleDataAdapter();
                _adp.SelectCommand = _cm;
                _dt = new DataTable();
                _adp.Fill( _dt );
            }
            catch ( Exception  )
            {
                _dt = null;
            }
            finally
            {
                this.closeConnection();
            }

            return _dt;
        }


        public bool executeOraQuery( string _querry , string _ipConfigName )
        {
            bool _rsFlag = true;

            try
            {
                this.GetConnection( _ipConfigName );
                OracleCommand command = new OracleCommand( _querry , _conn );
                command.ExecuteNonQuery();
            }
            catch ( Exception  )
            {
                _rsFlag = false;
            }

            return _rsFlag;
        }

        public bool runQuerryByID( int _id , string _ip )
        {
            bool _rsFlag = true;
            try
            {
                SQLCon _conn = new SQLCon();
                DataTable _dtSQL = new DataTable();
                _dtSQL = _conn.returnDataTable( "SELECT Querry FROM tb_QUERRY WHERE QuerryID = " + _id );

                this.executeOraQuery( _dtSQL.Rows[0]["Querry"].ToString() , _ip );
            }
            catch ( Exception  )
            {
                _rsFlag = false;
            }

            return _rsFlag;
        }

        public bool checkOraTableViewExits( string _name , string _ip )
        {
            bool _rsFlag = false;

            try
            {
                DataTable _dt = new DataTable();
                string _querry = "SELECT * FROM " + _name;
                _dt = this.returnDataTable( _querry , _ip );

                if ( _dt != null )
                {
                    _rsFlag = true;
                }
                else
                {
                    _rsFlag = false;
                }
            }
            catch ( Exception  )
            {
                _rsFlag = false;
            }

            return _rsFlag;
        }
    }
}
