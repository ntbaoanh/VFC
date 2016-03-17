using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using PRO;

namespace VFC._NhaCungCap
{
    public partial class frmNCC_NhaCungCap_Manage : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_ADMIN admin;
        cl_DAL_NhaCungCap _dalNCC;

        public frmNCC_NhaCungCap_Manage()
        {
            InitializeComponent();
        }

        #region Action
        private void LOAD_DSTinhThanh()
        {
            admin = new cl_DAL_ADMIN();
            listThanhPho.Properties.DataSource = admin.GET_DSTinhThanh();
        }

        private void LOAD_DSNganhNghe()
        {
            admin = new cl_DAL_ADMIN();
            listNganhNghe.Properties.DataSource = admin.GET_NganhNghe();
        }

        private void LOAD_DSNhaCungCap()
        {
            _dalNCC = new cl_DAL_NhaCungCap();
            gridControl1.DataSource = _dalNCC.GET_DSNhaCungCap();
        }

        private string iValidate()
        {
            string rs = "";

            if (txtTenNCC.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền vào Tên nhà cung cấp." + Environment.NewLine;
            }

            if (txtNguoiLienLac.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền vào Tên người liên lạc." + Environment.NewLine;
            }

            if (txtPhone.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền vào Số điện thoại người liên lạc." + Environment.NewLine;
            }

            if (rdNam.Checked == false && rdNu.Checked == false)
            {
                rs += "Vui lòng chọn giới tính người liên lạc." + Environment.NewLine;
            }

            if (txtTenCty.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền vào Tên công ty." + Environment.NewLine;
            }

            if (txtSoNha.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền Địa chỉ - Số nhà." + Environment.NewLine;
            }

            if (txtDuong.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền Địa chỉ - Đường." + Environment.NewLine;
            }

            if (txtPhuongQuan.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền Địa chỉ - Quận." + Environment.NewLine;
            }

            if (listThanhPho.EditValue == null)
            {
                rs += "Vui lòng chọn Địa chỉ - Thành phố." + Environment.NewLine;
            }

            if (listNganhNghe.EditValue == null)
            {
                rs += "Vui lòng chọn Ngành nghề" + Environment.NewLine;
            }

            return rs;
        }

        private void ClearDetail()
        {
            txtCompanyPhone.Text = "";
            txtDuong.Text = "";
            txtMST.Text = "";
            txtNganHang.Text = "";
            txtNguoiLienLac.Text = "";
            txtNguoiThuHuong.Text = "";
            txtNotes.Text = "";
            txtPhone.Text = "";
            txtPhuongQuan.Text = "";
            txtSoNha.Text = "";
            txtSoTK.Text = "";
            txtTenCty.Text = "";
            txtTenNCC.Text = "";
            listNganhNghe.EditValue = null;
            listThanhPho.EditValue = null;

            this.LOAD_DSNhaCungCap();
        }
        #endregion

        private void frmNCC_NhaCungCap_Manage_Load(object sender, EventArgs e)
        {
            this.LOAD_DSTinhThanh();
            this.LOAD_DSNganhNghe();
            this.LOAD_DSNhaCungCap();
            lbNote1.Text = "* Nếu muốn thay đổi tên hoặc xóa Nhà cung cấp" + Environment.NewLine + " ==> Vui lòng liên hệ Quản trị viên.";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string ivalidate = this.iValidate();

            if (ivalidate.Equals(""))
            {
                cl_PRO_NhaCungCap ncc = new cl_PRO_NhaCungCap();
                ncc.TenNCC = txtTenNCC.Text.Trim();
                ncc.NguoiLienLac = txtNguoiLienLac.Text.Trim();
                ncc.Phone = txtPhone.Text.Trim();

                if (rdNam.Checked == true)
                {
                    ncc.GioiTinhNguoiLL = 1;
                }
                else
                {
                    ncc.GioiTinhNguoiLL = 0;
                }

                ncc.Notes = txtNotes.Text.Trim();
                ncc.TenCty = txtTenCty.Text.Trim();
                ncc.ADDR_SoNha = txtSoNha.Text.Trim();
                ncc.ADDR_Duong = txtDuong.Text.Trim();
                ncc.ADDR_Quan = txtPhuongQuan.Text.Trim();
                ncc.ADDR_ThanhPho = int.Parse(listThanhPho.EditValue.ToString());
                ncc.CompanyPhone = txtCompanyPhone.Text.Trim();
                ncc.MST = txtMST.Text.Trim();
                ncc.NganhNghe = int.Parse(listNganhNghe.EditValue.ToString());
                ncc.TT_SoTK = txtSoTK.Text.Trim();
                ncc.TT_NganHang = txtNganHang.Text.Trim();
                ncc.TT_NguoiThuHuong = txtNguoiThuHuong.Text.Trim();
                ncc.CreatedBy = frmHO_Main._userLogin.UserName;
                //ncc.CreatedBy = "NHANNT";
                cl_DAL_NhaCungCap _dalNhaCungCap = new cl_DAL_NhaCungCap();
                string rs = "";

                if (lbFlagNew.Text.Equals("new"))
                {
                    rs = _dalNhaCungCap.INSERT_NhaCungCap(ncc);
                }
                else if (lbFlagNew.Text.Equals("edit"))
                {
                    DAL.cl_DAL_User user = new cl_DAL_User();
                    frmHO_Main._flagOverride = false;
                    _Admin.frmOverrideLogin overrideLogin = new _Admin.frmOverrideLogin();
                    overrideLogin.ShowDialog();
                    try
                    {
                        if (frmHO_Main._flagOverride == true)
                        {
                            if (user.checkUserRoleOverride(frmHO_Main._userLogin.UserName, "43"))
                            {
                                ncc.NCC_SID = int.Parse(lbNCC_SID.Text);
                                if (rdNam.Checked == true)
                                {
                                    ncc.Active = 1;
                                }
                                else
                                {
                                    ncc.Active = 0;
                                }
                                rs = _dalNhaCungCap.UPDATE_NhaCungCap(ncc);
                                frmHO_Main._flagOverride = false;
                            }
                            else
                            {
                                frmMessageBox.Show("Thông báo", "Bạn không có quyền ghi đè.", "error");
                                rs = "fail";
                            }
                        }
                        else
                        {
                            rs = "fail";
                        }
                    }
                    catch (Exception )
                    {
                        rs = "fail";
                    }
                }

                if (rs.Equals("success"))
                {
                    if (lbFlagNew.Text.Equals("new"))
                    {
                        frmMessageBox.Show("Thông báo", "Tạo mới nhà cung cấp thành công.", "done");
                        this.ClearDetail();
                    }
                    else if (lbFlagNew.Text.Equals("edit"))
                    {
                        frmMessageBox.Show("Thông báo", "Cập nhật nhà cung cấp thành công.", "done");
                        this.ClearDetail();
                    }
                }
                else if (rs.Equals("fail"))
                {
                    if (lbFlagNew.Text.Equals("new"))
                    {
                        frmMessageBox.Show("Thông báo", "Tạo mới nhà cung cấp thất bại.", "error");
                    }
                    else if (lbFlagNew.Text.Equals("edit"))
                    {
                        frmMessageBox.Show("Thông báo", "Cập nhật nhà cung cấp thất bại.", "error");
                    }
                }
                else if (rs.Equals("duplicate"))
                {
                    frmMessageBox.Show("Thông báo", "Tên nhà cung cấp bị trùng. Vui lòng thử tên khác.", "error");
                }
                else
                {
                    frmMessageBox.Show("Thông báo", "Lỗi không xác định. Vui lòng liên hệ quản trị viên.", "error");
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", ivalidate, "error");
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.ClearDetail();
            txtTenNCC.Enabled = true;
            lbFlagNew.Text = "new";
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            this.LOAD_DSNhaCungCap();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lbFlagNew.Text = "edit";
            txtTenNCC.Enabled = false;

            try
            {
                txtTenNCC.Text = gridView2.GetFocusedRowCellValue("TenNCC").ToString();
                txtNguoiLienLac.Text = gridView2.GetFocusedRowCellValue("NguoiLienLac").ToString();
                txtPhone.Text = gridView2.GetFocusedRowCellValue("Phone").ToString();
                string gender = gridView2.GetFocusedRowCellValue("GioiTinh_NguoiLL").ToString();
                if (gender.Equals("True"))
                {
                    rdNam.Checked = true;
                }
                else if (gender.Equals("False"))
                {
                    rdNu.Checked = true;
                }
                txtNotes.Text = gridView2.GetFocusedRowCellValue("Notes").ToString();
                txtTenCty.Text = gridView2.GetFocusedRowCellValue("TenCty").ToString();
                txtSoNha.Text = gridView2.GetFocusedRowCellValue("ADDR_SoNha").ToString();
                txtDuong.Text = gridView2.GetFocusedRowCellValue("ADDR_Duong").ToString();
                txtPhuongQuan.Text = gridView2.GetFocusedRowCellValue("ADDR_Quan").ToString();
                listThanhPho.EditValue = int.Parse(gridView2.GetFocusedRowCellValue("ADDR_ThanhPho").ToString());
                txtCompanyPhone.Text = gridView2.GetFocusedRowCellValue("CompanyPhone").ToString();
                txtMST.Text = gridView2.GetFocusedRowCellValue("MST").ToString();
                listNganhNghe.EditValue = int.Parse(gridView2.GetFocusedRowCellValue("NganhNghe").ToString());
                txtSoTK.Text = gridView2.GetFocusedRowCellValue("TT_SoTK").ToString();
                txtNganHang.Text = gridView2.GetFocusedRowCellValue("TT_NganHang").ToString();
                txtNguoiThuHuong.Text = gridView2.GetFocusedRowCellValue("TT_NguoiNhan").ToString();
                lbNCC_SID.Text = gridView2.GetFocusedRowCellValue("NCC_SID").ToString();
            }
            catch (Exception )
            {
                this.ClearDetail();
            }
        }
    }
}