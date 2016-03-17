using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PRO;

namespace DAL
{
    public class cl_DAL_Voucher
    {
        Utilities.ORACon _oraCon;

        public int CountASN( string _storeNo , string _ip )
        {
            int _rs = 0;

            DataTable _dt = new DataTable();

            try
            {
                string _sql = "SELECT COUNT(*) FROM VOUCHER_V WHERE ACTIVE = 1 AND VOU_CLASS = 2 AND STORE_NO = " + _storeNo;

                _oraCon = new Utilities.ORACon();
                _dt = new DataTable();

                _dt = _oraCon.returnDataTable( _sql , _ip );
                _rs = int.Parse( _dt.Rows[0][0].ToString() );
            }
            catch ( Exception  )
            {
                _rs = 0;
            }
            finally
            {

            }

            return _rs;
        }

        public DataTable GetASNList( string _storeNo , string _ip )
        {
            DataTable _dt = new DataTable();

            try
            {
                string _sql = "SELECT v.vou_sid "
                                + " , s.slip_sid "
                                + " , s.created_date as Slip_CreatedDate "
                                + " , v.created_date as Vou_CreatedDate "
                                + " , st.store_code as FromStore "
                                + " , sum(vou.qty) as SumQty "
                                + " , s.slip_no "
                            + " FROM slip_v s,  "
                                + " voucher_v v,  "
                                + " store_v st, "
                                + " vou_item vou "
                            + " WHERE s.vou_sid = v.vou_sid "
                                + " and v.vou_class = 2 "
                                + " and v.active = 1 "
                                + " and s.out_store_no = st.store_no "
                                + " and st.sbs_no = 2 "
                                + " and st.active = 1 "
                                + " and v.vou_sid = vou.vou_sid "
                                + " and v.store_no = " + _storeNo + " "
                            + " GROUP BY v.vou_sid "
                                + " , s.slip_sid "
                                + " , s.created_date  "
                                + " , v.created_date "
                                + " , st.store_code "
                                + " , s.slip_no";

                _oraCon = new Utilities.ORACon();
                _dt = new DataTable();

                _dt = _oraCon.returnDataTable( _sql , _ip );
            }
            catch ( Exception  )
            {
                _dt = null;
            }
            finally
            {

            }

            return _dt;
        }

        public DataTable GetASNDetail( string _vouSid , string _ip )
        {
            DataTable _dt = new DataTable();

            try
            {
                string _sql = "SELECT i.upc "
                              + " , i.description2 "
                              + " , i.attr "
                              + " , i.siz "
                              + " , sum(vou.qty) as SUMQTY "
                            + " FROM vou_item_v vou, "
                                  + " inventory_v i "
                            + " WHERE i.item_sid = vou.item_sid "
                              + " and vou_sid = '" + _vouSid + "' "
                            + " GROUP BY i.upc "
                              + " , i.description2 "
                              + " , i.attr "
                              + " , i.siz";

                _oraCon = new Utilities.ORACon();
                _dt = new DataTable();

                _dt = _oraCon.returnDataTable( _sql , _ip );
            }
            catch ( Exception  )
            {
                _dt = null;
            }
            finally
            {

            }

            return _dt;
        }

        public cl_PRO_Voucher GetVoucherByVouSid( string _vouSid , string _ip)
        {
            cl_PRO_Voucher _proVoucher = new cl_PRO_Voucher();
            DataTable _dt = new DataTable();

            try
            {
                string _sql = "SELECT v.vou_sid "
                                + " , s.slip_sid "
                                + " , s.created_date as Slip_CreatedDate "
                                + " , v.created_date as Vou_CreatedDate "
                                + " , st.store_code as FromStore "
                                + " , sum(vou.qty) as SumQty "
                                + " , s.slip_no "
                            + " FROM slip_v s,  "
                                + " voucher_v v,  "
                                + " store_v st, "
                                + " vou_item vou "
                            + " WHERE s.vou_sid = v.vou_sid "
                                + " and v.vou_class = 2 "
                                + " and v.active = 1 "
                                + " and s.out_store_no = st.store_no "
                                + " and st.sbs_no = 2 "
                                + " and st.active = 1 "
                                + " and v.vou_sid = vou.vou_sid "
                                + " and v.vou_sid = " + _vouSid + " "
                            + " GROUP BY v.vou_sid "
                                + " , s.slip_sid "
                                + " , s.created_date  "
                                + " , v.created_date "
                                + " , st.store_code "
                                + " , s.slip_no";

                _oraCon = new Utilities.ORACon();
                _dt = new DataTable();

                _dt = _oraCon.returnDataTable( _sql , _ip );

                _proVoucher.SlipCreatedDate = _dt.Rows[0]["Slip_CreatedDate"].ToString();
                _proVoucher.SlipNo = _dt.Rows[0]["Slip_No"].ToString();
                _proVoucher.SlipOutStoreCode = _dt.Rows[0]["FromStore"].ToString();
                _proVoucher.SlipSid = _dt.Rows[0]["slip_sid"].ToString();
                _proVoucher.SumQty = int.Parse( _dt.Rows[0]["SumQty"].ToString() );
                _proVoucher.VouSid = _dt.Rows[0]["vou_sid"].ToString();
            }
            catch ( Exception  )
            {
                _proVoucher.SlipCreatedDate = null;
                _proVoucher.SlipNo = null;
                _proVoucher.SlipOutStoreCode = null;
                _proVoucher.SlipSid = null;
                _proVoucher.SumQty = 0;
                _proVoucher.VouSid = null;
            }

            return _proVoucher;
        }
    }
}
