using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PRO;

namespace DAL
{
    public class cl_DAL_Inventory
    {
        Utilities.ORACon _oraCon;
        DataTable _dt;
        string tableInventory = "rap.vfcho_inventory";

        Utilities.SQLCon _sqlCon;

        public cl_PRO_Inventory getUPCInfo(string _upc, string _ip)
        {
            PRO.cl_PRO_Inventory upc = new PRO.cl_PRO_Inventory();

            try
            {
                _sqlCon = new Utilities.SQLCon();

                string _sql = "select v.UPC, v.price_list, v.price_retail, v.udf10, v.description2 from " + tableInventory + " v where UPC ='" + _upc + "'";

                _dt = _sqlCon.returnDataTable(_sql);

                if (_dt.Rows.Count == 1)
                {
                    upc.UPC = _dt.Rows[0]["UPC"].ToString();
                    upc.PriceList = _dt.Rows[0]["price_list"].ToString();
                    upc.PriceRetail = _dt.Rows[0]["price_retail"].ToString();
                    upc.UDF10 = _dt.Rows[0]["udf10"].ToString();
                    upc.Desc2 = _dt.Rows[0]["description2"].ToString();
                }
            }
            catch (Exception )
            {
                upc.UPC = null;
                upc.PriceList = null;
                upc.PriceRetail = null;
                upc.UDF10 = null;
                upc.Desc2 = null;
            }

            return upc;
        }

        public bool checkValidUPC(string _upc, string _ip)
        {
            bool flag = false;

            try
            {
                _sqlCon = new Utilities.SQLCon();

                string _sql = "select v.UPC, v.price_list, v.price_retail, v.udf10 from " + tableInventory + " v where UPC ='" + _upc + "'";

                _dt = _sqlCon.returnDataTable(_sql);

                if (_dt.Rows.Count == 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }
            catch (Exception )
            {
                flag = false;
            }

            return flag;
        }

        public bool checkSaleUPC(string _upc, string _ip)
        {
            bool flag = false;

            try
            {
                _sqlCon = new Utilities.SQLCon();

                string _sql = "select v.UPC, v.price_list, v.price_retail, v.udf10 from " + tableInventory + " v where UPC ='" + _upc + "' and v.price_retail < v.price_list";

                _dt = _sqlCon.returnDataTable(_sql);

                if (_dt.Rows.Count == 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }
            catch (Exception )
            {
                flag = false;
            }

            return flag;
        }

        /*
        public cl_PRO_Inventory getUPCInfo(string _upc, string _ip)
        {
            PRO.cl_PRO_Inventory upc = new PRO.cl_PRO_Inventory();

            try
            {
                _oraCon = new Utilities.ORACon();

                string _sql = "select v.UPC, v.price_list, v.price_retail, v.udf10, v.description2 from " + tableInventory + " v where UPC ='" + _upc + "'";
                _dt = _oraCon.returnDataTable(_sql, _ip);

                if (_dt.Rows.Count == 1)
                {
                    upc.UPC = _dt.Rows[0]["UPC"].ToString();
                    upc.PriceList = _dt.Rows[0]["price_list"].ToString();
                    upc.PriceRetail = _dt.Rows[0]["price_retail"].ToString();
                    upc.UDF10 = _dt.Rows[0]["udf10"].ToString();
                    upc.Desc2 = _dt.Rows[0]["description2"].ToString();
                }
            }
            catch (Exception ex)
            {
                upc.UPC = null;
                upc.PriceList = null;
                upc.PriceRetail = null;
                upc.UDF10 = null;
                upc.Desc2 = null;
            }

            return upc;
        }

        public bool checkValidUPC(string _upc, string _ip)
        {
            bool flag = false;

            try
            {
                _oraCon = new Utilities.ORACon();

                string _sql = "select v.UPC, v.price_list, v.price_retail, v.udf10 from " + tableInventory + " v where UPC ='" + _upc + "'";
                _dt = _oraCon.returnDataTable(_sql, _ip);

                if (_dt.Rows.Count == 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }
            catch (Exception ex)
            {
                flag = false;
            }

            return flag;
        }

        public bool checkSaleUPC(string _upc, string _ip)
        {
            bool flag = false;

            try
            {
                _oraCon = new Utilities.ORACon();

                string _sql = "select v.UPC, v.price_list, v.price_retail, v.udf10 from " + tableInventory + " v where UPC ='" + _upc + "' and v.price_retail < v.price_list";
                _dt = _oraCon.returnDataTable(_sql, _ip);

                if (_dt.Rows.Count == 1)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }
            catch (Exception ex)
            {
                flag = false;
            }

            return flag;
        }
        */
        #region Mã Thiết Kế
        public DataTable GetColorListByMTK( string _mtk )
        {
            _dt = new DataTable();

            _oraCon = new Utilities.ORACon();
            string _sql = "select ATTR "
                                + " from vfc_inventory_v_s2 "
                                + " where description1 like '%" + _mtk + "%' "
                                  + " and active = 1 "
                                  + " and sbs_no = 2 "
                                + " group by ATTR";

            _dt = _oraCon.returnDataTable( _sql , "192.168.9.248" );

            return _dt;
        }

        public cl_PRO_Inventory GetMTKInfo( string _mtk , string _ip248)
        {
            cl_PRO_Inventory _proMTK = new cl_PRO_Inventory();
            _dt = new DataTable();
            _oraCon = new Utilities.ORACon();

            string _sql = "SELECT * FROM VFCHO_MaThietKe WHERE MTK like '%" + _mtk + "%'";
            _dt = _oraCon.returnDataTable( _sql , _ip248 );

            _proMTK.ChatLieu = _dt.Rows[0]["CHAT_LIEU"].ToString();
            _proMTK.ColorCount = _dt.Rows[0]["COLOR_COUNT"].ToString();
            _proMTK.Desc2 = _dt.Rows[0]["TEN_SAN_PHAM"].ToString();
            _proMTK.MaThietKe = _dt.Rows[0]["MTK"].ToString();
            _proMTK.NhaCungCap = _dt.Rows[0]["SUPPLIER"].ToString();
            _proMTK.PriceList = _dt.Rows[0]["GIA_BAN_DAU"].ToString();
            _proMTK.PriceRetail = _dt.Rows[0]["GIA_BAN"].ToString();
            _proMTK.Season = _dt.Rows[0]["SEASON"].ToString();
            _proMTK.SizeRange = _dt.Rows[0]["SIZE_RANGE"].ToString();
            _proMTK.UDF10 = _dt.Rows[0]["COLOR_COUNT"].ToString();
            _proMTK.UDF7 = _dt.Rows[0]["UDF7"].ToString();
            _proMTK.UDF8 = _dt.Rows[0]["UDF8"].ToString();

            return _proMTK;
        }
        #endregion
    }
}
