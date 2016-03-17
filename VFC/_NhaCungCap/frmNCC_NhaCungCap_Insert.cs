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

namespace VFC._NhaCungCap
{
    public partial class frmNCC_NhaCungCap_Insert : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_ADMIN admin;

        public frmNCC_NhaCungCap_Insert()
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
        #endregion

        private void frmNCC_NhaCungCap_Insert_Load(object sender, EventArgs e)
        {
            this.LOAD_DSTinhThanh();
            this.LOAD_DSNganhNghe();
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
                ncc.ADDR_Duong= txtDuong.Text.Trim();
                ncc.ADDR_Quan = txtPhuongQuan.Text.Trim();
                ncc.ADDR_ThanhPho = int.Parse(listThanhPho.EditValue.ToString());
                ncc.CompanyPhone = txtCompanyPhone.Text.Trim();
                ncc.MST = txtMST.Text.Trim();
                ncc.NganhNghe = int.Parse(listNganhNghe.EditValue.ToString());
                ncc.TT_SoTK = txtSoTK.Text.Trim();
                ncc.TT_NganHang = txtNganHang.Text.Trim();
                ncc.TT_NguoiThuHuong = txtNguoiThuHuong.Text.Trim();
                //ncc.CreatedBy = frmHO_Main._userLogin.UserName;
                ncc.CreatedBy = "NHANNT";
                cl_DAL_NhaCungCap _dalNhaCungCap = new cl_DAL_NhaCungCap();

                if (_dalNhaCungCap.INSERT_NhaCungCap(ncc).Equals("success"))
                {
                    frmMessageBox.Show("Thông báo", "Tạo mới nhà cung cấp thành công.", "done");
                    this.Close();
                }
                else if (_dalNhaCungCap.INSERT_NhaCungCap(ncc).Equals("fail"))
                {
                    frmMessageBox.Show("Thông báo", "Tạo mới nhà cung cấp thất bại.", "done");
                }
                else
                {
                    frmMessageBox.Show("Thông báo", "Tên nhà cung cấp bị trùng. Vui lòng thử tên khác.", "done");
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", ivalidate, "error");
            }
        }
    }
}