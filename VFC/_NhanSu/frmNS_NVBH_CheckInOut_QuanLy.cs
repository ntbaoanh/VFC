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

namespace VFC._NhanSu
{
    public partial class frmNS_NVBH_CheckInOut_QuanLy : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_NhanVienBanHang _dalNvbh;

        public frmNS_NVBH_CheckInOut_QuanLy()
        {
            InitializeComponent();
        }

        #region Action
        private void Load_DSNhanVien()
        {
            _dalNvbh = new cl_DAL_NhanVienBanHang();
            gridControl_DSNhanVien.DataSource = _dalNvbh.GET_ALL_NVBH_By_Status(1);
        }

        private void Load_DSCheckInOut()
        {
            try
            {
                _dalNvbh = new cl_DAL_NhanVienBanHang();
                gridControl_ListCheckInOut.DataSource = _dalNvbh.GET_NVBH_ListCheckInOut(int.Parse(gridView_DSNhanVien.GetFocusedRowCellValue("NVSID").ToString()), ((DateTime)(date.EditValue)).ToString("MM/dd/yyyy"));
            }
            catch (Exception)
            { 
            
            }
        }
        #endregion

        private void frmNS_NVBH_CheckInOut_QuanLy_Load(object sender, EventArgs e)
        {
            date.EditValue = DateTime.Now;
            this.Load_DSNhanVien();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            try
            {
                int _nvSid = int.Parse(gridView_DSNhanVien.GetFocusedRowCellValue("NVSID").ToString());
                int _storeNo = int.Parse(gridView_DSNhanVien.GetFocusedRowCellValue("StoreNo").ToString());
                string _ten = gridView_DSNhanVien.GetFocusedRowCellValue("Ho").ToString() + " " + gridView_DSNhanVien.GetFocusedRowCellValue("Ten").ToString();
                string _storeCode = gridView_DSNhanVien.GetFocusedRowCellValue("Store_Code").ToString();

                _NhanSu.frmNS_NVBH_CheckInOut_Insert myFrm = new frmNS_NVBH_CheckInOut_Insert("I", _nvSid, _storeNo, _ten, _storeCode);
                myFrm.ShowDialog();
            }
            catch (Exception)
            {
                frmMessageBox.Show("Thông báo", "Vui lòng chọn nhân viên", "error");
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            try
            {
                int _nvSid = int.Parse(gridView_DSNhanVien.GetFocusedRowCellValue("NVSID").ToString());
                int _storeNo = int.Parse(gridView_DSNhanVien.GetFocusedRowCellValue("StoreNo").ToString());
                string _ten = gridView_DSNhanVien.GetFocusedRowCellValue("Ho").ToString() + " " + gridView_DSNhanVien.GetFocusedRowCellValue("Ten").ToString();
                string _storeCode = gridView_DSNhanVien.GetFocusedRowCellValue("Store_Code").ToString();

                _NhanSu.frmNS_NVBH_CheckInOut_Insert myFrm = new frmNS_NVBH_CheckInOut_Insert("O", _nvSid, _storeNo, _ten, _storeCode);
                myFrm.ShowDialog();
            }
            catch (Exception)
            {
                frmMessageBox.Show("Thông báo", "Vui lòng chọn nhân viên", "error");
            }
        }

        private void gridView_DSNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.Load_DSCheckInOut();
            try
            {
                lbNVSID.Text = gridView_DSNhanVien.GetFocusedRowCellValue("NVSID").ToString() +  "-" +
                    gridView_DSNhanVien.GetFocusedRowCellValue("NVID").ToString() ;
            }
            catch (Exception)
            {
                lbNVSID.Text = "";
            }
        }
    }
}