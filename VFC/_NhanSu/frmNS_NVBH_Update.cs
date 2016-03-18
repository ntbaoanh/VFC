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

namespace VFC._NhanSu
{
    public partial class frmNS_NVBH_Update : DevExpress.XtraEditors.XtraForm
    {
        string _type;
        int _nvsid;

        public frmNS_NVBH_Update()
        {
            InitializeComponent();
            _type = "new";
        }

        #region Action
        private void LoadDSCuaHang(GridLookUpEdit _grid)
        {
            cl_DAL_Store store = new cl_DAL_Store();
            _grid.Properties.DataSource = store.returnSQL_AllStoreCode();
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
            catch (Exception )
            {
                years = 0;
            }

            return years;
        }

        private string iValidate(string _type)
        {
            string rs = "";

            if (_type.Equals("new"))
            {
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
                }
                else
                {
                    try
                    {
                        cl_DAL_NhanVienBanHang dalNvbh = new cl_DAL_NhanVienBanHang();
                        if (lbNVSID.Text.Equals(""))
                        {
                            if (dalNvbh.CHECK_NVBH_Exists_ByCMND(txtCMND.Text))
                            {
                                rs += "Thông tin nhân viên đã có. Vui lòng kiểm tra lại." + Environment.NewLine;
                            }
                        }
                        else
                        {
                            if (!lbNVSID.Text.Equals(""))
                            {
                                if (!dalNvbh.CHECK_NVBH_Exists_ByCMND_Update(txtCMND.Text.Trim(), int.Parse(lbNVSID.Text)))
                                {
                                    if (dalNvbh.CHECK_NVBH_Exists_ByCMND(txtCMND.Text))
                                    {
                                        rs += "Thông tin nhân viên đã có. Vui lòng kiểm tra lại." + Environment.NewLine;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception )
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

                if (txtInfo_NVID.Text.Trim().Equals(""))
                {
                    rs += "Vui lòng điền vào ID cho nhân viên." + Environment.NewLine;
                }
                else
                {
                    try
                    {
                        cl_DAL_NhanVienBanHang dalNvbh = new cl_DAL_NhanVienBanHang();
                        if (lbNVSID.Text.Equals(""))
                        {
                            if (dalNvbh.CHECK_NVBH_Exists_ByNVID(int.Parse(txtInfo_NVID.Text)))
                            {
                                rs += "ID đã tồn tại. Vui lòng kiểm tra lại." + Environment.NewLine;
                            }
                        }
                        else
                        {
                            if (!lbNVSID.Text.Equals(""))
                            {
                                if (!dalNvbh.CHECK_NVBH_Exists_ByNVID_Update(int.Parse(txtInfo_NVID.Text.Trim()), int.Parse(lbNVSID.Text)))
                                {
                                    if (dalNvbh.CHECK_NVBH_Exists_ByNVID(int.Parse(txtInfo_NVID.Text)))
                                    {
                                        rs += "ID đã tồn tại. Vui lòng kiểm tra lại." + Environment.NewLine;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception )
                    {
                        rs += "Lỗi không xác định.[Check Duplicate NVID]" + Environment.NewLine;
                    }
                }

                try
                {
                    int.Parse(txtInfo_LuongCanBan.Text.Trim());
                }
                catch (Exception )
                {
                    rs += "Lương căn bản phải là số tự nhiên.";
                }
            }
            else if (_type.Equals("luanchuyen"))
            {
                if (listStores.EditValue == null)
                {
                    rs += "Vui lòng chọn cửa hàng muốn chuyển" + Environment.NewLine;
                }
                else
                {
                    if (listStoresInfo.EditValue.Equals(listStores.EditValue))
                    {
                        rs += "Cửa hàng muốn chuyển giống cửa hàng hiện tai." + Environment.NewLine;
                    }
                }

                if (dateLC.EditValue == null)
                {
                    rs += "Vui lòng chọn ngày áp dụng." + Environment.NewLine;
                }
                else
                {
                    if (!DateTime.Now.ToString("yyyy-MM-dd").Equals(((DateTime)dateLC.EditValue).ToString("yyyy-MM-dd")))
                    {
                        if (DateTime.Now > (DateTime)dateLC.EditValue)
                        {
                            rs += "Ngày áp dụng không thể ở quá khứ." + Environment.NewLine;
                        }
                    }
                }

                if (txtLC_GhiChu.Text.Trim().Equals(""))
                {
                    rs += "Vui lòng điền vào ghi chú." + Environment.NewLine;
                }
            }

            return rs;
        }

        private void LoadNVInfo_Disable()
        {
            cl_DAL_NhanVienBanHang _dalNvbh = new cl_DAL_NhanVienBanHang();
            cl_PRO_NhanVienBanHang _proNvbh = new cl_PRO_NhanVienBanHang();

            try
            {                
                _proNvbh = _dalNvbh.GET_NVBH_BySID(_nvsid.ToString());

                listStoresInfo.EditValue = _proNvbh.StoreNo;
                listStoresInfo.Enabled = false;
                cbbChucVu.SelectedText = _proNvbh.ChucVu;
                cbbChucVu.Enabled = false;
                txtHo.Text = _proNvbh.Ho;
                txtHo.Enabled = false;
                txtTen.Text = _proNvbh.Ten;
                txtTen.Enabled = false;
                txtCMND.Text = _proNvbh.Cmnd;
                txtCMND.Enabled = false;
                txtPhone.Text = _proNvbh.Phone;
                txtPhone.Enabled = false;
                dateNgaySinh.EditValue = _proNvbh.NgaySinh.Substring(0, 10);
                dateNgaySinh.Enabled = false;
                if(_proNvbh.GioiTinh.Equals("true"))
                {
                    rdNam.Checked = true;                    
                }
                else
                {
                    rdNu.Checked = true;
                }
                rdNam.Enabled = false;
                rdNu.Enabled = false;
                txtDiaChi.Text = _proNvbh.DiaChi;
                txtDiaChi.Enabled = false;
                txtInfo_NVID.Text = _proNvbh.NvbhId;
                txtInfo_NVID.Enabled = false;
                txtInfo_LuongCanBan.Text = _proNvbh.LuongCanBan.ToString();
                txtInfo_LuongCanBan.Enabled = false;
                txtInfo_GhiChu.Text = _proNvbh.GhiChu;
                txtInfo_GhiChu.Enabled = false;
            }
            catch (Exception ex)
            {
                frmMessageBox.Show("Thông báo", "Có lỗi trong quá trình lấy dữ liệu." + Environment.NewLine + " Vui lòng liên hệ quản trị viên." + Environment.NewLine + Environment.NewLine + ex.ToString(), "error");
                this.Close();
            }
            
        }

        private void LoadNVInfo_Enable()
        {
            cl_DAL_NhanVienBanHang _dalNvbh = new cl_DAL_NhanVienBanHang();
            cl_PRO_NhanVienBanHang _proNvbh = new cl_PRO_NhanVienBanHang();

            try
            {
                _proNvbh = _dalNvbh.GET_NVBH_BySID(_nvsid.ToString());

                listStoresInfo.EditValue = _proNvbh.StoreNo;
                listStoresInfo.Enabled = false;
                cbbChucVu.SelectedText = _proNvbh.ChucVu;
                cbbChucVu.Enabled = false;
                txtHo.Text = _proNvbh.Ho;
                txtTen.Text = _proNvbh.Ten;
                txtCMND.Text = _proNvbh.Cmnd;
                txtPhone.Text = _proNvbh.Phone;
                dateNgaySinh.EditValue = _proNvbh.NgaySinh;
                if (_proNvbh.GioiTinh == 1)
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txtDiaChi.Text = _proNvbh.DiaChi;
                txtInfo_NVID.Text = _proNvbh.NvbhId;
                txtInfo_LuongCanBan.Text = _proNvbh.LuongCanBan.ToString();
                txtInfo_GhiChu.Text = _proNvbh.GhiChu;
            }
            catch (Exception ex)
            {
                frmMessageBox.Show("Thông báo", "Có lỗi trong quá trình lấy dữ liệu." + Environment.NewLine + " Vui lòng liên hệ quản trị viên." + Environment.NewLine + Environment.NewLine + ex.ToString(), "error");
                this.Close();
            }

        }
        #endregion

        public frmNS_NVBH_Update(string _type, int _nvsid)
        {
            InitializeComponent();
            this._type = _type;
            this._nvsid = _nvsid;
        }

        private void frmNS_NVBH_Update_Load(object sender, EventArgs e)
        {
            xtraTabPage_LuanChuyen.PageEnabled = false;
            xtraTabPage_NghiViec.PageEnabled = false;
            xtraTabPage_DeBat.PageEnabled = false;
            xtraTabPage_ThongTin.PageEnabled = false;

            this.LoadDSCuaHang(listStoresInfo);

            if (_type.Equals("luanchuyen"))
            {
                this.Text = "Luân chuyển nhân viên";
                xtraTabPage_LuanChuyen.PageEnabled = true;
                this.LoadDSCuaHang(listStores);
                this.LoadNVInfo_Disable();
                txtLC_GhiChu.Text = "Luân chuyển nhân viên";
                lbNVSID.Text = _nvsid.ToString();
            }
            else if (_type.Equals("edit"))
            {
                this.Text = "Cập nhật nhân viên";
                xtraTabPage_ThongTin.PageEnabled = true;
                lbNVSID.Text = _nvsid.ToString();
                this.LoadNVInfo_Enable();
                txtInfo_GhiChu.Text = "Cập nhật nhân viên";
            }
            else if (_type.Equals("new"))
            {
                this.Text = "Tạo mới Nhân viên bán hàng";
                xtraTabPage_ThongTin.PageEnabled = true;
                txtInfo_GhiChu.Text = "POS - Tạo mới nhân viên";
            }
            else if (_type.Equals("debat"))
            {
                this.Text = "Đề bạt Nhân viên bán hàng";
                xtraTabPage_ThongTin.PageEnabled = true;
                txtInfo_GhiChu.Text ="Đề bạt nhân viên";
            }
            else if (_type.Equals("active"))
            {
                this.Text = "Active - Deactive Nhân viên bán hàng";
                xtraTabPage_ThongTin.PageEnabled = true;
                txtInfo_GhiChu.Text = "Active nhân viên";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string iValidate = this.iValidate("new");

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
                    proNvbh.DiaChi = txtDiaChi.Text.Trim();
                    proNvbh.StoreNo = int.Parse(listStoresInfo.EditValue.ToString());
                    proNvbh.ChucVu = cbbChucVu.Text;
                    proNvbh.StoreCode = listStoresInfo.EditValue.ToString();
                    proNvbh.ModifiedBy = frmHO_Main._userLogin.UserName;
                    proNvbh.UrlImage = "";                    
                    proNvbh.LuongCanBan = int.Parse(txtInfo_LuongCanBan.Text.Trim());
                    proNvbh.GhiChu = txtInfo_GhiChu.Text.Trim();
                    proNvbh.NvbhId = txtInfo_NVID.Text;

                    if (!lbNVSID.Text.Equals(""))
                    { 
                        proNvbh.NvbhSid = int.Parse(lbNVSID.Text);
                    }

                    cl_DAL_NhanVienBanHang dalNvbh = new cl_DAL_NhanVienBanHang();
                    if (lbNVSID.Text.Equals(""))
                    {
                        if (dalNvbh.INSERT_NVBH(proNvbh))
                        {
                            frmNS_NVBH_QuanLy.updateGridFlag = true; 
                            frmMessageBox.Show("Thông báo", "Tạo mới nhân viên bán hàng thành công.", "done");
                            this.Close();
                        }
                        else
                        {
                            frmMessageBox.Show("Thông báo", "Tạo mới nhân viên bán hàng thất bại.", "error");
                        }
                    }
                    else
                    {
                        if (dalNvbh.UPDATE_NVBH(proNvbh))
                        {
                            frmNS_NVBH_QuanLy.updateGridFlag = true; 
                            frmMessageBox.Show("Thông báo", "Cập nhật nhân viên bán hàng thành công.", "done");
                            this.Close();
                        }
                        else
                        {
                            frmMessageBox.Show("Thông báo", "Cập nhật nhân viên bán hàng thất bại.", "error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (lbNVSID.Text.Equals(""))
                    {
                        frmMessageBox.Show("Thông báo", "Tạo mới nhân viên bán hàng thất bại. [" + ex.ToString() + "]", "error");
                    }
                    else if (lbNVSID.Text.Equals(""))
                    {
                        frmMessageBox.Show("Thông báo", "Cập nhật nhân viên bán hàng thất bại. [" + ex.ToString() + "]", "error");
                    }
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", iValidate, "error");
            }
        }

        private void btThuyeChuyen_Click(object sender, EventArgs e)
        {
            string rs = this.iValidate("luanchuyen");

            if (rs.Equals(""))
            {
                string _dateLC = "";

                if (!DateTime.Now.ToString("yyyy-MM-dd").Equals(((DateTime)dateLC.EditValue).ToString("yyyy-MM-dd")))
                { 
                    _dateLC = ((DateTime)dateLC.EditValue).ToString("MM/dd/yyyy");
                }

                cl_DAL_NhanVienBanHang _dalNvbh = new cl_DAL_NhanVienBanHang();
                if (_dalNvbh.UPDATE_LuanChuyen_NVBH(int.Parse(listStores.EditValue.ToString()), txtLC_GhiChu.Text.Trim(), frmHO_Main._userLogin.UserName, _nvsid, _dateLC, int.Parse(listStoresInfo.EditValue.ToString())))
                {
                    frmMessageBox.Show("Thông báo.", "Luân chuyển nhân viên thành công.", "done");
                    frmNS_NVBH_QuanLy.updateGridFlag = true;
                    this.Close();
                }
                else
                {
                    frmMessageBox.Show("Thông báo.", "Luân chuyển nhân viên không thành công." + Environment.NewLine + "Liên hệ quản trị viên. [Lỗi không xác định]", "error");
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", rs.ToString(), "error");
            }
        }
    }
}