﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DAL;

namespace VFC._Sale
{
    public partial class frmSale_NVBH_CheckInOut : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_NhanVienBanHang dalNvbh;

        public frmSale_NVBH_CheckInOut()
        {
            InitializeComponent();
        }

        #region Action
        private void LoadDSNhanVien()
        {
            dalNvbh = new cl_DAL_NhanVienBanHang();

            gridControl1.DataSource = dalNvbh.GET_NVBH_By_Store(frmMain._myAppConfig.StoreCode);
        }

        private void GET_NVBH_Working_Status(int nvid)
        {
            dalNvbh = new cl_DAL_NhanVienBanHang();

            try
            {
                bool rs = dalNvbh.GET_NVBH_WorkingStatus(nvid);

                if (rs == true)
                {
                    btIn.Enabled = false;
                    btOut.Enabled = true;
                }
                else
                {
                    btIn.Enabled = true;
                    btOut.Enabled = false;
                }
            }
            catch (Exception )
            {
                btIn.Enabled = false;
                btOut.Enabled = false;
            }
        }

        private void ClearData()
        {
            lbHo.Text = "";
            lbTen.Text = "";
            lbPhone.Text = "";
            lbGioiTinh.Text = "";
            lbNVID.Text = "";
            btIn.Enabled = false;
            btOut.Enabled = false;
            this.LoadDSNhanVien();
        }

        private void Load_DSCheckInOut()
        {
            try
            {
                cl_DAL_NhanVienBanHang _dalNvbh = new cl_DAL_NhanVienBanHang();
                gridControl_ListCheckInOut.DataSource = _dalNvbh.GET_NVBH_ListCheckInOut(int.Parse(gridView1.GetFocusedRowCellValue("NVSID").ToString()), DateTime.Now.ToString("MM/dd/yyyy"));
            }
            catch (Exception)
            {

            }
        }

        private string iValidate()
        {
            string rs = "";

            if (lbNVID.Text.Equals(""))
            {
                rs += "Vui lòng chọn nhân viên.";
            }

            return rs;
        }
        #endregion

        private void frmSale_NVBH_CheckInOut_Load(object sender, EventArgs e)
        {
            this.Text = "Tình hình làm việc ngày " + DateTime.Now.ToShortDateString();
            this.LoadDSNhanVien();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                lbHo.Text = gridView1.GetFocusedRowCellValue("Ho").ToString();
                lbTen.Text = gridView1.GetFocusedRowCellValue("Ten").ToString();
                lbPhone.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
                lbGioiTinh.Text = gridView1.GetFocusedRowCellValue("GioiTinh").ToString();
                this.GET_NVBH_Working_Status(int.Parse(gridView1.GetFocusedRowCellValue("NVSID").ToString()));
                lbNVID.Text = gridView1.GetFocusedRowCellValue("NVSID").ToString();
                this.Load_DSCheckInOut();
            }
            catch (Exception )
            {
                this.ClearData();
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (this.iValidate().Equals(""))
            {
                dalNvbh = new cl_DAL_NhanVienBanHang();

                if (!dalNvbh.CHECK_NVBH_DiLamSom())
                {
                    frmMessageBox.Show("Thông báo", "Chưa tới giờ check in." + Environment.NewLine + "Vui lòng thử lại sau", "error");
                    this.ClearData();
                    btIn.Enabled = false;
                    btOut.Enabled = false;
                }
                else
                {
                    if (dalNvbh.INSERT_CheckInOut(int.Parse(lbNVID.Text), int.Parse(frmMain._myAppConfig.StoreNo), "I"))
                    {
                        frmMessageBox.Show("Thông báo", "Check In thành công.", "done");
                        this.ClearData();
                    }
                    else
                    {
                        frmMessageBox.Show("Thông báo", "Check In không thành công." + Environment.NewLine, "error");
                    }
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", this.iValidate() , "error");
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            if (this.iValidate().Equals(""))
            {
                dalNvbh = new cl_DAL_NhanVienBanHang();

                if (!dalNvbh.CHECK_NVBH_DiLamSom())
                {
                    frmMessageBox.Show("Thông báo", "Chưa tới giờ check in." + Environment.NewLine + "Vui lòng thử lại sau", "error");
                    btIn.Enabled = false;
                    btOut.Enabled = false;
                }
                else
                {
                    if (dalNvbh.INSERT_CheckInOut(int.Parse(lbNVID.Text), int.Parse(frmMain._myAppConfig.StoreNo), "O"))
                    {
                        frmMessageBox.Show("Thông báo", "Check Out thành công.", "done");
                        this.ClearData();
                    }
                    else
                    {
                        frmMessageBox.Show("Thông báo", "Check Out không thành công." + Environment.NewLine, "error");
                    }
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", this.iValidate() , "error");
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDSNhanVien();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string approve = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Approve"]);
                
                if (!approve.Equals("Checked"))
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }
    }
}