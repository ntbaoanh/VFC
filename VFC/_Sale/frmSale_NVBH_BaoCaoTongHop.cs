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
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;

namespace VFC._Sale
{
    public partial class frmSale_NVBH_BaoCaoTongHop : DevExpress.XtraEditors.XtraForm
    {
        public frmSale_NVBH_BaoCaoTongHop()
        {
            InitializeComponent();
        }

        #region Action

        private string iValidate()
        {
            string _rs = "";

            if ((DateTime)dateFrom.EditValue > (DateTime)dateTo.EditValue)
            {
                _rs += "Từ ngày không thể lớn hơn đến ngày.";
            }

            return _rs;
        }

        #endregion

        private void frmSale_NVBH_BaoCaoTongHop_Load(object sender, EventArgs e)
        {
            dateFrom.EditValue = DateTime.Now;
            dateTo.EditValue = DateTime.Now;
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Stopwatch sw = Stopwatch.StartNew();  

            string _ivalidate = iValidate();

            if (_ivalidate.Equals(""))
            {
                try
                {
                    cl_DAL_NhanVienBanHang _dalNvbh = new cl_DAL_NhanVienBanHang();
                    gridControl1.DataSource = _dalNvbh.GET_NVBH_BaoCaoTongHop(((DateTime)dateFrom.EditValue).ToString("MM/dd/yyyy"), ((DateTime)dateTo.EditValue).ToString("MM/dd/yyyy"), frmMain._myAppConfig.StoreNo);
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
            sw.Stop();
            lbDuration.Text = sw.Elapsed.TotalSeconds + " s";
            splashScreenManager1.CloseWaitForm();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string approve = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Approve"]);
                string active = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Active"]);
                if (!approve.Equals("Checked"))
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }

                if (!active.Equals("Checked"))
                {
                    e.Appearance.BackColor = Color.Aqua;
                    e.Appearance.BackColor2 = Color.Aquamarine;
                }
            }
        }
    }
}