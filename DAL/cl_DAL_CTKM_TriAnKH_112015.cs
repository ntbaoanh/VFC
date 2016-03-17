using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PRO;

namespace DAL
{
    public class cl_DAL_CTKM_TriAnKH_112015
    {
        public int CTKM_TriAnKH_112015_TyLeQuyDoi(int _storeNo)
        {
            int rs = 0;

            Utilities.SQLCon sqlCon = new Utilities.SQLCon();
            DataTable _dt = new DataTable();
            string _sqlString = "SELECT * FROM CTKM.TriAnKH_112015_Variables where StoreNo = " + _storeNo;

            _dt = sqlCon.returnDataTable(_sqlString);

            rs = Int32.Parse(_dt.Rows[0]["QuyDoi_SoLanQuay"].ToString());

            return rs;
        }

        public int CTKM_TriAnKH_112015_GiaTriHoaDon_Min(int _storeNo)
        {
            int rs = 0;

            Utilities.SQLCon sqlCon = new Utilities.SQLCon();
            DataTable _dt = new DataTable();
            string _sqlString = "SELECT * FROM CTKM.TriAnKH_112015_Variables where StoreNo = " + _storeNo;

            _dt = sqlCon.returnDataTable(_sqlString);

            rs = Int32.Parse(_dt.Rows[0]["GiaTriHoaDon_Min"].ToString());

            return rs;
        }

        public bool CTKM_TriAnKH_112015_CheckInvoice(string _invcSid)
        {
            bool rs = false;

            string output = "";
            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_CheckValid_Invoice";

                // input parm
                SqlParameter InvcSid = cmd.Parameters.Add("@InvcSid", SqlDbType.Char, 50);
                InvcSid.Value = _invcSid;

                // output parm
                SqlParameter Result = cmd.Parameters.Add("@output", SqlDbType.NVarChar, 50);
                Result.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                output = Result.Value.ToString();

                if (output.Equals("valid"))
                {
                    rs = true;
                }
                else
                {
                    rs = false;
                }
            }
            catch (SqlException )
            {
                rs = false;
            }
            catch (Exception )
            {
                rs = false;
            }

            return rs;
        }

        public bool CTKM_TriAnKH_112015_CheckICustomer(string _custSid)
        {
            bool rs = false;

            string output = "";
            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_CheckValid_Customer";

                // input parm
                SqlParameter CustSid = cmd.Parameters.Add("@CustSid", SqlDbType.Char, 50);
                CustSid.Value = _custSid;

                // output parm
                SqlParameter Result = cmd.Parameters.Add("@output", SqlDbType.NVarChar, 50);
                Result.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                output = Result.Value.ToString();

                if (output.Equals("valid"))
                {
                    rs = true;
                }
                else
                {
                    rs = false;
                }
            }
            catch (SqlException )
            {
                rs = false;
            }
            catch (Exception )
            {
                rs = false;
            }

            return rs;
        }

        public bool CTKM_TriAnKH_112015_Invoice_Insert(cl_PRO_Invoice _proInvoice)
        {
            bool rs = false;

            string output = "";
            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.spud_TriAnKH_112015_DSHoaDon_Insert";

                // input parm
                SqlParameter StoreNo = cmd.Parameters.Add("@StoreNo", SqlDbType.Int);
                StoreNo.Value = _proInvoice.StoreNo;

                SqlParameter InvcNo = cmd.Parameters.Add("@InvcNo", SqlDbType.Int);
                InvcNo.Value = _proInvoice.Invc_No;

                SqlParameter TotalMoney = cmd.Parameters.Add("@TotalMoney", SqlDbType.Int);
                TotalMoney.Value = _proInvoice.Amount;

                SqlParameter TotalQty = cmd.Parameters.Add("@TotalQty", SqlDbType.Int);
                TotalQty.Value = _proInvoice.Qty;

                SqlParameter DiscountMoney = cmd.Parameters.Add("@DiscountMoney", SqlDbType.Int);
                DiscountMoney.Value = _proInvoice.Discount;

                SqlParameter CreateDate = cmd.Parameters.Add("@CreateDate", SqlDbType.NVarChar, 50);
                CreateDate.Value = this.ConvertDateToSQL(_proInvoice.CreatedDate);

                SqlParameter CreateTime = cmd.Parameters.Add("@CreateTime", SqlDbType.NVarChar, 50);
                CreateTime.Value = _proInvoice.Time;

                SqlParameter CustomerSid = cmd.Parameters.Add("@CustomerSid", SqlDbType.NVarChar, 50);
                CustomerSid.Value = _proInvoice.Cust_sid;

                SqlParameter InvcSid = cmd.Parameters.Add("@InvcSid", SqlDbType.NVarChar, 50);
                InvcSid.Value = _proInvoice.Invc_sid;

                // output parm
                SqlParameter Result = cmd.Parameters.Add("@output", SqlDbType.NVarChar, 50);
                Result.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                output = Result.Value.ToString();

                if (output.Equals("committed"))
                {
                    rs = true;
                }
                else
                {
                    rs = false;
                }
            }
            catch (SqlException )
            {
                rs = false;
            }
            catch (Exception )
            {
                rs = false;
            }

            return rs;
        }

        public bool CTKM_TriAnKH_112015_Customer_Insert(cl_PRO_Customer _proCustomer)
        {
            bool rs = false;

            string output = "";
            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.spud_TriAnKH_112015_Customer_Insert";

                // input parm
                SqlParameter CustSid = cmd.Parameters.Add("@CustSid", SqlDbType.NVarChar, 50);
                CustSid.Value = _proCustomer.CustSid;

                SqlParameter CustomerID = cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 50);
                CustomerID.Value = _proCustomer.CustID;

                SqlParameter Ten = cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 50);
                Ten.Value = _proCustomer.Ten;

                SqlParameter Ho = cmd.Parameters.Add("@Ho", SqlDbType.NVarChar, 50);
                Ho.Value = _proCustomer.Ho;

                SqlParameter CMND = cmd.Parameters.Add("@CMND", SqlDbType.NVarChar, 50);
                CMND.Value = _proCustomer.Cmnd;

                SqlParameter DiaChi1 = cmd.Parameters.Add("@DiaChi1", SqlDbType.NVarChar, 50);
                DiaChi1.Value = _proCustomer.DiaChi1;

                SqlParameter DiaChi2 = cmd.Parameters.Add("@DiaChi2", SqlDbType.NVarChar, 50);
                DiaChi2.Value = _proCustomer.DiaChi2;

                SqlParameter ThanhPho = cmd.Parameters.Add("@ThanhPho", SqlDbType.NVarChar, 50);
                ThanhPho.Value = _proCustomer.ThanhPho;

                SqlParameter NgaySinh = cmd.Parameters.Add("@NgaySinh", SqlDbType.Int);
                NgaySinh.Value = _proCustomer.NgaySinh;

                SqlParameter ThangSinh = cmd.Parameters.Add("@ThangSinh", SqlDbType.Int);
                ThangSinh.Value = _proCustomer.ThangSinh;

                SqlParameter NamSinh = cmd.Parameters.Add("@NamSinh", SqlDbType.Int);
                NamSinh.Value = _proCustomer.NamSinh;

                SqlParameter GioiTinh = cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 50);
                GioiTinh.Value = _proCustomer.GioiTinh;

                SqlParameter CusStatusID = cmd.Parameters.Add("@CusStatusID", SqlDbType.Int);
                CusStatusID.Value = _proCustomer.CustStatus;

                SqlParameter Phone1 = cmd.Parameters.Add("@Phone1", SqlDbType.NVarChar, 50);
                Phone1.Value = _proCustomer.Phone1;

                SqlParameter Phone2 = cmd.Parameters.Add("@Phone2", SqlDbType.NVarChar, 50);
                Phone2.Value = _proCustomer.Phone2;

                // output parm
                SqlParameter Result = cmd.Parameters.Add("@output", SqlDbType.NVarChar, 50);
                Result.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                output = Result.Value.ToString();

                if (output.Equals("committed"))
                {
                    rs = true;
                }
                else
                {
                    rs = false;
                }
            }
            catch (SqlException )
            {
                rs = false;
            }
            catch (Exception )
            {
                rs = false;
            }

            return rs;
        }

        public bool CTKM_TriAnKH_112015_DSTrungThuong_Insert(string _storeNo
                                    , string _invcSid
                                    , string _custSid
                                    , string _loaiQT
                                    , string _giatriQT
                                    , string _workStation)
        {
            bool rs = false;

            string output = "";
            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.spud_TriAnKH_112015_DSKHTrungThuong_Insert";

                // input parm
                SqlParameter StoreNo = cmd.Parameters.Add("@StoreNo", SqlDbType.Int);
                StoreNo.Value = _storeNo;

                SqlParameter InvcSid = cmd.Parameters.Add("@InvcSid", SqlDbType.NVarChar, 50);
                InvcSid.Value = _invcSid;

                SqlParameter GiaTriQT = cmd.Parameters.Add("@GiaTriQT", SqlDbType.NVarChar, 50);
                GiaTriQT.Value = _giatriQT;

                SqlParameter LoaiQT = cmd.Parameters.Add("@LoaiQT", SqlDbType.NVarChar, 50);
                LoaiQT.Value = _loaiQT;

                SqlParameter CustomerSid = cmd.Parameters.Add("@CustomerSid", SqlDbType.NVarChar, 50);
                CustomerSid.Value = _custSid;

                SqlParameter WorkStation = cmd.Parameters.Add("@WorkStation", SqlDbType.NVarChar, 50);
                WorkStation.Value = _workStation;

                // output parm
                SqlParameter Result = cmd.Parameters.Add("@output", SqlDbType.NVarChar, 50);
                Result.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                output = Result.Value.ToString();

                if (output.Equals("committed"))
                {
                    rs = true;
                }
                else
                {
                    rs = false;
                }
            }
            catch (SqlException )
            {
                rs = false;
            }
            catch (Exception )
            {
                rs = false;
            }

            return rs;
        }

        public DataTable CTKM_TriAnKH_112015_DSKHTrungThuong(string _storeNo)
        {
            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_select_DSKHTrungThuong";
                cmd.Parameters.AddWithValue("@StoreNo", _storeNo);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);
            }
            catch (SqlException )
            {

            }
            catch (Exception )
            {

            }

            return _dt;
        }

        public string[] CTKM_TriAnKH_112015_Get_LoaiQT()
        {
            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_Get_LoaiQT";
                //cmd.Parameters.AddWithValue("@StoreNo", _storeNo);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);
            }
            catch (SqlException )
            {

            }
            catch (Exception )
            {

            }

            string[] rs = new string[_dt.Rows.Count];

            for (int i = 0; i < _dt.Rows.Count; i++)
            { 
                rs[i] = _dt.Rows[i]["DienGiai"].ToString();
            }

            return rs;
        }

        public string[] CTKM_TriAnKH_112015_Get_GiaTriQT(string _diengiai)
        {
            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_Get_GiaTriQT";
                cmd.Parameters.AddWithValue("@DienGiaiLoaiQT", _diengiai);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);
            }
            catch (SqlException )
            {

            }
            catch (Exception )
            {

            }

            string[] rs = new string[_dt.Rows.Count];

            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                rs[i] = _dt.Rows[i]["GiaTriQT"].ToString();
            }

            return rs;
        }

        public string CTKM_TriAnKH_112015_Get_SoLanQuay(string _storeNo, string _invcNo)
        {
            string rs = "";
            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_Get_SoLanQuay";
                cmd.Parameters.AddWithValue("@StoreNo", _storeNo);
                cmd.Parameters.AddWithValue("@InvcNo", _invcNo);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);

                rs = _dt.Rows[0]["SoLan_Quay"].ToString();
            }
            catch (SqlException )
            {

            }
            catch (Exception )
            {

            }

            return rs;
        }

        public string CTKM_TriAnKH_112015_Get_SoLanDaQuay(string _storeNo, string _invcNo)
        {
            string rs = "";
            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_Get_SoLanQuay";
                cmd.Parameters.AddWithValue("@StoreNo", _storeNo);
                cmd.Parameters.AddWithValue("@InvcNo", _invcNo);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);

                rs = _dt.Rows[0]["SoLan_DaQuay"].ToString();
            }
            catch (SqlException )
            {

            }
            catch (Exception )
            {

            }

            return rs;
        }

        public int CTKM_TriAnKH_112015_Count_SoLanQuay(string _storeNo)
        {
            int rs = -1;
            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_COUNT_SoLanQuay";
                cmd.Parameters.AddWithValue("@StoreNo", _storeNo);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);

                rs = int.Parse( _dt.Rows[0]["SumLanQuay"].ToString());
            }
            catch (SqlException )
            {

            }
            catch (Exception )
            {

            }

            return rs;
        }

        public int CTKM_TriAnKH_112015_Quay_Get_LoaiQT(string _storeNo, string _soBill)
        {
            int rs = -1;

            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_Quay_Get_LoaiQT";
                cmd.Parameters.AddWithValue("@StoreNo", _storeNo);
                cmd.Parameters.AddWithValue("@SoBill", _soBill);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);

                rs = int.Parse(_dt.Rows[0]["LoaiID"].ToString());
            }
            catch (SqlException )
            {

            }
            catch (Exception )
            {

            }

            return rs;
        }

        public int CTKM_TriAnKH_112015_Quay_Get_GiaTriQT(string _storeNo, string _soBill)
        {
            int rs = -1;

            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_Quay_Get_LoaiQT";
                cmd.Parameters.AddWithValue("@StoreNo", _storeNo);
                cmd.Parameters.AddWithValue("@SoBill", _soBill);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);

                rs = int.Parse(_dt.Rows[0]["GiaTriID"].ToString());
            }
            catch (SqlException )
            {

            }
            catch (Exception )
            {

            }

            return rs;
        }

        public bool CTKM_TriAnKH_112015_Check_Run(string _storeNo)
        {
            bool rs = false;

            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_Check_Run";
                cmd.Parameters.AddWithValue("@StoreNo", _storeNo);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);
                int temp = 0;
                temp = int.Parse(_dt.Rows[0]["CheckRun"].ToString());

                if (temp != 0)
                {
                    rs = true;
                }
            }
            catch (Exception )
            {

            }

            return rs;
        }

        public string CTKM_TriAnKH_112015_Get_RunDate(int _storeNo)
        {
            string rs = "";

            Utilities.SQLCon sqlCon = new Utilities.SQLCon();
            DataTable _dt = new DataTable();
            string _sqlString = "SELECT * FROM CTKM.TriAnKH_112015_Variables where StoreNo = " + _storeNo;

            _dt = sqlCon.returnDataTable(_sqlString);

            rs = _dt.Rows[0]["RunDate"].ToString();

            return rs;
        }

        public bool CTKM_TriAnKH_112015_Insert_XXX(int _totalQty, int[] _LoaiQt, int[] _GiaTriQT , int _storeNo)
        {
            bool _rs = false;
            
            int soVongQuay = _totalQty / 10;

            try {
                for (int i = 0; i < soVongQuay; i++)
                {
                    //------------------------------------
                    Utilities.SQLCon sqlCon = new Utilities.SQLCon();
                    DataTable _dt = new DataTable();
                    string _sqlString = "SELECT count(*) AS SOLANQUAY FROM CTKM.TriAnKH_112015_XXX where StoreNo = " + _storeNo;

                    _dt = sqlCon.returnDataTable(_sqlString);

                    int soLanCoTheQuay = Int32.Parse(_dt.Rows[0]["SOLANQUAY"].ToString());

                    //----------------------------------------------
                    //Hàm trả về mảng 10 số random from ... to ...
                    //----------------------------------------------
                    Random random = new Random();

                    int max = soLanCoTheQuay + 11;
                    int min = soLanCoTheQuay + 1;
                    int count = max - min;

                    if (max <= min || count < 0 ||
                            (count > max - min && max - min > 0))
                    {
                        throw new ArgumentOutOfRangeException("Range " + min + " to " + max +
                                " (" + ((Int64)max - (Int64)min) + " values), or count " + count + " is illegal");
                    }

                    HashSet<int> candidates = new HashSet<int>();

                    for (int top = max - count; top < max; top++)
                    {
                        if (!candidates.Add(random.Next(min, top + 1)))
                        {
                            candidates.Add(top);
                        }
                    }

                    List<int> result = candidates.ToList();

                    for (int m = result.Count - 1; m > 0; m--)
                    {
                        int k = random.Next(m + 1);
                        int tmp = result[k];
                        result[k] = result[m];
                        result[m] = tmp;
                    }
                    //----------------------------------------------
                    //END Hàm trả về mảng 10 số random from ... to ...
                    //----------------------------------------------

                    for (int j = 0; j < 10; j++)
                    {
                        string output = "";

                        DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = _sqlCon.getConnection();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "CTKM.spud_Insert_XXX_Temp";

                        // input parm
                        SqlParameter StoreNo = cmd.Parameters.Add("@StoreNo", SqlDbType.Int);
                        StoreNo.Value = _storeNo;

                        SqlParameter SoLanQuay = cmd.Parameters.Add("@SoLanQuay", SqlDbType.Int);
                        SoLanQuay.Value = result[j];

                        SqlParameter LoaiQT = cmd.Parameters.Add("@LoaiQT", SqlDbType.Int);
                        LoaiQT.Value = _LoaiQt[j];

                        SqlParameter GiaTriQT = cmd.Parameters.Add("@GiaTriQT", SqlDbType.Int);
                        GiaTriQT.Value = _GiaTriQT[j];

                        // output parm
                        SqlParameter Result = cmd.Parameters.Add("@output", SqlDbType.NVarChar, 50);
                        Result.Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        output = Result.Value.ToString();

                        if (output.Equals("error"))
                        {
                            _rs = false;
                        }
                        else
                        {
                            _rs = true;
                        }
                    }
                }
            }
            catch (Exception ) {
                _rs = false;
            }

            return _rs;
        }

        public string CTKM_TriAnKH_112015_Count_SoLan_CoTheQuay(string _storeNo)
        {
            string rs = "";
            
            Utilities.SQLCon sqlCon = new Utilities.SQLCon();
            DataTable _dt = new DataTable();
            string _sqlString = "SELECT count(*) FROM CTKM.TriAnKH_112015_XXX where StoreNo = " + _storeNo;

            _dt = sqlCon.returnDataTable(_sqlString);

            rs = _dt.Rows[0][0].ToString();

            return rs;
        }

        public string CTKM_TriAnKH_112015_Count_SoLan_DaQuay(string _storeNo, string _date)
        {
            string rs = "";

            Utilities.SQLCon sqlCon = new Utilities.SQLCon();
            DataTable _dt = new DataTable();
            string _sqlString = "SELECT count(*) FROM CTKM.TriAnKH_112015_DSTrungThuong where StoreNo = " + _storeNo + " and CreatedDate = '" + ConvertDateToSQL(_date) + "'";

            _dt = sqlCon.returnDataTable(_sqlString);

            rs = _dt.Rows[0][0].ToString();

            return rs;
        }

        private string ConvertDateToSQL( string _date )
        {
            string _rs = "";

            _rs = _date.Substring( 3 , 2 ) + "/" + _date.Substring( 0 , 2 ) + "/" + _date.Substring( 6 , 4 );

            return _rs;
        }
    }
}
