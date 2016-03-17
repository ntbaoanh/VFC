using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_InMaVach
    {
        Utilities.SQLCon sqlCon;
        DataTable _dt;

        public string UpdateLenhIn(string _upc, string _datePrint, string _dateReturn)
        {
            string result = "0";
            try
            {
                sqlCon = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlCon.getConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ADMIN.InMaVach_Update_DS_MaVach";

                // input parm
                SqlParameter UPC = command.Parameters.Add( "@UPC" , SqlDbType.NVarChar , 8 );
                UPC.Value = _upc;

                SqlParameter DatePrint = command.Parameters.Add( "@DatePrint" , SqlDbType.NVarChar , 8 );
                DatePrint.Value = _datePrint;

                SqlParameter DateReturn = command.Parameters.Add( "@DateReturn" , SqlDbType.NVarChar , 8 );
                DateReturn.Value = _dateReturn;

                // output parm
                SqlParameter Result = command.Parameters.Add( "@output" , SqlDbType.Int );
                Result.Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                result = Result.Value.ToString();
            }
            catch ( Exception  )
            {

            }

            sqlCon.closeConnection();
            return result;
        }

        public DataTable GetDSachMaVach( string _mtk , string _active)
        {
            _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ADMIN.InMaVach_select_By_MTK";

                if ( !_mtk.Equals( "" ) )
                {
                    cmd.Parameters.AddWithValue( "@MTK" , _mtk );
                }

                if ( !_active.Equals( "all" ) )
                {
                    if ( _active.Equals( "True" ) )
                    {
                        cmd.Parameters.AddWithValue( "@Active" , '1' );
                    }
                    else if ( _active.Equals( "False" ) )
                    {
                        cmd.Parameters.AddWithValue( "@Active" , '0' );
                    }
                }

                SqlDataAdapter adp = new SqlDataAdapter( cmd );

                adp.Fill( _dt );
            }
            catch ( SqlException  )
            {

            }
            catch ( Exception  )
            {

            }

            return _dt;
        }

        public string UploadData( string _sid )
        {
            string result = "0";
            try
            {
                sqlCon = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlCon.getConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ADMIN.InMaVach_Insert";

                // input parm
                SqlParameter SID = command.Parameters.Add( "@SID" , SqlDbType.NVarChar , 13 );
                SID.Value = _sid;

                // output parm
                SqlParameter Result = command.Parameters.Add( "@output" , SqlDbType.Int );
                Result.Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                result = Result.Value.ToString();
            }
            catch ( Exception  )
            {

            }

            sqlCon.closeConnection();
            return result;
        }

        public string SentKLT( string _sid )
        {
            string result = "0";
            try
            {
                sqlCon = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlCon.getConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ADMIN.InMaVach_Sent_KLT";

                // input parm
                SqlParameter SID = command.Parameters.Add( "@SID" , SqlDbType.NVarChar , 13 );
                SID.Value = _sid;

                // output parm
                SqlParameter Result = command.Parameters.Add( "@output" , SqlDbType.Int );
                Result.Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                result = Result.Value.ToString();
            }
            catch ( Exception  )
            {

            }

            sqlCon.closeConnection();
            return result;
        }

        public string DeActive_MTK( string _sid )
        {
            string result = "0";
            try
            {
                sqlCon = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlCon.getConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ADMIN.InMaVach_DeActive_SID";

                // input parm
                SqlParameter SID = command.Parameters.Add( "@SID" , SqlDbType.NVarChar , 13 );
                SID.Value = _sid;

                // output parm
                SqlParameter Result = command.Parameters.Add( "@output" , SqlDbType.Int );
                Result.Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                result = Result.Value.ToString();
            }
            catch ( Exception  )
            {

            }

            sqlCon.closeConnection();
            return result;
        }
    }
}
