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
using PRO;

namespace VFC._NhanSu
{
    public partial class frmNS_NVBH_Insert : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_ADMIN admin;

        public frmNS_NVBH_Insert()
        {
            InitializeComponent();
        }

        #region Action
        private void LoadDSTinhThanh()
        {
            cl_DAL_ADMIN admin = new cl_DAL_ADMIN();
            listThanhPho.Properties.DataSource = admin.GET_DSTinhThanh();
        }

        private int Count_Tuoi(string date)
        {
            int years;

            try
            {
                DateTime zeroTime = new DateTime(1, 1, 1);

                DateTime a = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(3, 2)), int.Parse(date.Substring(0, 2)));
                DateTime b = DateTime.Now;

                TimeSpan span = b - a;
                // because we start at year 1 for the Gregorian 
                // calendar, we must subtract a year here.
                years = (zeroTime + span).Year - 1;

                // 1, where my other algorithm resulted in 0.
            }
            catch (Exception ex)
            {
                years = 0;
            }

            return years;
        }

        private string iValidate()
        {
            string rs = "";

            if (this.Count_Tuoi(dateNgaySinh.EditValue.ToString()) < 18)
            {
                rs += "Nhân viên chưa đủ tuổi đi làm." + Environment.NewLine;
            }

            if (this.Count_Tuoi(dateNgaySinh.EditValue.ToString()) >= 30)
            {
                rs += "Nhân viên đã quá tuổi đi làm." + Environment.NewLine;
            }

            if (txtHo.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền vào Họ." + Environment.NewLine;
            }

            if (txtTen.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền vào Tên." + Environment.NewLine;
            }

            if (txtCMND.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền vào CMND." + Environment.NewLine;

                try
                {
                    cl_DAL_NhanVienBanHang dalNvbh = new cl_DAL_NhanVienBanHang();
                    if (dalNvbh.CHECK_NVBH_Exists_ByCMND(txtCMND.Text))
                    {
                        rs += "Thông tin nhân viên đã có. Vui lòng kiểm tra lại." + Environment.NewLine;
                    }
                }
                catch (Exception ex)
                {
                    rs += "Lỗi không xác định.[Check Duplicate CMND]" + Environment.NewLine;
                }
            }

            if (txtPhone.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền vào Số điện thoại." + Environment.NewLine;
            }

            if (rdNam.Checked == false && rdNu.Checked == false)
            {
                rs += "Vui lòng chọn giới tính." + Environment.NewLine;
            }

            if (txtDiaChi.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền vào Địa chỉ." + Environment.NewLine;
            }

            try
            {
                listThanhPho.EditValue.ToString();
            }
            catch (Exception ex)
            {
                rs += "Vui lòng chọn thành phố." + Environment.NewLine; 
            }

            return rs;
        }
        #endregion

        private void frmNS_NVBH_Insert_Load(object sender, EventArgs e)
        {
            lbCuaHang.Text = frmMain._myAppConfig.StoreCode;
            lbChuVu.Text = "NVBH";
            dateNgaySinh.EditValue = DateTime.Now;
            this.LoadDSTinhThanh();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string iValidate = this.iValidate();

            if (iValidate.Equals(""))
            {
                try
                {
                    cl_PRO_NhanVienBanHang proNvbh = new cl_PRO_NhanVienBanHang();

                    proNvbh.Ho = txtHo.Text.Trim();
                    proNvbh.Ten = txtTen.Text.Trim();
                    proNvbh.Cmnd = txtCMND.Text.Trim();
                    proNvbh.Phone = txtPhone.Text.Trim();
                    proNvbh.NgaySinh = dateNgaySinh.EditValue.ToString();
                    if (rdNam.Checked == true)
                    {
                        proNvbh.GioiTinh = 1;
                    }
                    else
                    {
                        proNvbh.GioiTinh = 0;
                    }
                    proNvbh.DiaChi = txtDiaChi.Text.Trim() + " " + listThanhPho.EditValue.ToString();
                    proNvbh.StoreNo = int.Parse(frmMain._myAppConfig.StoreNo);
                    proNvbh.ChucVu = "NVBH";
                    proNvbh.StoreCode = frmMain._myAppConfig.StoreCode;
                    proNvbh.ModifiedBy = "CHT-" + frmMain._myAppConfig.StoreCode;
                    proNvbh.UrlImage = "";
                    proNvbh.LuongCanBan = 0;
                    proNvbh.GhiChu = "POS - Tạo mới nhân viên";

                    cl_DAL_NhanVienBanHang dalNvbh = new cl_DAL_NhanVienBanHang();
                    if (dalNvbh.INSERT_NVBH(proNvbh))
                    {
                        frmMessageBox.Show("Thông báo", "Tạo mới nhân viên bán hàng thành công.", "done");
                        this.Close();
                    }
                    else 
                    {
                        frmMessageBox.Show("Thông báo", "Tạo mới nhân viên bán hàng thất bại.", "error");
                    }
                }
                catch (Exception ex)
                {
                    frmMessageBox.Show("Thông báo", "Tạo mới nhân viên bán hàng thất bại. ["+ex.ToString()+"]", "error");
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", iValidate, "error");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}