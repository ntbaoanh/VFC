using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_TK_Vai
    {
        SqlCommand cmd;
        Utilities.SQLCon conn;
        DataTable dt;

        public string INSERT_TK_Vai(cl_PRO_TK_Vai vai, DataTable dt)
        {
            string rs = "fail";

            try
            {
                cmd = new SqlCommand();
                conn = new Utilities.SQLCon();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TK.spud_Vai_Insert";
                cmd.Parameters.Add("@MaVai", SqlDbType.NVarChar, 200).Value = vai.MaVai;
                cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = vai.SupplierID;
                cmd.Parameters.Add("@ChatLieu", SqlDbType.NVarChar, 200).Value = vai.ChatLieu;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value = vai.GhiChu;
                cmd.Parameters.Add("@GiaNhapKho", SqlDbType.Int).Value = vai.GiaNhapKho;
                cmd.Parameters.Add("@NVTK", SqlDbType.NVarChar, 50).Value = vai.NVTK;
                cmd.Parameters.Add("@Colors", SqlDbType.Structured).Value = dt;

                cmd.Parameters.Add("@output", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output;

                cmd.Connection = conn.getConnection();
                cmd.ExecuteNonQuery();

                // read output value from @NewId
                rs = cmd.Parameters["@output"].Value.ToString();

                conn.closeConnection();
            }
            catch (Exception )
            { 
            
            }

            return rs;
        }

        public string UPDATE_TK_Vai(cl_PRO_TK_Vai vai, DataTable dt)
        {
            string rs = "fail";

            try
            {
                cmd = new SqlCommand();
                conn = new Utilities.SQLCon();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TK.spud_Vai_Update";
                cmd.Parameters.Add("@VaiID", SqlDbType.Int).Value = vai.VaiID;
                cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = vai.SupplierID;
                cmd.Parameters.Add("@ChatLieu", SqlDbType.NVarChar, 200).Value = vai.ChatLieu;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 500).Value = vai.GhiChu;
                cmd.Parameters.Add("@GiaNhapKho", SqlDbType.Int).Value = vai.GiaNhapKho;
                cmd.Parameters.Add("@NVTK", SqlDbType.NVarChar, 50).Value = vai.NVTK;
                cmd.Parameters.Add("@Colors", SqlDbType.Structured).Value = dt;

                cmd.Parameters.Add("@output", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output;

                cmd.Connection = conn.getConnection();
                cmd.ExecuteNonQuery();

                // read output value from @NewId
                rs = cmd.Parameters["@output"].Value.ToString();

                conn.closeConnection();
            }
            catch (Exception )
            {

            }

            return rs;
        }

        public DataTable GET_DSVai()
        {
            try
            {                
                conn = new Utilities.SQLCon();
                string query = "select * from TK.v_Vai order by VaiID DESC";

                return dt = conn.returnDataTable(query);
            }
            catch (Exception )
            {
                return dt = null;
            }
        }

        public DataTable GET_DSVaiColor(int vaiID)
        {
            try
            {
                conn = new Utilities.SQLCon();
                string query = "select Color_EN, Color_VN from TK.Vai_Color where VaiID = " + vaiID;

                return dt = conn.returnDataTable(query);
            }
            catch (Exception )
            {
                return dt = null;
            }
        }
    }
}
