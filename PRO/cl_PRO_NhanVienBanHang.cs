using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_NhanVienBanHang
    {
        string nvbhId;
        string ho;
        string ten;
        string ngaySinh;
        int storeNo;
        string cmnd;
        string phone;
        string diaChi;
        int gioiTinh;
        string ngayBatDau;
        string ngayNghiViec;
        int active;
        string modifiedDate;
        string modifiedBy;
        string chucVu;
        int nvbhSid;

        public int NvbhSid
        {
            get { return nvbhSid; }
            set { nvbhSid = value; }
        }

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
        string urlImage;

        public string UrlImage
        {
            get { return urlImage; }
            set { urlImage = value; }
        }
        int luongCanBan;

        public int LuongCanBan
        {
            get { return luongCanBan; }
            set { luongCanBan = value; }
        }
        int approve;

        public int Approve
        {
            get { return approve; }
            set { approve = value; }
        }
        string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        string storeCode;

        public string NgayNghiViec
        {
            get { return ngayNghiViec; }
            set { ngayNghiViec = value; }
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

        public int GioiTinh
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
