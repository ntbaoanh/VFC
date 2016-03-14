using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_Sales_NVBH
    {
        string nvbhId;
        string ten;
        int storeNo;
        string cmnd;
        string diaChi;
        string phone;
        string gioiTinh;
        int active;
        string ngaySinh;
        string ngayBatDau;
        string modifiedDate;
        string modifiedBy;
        string ho;
        string storeCode;
        int doanhSoNgay;
        int doanhSoThang;
        int doanhSoNam;

        public int DoanhSoNam
        {
            get { return doanhSoNam; }
            set { doanhSoNam = value; }
        }

        public int DoanhSoThang
        {
            get { return doanhSoThang; }
            set { doanhSoThang = value; }
        }

        public int DoanhSoNgay
        {
            get { return doanhSoNgay; }
            set { doanhSoNgay = value; }
        }

        public string StoreCode
        {
            get { return storeCode; }
            set { storeCode = value; }
        }
        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }

        public string NgayBatDau
        {
            get { return ngayBatDau; }
            set { ngayBatDau = value; }
        }

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public int Active
        {
            get { return active; }
            set { active = value; }
        }

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

        public string ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public int StoreNo
        {
            get { return storeNo; }
            set { storeNo = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string NvbhId
        {
            get { return nvbhId; }
            set { nvbhId = value; }
        }
    }
}
