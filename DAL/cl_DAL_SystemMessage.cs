using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PRO;

namespace DAL
{
    public class cl_DAL_SystemMessage
    {
        DataTable _dt;
        Utilities.SQLCon _conn;

        public cl_PRO_SystemMessage GetMessageInfoByMessageID( int _id )
        {
            cl_PRO_SystemMessage _proMessage = new cl_PRO_SystemMessage();

            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "SELECT * FROM tb_System_Messages WHERE MessageID = " + _id + " and Active = 1";

                _dt = _conn.returnDataTable( _sql );

                if ( _dt.Rows.Count == 1 )
                {
                    _proMessage.Active = (bool) _dt.Rows[0]["Active"];
                    _proMessage.CreatedBy = _dt.Rows[0]["CreatedBy"].ToString();
                    _proMessage.CreatedDate = _dt.Rows[0]["CreatedDate"].ToString();
                    _proMessage.Important = int.Parse(_dt.Rows[0]["Important"].ToString());
                    _proMessage.Message = _dt.Rows[0]["Message"].ToString();
                    _proMessage.MessageId = int.Parse(_dt.Rows[0]["MessageId"].ToString());
                    _proMessage.ModifiedBy = _dt.Rows[0]["ModifiedBy"].ToString();
                    _proMessage.ModifiedDate = _dt.Rows[0]["ModifiedDate"].ToString();
                    _proMessage.Title = _dt.Rows[0]["Title"].ToString();
                }
            }
            catch ( NullReferenceException  )
            {

            }
            catch ( Exception  )
            {

            }

            return _proMessage;
        }

        public cl_PRO_SystemMessage GetMessageInfoByPushMessageNo( int _no )
        {
            cl_PRO_SystemMessage _proMessage = new cl_PRO_SystemMessage();

            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "SELECT * FROM v_SystemMessageInfo WHERE No = " + _no + " and Active = 1";

                _dt = _conn.returnDataTable( _sql );

                if ( _dt.Rows.Count == 1 )
                {
                    _proMessage.Active = (bool) _dt.Rows[0]["Active"];
                    _proMessage.CreatedBy = _dt.Rows[0]["CreatedBy"].ToString();
                    _proMessage.CreatedDate = _dt.Rows[0]["CreatedDate"].ToString();
                    _proMessage.Important = int.Parse( _dt.Rows[0]["Important"].ToString() );
                    _proMessage.Message = _dt.Rows[0]["Message"].ToString();
                    _proMessage.MessageId = int.Parse( _dt.Rows[0]["MessageId"].ToString() );
                    _proMessage.ModifiedBy = _dt.Rows[0]["ModifiedBy"].ToString();
                    _proMessage.ModifiedDate = _dt.Rows[0]["ModifiedDate"].ToString();
                    _proMessage.Title = _dt.Rows[0]["Title"].ToString();
                    _proMessage.PushDateRead = _dt.Rows[0]["DateRead"].ToString();
                    _proMessage.PushNo = int.Parse(_dt.Rows[0]["No"].ToString());
                    _proMessage.PushReadStatus = (bool)( _dt.Rows[0]["StatusRead"]);
                    _proMessage.PushStore = _dt.Rows[0]["StoreCode"].ToString();
                }
            }
            catch ( NullReferenceException  )
            {

            }
            catch ( Exception  )
            {

            }

            return _proMessage;
        }

        public bool UpdateRead( int _no , string _store , int _messageID )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pSystemMessage_UpdateRead";
                command.Parameters.AddWithValue( "@MessageID" , _messageID );
                command.Parameters.AddWithValue( "@StoreCode" , _store );
                command.Parameters.AddWithValue( "@No" , _no );
                command.Connection = _conn.getConnection();

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
                throw new Exception( "[pSystemMessage_UpdateRead] - " + ex.Message );
            }

            _conn.closeConnection();

            return _rsFlag;
        }

        public int CountMessageUnread( string _storeCode )
        {
            int _rs = 0;

            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "SELECT COUNT(*) FROM v_SystemMessageInfo where StoreCode = '" + _storeCode + "' and StatusRead = 0";

                _dt = _conn.returnDataTable( _sql );

                _rs = int.Parse( _dt.Rows[0][0].ToString() );
            }
            catch ( NullReferenceException  )
            {
                _rs = -2;
            }
            catch ( Exception  )
            {
                _rs = -1;
            }

            return _rs;
        }

        public DataTable GetAllMessageActive_StoreCode(string _storeCode)
        {
            _dt = new DataTable();

            _conn = new Utilities.SQLCon();
            string _sql = "SELECT * "
                        + " FROM v_SystemMessageInfo WHERE Active = 1 and StoreCode = '" + _storeCode + "' ORDER BY Important DESC";

            _dt = _conn.returnDataTable( _sql );

            return _dt;
        }

        public DataTable GetAllMessageActive()
        {
            _dt = new DataTable();

            _conn = new Utilities.SQLCon();
            string _sql = "SELECT * FROM tb_System_Messages WHERE Active = 1 ORDER BY MessageID DESC";

            _dt = _conn.returnDataTable( _sql );

            return _dt;
        }

        public DataTable GetAllMessage()
        {
            _dt = new DataTable();

            _conn = new Utilities.SQLCon();
            string _sql = "SELECT * FROM tb_System_Messages ORDER BY MessageID DESC";

            _dt = _conn.returnDataTable( _sql );

            return _dt;
        }

        public DataTable GetAllMessage( string _userLogin )
        {
            _dt = new DataTable();

            _conn = new Utilities.SQLCon();
            string _sql = "SELECT * FROM tb_System_Messages WHERE CreatedBy = N'" + _userLogin + "' ORDER BY MessageID DESC";

            _dt = _conn.returnDataTable( _sql );

            return _dt;
        }

        public DataTable GetMessageByDate(string _fromDate, string _toDate)
        {
            _dt = new DataTable();

            _conn = new Utilities.SQLCon();
            string _sql = "SELECT * FROM tb_System_Messages WHERE CreatedDate >= '" 
                                    + this.ConvertDateToSQL( _fromDate ) 
                                    + " 00:00:00' and CreatedDate <= '" 
                                    + this.ConvertDateToSQL( _fromDate ) 
                                    + " 23:59:59' ORDER BY MessageID DESC";

            _dt = _conn.returnDataTable( _sql );

            return _dt;
        }

        public DataTable GetMessageByDate( string _fromDate, string _toDate, string _userLogin )
        {
            _dt = new DataTable();

            _conn = new Utilities.SQLCon();
            string _sql = "SELECT * FROM tb_System_Messages WHERE CreatedDate >= '"
                                    + this.ConvertDateToSQL( _fromDate )
                                    + " 00:00:00' and CreatedDate <= '"
                                    + this.ConvertDateToSQL( _fromDate )
                                    + " 23:59:59' AND CreatedBy = N'" + _userLogin + "' ORDER BY MessageID DESC";

            _dt = _conn.returnDataTable( _sql );

            return _dt;
        }

        public bool InsertPushMessage( int _messageID , string _storeCode )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pSystemMessage_PushStore";
                command.Parameters.AddWithValue( "@MessageID" , _messageID );
                command.Parameters.AddWithValue( "@StoreCode" , _storeCode );
                command.Connection = _conn.getConnection();

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
                throw new Exception( "[pSystemMessage_PushStore] - " + ex.Message );
            }

            _conn.closeConnection();
            return _rsFlag;
        }

        public bool InsertMessage( string _title ,
                                                string _body ,
                                                string _createdBy ,                                                
                                                int _important )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pSystemMessage_Info_Insert";
                command.Parameters.AddWithValue( "@Title" , _title );
                command.Parameters.AddWithValue( "@Message" , _body );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@Important" , _important );
                command.Connection = _conn.getConnection();

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
                throw new Exception( "[pSystemMessage_Info_Insert] - " + ex.Message );
            }

            _conn.closeConnection();
            return _rsFlag;
        }

        public bool UpdateMessage( int _id ,
                                                string _title ,
                                                string _body ,
                                                string _modifiedBy ,
                                                int _important )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pSystemMessage_Info_Update";
                command.Parameters.AddWithValue( "@MessageID" , _id );
                command.Parameters.AddWithValue( "@Title" , _title );
                command.Parameters.AddWithValue( "@Message" , _body );
                command.Parameters.AddWithValue( "@ModifiedBy" , _modifiedBy );
                command.Parameters.AddWithValue( "@Important" , _important );
                command.Connection = _conn.getConnection();

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
                throw new Exception( "[pSystemMessage_Info_Update] - " + ex.Message );
            }

            _conn.closeConnection();
            return _rsFlag;
        }

        public bool ActiveMessage( string _modifiedBy ,
                                                int _id )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pSystemMessage_Info_Active";
                command.Parameters.AddWithValue( "@ModifiedBy" , _modifiedBy );
                command.Parameters.AddWithValue( "@MessageID" , _id );
                command.Connection = _conn.getConnection();

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
                throw new Exception( "[pSystemMessage_Info_Active] - " + ex.Message );
            }

            _conn.closeConnection();
            return _rsFlag;
        }

        public bool DeActiveMessage( string _modifiedBy ,
                                                int _id )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pSystemMessage_Info_DeActive";
                command.Parameters.AddWithValue( "@ModifiedBy" , _modifiedBy );
                command.Parameters.AddWithValue( "@MessageID" , _id );
                command.Connection = _conn.getConnection();

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
                throw new Exception( "[pSystemMessage_Info_DeActive] - " + ex.Message );
            }

            _conn.closeConnection();
            return _rsFlag;
        }

        private string ConvertDateToSQL( string _date )
        {
            string _rs = "";

            _rs = _date.Substring( 3 , 2 ) + "/" + _date.Substring( 0 , 2 ) + "/" + _date.Substring( 6 , 4 );

            return _rs;
        }
    }
}
