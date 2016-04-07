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
using DevExpress.XtraEditors.Controls;

namespace VFC._Admin
{
    public partial class frmAdmin_QuanLy_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        cl_DAL_User _dalUser;

        public frmAdmin_QuanLy_NhanVien()
        {
            InitializeComponent();
        }

        #region Action
        private void Load_DS_NhanVien()
        {
            _dalUser = new cl_DAL_User();
            gridControl1.DataSource = _dalUser.GET_DS_User("1");
        }

        private void Load_DS_BP()
        {
            DataTable _dt = new DataTable();
            DAL.Utilities.SQLCon _conn = new DAL.Utilities.SQLCon();

            string _query = "select t.TaskID, d.DepartmentID, d.Description " +
                            "from tb_User_Tasks t join tb_Departments d on t.DepartmentID = d.DepartmentID";
            _dt = _conn.returnDataTable(_query);

            listBoPhan.Properties.DataSource = _dt;
            listBoPhan_Right.Properties.DataSource = _dt;
        }

        private void Load_DS_UserRight(string _departmentID, string _user)
        {
            try
            {
                chkListRights.Items.Clear();
                _dalUser = new cl_DAL_User();

                DataTable _dt = new DataTable();
                _dt = _dalUser.GET_DS_UserRight(listBoPhan_Right.EditValue.ToString());

                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    string _roleID = _dt.Rows[i]["RoleID"].ToString();
                    string _roleDescription = _dt.Rows[i]["Description"].ToString();

                    CheckedListBoxItem item = new CheckedListBoxItem(_roleID, _roleDescription);

                    if (_dalUser.checkUserRole(_user, _roleID))
                    {
                        item.CheckState = CheckState.Checked;
                    }

                    chkListRights.Items.Add(item);
                }
            }
            catch (Exception)
            {
                chkListRights.Items.Clear();
            }
        }

        private void Load_DS_Region(string _user)
        {
            _dalUser = new cl_DAL_User();

            for (int i = 0; i < chkRegion.Items.Count; i++)
            { 
                if(_dalUser.checkUserRegion(_user, chkRegion.Items[i].Value.ToString()))
                {
                    chkRegion.Items[i].CheckState = CheckState.Checked;
                }
                else
                {
                    chkRegion.Items[i].CheckState = CheckState.Unchecked;
                }
            }
        }
        #endregion

        private void frmAdmin_QuanLy_NhanVien_Load(object sender, EventArgs e)
        {
            this.Load_DS_NhanVien();
            this.Load_DS_BP();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                lbUserName.Text = gridView1.GetFocusedRowCellValue("UserID").ToString();
                this.Load_DS_Region(lbUserName.Text);
                txtFName.Text = gridView1.GetFocusedRowCellValue("FullName").ToString();
                txtPhone.Text = "0" + gridView1.GetFocusedRowCellValue("PhoneNumber").ToString();
                string _active = gridView1.GetFocusedRowCellValue("Active").ToString();
                if (_active.Equals("1"))
                {
                    rdActive.Checked = true;
                }
                else
                {
                    rdDeActive.Checked = true;
                }

                string _departmentId = gridView1.GetFocusedRowCellValue("DepartmentID").ToString();
                listBoPhan.EditValue = _departmentId;
                //chkListRights.Items.Clear();
                listBoPhan_Right.EditValue = null;
            }
            catch (Exception)
            {
                lbUserName.Text = "";
                txtFName.Text = "";
                txtPhone.Text = "";
                rdActive.Checked = false;
                rdDeActive.Checked = false;
                listBoPhan.EditValue = null;
                for (int i = 0; i < chkRegion.Items.Count; i++)
                {
                    chkRegion.Items[i].CheckState = CheckState.Unchecked;
                }
                listBoPhan_Right.EditValue = null;
            }
        }

        private void listBoPhan_Right_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Load_DS_UserRight(listBoPhan.EditValue.ToString(), lbUserName.Text);
            }
            catch (Exception)
            {
                chkListRights.Items.Clear();
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkAll.CheckState == CheckState.Checked)
                {
                    for (int i = 0; i < chkListRights.ItemCount; i++)
                    {
                        chkListRights.Items[i].CheckState = CheckState.Checked;
                    }
                }
                else
                {
                    for (int i = 0; i < chkListRights.ItemCount; i++)
                    {
                        chkListRights.Items[i].CheckState = CheckState.Unchecked;
                    }
                }
            }
            catch (Exception)
            {
                chkListRights.Items.Clear();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void btResetPass_Click(object sender, EventArgs e)
        {

        }

        private void chkListRights_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            _dalUser = new cl_DAL_User();
            string _user = lbUserName.Text;
            string _roleid = chkListRights.Items[e.Index].Value.ToString();

            if (e.State == CheckState.Checked)
            {
                if (!_dalUser.UPDATE_UserRight(_user, _roleid, "1"))
                {
                    frmMessageBox.Show("Thông báo", "Cập nhật thất bại", "error");
                }
            }
            else
            {
                if (!_dalUser.UPDATE_UserRight(_user, _roleid, "0"))
                {
                    frmMessageBox.Show("Thông báo", "Cập nhật thất bại", "error");
                }
            }
        }
    }
}