using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace VFC._Report
{
    public partial class rp_SoLieu_XuLyCLKK : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_SoLieu_XuLyCLKK()
        {
            InitializeComponent();
        }

        public void addSource(DataSet ds, string _date, string _doiChieuNo)
        {
            DataTable _dt = ds.Tables[0];

            lbStore.Text = _dt.Rows[0]["STORE"].ToString();
            lbNgayThangNam.Text = _date;
            lbNgayThangNam2.Text = _date;
            lbNgayThangNam3.Text = _date;
            lbCuaHangTruong.Text = _dt.Rows[0]["CUAHANGTRUONG"].ToString();
            lbCuaHangTruong1.Text = _dt.Rows[0]["CUAHANGTRUONG"].ToString();
            lbDaiDienSoLieu.Text = _dt.Rows[0]["DAIDIENSOLIEU"].ToString();
            lbDaiDienSoLieu1.Text = _dt.Rows[0]["DAIDIENSOLIEU"].ToString();
            lbTuNgay.Text = _dt.Rows[0]["TUNGAY"].ToString();
            lbDenNgay.Text = _dt.Rows[0]["DENNGAY"].ToString();
            lbDauKy.Text = _dt.Rows[0]["DAUKY"].ToString();
            lbTongNhap.Text = _dt.Rows[0]["NHAP"].ToString();
            lbTongXuat.Text = _dt.Rows[0]["XUAT"].ToString();
            lbTongBan.Text = _dt.Rows[0]["BAN"].ToString();
            lbSlgKK.Text = _dt.Rows[0]["KIEMKE"].ToString();
            lbSlgCLKK.Text = _dt.Rows[0]["SLGCLKK"].ToString();
            lbGiaTriCLKK.Text = _dt.Rows[0]["GIATRICLKK"].ToString();
            lbGiaTriDenBu.Text = _dt.Rows[0]["GIATRIDENBU"].ToString();
            lbGiaTriThuong.Text = _dt.Rows[0]["GIATRITHUONG"].ToString();
            lbTongDoanhThu.Text = _dt.Rows[0]["TONGDOANHTHU"].ToString();
            lbThatThoat.Text = _dt.Rows[0]["GIATRITHATTHOAT"].ToString();
            lbCLKKNO.Text = _dt.Rows[0]["SOCLKK"].ToString();
            lbDoiChieuNo.Text = "(Lần thứ " + _doiChieuNo + ")";
            lbSlgCuoiKy.Text = _dt.Rows[0]["CUOIKY"].ToString();            
        }
    }
}
