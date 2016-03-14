using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PRO;

namespace DAL
{
    public class cl_DAL_NhaCungCap
    {
        DataTable dt;
        Utilities.SQLCon conn;
        SqlCommand cmd;

        public string INSERT_NhaCungCap(cl_PRO_NhaCungCap ncc)
        {
            string rs = "fail";

            try
            {
                cmd = new SqlCommand();
                conn = new Utilities.SQLCon();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SUPPLIER].[spud_NhaCungCap_Insert]";
                cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 50).Value = ncc.TenNCC;
                cmd.Parameters.Add("@TenCty", SqlDbType.NVarChar, 200).Value = ncc.TenCty;
                cmd.Parameters.Add("@ADDR_SoNha", SqlDbType.NVarChar, 20).Value = ncc.ADDR_SoNha;
                cmd.Parameters.Add("@ADDR_Duong", SqlDbType.NVarChar, 200).Value = ncc.ADDR_Duong;
                cmd.Parameters.Add("@ADDR_Quan", SqlDbType.NVarChar, 30).Value = ncc.ADDR_Quan;
                cmd.Parameters.Add("@ADDR_ThanhPho", SqlDbType.Int).Value = ncc.ADDR_ThanhPho;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 11).Value = ncc.Phone;
                cmd.Parameters.Add("@CompanyPhone", SqlDbType.NVarChar, 10).Value = ncc.CompanyPhone;
                cmd.Parameters.Add("@MST", SqlDbType.NVarChar, 20).Value = ncc.MST;
                cmd.Parameters.Add("@NguoiLienLac", SqlDbType.NVarChar, 200).Value = ncc.NguoiLienLac;
                cmd.Parameters.Add("@GioiTinhNguoiLL", SqlDbType.Int).Value = ncc.GioiTinhNguoiLL;
                cmd.Parameters.Add("@TT_SoTK", SqlDbType.NVarChar, 50).Value = ncc.TT_SoTK;
                cmd.Parameters.Add("@TT_NganHang", SqlDbType.NVarChar, 500).Value = ncc.TT_NganHang;
                cmd.Parameters.Add("@TT_NguoiNhan", SqlDbType.NVarChar, 400).Value = ncc.TT_NguoiThuHuong;
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value = ncc.Notes;
                cmd.Parameters.Add("@NganhNghe", SqlDbType.Int).Value = ncc.NganhNghe;
                cmd.Parameters.Add("@User", SqlDbType.NVarChar, 50).Value = ncc.CreatedBy;
                cmd.Parameters.Add("@output", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output;

                cmd.Connection = conn.getConnection();
                cmd.ExecuteNonQuery();

                // read output value from @NewId
                rs = cmd.Parameters["@output"].Value.ToString();

                conn.closeConnection();
            }
            catch (Exception ex)
            {

            }

            return rs;
        }

        public string UPDATE_NhaCungCap(cl_PRO_NhaCungCap ncc)
        {
            string rs = "fail";

            try
            {
                cmd = new SqlCommand();
                conn = new Utilities.SQLCon();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SUPPLIER].[spud_NhaCungCap_Update]";
                cmd.Parameters.Add("@NCC_SID", SqlDbType.Int).Value = ncc.NCC_SID;
                cmd.Parameters.Add("@TenCty", SqlDbType.NVarChar, 200).Value = ncc.TenCty;
                cmd.Parameters.Add("@ADDR_SoNha", SqlDbType.NVarChar, 20).Value = ncc.ADDR_SoNha;
                cmd.Parameters.Add("@ADDR_Duong", SqlDbType.NVarChar, 200).Value = ncc.ADDR_Duong;
                cmd.Parameters.Add("@ADDR_Quan", SqlDbType.NVarChar, 30).Value = ncc.ADDR_Quan;
                cmd.Parameters.Add("@ADDR_ThanhPho", SqlDbType.Int).Value = ncc.ADDR_ThanhPho;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 11).Value = ncc.Phone;
                cmd.Parameters.Add("@CompanyPhone", SqlDbType.NVarChar, 10).Value = ncc.CompanyPhone;
                cmd.Parameters.Add("@MST", SqlDbType.NVarChar, 20).Value = ncc.MST;
                cmd.Parameters.Add("@NguoiLienLac", SqlDbType.NVarChar, 200).Value = ncc.NguoiLienLac;
                cmd.Parameters.Add("@GioiTinhNguoiLL", SqlDbType.Bit).Value = ncc.GioiTinhNguoiLL;
                cmd.Parameters.Add("@TT_SoTK", SqlDbType.NVarChar, 50).Value = ncc.TT_SoTK;
                cmd.Parameters.Add("@TT_NganHang", SqlDbType.NVarChar, 500).Value = ncc.TT_NganHang;
                cmd.Parameters.Add("@TT_NguoiNhan", SqlDbType.NVarChar, 400).Value = ncc.TT_NguoiThuHuong;
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value = ncc.Notes;
                cmd.Parameters.Add("@NganhNghe", SqlDbType.Int).Value = ncc.NganhNghe;
                cmd.Parameters.Add("@output", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output;

                cmd.Connection = conn.getConnection();
                cmd.ExecuteNonQuery();

                // read output value from @NewId
                rs = cmd.Parameters["@output"].Value.ToString();

                conn.closeConnection();
            }
            catch (Exception ex)
            {

            }

            return rs;
        }

        public DataTable GET_DSNhaCungCap()
        {
            try
            {
                conn = new Utilities.SQLCon();
                string query = "select * from SUPPLIER.v_NhaCungCap";

                return dt = conn.returnDataTable(query);
            }
            catch (Exception ex)
            {
                return dt = null;
            }
        }
    }
}
