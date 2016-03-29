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

namespace VFC._NhanSu
{
    public partial class frmNS_NVBH_CheckInOut_InsertBoth : DevExpress.XtraEditors.XtraForm
    {
        string _ten, _storecode;
        int _nvsid, _storeno;

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
                    _rs += "Ngày không được trước ngày hôm nay." + Environment.NewLine;
                }
            }

            if ((DateTime)timeCheckOut.EditValue < (DateTime)timeCheckIn.EditValue)
            {
                _rs += "Giờ ra không được trước giờ vào." + Environment.NewLine;
            }

            return _rs;
        }
        #endregion

        public frmNS_NVBH_CheckInOut_InsertBoth(int nvsid
                                    , int storeno
                                    , string ten
                                    , string storeCode)
        {
            InitializeComponent();
            _nvsid = nvsid;
            _storeno = storeno;
            _ten = ten;
            _storecode = storeCode;
        }

        private void frmNS_NVBH_CheckInOut_InsertBoth_Load(object sender, EventArgs e)
        {
            timeCheckIn.Properties.Mask.MaskType = MaskType.DateTime;
            timeCheckIn.Properties.Mask.EditMask = "HH:mm";
            timeCheckIn.MaskBox.Mask.UseMaskAsDisplayFormat = true;

            timeCheckOut.Properties.Mask.MaskType = MaskType.DateTime;
            timeCheckOut.Properties.Mask.EditMask = "HH:mm";
            timeCheckOut.MaskBox.Mask.UseMaskAsDisplayFormat = true;

            lbNVSID.Text = _nvsid.ToString();
            lbTen.Text = _ten;
            lbCuaHang.Text = _storecode;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string ivalidate = this.iValidate();

            if (ivalidate.Equals(""))
            {

            }
            else
            {
                frmMessageBox.Show("Thông báo", ivalidate, "error");
            }
        }
    }
}