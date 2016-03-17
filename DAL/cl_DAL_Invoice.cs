using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRO;
using System.Data;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_Invoice
    {
        Utilities.ORACon oraCon;
        Utilities.SQLCon sqlCon;

        #region SQL
        public cl_PRO_Invoice getInvoiceInfoFromInvcSid( string _invcSid )
        {
            cl_PRO_Invoice _myInvoice = new cl_PRO_Invoice();
            sqlCon = new Utilities.SQLCon();
            string _sql = "SELECT * FROM v_CS_PromotionCode_Invoice_Info WHERE InvcSid = '" + _invcSid + "'";
            DataTable _dt = new DataTable();

            try
            {
                _dt = sqlCon.returnDataTable( _sql );

                if ( _dt.Rows.Count == 1 )
                {
                    _myInvoice.Invc_No = _dt.Rows[0]["InvcNo"].ToString();
                    _myInvoice.StoreCode = _dt.Rows[0]["Store_Code"].ToString();
                    _myInvoice.Amount = _dt.Rows[0]["TotalMoney"].ToString();
                    _myInvoice.Discount = _dt.Rows[0]["DiscountMoney"].ToString();
                    _myInvoice.Qty = _dt.Rows[0]["TotalQty"].ToString();
                    _myInvoice.Cust_sid = _dt.Rows[0]["CustomerSid"].ToString();
                    _myInvoice.CreatedDate = _dt.Rows[0]["Date_Create"].ToString();
                    _myInvoice.Time = _dt.Rows[0]["Time_Create"].ToString();
                }
                else
                {
                    _myInvoice = null;
                }
            }
            catch ( Exception ex )
            {
                throw new Exception( "[getInvoiceInfoFromInvcSid]-" + _invcSid + " / " + ex.Message );
            }

            return _myInvoice;
        }

        public string GetInvcSidUsed( string _date , string _storeNo )
        {
            string _rs = " ";

            sqlCon = new Utilities.SQLCon();
            DataTable _dt = new DataTable();
            string _sqlString = "select invcsid from v_CS_PromotionCode_Invoice_Info where StoreNo = " + _storeNo + " and Date_Create = '" + this.ConvertDateToSQL( _date ) + "'";

            _dt = sqlCon.returnDataTable( _sqlString );

            for ( int i = 0 ; i < _dt.Rows.Count ; i++ )
            {
                _rs += _dt.Rows[i]["INVCSID"].ToString() + ",";
            }

            return _rs.Substring( 0 , ( _rs.Length - 1 ) );
        }

        public string NVBH_GetInvcSidUsed(string _date, string _storeNo)
        {
            string _rs = " ";

            sqlCon = new Utilities.SQLCon();
            DataTable _dt = new DataTable();
            string _sqlString = "select InvoiceSid from SALES.v_NVBH_Invoice where StoreNo = " + _storeNo + " and Date_Create = '" + this.ConvertDateToSQL(_date) + "'";

            _dt = sqlCon.returnDataTable(_sqlString);

            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                _rs += _dt.Rows[i]["InvoiceSid"].ToString() + ",";
            }

            return _rs.Substring(0, (_rs.Length - 1));
        }

        private string CTKM_TriAnKH_112015_InvcList_Used(int _storeNo)
        {
            string rs = "";

            DataTable _dt = new DataTable();

            try
            {
                DAL.Utilities.SQLCon _sqlCon = new DAL.Utilities.SQLCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _sqlCon.getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CTKM.TriAnKH_112015_select_UsedInvc";
                cmd.Parameters.AddWithValue("@StoreNo", _storeNo);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(_dt);

                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    rs += _dt.Rows[i]["InvcSid"].ToString() + ",";
                }
            }
            catch (SqlException )
            {

            }
            catch (Exception )
            {

            }

            if (rs.Length == 0)
            {
                rs = "";
            }
            else
            {
                rs =  rs.Substring(0, rs.Length-1);
            }

            return rs;
        }
        #endregion

        #region Oralcle
        public cl_PRO_Invoice getInvoiceByInvcNo( string _date 
                                                    , string _invcNo 
                                                    , string _storeNo 
                                                    , string _ipConfigName 
                                                    , string _sbsNo )
        {
            DataTable dt = new DataTable();
            cl_PRO_Invoice _rsInvoice = new cl_PRO_Invoice();

            try
            {
                /*
                Utilities.ORACon _oraCon = new Utilities.ORACon();
                OracleCommand command = new OracleCommand();
                command.Connection = _oraCon.GetConnection( _ipConfigName );
                //command.Connection = _oraCon.GetConnection( "192.168.9.248" );
                command.CommandText = "NN_Invoice.spud_GET_Invoice_By_InvcNo";
                command.CommandType = CommandType.StoredProcedure;

                OracleParameter v_Date = command.Parameters.Add( "v_Date" , OracleDbType.Varchar2 );
                v_Date.Value = _date;

                OracleParameter v_StoreNo = command.Parameters.Add( "v_StoreNo" , OracleDbType.Varchar2 );
                v_StoreNo.Value = _storeNo;

                OracleParameter v_SbsNo = command.Parameters.Add( "v_SbsNo" , OracleDbType.Varchar2 );
                v_SbsNo.Value = _sbsNo;

                OracleParameter v_InvcNo = command.Parameters.Add( "v_InvcNo" , OracleDbType.Varchar2 );
                v_InvcNo.Value = _invcNo;

                OracleParameter my_cursor = command.Parameters.Add( "my_cursor" , OracleDbType.RefCursor );
                my_cursor.Direction = ParameterDirection.Output;

                OracleDataAdapter da = new OracleDataAdapter( command );
                da.Fill( dt );
                */
                string sqlReciept = "SELECT   "
                                             + " Trunc(i.Created_Date) AS CREATED_DATE,  "
                                             + " TO_CHAR(i.Created_Date, 'HH24:MI:SS') AS CREATED_TIME,  "
                                             + " i.Invc_No AS INVC_NO,   "
                                             + " i.Invc_Sid AS INVC_SID,   "
                                             + " sum(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)) AS TOTALMONEY, "
                                             + " sum(it.QTY) AS SUMQTY, "
                                             + " sum((NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE) - (NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100))) AS DISCAMOUNT, "
                                             + " i.cust_sid "
                                         + " FROM "
                                             + " INVOICE_v i,  "
                                             + " INVC_ITEM it,  "
                                             + " STORE s,  "
                                             + " INVENTORY_V v "
                                         + " WHERE "
                                             + " i.invc_sid = it.invc_sid "
                                             + " AND i.sbs_no = s.sbs_no  "
                                             + " AND i.store_no = s.store_no  "
                                             + " AND v.item_sid = it.item_sid  "
                                             + " AND v.sbs_no = i.sbs_no  "
                                             + " AND i.held <> 1  "
                                             + " AND nvl(i.HiSec_Type,0) NOT IN (2,3,4,5,10,11)  "
                                             + " AND i.Invc_Type IN (0,2)  "
                                             + " AND (i.Sbs_No = ' " + _sbsNo + " ' )  "
                                             + " AND 0 = (case  "
                                                     + " when i.Status = 1 then 1   "
                                                     + " WHEN BitAnd(65536, i.Proc_Status) <> 0 THEN 2  "
                                                     + " WHEN BitAnd(131072, i.Proc_Status) <> 0 THEN 3   "
                                                     + " ELSE 0  END)  "
                                             + " AND nvl(it.Kit_Flag,0) NOT IN (2, 3)  "
                                             + " AND ((Trunc(i.Created_Date) >= TO_DATE('" + _date + "', 'dd/MM/yyyy'))  "
                                             + " AND (Trunc(i.Created_Date) <= TO_DATE('" + _date + "', 'dd/MM/yyyy')))  "
                                             + " AND (i.STORE_NO = '" + _storeNo + "')  "                     
                                             + " AND (i.INVC_NO = '" + _invcNo + "' )  "
                                         + " GROUP BY "
                                             + " Trunc(i.Created_Date), "
                                             + " TO_CHAR(i.Created_Date, 'HH24:MI:SS'),  "
                                             + " i.Invc_No, "
                                             + " i.Invc_Sid, "
                                             + " i.Cust_Sid "
                                         + " ORDER BY "
                                             + " i.invc_no ";

                oraCon = new Utilities.ORACon();
                dt = new DataTable();

                dt = oraCon.returnDataTable( sqlReciept , _ipConfigName );

                decimal _amount = Convert.ToDecimal( dt.Rows[0]["TOTALMONEY"].ToString() );
                decimal _discount = Convert.ToDecimal( dt.Rows[0]["DISCAMOUNT"].ToString() );

                _rsInvoice.Amount = Math.Round( _amount ).ToString();
                _rsInvoice.CreatedDate = dt.Rows[0]["CREATED_DATE"].ToString();
                _rsInvoice.Discount = Math.Round( _discount ).ToString();
                _rsInvoice.Invc_No = dt.Rows[0]["INVC_NO"].ToString();
                _rsInvoice.Qty = dt.Rows[0]["SUMQTY"].ToString();
                _rsInvoice.StoreNo = _storeNo;
                _rsInvoice.Cust_sid = dt.Rows[0]["CUST_SID"].ToString();
                _rsInvoice.Time = dt.Rows[0]["CREATED_TIME"].ToString();
                _rsInvoice.Invc_sid = dt.Rows[0]["INVC_SID"].ToString();
            }
            catch ( Exception  )
            {
                _rsInvoice = null;
            }
            finally
            {
                oraCon.closeConnection();
            }

            return _rsInvoice;
        }

        /*
        public cl_PRO_Invoice getInvoiceInfoFromInvcSid_ORA( string _invcSid , string _ip , string _sbsNo )
        {
            cl_PRO_Invoice _myInvoice = new cl_PRO_Invoice();
            DataTable dt = new DataTable();

            try
            {
                Utilities.ORACon _oraCon = new Utilities.ORACon();
                OracleCommand command = new OracleCommand();
                command.Connection = _oraCon.GetConnection( _ip );
                //command.Connection = _oraCon.GetConnection( "192.168.9.248" );
                command.CommandText = "NN_Invoice.spud_GET_Invc_By_InvcSid";
                command.CommandType = CommandType.StoredProcedure;

                OracleParameter v_InvcSid = command.Parameters.Add( "v_InvcSid" , OracleDbType.Varchar2 );
                v_InvcSid.Value = _invcSid;

                OracleParameter v_SbsNo = command.Parameters.Add( "v_SbsNo" , OracleDbType.Varchar2 );
                v_SbsNo.Value = _sbsNo;

                OracleParameter my_cursor = command.Parameters.Add( "my_cursor" , OracleDbType.RefCursor );
                my_cursor.Direction = ParameterDirection.Output;

                OracleDataAdapter da = new OracleDataAdapter( command );
                da.Fill( dt );

                decimal _amount = Convert.ToDecimal( dt.Rows[0]["TOTALMONEY"].ToString() );
                decimal _discount = Convert.ToDecimal( dt.Rows[0]["DISCAMOUNT"].ToString() );

                _myInvoice.Amount = Math.Round( _amount ).ToString();
                _myInvoice.CreatedDate = dt.Rows[0]["CREATED_DATE"].ToString();
                _myInvoice.Cust_sid = dt.Rows[0]["CUST_SID"].ToString();
                _myInvoice.Discount = Math.Round( _discount ).ToString();
                _myInvoice.Invc_No = dt.Rows[0]["INVC_NO"].ToString();
                _myInvoice.Invc_sid = dt.Rows[0]["INVC_SID"].ToString();
                _myInvoice.Qty = dt.Rows[0]["SUMQTY"].ToString();
                _myInvoice.StoreCode = dt.Rows[0]["STORE_CODE"].ToString();
                _myInvoice.StoreNo = dt.Rows[0]["STORE_NO"].ToString();
                _myInvoice.Time = dt.Rows[0]["CREATED_TIME"].ToString();
            }
            catch ( Exception ex )
            {
                _myInvoice = null;
            }
            finally
            {

            }

            return _myInvoice;
        }
        */

        public cl_PRO_Invoice getInvoiceInfoFromInvcSid_ORA(string _invcSid, string _ip, string _sbsNo)
        {
            DataTable dt = new DataTable();
            cl_PRO_Invoice _rsInvoice = new cl_PRO_Invoice();

            try
            {
                string sqlReciept = "SELECT    "
                                                 + " Trunc(i.Created_Date) AS CREATED_DATE,   "
                                                 + " TO_CHAR(i.Created_Date, 'HH24:MI:SS') AS CREATED_TIME,   "
                                                 + " i.Invc_No AS INVC_NO,    "
                                                 + " i.Invc_Sid AS INVC_SID,   " 
                                                 + " i.Cust_Sid AS CUST_SID,    "
                                                 + " i.Store_No AS STORE_NO,    "
                                                 + " s.Store_Code AS STORE_CODE,    "
                                                 + " sum(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)) AS TOTALMONEY,  "
                                                 + " sum(it.QTY) AS SUMQTY,  "
                                                 + " sum((NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE) - (NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100))) AS DISCAMOUNT  "
                                             + " FROM  "
                                                 + " INVOICE_v i,   "
                                                 + " INVC_ITEM it,   "
                                                 + " STORE s,   "
                                                 + " INVENTORY_V v  "
                                             + " WHERE  "
                                                 + " i.invc_sid = it.invc_sid  "
                                                 + " AND i.sbs_no = s.sbs_no   "
                                                 + " AND i.store_no = s.store_no   "
                                                 + " AND v.item_sid = it.item_sid   "
                                                 + " AND v.sbs_no = i.sbs_no   "
                                                 + " AND i.held <> 1   "
                                                 + " AND nvl(i.HiSec_Type,0) NOT IN (2,3,4,5,10,11)  "
                                                 + " AND i.Invc_Type IN (0,2)  "
                                                 + " AND (i.Sbs_No in ( ' " + _sbsNo + "' )) "  
                                                 + " AND 0 = (case "  
                                                         + " when i.Status = 1 then 1 "   
                                                         + " WHEN BitAnd(65536, i.Proc_Status) <> 0 THEN 2 "  
                                                         + " WHEN BitAnd(131072, i.Proc_Status) <> 0 THEN 3 "   
                                                         + " ELSE 0  END) "  
                                                 + " AND nvl(it.Kit_Flag,0) NOT IN (2, 3) "  
                                                 + " AND (i.INVC_SID IN (" + _invcSid + ")) "
                                                 + " AND (i.INVC_SID = it.INVC_SID) "
                                             + " GROUP BY "
                                                 + " Trunc(i.Created_Date), " 
                                                 + " TO_CHAR(i.Created_Date, 'HH24:MI:SS'), "  
                                                 + " i.Invc_No, "
                                                 + " i.Invc_Sid, "
                                                 + " i.cust_sid, "
                                                 + " i.Store_No, "
                                                 + " s.Store_Code "
                                             + " ORDER BY "
                                                 + " i.invc_no";

                oraCon = new Utilities.ORACon();
                dt = new DataTable();

                dt = oraCon.returnDataTable(sqlReciept, _ip);

                decimal _amount = Convert.ToDecimal(dt.Rows[0]["TOTALMONEY"].ToString());
                decimal _discount = Convert.ToDecimal(dt.Rows[0]["DISCAMOUNT"].ToString());

                _rsInvoice.Amount = Math.Round(_amount).ToString();
                _rsInvoice.CreatedDate = dt.Rows[0]["CREATED_DATE"].ToString();
                _rsInvoice.Cust_sid = dt.Rows[0]["CUST_SID"].ToString();
                _rsInvoice.Discount = Math.Round(_discount).ToString();
                _rsInvoice.Invc_No = dt.Rows[0]["INVC_NO"].ToString();
                _rsInvoice.Invc_sid = dt.Rows[0]["INVC_SID"].ToString();
                _rsInvoice.Qty = dt.Rows[0]["SUMQTY"].ToString();
                _rsInvoice.StoreCode = dt.Rows[0]["STORE_CODE"].ToString();
                _rsInvoice.StoreNo = dt.Rows[0]["STORE_NO"].ToString();
                _rsInvoice.Time = dt.Rows[0]["CREATED_TIME"].ToString();
            }
            catch (Exception )
            {
                _rsInvoice = null;
            }
            finally
            {
                oraCon.closeConnection();
            }

            return _rsInvoice;
        }

        public DataTable GET_DoanhThu_TheoNgay( string _fromDate 
                                                    , string _toDate 
                                                    , string _storeCode
                                                    , string _ipConfigName 
                                                    , string _sbsNo)
        {
            DataTable _dt = new DataTable();

            try
            {   
                string sqlReciept = "SELECT "
                                         + " Trunc(i.Created_Date) AS CREATED_DATE,  "
                                         + " TO_CHAR(i.Created_Date, 'HH24:MI:SS') AS CREATED_TIME,  "
                                         + " i.Invc_No AS INVC_NO,   "
                                         + " i.CUST_SID AS CUST_SID,   "
                                         + " i.Invc_Sid AS INVC_SID,       "
                                         + " ROUND(sum(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)), 0) AS TOTALMONEY,   "
                                         + " sum(it.QTY) AS SUMQTY, "
                                         + " ROUND(sum((NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE) - (NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100))),0) AS DISCAMOUNT   "
                                     + " FROM "
                                         + " INVOICE_v i,  "
                                         + " INVC_ITEM it,  "
                                         + " STORE s,  "
                                         + " INVENTORY_V v "
                                     + " WHERE "
                                         + " i.invc_sid = it.invc_sid "
                                         + " AND i.sbs_no = s.sbs_no  "
                                         + " AND i.store_no = s.store_no  "
                                         + " AND v.item_sid = it.item_sid  "
                                         + " AND v.sbs_no = i.sbs_no  "
                                         + " AND i.held <> 1  "
                                         + " AND nvl(i.HiSec_Type,0) NOT IN (2,3,4,5,10,11)  "
                                         + " AND i.Invc_Type IN (0,2)  "
                                         + " AND (i.Sbs_No in ( '" + _sbsNo + "' ))  "
                                         + " AND 0 = (case  "
                                                 + " when i.Status = 1 then 1   "
                                                 + " WHEN BitAnd(65536, i.Proc_Status) <> 0 THEN 2  "
                                                 + " WHEN BitAnd(131072, i.Proc_Status) <> 0 THEN 3   "
                                                 + " ELSE 0  END)  "
                                         + " AND nvl(it.Kit_Flag,0) NOT IN (2, 3)  "
                                         + " AND ((Trunc(i.Created_Date) >= TO_DATE('" + _fromDate + "', 'dd/MM/yyyy'))  "
                                         + " AND (Trunc(i.Created_Date) <= TO_DATE('" + _toDate + "', 'dd/MM/yyyy')))  "
                                         + " AND (i.STORE_NO IN (select STORE_NO from store_v where store_code = '" + _storeCode + "' and sbs_no = " + _sbsNo + "))  "
                                     + " GROUP BY "
                                         + " Trunc(i.Created_Date), "
                                         + " TO_CHAR(i.Created_Date, 'HH24:MI:SS'),  "
                                         + " i.Invc_No, "
                                         + " i.CUST_SID , "
                                         + " i.Invc_Sid "
                                     + " ORDER BY "
                                         + " i.invc_no ";

                oraCon = new Utilities.ORACon();
                _dt = new DataTable();
                _dt = oraCon.returnDataTable( sqlReciept , _ipConfigName );
            }
            catch ( Exception  )
            {
                _dt = null;
            }

            return _dt;
        }

        public DataTable getInvoiceByDateWithCustomer( string _fromDate , string _toDate , string _ipConfigName , string _custSid , string _sbsNo )
        {
            DataTable _dt = new DataTable();

            try
            {
                Utilities.ORACon _oraCon = new Utilities.ORACon();

                OracleCommand command = new OracleCommand();
                command.Connection = _oraCon.GetConnection( _ipConfigName );
                //command.Connection = _oraCon.GetConnection( "192.168.9.248" );
                command.CommandText = "NN_Invoice.spud_GET_Invoice_By_Date_CustSid";
                command.CommandType = CommandType.StoredProcedure;

                OracleParameter v_FromDate = command.Parameters.Add( "v_FromDate" , OracleDbType.Varchar2 );
                v_FromDate.Value = _fromDate;

                OracleParameter v_ToDate = command.Parameters.Add( "v_ToDate" , OracleDbType.Varchar2 );
                v_ToDate.Value = _toDate;

                OracleParameter v_CustSid = command.Parameters.Add( "v_CustSid" , OracleDbType.Int16 );
                v_CustSid.Value = _custSid;

                OracleParameter v_sbs_no = command.Parameters.Add( "v_sbs_no" , OracleDbType.Int16 );
                v_sbs_no.Value = _sbsNo;

                OracleParameter my_cursor = command.Parameters.Add( "my_cursor" , OracleDbType.RefCursor );
                my_cursor.Direction = ParameterDirection.Output;

                OracleDataAdapter da = new OracleDataAdapter( command );
                da.Fill( _dt );
            }
            catch ( Exception  )
            {
                _dt = null;
            }

            return _dt;
        }

        public DataTable Get_Invoice_ByDate( string _fromDate 
                                                , string _toDate 
                                                , string _storeCode
                                                , string _ipConfigName 
                                                , string _sbsNo 
                                                , int _rownum)
        {
            DataTable dt = new DataTable();
            string sqlReciept = "";

            try
            {
                if ( _rownum > 0 )
                {
                    sqlReciept += "SELECT * FROM ( ";
                }

                sqlReciept += "SELECT   "
                    + " Trunc(i.Created_Date) AS CREATED_DATE,  "
                    + " TO_CHAR(i.Created_Date, 'HH24:MI:SS') AS CREATED_TIME,  "
                    + " i.Invc_No AS INVC_NO,   "
                    + " i.Invc_Sid AS INVC_SID,   "
                    + " sum(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)) AS TOTALMONEY, "
                    + " sum(it.QTY) AS SUMQTY, "
                    + " sum((NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE) - (NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100))) AS DISCAMOUNT "
                + " FROM "
                    + " INVOICE_v i,  "
                    + " INVC_ITEM it,  "
                    + " STORE s,  "
                    + " INVENTORY_V v "
                + " WHERE "
                    + " i.invc_sid = it.invc_sid "
                    + " AND i.sbs_no = s.sbs_no  "
                    + " AND i.store_no = s.store_no  "
                    + " AND v.item_sid = it.item_sid  "
                    + " AND v.sbs_no = i.sbs_no  "
                    + " AND i.held <> 1  "
                    + " AND nvl(i.HiSec_Type,0) NOT IN (2,3,4,5,10,11)  "
                    + " AND i.Invc_Type IN (0,2)  "
                    + " AND (i.Sbs_No in (" + _sbsNo + "))  "
                    + " AND 0 = (case  "
                            + " when i.Status = 1 then 1   "
                            + " WHEN BitAnd(65536, i.Proc_Status) <> 0 THEN 2  "
                            + " WHEN BitAnd(131072, i.Proc_Status) <> 0 THEN 3   "
                            + " ELSE 0  END)  "
                    + " AND nvl(it.Kit_Flag,0) NOT IN (2, 3)  "
                    + " AND ((Trunc(i.Created_Date) >= TO_DATE('" + _fromDate.Substring( 0 , 10 ) + "', 'dd/MM/yyyy'))  "
                    + " AND (Trunc(i.Created_Date) <= TO_DATE('" + _toDate.Substring( 0 , 10 ) + "', 'dd/MM/yyyy')))  "
                    + " AND (i.STORE_NO IN (select Store_No from store_v where store_code = '" + _storeCode + "' and sbs_no = " + _sbsNo + ")) ";

                string _listInvcSid = this.GetInvcSidUsed( _fromDate , _toDate , _storeCode );
                if ( !_listInvcSid.Equals( "" ) )
                {
                    sqlReciept += " AND i.invc_sid not in (" + _listInvcSid + ") ";
                }

                sqlReciept += " GROUP BY"
                + " Trunc(i.Created_Date), "
                + " TO_CHAR(i.Created_Date, 'HH24:MI:SS'),  "
                + " i.Invc_No, "
                + " i.Invc_Sid "
            + " ORDER BY "
                + " i.invc_no DESC )";

                if ( _rownum > 0 )
                {
                    sqlReciept += " where ROWNUM <= " + _rownum;
                }

                oraCon = new Utilities.ORACon();
                dt = new DataTable();

                dt = oraCon.returnDataTable( sqlReciept , _ipConfigName );
            }
            catch ( Exception  )
            {
                dt = null;
            }
            finally
            {

            }

            return dt;
        }

        public DataTable NVBH_Get_Invoice_ByDate(string _fromDate
                                                , string _toDate
                                                , string _storeCode
                                                , string _ipConfigName
                                                , string _sbsNo
                                                , int _rownum)
        {
            DataTable dt = new DataTable();
            string sqlReciept = "";

            try
            {
                if (_rownum > 0)
                {
                    sqlReciept += "SELECT * FROM ( ";
                }

                sqlReciept += "SELECT   "
                    + " Trunc(i.Created_Date) AS CREATED_DATE,  "
                    + " TO_CHAR(i.Created_Date, 'HH24:MI:SS') AS CREATED_TIME,  "
                    + " i.Invc_No AS INVC_NO,   "
                    + " i.Invc_Sid AS INVC_SID,   "
                    + " sum(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)) AS TOTALMONEY, "
                    + " sum(it.QTY) AS SUMQTY, "
                    + " sum((NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE) - (NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100))) AS DISCAMOUNT "
                + " FROM "
                    + " INVOICE_v i,  "
                    + " INVC_ITEM it,  "
                    + " STORE s,  "
                    + " INVENTORY_V v "
                + " WHERE "
                    + " i.invc_sid = it.invc_sid "
                    + " AND i.sbs_no = s.sbs_no  "
                    + " AND i.store_no = s.store_no  "
                    + " AND v.item_sid = it.item_sid  "
                    + " AND v.sbs_no = i.sbs_no  "
                    + " AND i.held <> 1  "
                    + " AND nvl(i.HiSec_Type,0) NOT IN (2,3,4,5,10,11)  "
                    + " AND i.Invc_Type IN (0,2)  "
                    + " AND (i.Sbs_No in (" + _sbsNo + "))  "
                    + " AND 0 = (case  "
                            + " when i.Status = 1 then 1   "
                            + " WHEN BitAnd(65536, i.Proc_Status) <> 0 THEN 2  "
                            + " WHEN BitAnd(131072, i.Proc_Status) <> 0 THEN 3   "
                            + " ELSE 0  END)  "
                    + " AND nvl(it.Kit_Flag,0) NOT IN (2, 3)  "
                    + " AND ((Trunc(i.Created_Date) >= TO_DATE('" + _fromDate.Substring(0, 10) + "', 'dd/MM/yyyy'))  "
                    + " AND (Trunc(i.Created_Date) <= TO_DATE('" + _toDate.Substring(0, 10) + "', 'dd/MM/yyyy')))  "
                    + " AND (i.STORE_NO IN (select Store_No from store_v where store_no = '" + _storeCode + "' and sbs_no = " + _sbsNo + ")) ";

                string _listInvcSid = this.NVBH_GetInvcSidUsed(_fromDate, _storeCode);
                if (!_listInvcSid.Equals(""))
                {
                    sqlReciept += " AND i.invc_sid not in (" + _listInvcSid + ") ";
                }

                sqlReciept += " GROUP BY"
                + " Trunc(i.Created_Date), "
                + " TO_CHAR(i.Created_Date, 'HH24:MI:SS'),  "
                + " i.Invc_No, "
                + " i.Invc_Sid "
            + " ORDER BY "
                + " i.invc_no DESC )";

                if (_rownum > 0)
                {
                    sqlReciept += " where ROWNUM <= " + _rownum;
                }

                oraCon = new Utilities.ORACon();
                dt = new DataTable();

                dt = oraCon.returnDataTable(sqlReciept, _ipConfigName);
            }
            catch (Exception )
            {
                dt = null;
            }
            finally
            {

            }

            return dt;
        }

        public DataTable getInvoiceByInvcNo( string _fromDate , string _toDate , string _storeNo , string _ipConfigName , string _invcNo , string _sbsNo )
        {
            DataTable dt = new DataTable();

            try
            {
                string sqlReciept = "SELECT   "
                    + " Trunc(i.Created_Date) AS CREATED_DATE,  "
                    + " TO_CHAR(i.Created_Date, 'HH24:MI:SS') AS CREATED_TIME,  "
                    + " i.Invc_No AS INVC_NO,   "
                    + " i.Invc_No AS INVC_SID,   "
                    + " sum(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)) AS TOTALMONEY, "
                    + " sum(it.QTY) AS SUMQTY, "
                    + " sum((NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE) - (NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100))) AS DISCAMOUNT "
                + " FROM "
                    + " INVOICE_v i,  "
                    + " INVC_ITEM it,  "
                    + " STORE s,  "
                    + " INVENTORY_V v "
                + " WHERE "
                    + " i.invc_sid = it.invc_sid "
                    + " AND i.sbs_no = s.sbs_no  "
                    + " AND i.store_no = s.store_no  "
                    + " AND v.item_sid = it.item_sid  "
                    + " AND v.sbs_no = i.sbs_no  "
                    + " AND i.held <> 1  "
                    + " AND nvl(i.HiSec_Type,0) NOT IN (2,3,4,5,10,11)  "
                    + " AND i.Invc_Type IN (0,2)  "
                    + " AND (i.Sbs_No in (" + _sbsNo + "))  "
                    + " AND 0 = (case  "
                            + " when i.Status = 1 then 1   "
                            + " WHEN BitAnd(65536, i.Proc_Status) <> 0 THEN 2  "
                            + " WHEN BitAnd(131072, i.Proc_Status) <> 0 THEN 3   "
                            + " ELSE 0  END)  "
                    + " AND nvl(it.Kit_Flag,0) NOT IN (2, 3)  "
                    + " AND ((Trunc(i.Created_Date) >= TO_DATE('" + _fromDate + "', 'dd/MM/yyyy'))  "
                    + " AND (Trunc(i.Created_Date) <= TO_DATE('" + _toDate + "', 'dd/MM/yyyy')))  "
                    + " AND (i.STORE_NO IN ('" + _storeNo + "'))  "
                    + " AND (i.INVC_NO IN ('" + _invcNo + "'))  "
                    + " AND (i.INVC_SID = it.INVC_SID)  "
                + " GROUP BY"
                    + " Trunc(i.Created_Date), "
                    + " TO_CHAR(i.Created_Date, 'HH24:MI:SS'),  "
                    + " i.Invc_No,"
                    + " i.Invc_Sid"
                + " ORDER BY "
                    + " i.invc_no ";

                oraCon = new Utilities.ORACon();
                dt = new DataTable();

                dt = oraCon.returnDataTable( sqlReciept , _ipConfigName );
            }
            catch ( Exception  )
            {
                dt = null;
            }
            finally
            {

            }

            return dt;
        }

        public DataTable getInvoiceDetailByInvcNo( string _date , string _invcNo , string _storeNo , string _ipConfigName )
        {
            DataTable dt = new DataTable();

            try
            {
                string sqlReciept = "select v.upc AS UPC,  "
                                        + " it.ITEM_POS, "
                                        + " it.qty AS QTY,  "
                                        + " v.DESCRIPTION2 AS MOTA, "
                                        + " v.SIZ AS SIZ, "
                                        + " v.ATTR AS MAU, "
                                        + " (it.price * it.qty) AS PRICE,  "
                                        + " (NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE)-(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)) AS DISCOUNT, "
                                        + " i.INVC_NO AS INVC_NO "
                                + " from inventory_v v, invoice_v i, invc_item it  "
                                + " where it.item_sid = v.item_sid  "
                                        + " and i.invc_no = " + _invcNo
                                        + " AND i.invc_sid = it.invc_sid "
                                       + "  AND ((Trunc(i.Created_Date) >= TO_DATE('" + _date + "', 'dd/MM/yyyy')) AND (Trunc(i.Created_Date) <= TO_DATE('" + _date + "', 'dd/MM/yyyy')))    "
                                        + " and i.store_no =  " + _storeNo
                                + " GROUP BY  v.upc,  "
                                        + " it.ITEM_POS, "
                                        + " it.qty,  "
                                        + " v.DESCRIPTION2, "
                                        + " v.SIZ, "
                                        + " v.ATTR, "
                                        + " it.price,  "
                                        + " (NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE)-(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)), "
                                        + " i.INVC_NO ";

                oraCon = new Utilities.ORACon();
                dt = new DataTable();

                dt = oraCon.returnDataTable( sqlReciept , _ipConfigName );
            }
            catch ( Exception  )
            {
                dt = null;
            }
            finally
            {

            }

            return dt;
        }

        public DataTable GET_Sum_DoanhThu_By_StoreCode( string _fromDate , string _toDate , string _storeCode , string _sbsNo , bool _server)
        {
            DataTable _dt = new DataTable();

            try
            {
                if ( !_server )
                {
                    string sqlReciept = "";
                    sqlReciept += "SELECT s.REGION_NAME, s.STORE_CODE, "
                                            + " ROUND((sum(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)))  , 0) AS TOTAL_MONEY, "
                                            + " sum(it.QTY) AS TOTAL_QTY, "
                                            + " ROUND((sum((NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE) - (NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)))),0) AS TOTAL_DISCOUNT "
                                        + " FROM "
                                            + " INVOICE_v i,  "
                                            + " INVC_ITEM it,  "
                                            + " STORE_v s,  "
                                            + " INVENTORY_V v "
                                        + " WHERE "
                                            + " i.invc_sid = it.invc_sid "
                                            + " AND i.sbs_no = s.sbs_no  "
                                            + " AND i.store_no = s.store_no  "
                                            + " AND v.item_sid = it.item_sid  "
                                            + " AND v.sbs_no = i.sbs_no  "
                                            + " AND i.held <> 1  "
                                            + " AND nvl(i.HiSec_Type,0) NOT IN (2,3,4,5,10,11)  "
                                            + " AND i.Invc_Type IN (0,2)  "
                                            + " AND (i.Sbs_No in ( '" + _sbsNo + "' ))  "
                                            + " AND 0 = (case  "
                                                    + " when i.Status = 1 then 1   "
                                                    + " WHEN BitAnd(65536, i.Proc_Status) <> 0 THEN 2  "
                                                    + " WHEN BitAnd(131072, i.Proc_Status) <> 0 THEN 3   "
                                                    + " ELSE 0  END)  "
                                            + " AND nvl(it.Kit_Flag,0) NOT IN (2, 3)  "
                                            + " AND ((Trunc(i.Created_Date) >= TO_DATE('" + _fromDate + "', 'dd/MM/yyyy'))  "
                                            + " AND (Trunc(i.Created_Date) <= TO_DATE('" + _toDate + "', 'dd/MM/yyyy')))  "
                                            + " AND i.STORE_NO NOT IN (163,237,111,110,109,2,1,307,309)"
                                            + " AND (i.STORE_NO IN (select store_no from store where store_code = '" + _storeCode + "' and sbs_no = " + _sbsNo + "))  "
                                        + " GROUP BY s.REGION_NAME, s.STORE_CODE "
                                        + " ORDER BY "
                                            + " s.REGION_NAME";

                    oraCon = new Utilities.ORACon();
                    _dt = new DataTable();

                    _dt = oraCon.returnDataTable( sqlReciept , "PC-"+_storeCode );
                }
                else
                {
                    Utilities.ORACon _oraCon = new Utilities.ORACon();
                    OracleCommand command = new OracleCommand();

                    command.Connection = _oraCon.GetConnection( "192.168.9.248" );

                    command.CommandText = "NN_Invoice.GET_Sum_DoanhThu_By_StoreCode";
                    command.CommandType = CommandType.StoredProcedure;

                    OracleParameter v_FromDate = command.Parameters.Add( "v_FromDate" , OracleDbType.Varchar2 );
                    v_FromDate.Value = _fromDate;

                    OracleParameter v_ToDate = command.Parameters.Add( "v_ToDate" , OracleDbType.Varchar2 );
                    v_ToDate.Value = _toDate;

                    OracleParameter v_StoreCode = command.Parameters.Add( "v_StoreCode" , OracleDbType.Varchar2 );
                    v_StoreCode.Value = _storeCode;

                    OracleParameter v_sbs_no = command.Parameters.Add( "v_SbsNo" , OracleDbType.Varchar2 );
                    v_sbs_no.Value = _sbsNo;

                    OracleParameter my_cursor = command.Parameters.Add( "my_cursor" , OracleDbType.RefCursor );
                    my_cursor.Direction = ParameterDirection.Output;

                    OracleDataAdapter da = new OracleDataAdapter( command );
                    da.Fill( _dt );
                }                
            }
            catch ( Exception  )
            {
                _dt = null;
            }

            return _dt;
        }

        public DataTable GET_Invoice_CTKM_TriAnKH_112015(int _gtriHD, int _storeNo, int _sbsNo, string _ipConfigName, string _date)
        {
            //string _date = "08/11/2015";
            DataTable dt = new DataTable();
            string _invcSidUsed = this.CTKM_TriAnKH_112015_InvcList_Used(_storeNo);
            try
            {
                string sqlReciept = "SELECT * FROM (SELECT   "
                    + " Trunc(i.Created_Date) AS CREATED_DATE,  "
                    + " TO_CHAR(i.Created_Date, 'HH24:MI:SS') AS CREATED_TIME,  "
                    + " i.Invc_No AS INVC_NO,   "
                    + " i.INVC_SID AS INVC_SID,   "
                    + " i.Cust_Sid AS CUST_SID,   "
                    + " round(sum(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)),0) AS TOTALMONEY, "
                    + " sum(it.QTY) AS SUMQTY, "
                    + " round(sum((NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE) - (NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100))),0) AS DISCAMOUNT "
                + " FROM "
                    + " INVOICE_v i,  "
                    + " INVC_ITEM it,  "
                    + " STORE s,  "
                    + " INVENTORY_V v "
                + " WHERE "
                    + " i.invc_sid = it.invc_sid "
                    + " AND i.sbs_no = s.sbs_no  "
                    + " AND i.store_no = s.store_no  "
                    + " AND v.item_sid = it.item_sid  "
                    + " AND v.sbs_no = i.sbs_no  "
                    + " AND i.held <> 1  "
                    + " AND nvl(i.HiSec_Type,0) NOT IN (2,3,4,5,10,11)  "
                    + " AND i.Invc_Type IN (0,2)  "
                    + " AND (i.Sbs_No in (" + _sbsNo + "))  "
                    + " AND 0 = (case  "
                            + " when i.Status = 1 then 1   "
                            + " WHEN BitAnd(65536, i.Proc_Status) <> 0 THEN 2  "
                            + " WHEN BitAnd(131072, i.Proc_Status) <> 0 THEN 3   "
                            + " ELSE 0  END)  "
                    + " AND nvl(it.Kit_Flag,0) NOT IN (2, 3)  "
                    + " AND ((Trunc(i.Created_Date) >= TO_DATE('" + _date + "', 'dd/MM/yyyy'))  "
                    + " AND (Trunc(i.Created_Date) <= TO_DATE('" + _date + "', 'dd/MM/yyyy')))  "
                    + " AND (i.STORE_NO IN ('" + _storeNo + "'))  "
                    + " AND (i.INVC_SID = it.INVC_SID)  "
                + " GROUP BY"
                    + " Trunc(i.Created_Date), "
                    + " TO_CHAR(i.Created_Date, 'HH24:MI:SS'),  "
                    + " i.Invc_No, "
                    + " i.Invc_Sid, "
                    + " i.Cust_Sid "
                + " ORDER BY "
                    + " i.invc_no) temp where temp.TOTALMONEY >= " + _gtriHD ;

                if(!_invcSidUsed.Equals(""))
                    sqlReciept += " and temp.invc_sid not in ("+ _invcSidUsed +")";

                oraCon = new Utilities.ORACon();
                dt = new DataTable();

                dt = oraCon.returnDataTable(sqlReciept, _ipConfigName);
            }
            catch (Exception )
            {
                dt = null;
            }
            finally
            {

            }

            return dt;
        }
        #endregion

        #region Action
        private string ConvertDateToSQL( string _date )
        {
            string _rs = "";

            _rs = _date.Substring( 3 , 2 ) + "/" + _date.Substring( 0 , 2 ) + "/" + _date.Substring( 6 , 4 );

            return _rs;
        }

        private string GetInvcSidUsed( string _fromDate , string _toDate , string _storeCode )
        {
            string _rs = " ";

            sqlCon = new Utilities.SQLCon();
            DataTable _dt = new DataTable();
            string _sqlString = "select invcsid from v_CS_PromotionCode_Invoice_Info where Store_Code = '" + _storeCode + "' and Date_Create >= '" + this.ConvertDateToSQL( _fromDate ) + "' and Date_Create <= '" + this.ConvertDateToSQL( _toDate ) + "'";

            _dt = sqlCon.returnDataTable( _sqlString );

            for ( int i = 0 ; i < _dt.Rows.Count ; i++ )
            {
                DataRow row = _dt.Rows[i];
                _rs += row["INVCSID"].ToString() + ",";
            }

            return _rs.Substring( 0 , ( _rs.Length - 1 ) );
        }
        #endregion
    }
}
