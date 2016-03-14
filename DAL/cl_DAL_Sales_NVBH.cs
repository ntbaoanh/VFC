using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PRO;

namespace DAL
{
    public class cl_DAL_Sales_NVBH
    {
        Utilities.SQLCon _connSQL;
        DataTable dt;

        public DataTable GET_NVBH_By_Store(string _storeCode)
        {
            dt = new DataTable();
            _connSQL = new Utilities.SQLCon();

            string query = "select * from sales.v_NhanVienBanHang where Store_Code = '" + _storeCode + "'";
            dt = _connSQL.returnDataTable(query);

            return dt;
        }

        public DataTable GET_NVBH_By_Store_Working(string _storeCode)
        {
            dt = new DataTable();
            _connSQL = new Utilities.SQLCon();

            string query = "select * from sales.v_NhanVienBanHang where Store_Code = '" + _storeCode + "' and working not in ('OFF')";
            dt = _connSQL.returnDataTable(query);

            return dt;
        }

        public cl_PRO_Sales_NVBH GET_NVBH_ByID(string id)
        {
            cl_PRO_Sales_NVBH myNV = new cl_PRO_Sales_NVBH();

            try
            {
                string query = "select * from sales.v_nhanvienbanhang where nvid = '" + id + "'";

                _connSQL = new Utilities.SQLCon();
                dt = new DataTable();
                dt = _connSQL.returnDataTable(query);

                myNV.NvbhId = dt.Rows[0]["NVID"].ToString();
                if (dt.Rows[0]["Active"].ToString() == "True")
                {
                    myNV.Active = 1;
                }
                else
                {
                    myNV.Active = 0;
                }
                myNV.Cmnd = dt.Rows[0]["CMND"].ToString();
                myNV.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                myNV.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
                myNV.Ho = dt.Rows[0]["Ho"].ToString();
                myNV.ModifiedBy = dt.Rows[0]["Modified_By"].ToString();
                myNV.ModifiedDate = dt.Rows[0]["Modified_Date"].ToString();
                myNV.NgayBatDau = dt.Rows[0]["NgayBatDau"].ToString();
                myNV.NgaySinh = dt.Rows[0]["NgaySinh"].ToString();
                myNV.Phone = dt.Rows[0]["Phone"].ToString();
                myNV.StoreNo = Int32.Parse(dt.Rows[0]["StoreNo"].ToString());
                myNV.Ten = dt.Rows[0]["Ten"].ToString();
                myNV.StoreCode = dt.Rows[0]["Store_Code"].ToString();
            }
            catch (Exception ex)
            {
                myNV = null;
            }

            return myNV;
        }

        public bool INSERT_NVBH(cl_PRO_Sales_NVBH _nvbh)
        {
            bool flag = false;

            string[] names = new string[10] {"@idNV"
                                            , "@Ho"
                                            , "@Ten"
                                            , "@NgaySinh"
                                            , "@StoreNo"
                                            , "@CMND"
                                            , "@Phone"
                                            , "@DiaChi"
                                            , "@GioiTinh"
                                            , "@NgayBatDau"};

            object[] values = new object[10] { _nvbh.NvbhId
                                            , _nvbh.Ho
                                            , _nvbh.Ten
                                            , _nvbh.NgaySinh
                                            , _nvbh.StoreNo
                                            , _nvbh.Cmnd
                                            , _nvbh.Phone
                                            , _nvbh.DiaChi
                                            , _nvbh.GioiTinh
                                            , _nvbh.NgayBatDau};

            _connSQL = new Utilities.SQLCon();

            flag = _connSQL.execStoreProcedure("SALES.spud_INSERT_NVBH", names, values);

            return flag;
        }

        public bool UPDATE_NVBH(cl_PRO_Sales_NVBH _nvbh)
        {
            bool flag = false;

            string[] names = new string[12] {"@idNV"
                                            , "@Ho"
                                            , "@Ten"
                                            , "@NgaySinh"
                                            , "@StoreNo"
                                            , "@CMND"
                                            , "@Phone"
                                            , "@DiaChi"
                                            , "@GioiTinh"
                                            , "@NgayBatDau"
                                            , "@Active"
                                            , "@ModifiedBy"};

            object[] values = new object[12] { _nvbh.NvbhId
                                            , _nvbh.Ho
                                            , _nvbh.Ten
                                            , _nvbh.NgaySinh
                                            , _nvbh.StoreNo
                                            , _nvbh.Cmnd
                                            , _nvbh.Phone
                                            , _nvbh.DiaChi
                                            , _nvbh.GioiTinh
                                            , _nvbh.NgayBatDau
                                            , _nvbh.Active
                                            , _nvbh.ModifiedBy};

            _connSQL = new Utilities.SQLCon();

            flag = _connSQL.execStoreProcedure("SALES.spud_UPDATE_NVBH", names, values);

            return flag;
        }

        public bool INSERT_NVBH_Invoice(string _invcSid, string _idnv)
        {
            bool flag = false;

            try
            {
                string[] names = new string[2] {"@IDNV"
                                            , "@InvoiceSid"};

                object[] values = new object[2] { Int32.Parse(_idnv), _invcSid };

                _connSQL = new Utilities.SQLCon();

                flag = _connSQL.execStoreProcedure("SALES.spud_NVBH_Insert_NVBH_Invc", names, values);
            }
            catch (Exception ex)
            { 
                
            }
            return flag;
        }

        public bool INSERT_Invoice(cl_PRO_Invoice _invoice)
        {
            bool _rsFlag = false;

            if (_invoice == null)
            {
                _rsFlag = false;
            }
            else
            {
                try
                {
                    _connSQL = new Utilities.SQLCon();
                    string _myDate = _connSQL.ConvertDateToSQL(_invoice.CreatedDate);

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[SALES].[spud_NVBH_Insert_Invoice]";
                    command.Parameters.AddWithValue("@InvcSid", _invoice.Invc_sid);
                    command.Parameters.AddWithValue("@StoreNo", _invoice.StoreNo);
                    command.Parameters.AddWithValue("@InvcNo", _invoice.Invc_No);
                    command.Parameters.AddWithValue("@TotalMoney", _invoice.Amount);
                    command.Parameters.AddWithValue("@TotalQty", _invoice.Qty);
                    command.Parameters.AddWithValue("@DiscountMoney", _invoice.Discount);
                    command.Parameters.AddWithValue("@CreateDate", _myDate);
                    command.Parameters.AddWithValue("@CreateTime", _invoice.Time);

                    command.Connection = _connSQL.getConnection();

                    int effect = command.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        _rsFlag = true;
                    }
                    else
                    {
                        _rsFlag = false;
                    }
                }
                catch (Exception ex)
                {
                    _rsFlag = false;
                    throw new Exception(ex.Message);
                }

                _connSQL.closeConnection();
            }

            return _rsFlag;
        }

        public bool CHECK_Exists_InvcSid(string invcSid)
        {
            bool flag = false;

            string query = "select InvcSid from tb_CS_PromotionCode_Invoice where InvcSid = '" + invcSid + "'" ;
            _connSQL = new Utilities.SQLCon();

            dt = new DataTable();
            dt = _connSQL.returnDataTable(query);

            if (dt.Rows.Count == 1)
            {
                flag = true;
            }

            return flag;
        }

        public bool GET_NVBH_WorkingStatus(int nvid)
        {
            bool check = true;

            try
            {
                _connSQL = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SALES.spud_NVBH_Check_WorkingStatus";
                command.Parameters.AddWithValue("@NVID", nvid);

                SqlParameter _output = command.Parameters.Add("@output", SqlDbType.Bit);
                _output.Direction = ParameterDirection.Output;

                command.Connection = _connSQL.getConnection();

                command.ExecuteNonQuery();

                if (_output.Value.Equals(true))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch (Exception ex)
            {
                check = false;
                throw new Exception(ex.Message);
            }

            return check;
        }

        public bool CHECK_NVBH_DiLamSom()
        {
            bool check = true;

            try
            {
                _connSQL = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SALES.proc_NVBH_ChkIO_Check_DiLamSom";

                SqlParameter _output = command.Parameters.Add("@output", SqlDbType.Bit);
                _output.Direction = ParameterDirection.Output;

                command.Connection = _connSQL.getConnection();

                command.ExecuteNonQuery();

                if (_output.Value.Equals(true))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch (Exception ex)
            {
                check = false;
                throw new Exception(ex.Message);
            }

            return check;
        }

        public bool INSERT_CheckInOut(int nvid, int storeno, string status)
        {
            bool check = true;

            try
            {
                _connSQL = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SALES.spud_NVBH_CheckInOut";
                command.Parameters.AddWithValue("@NVID", nvid);
                command.Parameters.AddWithValue("@StoreNo", storeno);
                command.Parameters.AddWithValue("@CheckStatus", status);

                SqlParameter _output = command.Parameters.Add("@output", SqlDbType.NVarChar, 20);

                _output.Direction = ParameterDirection.Output;

                command.Connection = _connSQL.getConnection();

                command.ExecuteNonQuery();

                if (_output.Value.Equals("success"))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch (Exception ex)
            {
                check = false;
                throw new Exception(ex.Message);
            }

            return check;
        }
    }
}
