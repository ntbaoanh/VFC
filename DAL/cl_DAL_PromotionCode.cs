using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PRO;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_PromotionCode
    {
        Utilities.SQLCon _conn;
        DataTable _dt;

        public DataTable GetListLoaiKM()
        {
            _dt = new DataTable();
            _conn = new Utilities.SQLCon();

            try
            {
                string _querry = "SELECT LoaiKMID, LoaiKMDescription FROM dbo.tb_CS_PromotionCode_PartNumber_LoaiKM";
                _dt = _conn.returnDataTable( _querry );
            }
            catch ( Exception  )
            {
                _dt = null;
            }

            return _dt;
        }

        public string GetPartNumberNotes( int _partNumber )
        {
            string _rs = "";

            try
            {
                int selectedPartNumber = _partNumber;

                _conn = new DAL.Utilities.SQLCon();
                DataTable _dt = new DataTable();
                string sql = "SELECT Notes FROM tb_CS_PromotionCode_PartNumber_Info where PartNumber = " + selectedPartNumber;

                _dt = _conn.returnDataTable( sql );

                _rs = _dt.Rows[0][0].ToString();
            }
            catch ( NullReferenceException  )
            {
                _rs = "No Record";
            }
            catch ( Exception  )
            {
                _rs = "Exception";
            }

            return _rs;
        }

        private bool UpdateGetPromotionCode( int _beginProCodeSid ,
                                                int _endProCodeSid ,
                                                string _dateExpire ,
                                                string _dateCreate ,
                                                string _createdBy ,
                                                string _modifiedBy ,
                                                int _status ,
                                                int _partNumber ,
                                                int _loaiKM ,
                                                int _amountKM ,
                                                string _notes )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pCS_PromotionCode_Info_Update";
                command.Parameters.AddWithValue( "@BeginProCodeSid" , _beginProCodeSid );
                command.Parameters.AddWithValue( "@EndProCodeSid" , _endProCodeSid );
                command.Parameters.AddWithValue( "@DateExpire" , this.ConvertDateToSQL( _dateExpire ) );
                command.Parameters.AddWithValue( "@DateCreate" , this.ConvertDateToSQL( _dateCreate ) );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@ModifiedBy" , _modifiedBy );
                command.Parameters.AddWithValue( "@Status" , _status );
                command.Parameters.AddWithValue( "@PartNumber" , _partNumber );
                command.Parameters.AddWithValue( "@LoaiKM" , _loaiKM );
                command.Parameters.AddWithValue( "@AmountKM" , _amountKM );
                command.Parameters.AddWithValue( "@Notes" , _notes );
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
                throw new Exception( "[UpdateGetPromotionCode] - " + ex.Message );
            }

            _conn.closeConnection();
            return _rsFlag;
        }

        public bool HoldPromotionCode( string _proCode
                                        , string _storeCode
                                        , int _amount
                                        , string _custCMND
                                        , string _custPhone1
                                        , string _custFName
                                        , string _createdBy
                                        , string _workStation
                                        , int _invcNo )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pCS_ProCode_HoldCode";
                command.Parameters.AddWithValue( "@ProCode" , _proCode );
                command.Parameters.AddWithValue( "@StoreCode" , _storeCode );
                command.Parameters.AddWithValue( "@Amount" , _amount );
                command.Parameters.AddWithValue( "@Cust_CMND" , _custCMND );
                command.Parameters.AddWithValue( "@Cust_Phone1" , _custPhone1 );
                command.Parameters.AddWithValue( "@Cust_FullName" , _custFName );
                command.Parameters.AddWithValue( "@CreatedBy" , _createdBy );
                command.Parameters.AddWithValue( "@WorkStation" , _workStation );
                command.Parameters.AddWithValue( "@InvcNo" , _invcNo );
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
                throw new Exception( "[HoldPromotionCode] - " + ex.Message );
            }

            _conn.closeConnection();
            return _rsFlag;
        }

        public DataTable GetListPartNumber( string _orderBy )
        {
            _conn = new Utilities.SQLCon();
            DataTable _dtResult = new DataTable();

            try
            {
                _dtResult = _conn.returnDataTable( "SELECT * " +
                                            "FROM v_CS_PromotionCode_ListPartNumber ORDER BY PartNumber " + _orderBy );
            }
            catch ( Exception  )
            {
                _dtResult = null;
            }

            return _dtResult;
        } 

        public DataTable GetPromotionCode_Used_All_ByDate( string _fromDate , string _toDate )
        {
            _conn = new Utilities.SQLCon();
            DataTable _dtResult = new DataTable();

            try
            {
                string _querry = "SELECT * " +
                                            "FROM v_CS_PromotionCode_Used_2Info " +
                                            "WHERE sys_NgayTao >= '" + this.ConvertDateToSQL( _fromDate ) + "'" +
                                            " and sys_NgayTao <= '" + this.ConvertDateToSQL( _toDate ) + "'";
                _dtResult = _conn.returnDataTable( _querry );
            }
            catch ( Exception  )
            {
                _dtResult = null;
            }

            return _dtResult;
        }

        public DataTable GetPromotionCode_Used_PartNumber( string _partNumber )
        {
            _conn = new Utilities.SQLCon();
            DataTable _dtResult = new DataTable();

            try
            {
                _dtResult = _conn.returnDataTable( "SELECT * " +
                                            "FROM v_CS_PromotionCode_Used_2Info WHERE PartNumber in (" + _partNumber + ")" );
            }
            catch ( Exception  )
            {
                _dtResult = null;
            }

            return _dtResult;
        }

        public DataTable GetPromotionCode_Used_PartNumber_ByDate( string _partNumber , string _fromDate , string _toDate )
        {
            _conn = new Utilities.SQLCon();
            DataTable _dtResult = new DataTable();

            try
            {
                _dtResult = _conn.returnDataTable( "SELECT * " +
                                            "FROM v_CS_PromotionCode_Used_2Info " +
                                            "WHERE PartNumber in (" + _partNumber + ") " +
                                            "AND sys_NgayTao >= '" + this.ConvertDateToSQL( _fromDate ) + "' " +
                                            "AND sys_NgayTao <= '" + this.ConvertDateToSQL( _toDate ) + "'" );
            }
            catch ( Exception  )
            {
                _dtResult = null;
            }

            return _dtResult;
        }

        public DataTable GetPromotionCode_Used_All()
        {
            _conn = new Utilities.SQLCon();
            DataTable _dtResult = new DataTable();

            try
            {
                _dtResult = _conn.returnDataTable( "SELECT * " +
                                            "FROM v_CS_PromotionCode_Used_2Info " );
            }
            catch ( Exception  )
            {
                _dtResult = null;
            }

            return _dtResult;
        }

        public bool ActivePromotionCode( int _qty , string _dateExpire , string _dateCreate , string _createdBy , string _modifiedBy , int _loaiKM , int _amountKM , string _notes )
        {
            bool _rsFlag = false;
            try
            {
                int beginProCodeSid = this.GetMinProCodeSidWaiting() + 1;
                int partNumber = this.GetPartNumber() + 1;

                if ( this.UpdateGetPromotionCode( beginProCodeSid , beginProCodeSid + ( _qty - 1 ) , _dateExpire , _dateCreate , _createdBy , _modifiedBy , 1 , partNumber , _loaiKM , _amountKM , _notes ) )
                {
                    _rsFlag = true;
                }
            }
            catch ( Exception ex )
            {
                _rsFlag = false;
                throw new Exception( ex.ToString() );
            }


            return _rsFlag;
        }

        private int GetMinProCodeSidWaiting()
        {
            int _rsInt = -1;

            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT     MAX(ProCodeSid) AS ProCodeSid " +
                                        "FROM       dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE      (Status <> 0)" );

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rsInt = int.Parse( _dt.Rows[0]["ProCodeSid"].ToString() );
                }
                catch ( Exception  )
                {
                    _rsInt = 0;
                }
            }
            else
            {
                _rsInt = 0;
            }

            return _rsInt;
        }

        private int GetPartNumber()
        {
            int _rsInt = -1;

            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT     MAX(PartNumber) AS PartNumber " +
                                        "FROM       dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE      (Status <> 0)" );

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rsInt = int.Parse( _dt.Rows[0]["PartNumber"].ToString() );
                }
                catch ( Exception  )
                {
                    _rsInt = 0;
                }
            }
            else
            {
                _rsInt = 0;
            }

            return _rsInt;
        }

        public int checkAvaiableProCode( string _code )
        {
            int _rsFlag = 0;

            try
            {
                _dt = new DataTable();
                _conn = new Utilities.SQLCon();

                string sql = "SELECT * FROM tb_CS_PromotionCode_Info WHERE ProCode = '" + _code + "'";

                _dt = _conn.returnDataTable( sql );

                if ( _dt.Rows.Count == 1 )
                {
                    if ( _dt.Rows[0]["Status"].ToString().Equals( "1" ) )
                    {
                        _rsFlag = 1;
                    }
                    else if ( _dt.Rows[0]["Status"].ToString().Equals( "2" ) )
                    {
                        _rsFlag = 2;
                    }
                    else if ( _dt.Rows[0]["Status"].ToString().Equals( "3" ) )
                    {
                        _rsFlag = 3;
                    }
                    else if ( _dt.Rows[0]["Status"].ToString().Equals( "4" ) )
                    {
                        _rsFlag = 4;
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

        public string getInvcSidFromProCode( string _code )
        {
            string _rsString = "";

            _dt = new DataTable();

            _conn = new Utilities.SQLCon();
            string sql = "SELECT * FROM v_CS_PromotionCode_Used_2Info WHERE ProCode = '" + _code + "'";
            _dt = _conn.returnDataTable( sql );

            if ( _dt.Rows.Count == 1 )
            {
                _rsString = _dt.Rows[0]["InvcSid"].ToString();
            }
            else
            {
                _rsString = "";
            }

            return _rsString;
        }

        public cl_PRO_PromotionCode getProCodeInfo( string _proCode , int _proCodeStatus )
        {
            cl_PRO_PromotionCode _rsCode = new cl_PRO_PromotionCode();
            DataTable _dt = new DataTable();
            _conn = new Utilities.SQLCon();

            try
            {
                if ( _proCodeStatus == 1 || _proCodeStatus == 3 || _proCodeStatus == 4 )
                {
                    string sql = "SELECT * FROM v_CS_PromotionCode_Info WHERE Status in ( 1 , 3 , 4 ) and ProCode = N'" + _proCode + "'";
                    _dt = _conn.returnDataTable( sql );

                    _rsCode.StoreNo = null;
                }
                else if ( _proCodeStatus == 2 )
                {
                    string sql = "SELECT * FROM v_CS_PromotionCode_Used_2Info WHERE ProCode = N'" + _proCode + "'";
                    _dt = _conn.returnDataTable( sql );

                    _rsCode.StoreNo = _dt.Rows[0]["sys_StoreNo"].ToString();
                    _rsCode.StoreCode = _dt.Rows[0]["sys_StoreCode"].ToString();
                }

                _rsCode.DateExpire = Convert.ToDateTime( _dt.Rows[0]["Date_Expire"].ToString() ).ToShortDateString();
                _rsCode.UsedCount = int.Parse( _dt.Rows[0]["UsedCount"].ToString() );
                _rsCode.LoaiKM = _dt.Rows[0]["LoaiKMDescription"].ToString();
                _rsCode.AmountKM = int.Parse( _dt.Rows[0]["AmountKM"].ToString() );
                _rsCode.ProCodeSid = int.Parse( _dt.Rows[0]["ProCodeSid"].ToString() );
            }
            catch ( Exception  )
            {
                //throw new Exception( "[cl_DAL_PromotionCode-getProCodeInfo]" + ex.ToString() );
            }

            return _rsCode;
        }

        public bool insertPromotionCode_Info_Invoice( cl_PRO_Invoice _invoice , string _proCodeSid , string _custSid )
        {
            bool _rsFlag = false;

            if ( _invoice == null )
            {
                _rsFlag = false;
            }
            else
            {
                try
                {
                    _conn = new Utilities.SQLCon();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pCS_Invoice_ProCode_Insert";
                    command.Parameters.AddWithValue( "@InvcSid" , _invoice.Invc_sid );
                    command.Parameters.AddWithValue( "@StoreNo" , _invoice.StoreNo );
                    command.Parameters.AddWithValue( "@InvcNo" , _invoice.Invc_No );
                    command.Parameters.AddWithValue( "@TotalMoney" , _invoice.Amount );
                    command.Parameters.AddWithValue( "@TotalQty" , _invoice.Qty );
                    command.Parameters.AddWithValue( "@DiscountMoney" , _invoice.Discount );
                    command.Parameters.AddWithValue( "@CreateDate" , this.ConvertDateToSQL( _invoice.CreatedDate ) );
                    command.Parameters.AddWithValue( "@CreateTime" , _invoice.Time );
                    command.Parameters.AddWithValue( "@ProCodeSid" , _proCodeSid );
                    command.Parameters.AddWithValue( "@CustomerSid" , _custSid );

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
                    throw new Exception( ex.Message );
                }

                _conn.closeConnection();
            }

            return _rsFlag;
        }

        public bool DeActiveCode( int _partNumber )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pCS_PromotionCode_DeActiveCode";
                command.Parameters.AddWithValue( "@PartNumber" , _partNumber );

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
                throw new Exception( ex.Message );
            }

            _conn.closeConnection();
            return _rsFlag;
        }

        public bool ReleasePromotionCode( string _proCode
                                        , string _storeCode
                                        , int _amount
                                        , string _custCMND
                                        , string _custPhone1
                                        , string _releasedBy
                                        , string _workStation
                                        , int _invcNo )
        {
            bool _rsFlag = false;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pCS_ProCode_ReleaseCode";
                command.Parameters.AddWithValue( "@ProCode" , _proCode );
                command.Parameters.AddWithValue( "@StoreCode" , _storeCode );
                command.Parameters.AddWithValue( "@Amount" , _amount );
                command.Parameters.AddWithValue( "@Cust_CMND" , _custCMND );
                command.Parameters.AddWithValue( "@Cust_Phone1" , _custPhone1 );
                command.Parameters.AddWithValue( "@ReleaseBy" , _releasedBy );
                command.Parameters.AddWithValue( "@WorkStation" , _workStation );
                command.Parameters.AddWithValue( "@InvcNo" , _invcNo );
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
                throw new Exception( "[ReleasePromotionCode] - " + ex.Message );
            }

            _conn.closeConnection();
            return _rsFlag;
        }
        #region Count Code
        public int CountUsedCode(int _partNumber)
        {
            int _rs = -1;
            DataTable _dt = new DataTable();
            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT count(*) as QTY " +
                                        "FROM dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE (Status = 2) and PartNumber = " + _partNumber );

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rs = int.Parse( _dt.Rows[0]["QTY"].ToString() );
                }
                catch ( Exception  )
                {
                    
                }
            }
            else
            {
                
            }

            return _rs;
        }

        public int CountHoldCode(int _partNumber)
        {
            int _rs = -1;
            DataTable _dt = new DataTable();
            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT count(*) as QTY " +
                                        "FROM dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE (Status = 3) and PartNumber = " + _partNumber );

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rs = int.Parse( _dt.Rows[0]["QTY"].ToString() );
                }
                catch ( Exception  )
                {
                    
                }
            }
            else
            {
                
            }

            return _rs;
        }

        public int CountAvailableCode(int _partNumber)
        {
            int _rs = -1;
            DataTable _dt = new DataTable();
            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT count(*) as QTY " +
                                        "FROM dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE (Status = 1) and PartNumber = " + _partNumber );

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rs = int.Parse( _dt.Rows[0]["QTY"].ToString() );
                }
                catch ( Exception  )
                {
                    
                }
            }
            else
            {
                
            }

            return _rs;
        }

        public int CountExpiredCode( int _partNumber )
        {
            int _rs = -1;
            DataTable _dt = new DataTable();
            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT count(*) as QTY " +
                                        "FROM dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE (Status = 4) and PartNumber = " + _partNumber );

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rs = int.Parse( _dt.Rows[0]["QTY"].ToString() );
                }
                catch ( Exception  )
                {
                    
                }
            }
            else
            {
               
            }

            return _rs;
        }

        public int CountExpiredCode( )
        {
            int _rs = -1;
            DataTable _dt = new DataTable();
            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT count(*) as QTY " +
                                        "FROM dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE (Status = 4) and PartNumber = ");

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rs = int.Parse( _dt.Rows[0]["QTY"].ToString() );
                }
                catch ( Exception  )
                {
                    
                }
            }
            else
            {
                
            }

            return _rs;
        }

        public int CountHoldCode()
        {
            int _rs = -1;
            DataTable _dt = new DataTable();
            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT count(*) as QTY " +
                                        "FROM dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE (Status = 3)" );

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rs = int.Parse( _dt.Rows[0]["QTY"].ToString() );
                }
                catch ( Exception  )
                {
                   
                }
            }
            else
            {
                
            }

            return _rs;
        }

        public int CountAvailableCode()
        {
            int _rs = -1;
            DataTable _dt = new DataTable();
            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT count(*) as QTY " +
                                        "FROM dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE (Status = 1)" );

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rs = int.Parse( _dt.Rows[0]["QTY"].ToString() );
                }
                catch ( Exception  )
                {
                    
                }
            }
            else
            {
               
            }

            return _rs;
        }

        public int CountUsedCode()
        {
            int _rs = -1;
            DataTable _dt = new DataTable();
            _conn = new Utilities.SQLCon();
            _dt = _conn.returnDataTable( "SELECT count(*) as QTY " +
                                        "FROM dbo.tb_CS_PromotionCode_Info " +
                                        "WHERE (Status = 2)" );

            if ( _dt.Rows.Count == 1 )
            {
                try
                {
                    _rs = int.Parse( _dt.Rows[0]["QTY"].ToString() );
                }
                catch ( Exception  )
                {
                    
                }
            }
            else
            {
                
            }

            return _rs;
        }
#endregion

        public DataTable GetProCodeByPhone( string _phone )
        {
            _dt = new DataTable();

            try
            {
                _conn = new Utilities.SQLCon();
                string _sql = "select ci.ProCodeSid "
                                    + " , ci.ProCode  "
                                    + " , ci.Status "
                                    + " , ci.Date_Expire "
                                    + " , ci.LoaiKMDescription "
                                    + " , ci.AmountKM "
                                    + " , cc.CustSid "
                                    + " , c.GioiTinh "
                                    + " , (c.Ho + c.Ten) as HoTen "
                                    + " , c.CMND "
                                    + " , c.Phone1 "
                                    + " ,  (c.DiaChi1 + ' ' +c.DiaChi2 + ' ' + c.ThanhPho) as DiaChi "
                                    + " , (c.NgaySinh + '/' + c.ThangSinh + '/' + c.NamSinh) as NgaySinh "
                                    + " , c.CustSid "
                                    + " from v_CS_PromotionCode_Info ci, "
	                                    + " tb_CS_PromotionCode_Customer cc, "
	                                    + " tb_Customers c  "
                                    + "  where ci.ProCodeSid = cc.ProCodeSid  "
                                    + " and c.CustSid = cc.CustSid "
                                    + " and ci.ProCodeSid in (select ProCodeSid  "
		                                    + " from tb_CS_PromotionCode_Customer  "
		                                    + " where CustSid in (select CustSid  "
                                                                + " from tb_Customers  "
							                                    + " where Phone1 = '" + _phone + "'))";

                _dt = _conn.returnDataTable( _sql );
            }
            catch ( NullReferenceException  )
            {
            }
            catch ( Exception  )
            {
            }

            return _dt;
        }

        private string ConvertDateToSQL( string _date )
        {
            string _rs = "";

            _rs = _date.Substring( 3 , 2 ) + "/" + _date.Substring( 0 , 2 ) + "/" + _date.Substring( 6 , 4 );

            return _rs;
        }
    }
}
