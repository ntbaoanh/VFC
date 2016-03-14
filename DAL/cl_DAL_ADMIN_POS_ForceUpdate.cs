using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_ADMIN_POS_ForceUpdate
    {
        Utilities.SQLCon _conn;
        DataTable _dt = new DataTable();

        public int Check_Update_DoanhThu(string _store)
        {
            int rs = 0;
            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.Connection = _conn.getConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ADMIN.spud_Check_UpdateDoanhThu";

                // input parm
                SqlParameter Store = command.Parameters.Add( "@store" , SqlDbType.NVarChar , 8 );
                Store.Value = _store;

                // output parm
                SqlParameter Result = command.Parameters.Add( "@output" , SqlDbType.Int );
                Result.Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                rs = int.Parse(Result.Value.ToString());
            }
            catch ( SqlException ex )
            {

            }
            catch ( Exception ex )
            {

            }

            _conn.closeConnection();
            return rs;
        }

        public bool POS_UpdateDoanhThu_Insert( string _storeCode 
                                , string _region
                                , int _money
                                , int _discount
                                , int _qty)
        {
            bool check = true;
            
            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pWeb_Insert_SalesRevenue";
                command.Parameters.AddWithValue( "@Store" , _storeCode );
                command.Parameters.AddWithValue( "@Region" , _region );
                command.Parameters.AddWithValue( "@TotalMoney" , _money );
                command.Parameters.AddWithValue( "@TotalDiscount" , _discount );
                command.Parameters.AddWithValue( "@TotalQty" , _qty );
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
    }
}
