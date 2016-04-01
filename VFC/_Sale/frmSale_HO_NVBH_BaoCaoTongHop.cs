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

namespace VFC._Sale
{
    public partial class frmSale_HO_NVBH_BaoCaoTongHop : DevExpress.XtraEditors.XtraForm
    {
        public frmSale_HO_NVBH_BaoCaoTongHop()
        {
            InitializeComponent();
        }

        #region Action
        private string GET_Choose_KhuVuc()
        {
            string _rs = "";

            try
            {
                for (int i = 0; i < listCheckKhuVuc.ItemCount; i++)
                {
                    if (listCheckKhuVuc.Items[i].CheckState == CheckState.Checked)
                    {
                        _rs += listCheckKhuVuc.Items[i].Value.ToString() + ",";
                    }
                }

                _rs = _rs.Substring(0, _rs.Length - 1);
            }
            catch (Exception)
            {
                _rs = "";
            }

            return _rs;
        }

        private string GET_Choose_CuaHang()
        {
            string _rs = "";

            for (int i = 0; i < listCheckCuaHang.Items.Count; i++)
            {
                if (listCheckCuaHang.Items[i].CheckState == CheckState.Checked)
                {
                    _rs += listCheckCuaHang.Items[i].Value.ToString() + ",";
                }
            }

            return _rs.Substring(0, _rs.Length-1);
        }

        private string iValidate()
        {
            string _rs = "";

            if ((DateTime)dateFrom.EditValue > (DateTime)dateTo.EditValue)
            {
                _rs += "Ngày không đúng. Vui lòng chọn lại." + Environment.NewLine;
            }

            bool flag = false;
            for (int i = 0; i < listCheckCuaHang.ItemCount; i++)
            {
                if (listCheckCuaHang.Items[i].CheckState == CheckState.Checked)
                {
                    flag = true;
                }
            }

            if (!flag)
            {
                _rs += "Vui lòng chọn cửa hàng" + Environment.NewLine;
            }

            return _rs;
        }
        #endregion

        private void frmSale_HO_NVBH_BaoCaoTongHop_Load(object sender, EventArgs e)
        {
            dateFrom.EditValue = DateTime.Now;
            dateTo.EditValue = DateTime.Now;
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            string _ivalidate = iValidate();

            if (_ivalidate.Equals(""))
            {
                try
                {
                    pivotGridControl1.Fields.Clear();

                    cl_DAL_NhanVienBanHang _dalNvbh = new cl_DAL_NhanVienBanHang();
                    DataTable _dt = new DataTable();
                    _dt = _dalNvbh.GET_NVBH_BaoCaoTongHop(((DateTime)dateFrom.EditValue).ToString("MM/dd/yyyy"), ((DateTime)dateTo.EditValue).ToString("MM/dd/yyyy"), this.GET_Choose_CuaHang());;
                    
                    pivotGridControl1.DataSource = _dt;
                    gridControl_DuLieuTho.DataSource = _dt;

                    PivotGridField f_StoreCode = new PivotGridField("Store_Code", PivotArea.RowArea);
                    f_StoreCode.Caption = "Cửa hàng";

                    PivotGridField f_TenNV = new PivotGridField("HoTen", PivotArea.RowArea);
                    f_TenNV.Caption = "Họ và tên";

                    PivotGridField f_NVID = new PivotGridField("NVID", PivotArea.RowArea);
                    f_NVID.Caption = "ID";

                    PivotGridField f_TongNC = new PivotGridField("Total_NC", PivotArea.DataArea);
                    f_TongNC.Caption = "Tổng giờ công";
                    f_TongNC.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    f_TongNC.CellFormat.FormatString = "{0:#,#}";

                    PivotGridField f_TongK = new PivotGridField("Total_K", PivotArea.DataArea);
                    f_TongK.Caption = "Tổng giờ tăng ca";
                    f_TongK.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    f_TongK.CellFormat.FormatString = "{0:#,#}";

                    PivotGridField f_TongDoanhSo = new PivotGridField("TongDoanhSo", PivotArea.DataArea);
                    f_TongDoanhSo.Caption = "Tổng doanh số";
                    f_TongDoanhSo.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    f_TongDoanhSo.CellFormat.FormatString = "{0:#,#}";

                    PivotGridField f_TongSlg = new PivotGridField("TongSoLuong", PivotArea.DataArea);
                    f_TongSlg.Caption = "Tổng số lượng";
                    f_TongSlg.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    f_TongSlg.CellFormat.FormatString = "{0:#,#}";

                    PivotGridField f_TongSoBill = new PivotGridField("TotalBill", PivotArea.DataArea);
                    f_TongSoBill.Caption = "Tổng số bill";
                    f_TongSoBill.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    f_TongSoBill.CellFormat.FormatString = "{0:#,#}";

                    // Add the fields to the control's field collection.         
                    pivotGridControl1.Fields.AddRange(new PivotGridField[] { f_StoreCode
                                , f_NVID
                                , f_TenNV
                                , f_TongNC
                                , f_TongK
                                , f_TongDoanhSo
                                , f_TongSlg
                                , f_TongSoBill});

                    pivotGridControl1.CollapseAll();
                }
                catch (Exception ex)
                {
                    frmMessageBox.Show("Thông báo", "Có lõi trong quá trình lấy dữ liệu." + Environment.NewLine + "Vui lòng liên hệ quản trị viên." + Environment.NewLine + ex.ToString(), "error");
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", _ivalidate, "error");
            }
        }

        private void chkAllCuaHang_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkAllCuaHang.CheckState == CheckState.Checked)
                {
                    for (int i = 0; i < listCheckCuaHang.ItemCount; i++)
                    {
                        listCheckCuaHang.Items[i].CheckState = CheckState.Checked;
                    }
                }
                else
                {
                    for (int i = 0; i < listCheckCuaHang.ItemCount; i++)
                    {
                        listCheckCuaHang.Items[i].CheckState = CheckState.Unchecked;
                    }
                }
            }
            catch (Exception)
            { 
                
            }
        }

        private void listCheckKhuVuc_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
         {
            try
            {
                DataSet ds = new DataSet();
                string _region = this.GET_Choose_KhuVuc();

                if (_region.Equals(""))
                {
                    listCheckCuaHang.Items.Clear();

                    for (int i = 0; i < listCheckKhuVuc.ItemCount; i++)
                    {
                        listCheckKhuVuc.Items[i].CheckState = CheckState.Unchecked;
                    }

                    chkAllCuaHang.CheckState = CheckState.Unchecked;
                }
                else
                {
                    cl_DAL_Store _stores = new cl_DAL_Store();
                    DataTable _dt = new DataTable();

                    _dt = _stores.returnORA_StoreCodeFromRegion(_region);

                    listCheckCuaHang.Items.Clear();
                    foreach (DataRow dataRow in _dt.Rows)
                    {
                        if (!dataRow["STORE_CODE"].ToString().Equals("ZT2")
                                && !dataRow["STORE_CODE"].ToString().Equals("KDP")
                                && !dataRow["STORE_CODE"].ToString().Equals("ZAA")
                                && !dataRow["STORE_CODE"].ToString().Equals("MER")
                                && !dataRow["STORE_CODE"].ToString().Equals("ZHN")
                                && !dataRow["STORE_CODE"].ToString().Equals("ZDN"))
                        {
                            listCheckCuaHang.Items.Add(dataRow["STORE_NO"], dataRow["STORE_CODE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                frmMessageBox.Show("Thông báo lỗi", ex.ToString(), "error");
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            saveFileDialog1.ShowDialog();  
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveFileDialog1.FileName;
            try
            {
                pivotGridControl1.ExportToXlsx(fileName);
            }
            catch (Exception)
            {

            }
        }

        private void btExportRawData_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            saveFileDialog2.ShowDialog();  
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveFileDialog2.FileName;
            try
            {
                gridView_DuLieuTho.BestFitColumns();
                gridControl_DuLieuTho.ExportToXlsx(fileName);
            }
            catch (Exception)
            {

            }
        }
    }
}