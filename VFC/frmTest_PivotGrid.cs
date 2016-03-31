using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using DevExpress.XtraPivotGrid;

namespace VFC
{
    public partial class frmTest_PivotGrid : DevExpress.XtraEditors.XtraForm
    {
        public frmTest_PivotGrid()
        {
            InitializeComponent();
        }

        private void FillData()
        {
            string query = "SELECT  Trunc(i.Created_Date) AS CREATED_DATE,   "
                    + " TO_CHAR(i.Created_Date, 'HH24:MI:SS') AS CREATED_TIME,    "
                    + " i.Invc_No AS INVC_NO, "
                    + " v.upc, "
                    + " v.udf9, "
                    + " v.gender, "
                    + " ROUND(sum(NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100)), 0) AS TOTALMONEY,   "
                    + " sum(it.QTY) AS SUMQTY,   "
                    + " ROUND(sum((NVL(it.qty * i.Report_Modifier, 0) * it.ORIG_PRICE) - (NVL(it.qty * i.Report_Modifier, 0)*it.PRICE*((100-NVL(DISC_PERC, 0))/100))),0) AS DISCAMOUNT     "
                    + " FROM  INVOICE_v i,   "
                    + " INVC_ITEM it,   "
                    + " STORE s,   "
                    + " vfc_inventory_v_s2 v   "
                    + " WHERE  i.invc_sid = it.invc_sid  "
                    + " AND i.sbs_no = s.sbs_no   "
                    + " AND i.store_no = s.store_no   "
                    + " AND v.item_sid = it.item_sid   "
                    + " AND v.sbs_no = i.sbs_no   "
                    + " AND i.held <> 1   "
                    + " AND nvl(i.HiSec_Type,0) NOT IN (2,3,4,5,10,11)   "
                    + " AND i.Invc_Type IN (0,2) "
                    + " AND (i.Sbs_No in ( '2' )) "
                    + " AND 0 = (case   when i.Status = 1 then 1    WHEN BitAnd(65536, i.Proc_Status) <> 0 THEN 2   WHEN BitAnd(131072, i.Proc_Status) <> 0 THEN 3    ELSE 0  END)    "
                    + " AND nvl(it.Kit_Flag,0) NOT IN (2, 3)   "
                    + " AND ((Trunc(i.Created_Date) >= TO_DATE('30/11/2015', 'dd/MM/yyyy'))   "
                    + " AND (Trunc(i.Created_Date) <= TO_DATE('06/12/2015', 'dd/MM/yyyy')))   "
                    + " AND (i.STORE_NO IN (select STORE_NO from store_v where store_code = 'NT8' and sbs_no = 2))   "
                    + " GROUP BY  Trunc(i.Created_Date),   "
                    + " TO_CHAR(i.Created_Date, 'HH24:MI:SS'),   "
                    + " i.Invc_No,  "
                    + " v.upc, "
                    + " v.udf9, "
                    + " v.gender "
                    + " ORDER BY  i.invc_no ";

            DAL.Utilities.ORACon _conn = new DAL.Utilities.ORACon();
            pivotGridControl1.DataSource = _conn.returnDataTable(query, "192.168.9.248");
        }

        private void frmTest_PivotGrid_Load(object sender, EventArgs e)
        {
            this.FillData();

            PivotGridField fieldUDF9 = new PivotGridField("UDF9", PivotArea.RowArea);
            fieldUDF9.Caption = "Kết cấu";

            PivotGridField fieldGender = new PivotGridField("GENDER", PivotArea.RowArea);
            fieldGender.Caption = "Giới tính";

            PivotGridField fieldMoney = new PivotGridField("TOTALMONEY", PivotArea.ColumnArea);
            fieldMoney.Caption = "Doanh số";                 
            fieldMoney.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldMoney.CellFormat.FormatString = "{0:#,#}";

            PivotGridField fieldSumQty = new PivotGridField("SUMQTY", PivotArea.ColumnArea);
            fieldSumQty.Caption = "Tổng số sp";
            fieldSumQty.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldSumQty.CellFormat.FormatString = "{0:#,#}";

            PivotGridField fieldDiscount = new PivotGridField("DISCAMOUNT", PivotArea.FilterArea);
            fieldDiscount.Caption = "Chiết khấu";
            fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldDiscount.CellFormat.FormatString = "{0:#,#}";

            // Add the fields to the control's field collection.         
            pivotGridControl1.Fields.AddRange(new PivotGridField[] {fieldUDF9, fieldGender, fieldDiscount, fieldMoney, fieldSumQty});

            //// Arrange the row fields within the Row Header Area.
            //fieldCountry.AreaIndex = 0;
            //fieldCustomer.AreaIndex = 1;

            //// Arrange the column fields within the Column Header Area.
            //fieldCategoryName.AreaIndex = 0;
            //fieldYear.AreaIndex = 1;         
        }
    }
}