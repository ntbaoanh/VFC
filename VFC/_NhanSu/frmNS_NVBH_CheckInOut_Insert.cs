using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DAL;

namespace VFC._NhanSu
{
    public partial class frmNS_NVBH_CheckInOut_Insert : DevExpress.XtraEditors.XtraForm
    {
        string _type, _ten, _storecode;
        int _nvsid ,_storeno;

        #region Action
        private string iValidate()
        {
            string _rs = "";

            if (dateCheckInOut.EditValue == null)
            {
                _rs += "Vui lòng chọn ngày";
            }
            else
            {
                if ((DateTime)(dateCheckInOut.EditValue) > DateTime.Now)
                {
                    _rs += "Ngày không được trước ngày hôm nay.";
                }
            }

            return _rs;
        }
        #endregion

        public frmNS_NVBH_CheckInOut_Insert(string type
                                    , int nvsid
                                    , int storeno
                                    , string ten
                                    , string storeCode)
        {
            InitializeComponent();
            _type = type;
            _nvsid = nvsid;
            _storeno = storeno;
            _ten = ten;
            _storecode = storeCode;

            if (_type.Equals("I"))
            {
                this.Text = "Thêm giờ vào của Nhân viên";
            }
            else
            {
                this.Text = "Thêm giờ ra của Nhân viên";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //frmMessageBox.Show("", ((DateTime)timeEdit1.EditValue).ToString("HH:mm:ss"), "error");
            string _validate = iValidate();
            if (_validate.Equals(""))
            {
                cl_DAL_NhanVienBanHang _dalNVBH = new cl_DAL_NhanVienBanHang();
                string _rs = _dalNVBH.INSERT_CheckInOut(_nvsid, _storeno, ((DateTime)(dateCheckInOut.EditValue)).ToString("MM/dd/yyyy") + " " + ((DateTime)timeCheckInOut.EditValue).ToString("HH:mm:ss"), _type, frmHO_Main._userLogin.UserName);

                /*
	                output value
	                currentIn = Trạng thái đang check In không thể check In lần nữa
	                currentOut = Trạng thái đã check Out. Không thể check out nữa
	                noIn = Chưa check in vào nên không thể check out
	                success = Insert thành công
	                fail = Insert thất bại
	                checkinsoon = Check in trước 8am
                    insertDouble = Không thể insert Vào hoặc Ra đơn lẻ.
                */

                switch (_rs)
                {
                    case "currentIn":
                        frmMessageBox.Show("Thông báo", "Đang check In. Không thể check in thêm nữa", "error");
                        this.Close();
                        break;
                    case "currentOut":
                        frmMessageBox.Show("Thông báo", "Đang check Out. Không thể check out thêm nữa", "error");
                        this.Close();
                        break;
                    case "noIn":
                        frmMessageBox.Show("Thông báo", "Chưa check In. Không thể check out.", "error");
                        this.Close();
                        break;
                    case "checkinsoon":
                        frmMessageBox.Show("Thông báo", "Check In trước 8am. Không thể check in", "error");
                        break;
                    case "fail":
                        frmMessageBox.Show("Thông báo", "Thêm mới thất bại. Vui lòng liên hệ quả trị viên.", "error");
                        this.Close();
                        break;
                    case "success":
                        frmMessageBox.Show("Thông báo", "Thêm mới thành công", "done");
                        this.Close();
                        break;
                    case "insertDouble":
                        frmMessageBox.Show("Thông báo", "Không thể thêm đơn lẻ Vào hoặc Ra giữa ca làm việc khác.", "error");
                        this.Close();
                        break;
                    default:
                        frmMessageBox.Show("Thông báo", "Lỗi không xác định", "error");
                        this.Close();
                        break;
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", _validate, "error");
            }
        }

        private void frmNS_NVBH_CheckInOut_Insert_Load(object sender, EventArgs e)
        {
            timeCheckInOut.Properties.Mask.MaskType = MaskType.DateTime;
            timeCheckInOut.Properties.Mask.EditMask = "HH:mm";
            timeCheckInOut.MaskBox.Mask.UseMaskAsDisplayFormat = true;

            lbNVSID.Text = _nvsid.ToString();
            lbTen.Text = _ten;
            lbCuaHang.Text = _storecode;
        }
    }
}