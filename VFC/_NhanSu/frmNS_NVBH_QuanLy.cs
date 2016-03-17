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
using System.Data.SqlClient;

namespace VFC._NhanSu
{
    public partial class frmNS_NVBH_QuanLy : DevExpress.XtraEditors.XtraForm
    {
        DAL.Utilities.SQLCon _conn;

        public frmNS_NVBH_QuanLy()
        {
            InitializeComponent();
        }

        #region Action
        private void LoadDSNhanVien(string _type)
        {
            string _query = "select NVSID, Active, GioiTinh, Store_Code, Ho, Ten, ChucVu from NHANSU.v_NhanVienBanHang ";

            if (_type.Equals("new"))
            {
                _query += " where approve = 0";
            }
            else if (_type.Equals("active"))
            {
                _query += " where active = 1";
            }
            else if (_type.Equals("deactive"))
            {
                _query += " where active = 0";
            }

            _query += " order by NVSID desc";

            _conn = new DAL.Utilities.SQLCon();

            gridControl1.DataSource = _conn.returnDataTable(_query);
        }
        #endregion

        private void frmNS_NVBH_QuanLy_Load(object sender, EventArgs e)
        {
            this.LoadDSNhanVien("new");
        }

        private void btDSNV_Moi_Click(object sender, EventArgs e)
        {
            this.LoadDSNhanVien("new");
        }

        private void btDSNV_DeActive_Click(object sender, EventArgs e)
        {
            this.LoadDSNhanVien("deactive");
        }

        private void btDSNV_Active_Click(object sender, EventArgs e)
        {
            this.LoadDSNhanVien("active");
        }

        private void btDSNV_All_Click(object sender, EventArgs e)
        {
            this.LoadDSNhanVien("all");
        }

        private void btDeActive_Click(object sender, EventArgs e)
        {

        }

        private void btChinhSua_Click(object sender, EventArgs e)
        {
            _NhanSu.frmNS_NVBH_Update myFrm = new frmNS_NVBH_Update("edit", int.Parse(gridView1.GetFocusedRowCellValue("NVSID").ToString()));
            myFrm.ShowDialog();
        }

        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            _NhanSu.frmNS_NVBH_Update myFrm = new frmNS_NVBH_Update();
            myFrm.ShowDialog();
        }

        private void btDeBat_Click(object sender, EventArgs e)
        {

        }

        private void btThuyenChuyen_Click(object sender, EventArgs e)
        {

        }
    }
}