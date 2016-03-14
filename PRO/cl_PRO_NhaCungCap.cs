using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_NhaCungCap
    {
        int nCC_SID;

        public int NCC_SID
        {
            get { return nCC_SID; }
            set { nCC_SID = value; }
        }
        string tenNCC;

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        string tenCty;

        public string TenCty
        {
            get { return tenCty; }
            set { tenCty = value; }
        }
        string aDDR_SoNha;

        public string ADDR_SoNha
        {
            get { return aDDR_SoNha; }
            set { aDDR_SoNha = value; }
        }
        string aDDR_Duong;

        public string ADDR_Duong
        {
            get { return aDDR_Duong; }
            set { aDDR_Duong = value; }
        }
        string aDDR_Quan;

        public string ADDR_Quan
        {
            get { return aDDR_Quan; }
            set { aDDR_Quan = value; }
        }
        int aDDR_ThanhPho;

        public int ADDR_ThanhPho
        {
            get { return aDDR_ThanhPho; }
            set { aDDR_ThanhPho = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        string companyPhone;

        public string CompanyPhone
        {
            get { return companyPhone; }
            set { companyPhone = value; }
        }
        string mST;

        public string MST
        {
            get { return mST; }
            set { mST = value; }
        }
        string nguoiLienLac;

        public string NguoiLienLac
        {
            get { return nguoiLienLac; }
            set { nguoiLienLac = value; }
        }
        int gioiTinhNguoiLL;

        public int GioiTinhNguoiLL
        {
            get { return gioiTinhNguoiLL; }
            set { gioiTinhNguoiLL = value; }
        }
        string tT_SoTK;

        public string TT_SoTK
        {
            get { return tT_SoTK; }
            set { tT_SoTK = value; }
        }
        string tT_NganHang;

        public string TT_NganHang
        {
            get { return tT_NganHang; }
            set { tT_NganHang = value; }
        }
        string tT_NguoiThuHuong;

        public string TT_NguoiThuHuong
        {
            get { return tT_NguoiThuHuong; }
            set { tT_NguoiThuHuong = value; }
        }
        string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        int nganhNghe;

        public int NganhNghe
        {
            get { return nganhNghe; }
            set { nganhNghe = value; }
        }
        int active;

        public int Active
        {
            get { return active; }
            set { active = value; }
        }

        string createdBy;

        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }
    }
}
