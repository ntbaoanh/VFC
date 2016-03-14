using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_RAP_DoSua
    {
        Utilities.SQLCon conn;
        DataTable _dt;
        SqlDataAdapter adp;
        SqlCommand cmd;

        public DataTable Get_NXT_TheoThang( string _namThang )
        {
            _dt = new DataTable();

            try
            {
                conn = new DAL.Utilities.SQLCon();

                cmd = new SqlCommand();
                cmd.Connection = conn.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RAP.spud_Get_NXT_TheoThang";
                if(!_namThang.Equals(""))
                    cmd.Parameters.AddWithValue( "@NamThang" , _namThang );

                adp = new SqlDataAdapter( cmd );

                adp.Fill( _dt );
            }
            catch ( Exception ex )
            {
                _dt = null;
            }

            return _dt;
        }

        public bool CapNhat_X_NXT_TheoThang( string _namThang )
        {
            bool flag = false;



            return flag;
        }

        public bool insertData( DataTable dt , string _docSid , string _date , string _store , int _sumQty , string condition )
        {
            bool flag = false;

            if ( condition.Equals( "IN" ) )
            {
                try
                {
                    conn = new Utilities.SQLCon();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pRAP_NhanHangSua_Insert_Info";
                    command.Parameters.AddWithValue( "@DocSid" , _docSid );
                    command.Parameters.AddWithValue( "@Store" , _store );
                    command.Parameters.AddWithValue( "@CreatedDate" , this.ConvertDateToSQL( _date ) );
                    command.Parameters.AddWithValue( "@DocQty" , _sumQty );
                    command.Connection = conn.getConnection();

                    int effect = command.ExecuteNonQuery();
                    if ( effect > 0 )
                    {
                        for ( int i = 0 ; i < dt.Rows.Count ; i++ )
                        {
                            SqlCommand command1 = new SqlCommand();
                            command1.CommandType = CommandType.StoredProcedure;
                            command1.CommandText = "pRAP_NhanHangSua_Insert_Item";
                            command1.Parameters.AddWithValue( "@DocSid" , _docSid );
                            command1.Parameters.AddWithValue( "@UPC" , dt.Rows[i]["UPC"].ToString() );
                            command1.Parameters.AddWithValue( "@UDF10" , dt.Rows[i]["UDF10"].ToString() );
                            command1.Parameters.AddWithValue( "@QTY" , dt.Rows[i]["QTY"].ToString() );
                            command1.Connection = conn.getConnection();

                            int effect1 = command1.ExecuteNonQuery();
                            if ( effect1 > 0 )
                            {
                                flag = true;
                            }
                            else
                            {
                                return flag = false;
                            }
                        }

                        flag = true;
                    }
                    else
                    {
                        return flag = false;
                    }
                }
                catch ( Exception ex )
                {
                    return flag = false;
                }
            }
            else
            {
                try
                {
                    conn = new Utilities.SQLCon();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pRAP_TraHangSua_Insert_Info";
                    command.Parameters.AddWithValue( "@DocSid" , _docSid );
                    command.Parameters.AddWithValue( "@Store" , _store );
                    command.Parameters.AddWithValue( "@CreatedDate" , this.ConvertDateToSQL( _date ) );
                    command.Parameters.AddWithValue( "@DocQty" , _sumQty );
                    command.Connection = conn.getConnection();

                    int effect = command.ExecuteNonQuery();
                    if ( effect > 0 )
                    {
                        for ( int i = 0 ; i < dt.Rows.Count ; i++ )
                        {
                            SqlCommand command1 = new SqlCommand();
                            command1.CommandType = CommandType.StoredProcedure;
                            command1.CommandText = "pRAP_TraHangSua_Insert_Item";
                            command1.Parameters.AddWithValue( "@DocSid" , _docSid );
                            command1.Parameters.AddWithValue( "@UPC" , dt.Rows[i]["UPC"].ToString() );
                            command1.Parameters.AddWithValue( "@UDF10" , dt.Rows[i]["UDF10"].ToString() );
                            command1.Parameters.AddWithValue( "@QTY" , dt.Rows[i]["QTY"].ToString() );
                            command1.Connection = conn.getConnection();

                            int effect1 = command1.ExecuteNonQuery();
                            if ( effect1 > 0 )
                            {
                                flag = true;
                            }
                            else
                            {
                                return flag = false;
                            }
                        }

                        flag = true;
                    }
                    else
                    {
                        return flag = false;
                    }
                }
                catch ( Exception ex )
                {
                    return flag = false;
                }
            }
            return flag;
        }

        public bool checkUpdate_DoSua_Qty( string store , string upc )
        {
            bool flag = false;
            DataTable dt = new DataTable();

            try
            {
                conn = new Utilities.SQLCon();

                //conn.getConnection();
                string sql = "SELECT * FROM tb_Rap_DoSua_Qty WHERE Store = N'" + store + "' and UPC = N'" + upc + "'";
                dt = conn.returnDataTable( sql );

                if ( dt.Rows.Count == 1 )
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

            }

            return flag;
        }

        public bool updateDoSua_Qty( DataTable dt , string store , string condition , string docSid )
        {
            bool flag = false;

            if ( condition == "IN" )
            {
                try
                {
                    for ( int i = 0 ; i < dt.Rows.Count ; i++ )
                    {
                        conn = new Utilities.SQLCon();

                        if ( checkUpdate_DoSua_Qty( store , dt.Rows[i]["UPC"].ToString() ) )
                        {
                            SqlCommand command = new SqlCommand();
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "pRAP_DoSua_Qty_Update";
                            command.Parameters.AddWithValue( "@Store" , store );
                            command.Parameters.AddWithValue( "@UPC" , dt.Rows[i]["UPC"].ToString() );
                            command.Connection = conn.getConnection();

                            int effect = command.ExecuteNonQuery();
                            if ( effect > 0 )
                            {
                                flag = true;
                            }
                            else
                            {
                                return flag = false;
                            }
                        }
                        else
                        {
                            SqlCommand command = new SqlCommand();
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "pRAP_DoSua_Qty_Insert";
                            command.Parameters.AddWithValue( "@Store" , store );
                            command.Parameters.AddWithValue( "@UPC" , dt.Rows[i]["UPC"].ToString() );
                            command.Parameters.AddWithValue( "@UDF10" , dt.Rows[i]["UDF10"].ToString() );
                            command.Connection = conn.getConnection();

                            int effect = command.ExecuteNonQuery();
                            if ( effect > 0 )
                            {
                                flag = true;
                            }
                            else
                            {
                                return flag = false;
                            }
                        }
                    }
                }
                catch ( Exception ex )
                {
                    return flag = false;
                }
            }
            else if ( condition == "OUT" )
            {
                try
                {
                    DataTable _tempDataTable = addColumnToDatatable( dt , store );

                    if ( !checkAvaiable_DoSua_Qty( _tempDataTable ) )
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "pRAP_DoSua_Qty_Delete";
                        command.Parameters.AddWithValue( "@DocSid" , docSid );
                        command.Connection = conn.getConnection();
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        for ( int i = 0 ; i < dt.Rows.Count ; i++ )
                        {
                            conn = new Utilities.SQLCon();
                            SqlCommand command = new SqlCommand();
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "pRAP_DoSua_Qty_DeUpdate";
                            command.Parameters.AddWithValue( "@Store" , store );
                            command.Parameters.AddWithValue( "@UPC" , _tempDataTable.Rows[i]["UPC"].ToString() );
                            command.Parameters.AddWithValue( "@QTY" , int.Parse( _tempDataTable.Rows[i]["QTY"].ToString() ) );
                            command.Connection = conn.getConnection();

                            int effect = command.ExecuteNonQuery();
                            if ( effect > 0 )
                            {
                                flag = true;
                            }
                            else
                            {
                                return flag = false;
                            }
                        }
                    }
                }
                catch ( Exception ex )
                {
                    return flag = false;
                }
            }

            return flag;
        }

        public DataTable addColumnToDatatable( DataTable dt , string store )
        {
            DataTable rs = new DataTable();

            rs.Columns.Add( "STORE" , typeof( string ) );
            rs.Columns.Add( "UPC" , typeof( string ) );
            rs.Columns.Add( "QTY" , typeof( int ) );
            rs.Columns.Add( "UDF10" , typeof( string ) );

            for ( int i = 0 ; i < dt.Rows.Count ; i++ )
            {
                int _qtyRow = int.Parse( dt.Rows[i]["QTY"].ToString() );
                rs.Rows.Add( store , dt.Rows[i]["UPC"].ToString() , _qtyRow , dt.Rows[i]["UDF10"].ToString() );
            }

            return rs;
        }

        public bool checkAvaiable_DoSua_Qty( DataTable _dt )
        {
            bool flag = false;
            DataTable dt = new DataTable();

            for ( int i = 0 ; i < _dt.Rows.Count ; i++ )
            {
                try
                {
                    conn = new Utilities.SQLCon();

                    string sql = "SELECT * FROM tb_Rap_DoSua_Qty WHERE Store = N'" + _dt.Rows[i]["Store"] + "' AND UPC = N'" + _dt.Rows[i]["UPC"] + "' AND QTY >=" + int.Parse( _dt.Rows[i]["QTY"].ToString() );

                    dt = conn.returnDataTable( sql );

                    if ( dt.Rows.Count == 1 )
                    {
                        flag = true;
                    }
                    else
                    {
                        return flag = false;
                    }
                }
                catch ( Exception ex )
                {
                    return flag = false;
                }
            }

            return flag;
        }

        public DataTable getWrongUPC( DataTable _dt )
        {
            DataTable dt = new DataTable();
            DataTable rs = new DataTable();

            rs.Columns.Add( "UPC" , typeof( string ) );

            for ( int i = 0 ; i < _dt.Rows.Count ; i++ )
            {
                try
                {
                    conn = new Utilities.SQLCon();
                    conn.getConnection();
                    string sql = "SELECT * FROM tb_Rap_DoSua_Qty WHERE Store = N'" + _dt.Rows[i][0] + "' AND UPC = N'" + _dt.Rows[i][1] + "' AND QTY >=" + int.Parse( _dt.Rows[i][2].ToString() );

                    dt = conn.returnDataTable( sql );

                    if ( dt.Rows.Count == 1 )
                    {

                    }
                    else
                    {
                        rs.Rows.Add( _dt.Rows[i][1] );
                    }
                }
                catch ( Exception ex )
                {

                }
            }

            return rs;
        }

        public string GetDocSid( string _type , string _store )
        {
            string _rs = "";

            if ( _type.Equals( "IN" ) )
            {
                try
                {
                    Utilities.SQLCon con = new Utilities.SQLCon();
                    DataTable dt = new DataTable();

                    string sqlString = " select max(cast(SUBSTRING(doc_sid,8,10) as int)) MaxNumber from tb_Rap_NhanDoSua where Doc_SID like '" + _store + "_IN_%'";

                    dt = con.returnDataTable( sqlString );

                    if ( dt.Rows.Count == 1 )
                    {
                        string temp = dt.Rows[0][0].ToString();

                        int sidInt = int.Parse( temp ) + 1;
                        _rs = _store + "_IN_" + sidInt;
                    }
                    else
                    {

                    }
                }
                catch ( Exception ex )
                {
                    _rs = _store + "_IN_1";
                }
            }
            else
            {
                try
                {
                    Utilities.SQLCon con = new Utilities.SQLCon();
                    DataTable dt = new DataTable();

                    string sqlString = " select max(cast(SUBSTRING(doc_sid,9,10) as int)) MaxNumber from tb_Rap_TraDoSua where Doc_SID like '" + _store + "_OUT_%'";

                    dt = con.returnDataTable( sqlString );

                    if ( dt.Rows.Count == 1 )
                    {
                        string temp = dt.Rows[0][0].ToString();

                        int sidInt = int.Parse( temp ) + 1;
                        _rs = _store + "_OUT_" + sidInt;
                    }
                    else
                    {

                    }
                }
                catch ( Exception ex )
                {
                    _rs = _store + "_OUT_1";
                }
            }

            return _rs;
        }

        public DataTable GetTonKho_Details( string _store )
        {
            DataTable _dt = new DataTable();
            conn = new Utilities.SQLCon();
            string querry = "SELECT * FROM tb_Rap_DoSua_Qty WHERE Store = '" + _store + "'";

            _dt = conn.returnDataTable( querry );
            return _dt;
        }

        public DataTable GetTonKho_Sum()
        {
            DataTable _dt = new DataTable();
            conn = new Utilities.SQLCon();
            string querry = "SELECT Store ,sum(QTY) as QTY FROM tb_Rap_DoSua_Qty GROUP BY Store";
            _dt = conn.returnDataTable( querry );
            return _dt;
        }

        private string ConvertDateToSQL( string _date )
        {
            string _rs = "";

            _rs = _date.Substring( 3 , 2 ) + "/" + _date.Substring( 0 , 2 ) + "/" + _date.Substring( 6 , 4 );

            return _rs;
        }

        public DataTable GetDetailByDocSID( string _docSID )
        {
            DataTable _dt = new DataTable();
            conn = new Utilities.SQLCon();
            string querry = "select * from tb_Rap_NhanDoSua_Item where Doc_SID = '" + _docSID + "'";
            _dt = conn.returnDataTable( querry );

            if ( _dt.Rows.Count == 0 )
            {
                querry = "select * from tb_Rap_TraDoSua_Item where Doc_SID = '" + _docSID + "'";
                _dt = conn.returnDataTable( querry );
            }

            return _dt;
        }

        public DataTable GetDanhSachInLai( string _date , string _store , string _type )
        {
            DataTable _dt = new DataTable();
            conn = new Utilities.SQLCon();
            string querry = "";

            if ( _type == "IN" )
            {
                querry = "SELECT *"
                         + " FROM tb_Rap_NhanDoSua"
                         + " WHERE Store_Code = '" + _store + "'"
                         + "  AND Created_Date = '" + this.ConvertDateToSQL( _date ) + "'"
                         + "  AND Doc_SID like '" + _store + "_IN_%'";
            }
            else
            {
                querry = "SELECT *"
                         + " FROM tb_Rap_TraDoSua"
                         + " WHERE Store_Code = '" + _store + "'"
                         + "  AND Created_Date = '" + this.ConvertDateToSQL( _date ) + "'"
                         + "  AND Doc_SID like '" + _store + "_OUT_%'";
            }

            _dt = conn.returnDataTable( querry );
            return _dt;
        }
    }
}
