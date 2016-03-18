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

namespace VFC._Vai
{
    public partial class frmVai_Manage : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_TK_Vai _dalVai;
        DataTable _dt;
        DAL.Utilities.SQLCon _connSQL;
        DataTable _tempdt;

        public frmVai_Manage()
        {
            InitializeComponent();
        }

        #region Action
        private void LoadDSVai()
        {
            _dalVai = new cl_DAL_TK_Vai();
            gridControl_Vai.DataSource = _dalVai.GET_DSVai();
        }

        private void LoadVaiColorByVaiID(int vaiID)
        {
            _dalVai = new cl_DAL_TK_Vai();
            _dt = _dalVai.GET_DSVaiColor(vaiID);

            _tempdt = new DataTable();
            _tempdt.Columns.Add("Color_EN", typeof(string));
            _tempdt.Columns.Add("Color_VN", typeof(string));

            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                _tempdt.Rows.Add(_dt.Rows[i]["Color_EN"], _dt.Rows[i]["Color_VN"]);
            }

            gridControl1.DataSource = _tempdt;

            lbColorCount.Text = _dt.Rows.Count.ToString();
        }

        private void LoadDSSuppliers()
        {
            try
            {
                string query = "select NCC_SID, TenNCC, TenCty, NguoiLienLac from SUPPLIER.NhaCungCap where NganhNghe = (select [SID] from SUPPLIER.NganhNghe where TenNganh = N'Vải')";

                _connSQL = new DAL.Utilities.SQLCon();

                listSuppliers.Properties.DataSource = _connSQL.returnDataTable(query);
            }
            catch (Exception ex)
            {
                frmMessageBox.Show("Thông báo", ex.ToString(), "error");
            }
        }

        private void AddColorToGrid(string colorEN, string colorVN)
        {
            colorEN = colorEN.ToUpper();
            colorVN = colorVN.ToUpper();

            try
            {
                _dt = (DataTable)gridControl1.DataSource;

                if (gridControl1.DataSource == null || _dt.Rows.Count == 0)
                {
                    _dt = new DataTable();
                    _dt.Columns.Add("Color_EN", typeof(string));
                    _dt.Columns.Add("Color_VN", typeof(string));
                    _dt.Rows.Add(colorEN, colorVN);
                }
                else
                {
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        if (_dt.Rows[i]["Color_EN"].Equals(colorEN) || _dt.Rows[i]["Color_VN"].Equals(colorVN))
                        {
                            frmMessageBox.Show("Thông báo", "Mã màu đã bị trùng. Vui lòng chọn mã khác", "error");
                            goto Finish;
                        }
                        else
                        {
                            _dt.Rows.Add(colorEN, colorVN);
                            goto Finish;
                        }
                    }
                }
            }
            catch (Exception )
            {

            }

        Finish:
            gridControl1.DataSource = _dt;
            lbColorCount.Text = _dt.Rows.Count.ToString();
            txtColorEN.Text = null;
            txtColorVN.Text = null;
        }

        private void DeleteSelectedRows(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            view.DeleteSelectedRows();
        }

        private string iValidate()
        {
            string rs = "";

            if (txtMaVai.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền Mã vải." + Environment.NewLine;
            }

            if (txtChatLieu.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền Chất liệu." + Environment.NewLine;
            }

            if (txtGiaNhapKho.Text.Trim().Equals(""))
            {
                rs += "Vui lòng điền Giá nhập kho." + Environment.NewLine;
            }

            if (listSuppliers.EditValue == null)
            {
                rs += "Vui lòng chọn Nhà cung cấp." + Environment.NewLine;
            }

            try
            {
                DataTable dt = (DataTable)gridControl1.DataSource;

                if (dt.Rows.Count == 0)
                {
                    rs += "Vui lòng nhập vào màu." + Environment.NewLine;
                }
            }
            catch (Exception )
            {
                rs += "Vui lòng nhập vào màu." + Environment.NewLine;
            }

            return rs;
        }

        private void ClearDetail()
        {
            txtChatLieu.Text = "";
            txtColorEN.Text = "";
            txtColorVN.Text = "";
            txtGiaNhapKho.Text = "";
            txtMaVai.Text = "";
            txtNotes.Text = "";
            gridControl1.DataSource = null;
            listSuppliers.EditValue = null;
            gridControl1.DataSource = null;
            lbColorCount.Text = "";
        }        
        #endregion

        private void frmVai_Update_Load(object sender, EventArgs e)
        {
            this.LoadDSVai();
            this.LoadDSSuppliers();
        }

        private void gridView_Vai_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lbFlagNew.Text = "edit";
            txtMaVai.Enabled = false;

            try
            {
                txtChatLieu.Text = gridView_Vai.GetFocusedRowCellValue("ChatLieu").ToString();
                txtGiaNhapKho.Text = gridView_Vai.GetFocusedRowCellValue("GiaNhapKho").ToString();
                txtMaVai.Text = gridView_Vai.GetFocusedRowCellValue("MaVai").ToString();
                txtNotes.Text = gridView_Vai.GetFocusedRowCellValue("GhiChu").ToString();
                this.LoadVaiColorByVaiID(int.Parse(gridView_Vai.GetFocusedRowCellValue("VaiID").ToString()));
                listSuppliers.EditValue = gridView_Vai.GetFocusedRowCellValue("DonViCungCapID").ToString();
                lbVaiID.Text = gridView_Vai.GetFocusedRowCellValue("VaiID").ToString();
            }
            catch (Exception )
            {
                this.ClearDetail();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.ClearDetail();
            lbFlagNew.Text = "new";
            txtMaVai.Enabled = true;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.LoadDSVai();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string iValidate = this.iValidate();
            string rs = "";

            if (iValidate.Equals(""))
            {
                cl_PRO_TK_Vai vai = new cl_PRO_TK_Vai();
                
                try
                {
                    vai.MaVai = txtMaVai.Text.Trim().ToUpper();
                    vai.SupplierID = Int16.Parse(listSuppliers.EditValue.ToString());
                    vai.ChatLieu = txtChatLieu.Text.Trim().ToUpper();
                    vai.GhiChu = txtNotes.Text.Trim().ToUpper();
                    vai.GiaNhapKho = int.Parse(txtGiaNhapKho.Text.Trim());
                    vai.NVTK = frmHO_Main._userLogin.UserName;
                    //vai.NVTK = "NHANNT";
                    cl_DAL_TK_Vai _dalVai = new cl_DAL_TK_Vai();
                    
                    if (lbFlagNew.Text.Equals("new"))
                    {
                        rs = _dalVai.INSERT_TK_Vai(vai, (DataTable)gridControl1.DataSource);
                    }
                    else if (lbFlagNew.Text.Equals("edit"))
                    {
                        vai.VaiID = int.Parse(lbVaiID.Text);
                        rs = _dalVai.UPDATE_TK_Vai(vai, (DataTable)gridControl1.DataSource);
                    }

                    if (rs.Equals("success"))
                    {
                        if (lbFlagNew.Text.Equals("new"))
                        {
                            frmMessageBox.Show("Thông báo", "Tạo mới thành công.", "done");
                        }
                        else if (lbFlagNew.Text.Equals("edit"))
                        {
                            frmMessageBox.Show("Thông báo", "Cập nhật thành công.", "done");
                        }
                        this.ClearDetail();
                        this.LoadDSVai();
                    }
                    else if (rs.Equals("fail"))
                    {

                        if(lbFlagNew.Text.Equals("new"))
                        { 
                            frmMessageBox.Show("Thông báo", "Tạo mới thất bại.", "error"); 
                        }
                        else if (lbFlagNew.Text.Equals("edit"))
                        {
                            frmMessageBox.Show("Thông báo", "Cập nhật thất bại.", "done");
                        }
                    }
                    else if (rs.Equals("duplicate"))
                    {
                        frmMessageBox.Show("Thông báo", "Trùng mã Vải. Vui lòng thử lại.", "error");
                    }
                    else
                    {
                        frmMessageBox.Show("Thông báo", "Lỗi không xác định. Vui lòng liên hệ quản trị viên." , "error");
                    }
                }
                catch (Exception ex)
                {
                    frmMessageBox.Show("Thông báo", ex.ToString(), "error");
                }
            }
            else
            {
                frmMessageBox.Show("Thông báo", iValidate, "error");
            }
        }

        private void btAddColor_Click(object sender, EventArgs e)
        {
            if (txtColorEN.Text.Trim().Equals("") || txtColorVN.Text.Trim().Equals(""))
            {
                frmMessageBox.Show("Thông báo", "Vui lòng điền vào màu Tiếng việt và Tiếng Anh", "error");
            }
            else
            {
                this.AddColorToGrid(txtColorEN.Text.Trim(), txtColorVN.Text.Trim());
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    this.DeleteSelectedRows(this.gridView1);
                    _dt = (DataTable)gridControl1.DataSource;
                    lbColorCount.Text = _dt.Rows.Count.ToString();
                }
                catch (Exception )
                { 
                    
                }
            }
        }
    }
}