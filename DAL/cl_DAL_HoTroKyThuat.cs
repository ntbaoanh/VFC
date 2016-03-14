using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_HoTroKyThuat
    {
        Utilities.SQLCon _conn;
        DataTable _dt;

        #region Chinh Sua Chung Tu
        public DataTable GetChinhSuaChungTuListByCondition( string _fromDate , string _toDate , string _docType )
        {
            _dt = new DataTable();

            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "SELECT * "
                            + " FROM tb_IT_NhapXoaPhieu "
                            + " WHERE DocType in (" + _docType + ") "
                                + " AND CreatedDate >= '" + this.ConvertDateToSQL(_fromDate) + " 00:00:00' "
                                + " AND CreatedDate <= '" + this.ConvertDateToSQL(_toDate) + " 23:59:59'";

                _dt = _conn.returnDataTable( _sql );
            }
            catch ( Exception ex )
            {

            }

            return _dt;
        }

        public DataTable GetChinhSuaChungTuListAll()
        {
            _dt = new DataTable();

            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "SELECT * "
                            + " FROM tb_IT_NhapXoaPhieu ";

                _dt = _conn.returnDataTable( _sql );
            }
            catch ( Exception ex )
            {

            }

            return _dt;
        }

        public bool insert_NhapXoaPhieu( string _fromStore , string _toStore , string _docDate , int _docQty , int _docNo , string _createdBy , string _job )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pIT_NhapXoaPhieu_Insert";
                command.Parameters.AddWithValue( "@FromStore" , _fromStore );
                command.Parameters.AddWithValue( "@ToStore" , _toStore );
                command.Parameters.AddWithValue( "@DocQty" , _docQty );
                command.Parameters.AddWithValue( "@DocNo" , _docNo );
                command.Parameters.AddWithValue( "@DocDate" , _docDate );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@Job" , _job );
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

        public bool insert_NhapXoaPhieu_Nhap( string _fromStore , string _docDate , int _docQty , int _docNo , string _createdBy , string _job , string _newDocDate , string _notes , string _docType )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pIT_NhapXoaPhieu_Nhap";
                command.Parameters.AddWithValue( "@FromStore" , _fromStore );
                command.Parameters.AddWithValue( "@DocQty" , _docQty );
                command.Parameters.AddWithValue( "@DocNo" , _docNo );
                command.Parameters.AddWithValue( "@DocDate" , _docDate );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@Job" , _job );
                command.Parameters.AddWithValue( "@NewDocDate" , _newDocDate );
                command.Parameters.AddWithValue( "@Notes" , _notes );
                command.Parameters.AddWithValue( "@DocType" , _docType );
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

        public bool insert_NhapXoaPhieu_Xoa( string _fromStore , string _docDate , int _docQty , int _docNo , string _createdBy , string _docType , string _newDocDate , string _notes , string _job )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pIT_NhapXoaPhieu_Xoa";
                command.Parameters.AddWithValue( "@FromStore" , _fromStore );
                command.Parameters.AddWithValue( "@DocQty" , _docQty );
                command.Parameters.AddWithValue( "@DocNo" , _docNo );
                command.Parameters.AddWithValue( "@DocDate" , _docDate );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@DocType" , _docType );
                command.Parameters.AddWithValue( "@NewDocDate" , _newDocDate );
                command.Parameters.AddWithValue( "@Notes" , _notes );
                command.Parameters.AddWithValue( "@Job" , _job );
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

        public bool insert_NhapXoaPhieu_Chinh( string _fromStore , string _docDate , int _docQty , int _docNo , string _createdBy , string _docType , string _newDocDate , string _notes , string _job )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pIT_NhapXoaPhieu_Chinh";
                command.Parameters.AddWithValue( "@FromStore" , _fromStore );
                command.Parameters.AddWithValue( "@DocQty" , _docQty );
                command.Parameters.AddWithValue( "@DocNo" , _docNo );
                command.Parameters.AddWithValue( "@DocDate" , _docDate );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@DocType" , _docType );
                command.Parameters.AddWithValue( "@NewDocDate" , _newDocDate );
                command.Parameters.AddWithValue( "@Notes" , _notes );
                command.Parameters.AddWithValue( "@Job" , _job );
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

        public bool insert_NhapXoaPhieu_XoaXuatLai( string _fromStore ,
            string _docDate ,
            int _docQty ,
            int _docNo ,
            string _createdBy ,
            string _job ,
            string _newDocDate ,
            string _notes ,
            int _newDocNo ,
            int _newDocQty ,
            string _toStore ,
            string _docType )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pIT_NhapXoaPhieu_XoaXuatLai";
                command.Parameters.AddWithValue( "@FromStore" , _fromStore );
                command.Parameters.AddWithValue( "@ToStore" , _toStore );
                command.Parameters.AddWithValue( "@DocQty" , _docQty );
                command.Parameters.AddWithValue( "@DocNo" , _docNo );
                command.Parameters.AddWithValue( "@DocDate" , _docDate );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@Job" , _job );
                command.Parameters.AddWithValue( "@NewDocQty" , _newDocQty );
                command.Parameters.AddWithValue( "@NewDocNo" , _newDocNo );
                command.Parameters.AddWithValue( "@NewDocDate" , _newDocDate );
                command.Parameters.AddWithValue( "@Notes" , _notes );
                command.Parameters.AddWithValue( "@DocType" , _docType );
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

        public bool insert_NhapXoaPhieu_NhapXuatBan( string _fromStore ,
            string _docDate ,
            int _docQty ,
            int _docNo ,
            string _createdBy ,
            string _docType ,
            string _newDocDate ,
            string _notes ,
            int _newDocNo ,
            int _newDocQty ,
            string _job )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pIT_NhapXoaPhieu_NhapXuatBan";
                command.Parameters.AddWithValue( "@FromStore" , _fromStore );
                command.Parameters.AddWithValue( "@DocQty" , _docQty );
                command.Parameters.AddWithValue( "@DocNo" , _docNo );
                command.Parameters.AddWithValue( "@DocDate" , _docDate );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@Job" , _job );
                command.Parameters.AddWithValue( "@NewDocQty" , _newDocQty );
                command.Parameters.AddWithValue( "@NewDocNo" , _newDocNo );
                command.Parameters.AddWithValue( "@NewDocDate" , _newDocDate );
                command.Parameters.AddWithValue( "@Notes" , _notes );
                command.Parameters.AddWithValue( "@DocType" , _docType );
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
        #endregion

        #region Ho Tro Ky Thuat
        public DataTable GetHoTro_All()
        {
            _dt = new DataTable();
            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "SELECT * FROM v_IT_HoTroKyThuat ORDER BY [No] DESC";

                _dt = _conn.returnDataTable( _sql );
            }
            catch ( Exception ex )
            {
                throw new Exception( ex.Message );
                _dt = null;
            }

            return _dt;
        }

        public DataTable GetHoTro_UnDone()
        {
            _dt = new DataTable();
            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "SELECT * FROM v_IT_HoTroKyThuat WHERE [Status] <> 'Done' ORDER BY [No] DESC";

                _dt = _conn.returnDataTable( _sql );
            }
            catch ( Exception ex )
            {
                throw new Exception( ex.Message );
                _dt = null;
            }

            return _dt;
        }

        public bool insert_HoTroKyThuat( string _store , string _note , string _createdBy , int _supportID , string _itPhuTrach )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pIT_HoTroKyThuat_Insert";
                command.Parameters.AddWithValue( "@Store" , _store );
                command.Parameters.AddWithValue( "@Note" , _note );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@SupportID" , _supportID );
                command.Parameters.AddWithValue( "@ITPhuTrach" , _itPhuTrach );
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

        public bool updateGetTicket( string _no , string _user , string _notes )
        {
            bool flag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pIT_HoTroKyThuat_Update_GetTicket";
                command.Parameters.AddWithValue( "@No" , _no );
                command.Parameters.AddWithValue( "@User" , _user );
                command.Parameters.AddWithValue( "@Note" , _notes );
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

        public bool updateDone( string _no , string _user , string _notes )
        {
            bool flag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pIT_HoTroKyThuat_Update_Done";
                command.Parameters.AddWithValue( "@No" , _no );
                command.Parameters.AddWithValue( "@User" , _user );
                command.Parameters.AddWithValue( "@Note" , _notes );
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

        public int CountSuCo( string _user )
        {
            int _result = 0;

            try
            {
                _conn = new Utilities.SQLCon();
                _conn.getConnection();
                _dt = _conn.returnDataTable( "select COUNT(*) from v_IT_HoTroKyThuat where ITPhuTrach = N'" + _user + "' and STATUS <> 'Done'" );

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

        public bool insert_YeuCauCapNhatKiemKe( string _store , string _dateKK , int _KKQty , string _itPhuTrach )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pSoLieu_CapNhatKiemKe_Insert";
                command.Parameters.AddWithValue( "@Store" , _store );
                command.Parameters.AddWithValue( "@DateKK" , _dateKK.Substring( 6 , 4 ) + "-" + _dateKK.Substring( 3 , 2 ) + "-" + _dateKK.Substring( 0 , 2 ) );
                command.Parameters.AddWithValue( "@ITPhuTrach" , _itPhuTrach );
                command.Parameters.AddWithValue( "@KKQty" , _KKQty );
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
        #endregion

        private string ConvertDateToSQL( string _date )
        {
            string _rs = "";

            _rs = _date.Substring( 3 , 2 ) + "/" + _date.Substring( 0 , 2 ) + "/" + _date.Substring( 6 , 4 );

            return _rs;
        }
    }
}
