using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Utilities
{
    public class Transaction
    {
        SQLCon _conn;

        public bool record( string _procName , string _jobID , string _user , string _computerName )
        {
            bool flag = false;

            try
            {
                _conn = new SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pRecord_Transaction";
                command.Parameters.AddWithValue( "@ProcName" , _procName );
                command.Parameters.AddWithValue( "@JobID" , _jobID );
                command.Parameters.AddWithValue( "@User" , _user );
                command.Parameters.AddWithValue( "@ComputerName" , _computerName );
                command.Connection = _conn.getConnection();

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
            catch ( Exception ex )
            {
                throw new Exception( ex.Message );
            }

            return flag;
        }
    }
}
