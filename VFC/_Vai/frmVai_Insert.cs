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
using PRO;

namespace VFC._Vai
{
    public partial class frmVai_Insert : DevExpress.XtraEditors.XtraForm
    {
        DAL.Utilities.SQLCon _connSQL;
        DataTable _dt;

        public frmVai_Insert()
        {
            InitializeComponent();
        }

        #region Action
        private void FillSuppliers()
        {
            try
            {
                string query = "select NCC_SID, TenNCC, TenCty, NguoiLienLac from SUPPLIER.NhaCungCap where NganhNghe = (select [SID] from SUPPLIER.NganhNghe where TenNghanh = N'Vải')";

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
                    _dt.Columns.Add("ColorEN", typeof(string));
                    _dt.Columns.Add("ColorVN", typeof(string));
                    _dt.Rows.Add(colorEN, colorVN);
                }
                else
                {
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        if (_dt.Rows[i]["ColorEN"].Equals(colorEN) || _dt.Rows[i]["ColorVN"].Equals(colorVN))
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
               
        private void DeleteSelectedRows(DevExpress.XtraGrid.Views.Grid.GridView view) {
            //if(view == null || view.SelectedRowsCount == 0) return;

            //DataRow[] rows = new DataRow[view.SelectedRowsCount];

            //for(int i = 0; i < view.SelectedRowsCount; i++)
            //    rows[i] = view.GetDataRow(view.GetSelectedRows()[i]);
            //view.BeginSort();

            //try {
            //    foreach(DataRow row in rows)
            //        row.Delete();
            //}
            //finally {
            //    view.EndSort();
            //}
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
        #endregion

        private void frmVai_Insert_Load(object sender, EventArgs e)
        {
            this.FillSuppliers();
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

        private void btSave_Click(object sender, EventArgs e)
        {
            string iValidate = this.iValidate();

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
                    string rs = _dalVai.INSERT_TK_Vai(vai, (DataTable)gridControl1.DataSource);
                    if (rs.Equals("success"))
                    {
                        frmMessageBox.Show("Thông báo", "Tạo mới thành công.", "done");
                        this.Close();
                    }
                    else if (rs.Equals("fail"))
                    {
                        frmMessageBox.Show("Thông báo", "Tạo mới thất bại.", "error");
                    }
                    else
                    {
                        frmMessageBox.Show("Thông báo", "Trùng mã Vải. Vui lòng thử lại.", "error");
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

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.DeleteSelectedRows(this.gridView1);
                lbColorCount.Text = _dt.Rows.Count.ToString();
            }
        }
    }
}