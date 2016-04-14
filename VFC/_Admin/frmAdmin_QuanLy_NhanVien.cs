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
using PRO;

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
            chkRegion.Items.Clear();

            CheckedListBoxItem itemHCM = new CheckedListBoxItem("HO CHI MINH", "Hồ Chí Minh");
            CheckedListBoxItem itemMDONG = new CheckedListBoxItem("MIEN DONG", "Miền Đông");
            CheckedListBoxItem itemMTAY = new CheckedListBoxItem("MIEN TAY", "Miền Tây");
            CheckedListBoxItem itemMTRUNG = new CheckedListBoxItem("MIEN TRUNG", "Miền Trung");
            CheckedListBoxItem itemMBAC = new CheckedListBoxItem("MIEN BAC", "Miền Bắc");

            chkRegion.Items.Add(itemHCM);
            chkRegion.Items.Add(itemMDONG);
            chkRegion.Items.Add(itemMTAY);
            chkRegion.Items.Add(itemMTRUNG);
            chkRegion.Items.Add(itemMBAC);

            for (int i = 0; i < chkRegion.Items.Count; i++)
            {
                if (_dalUser.checkUserRegion(_user, chkRegion.Items[i].Value.ToString()))
                {
                    chkRegion.Items[i].CheckState = CheckState.Checked;
                }
                else
                {
                    chkRegion.Items[i].CheckState = CheckState.Unchecked;
                }
            }

            lbFirst.Text = "2";
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
            try
            {
                _dalUser = new cl_DAL_User();
                cl_PRO_User _proUser = new cl_PRO_User();

                _proUser.UserName = lbUserName.Text;
                _proUser.Phone = txtPhone.Text.Trim();
                _proUser.FullName = txtFName.Text.Trim();
                _proUser.DepartmentID = listBoPhan.EditValue.ToString();
                if(rdActive.Checked == true)
                {
                    _proUser.Active = "1";
                }
                else
                {
                    _proUser.Active = "0";
                }


                if (_dalUser.UPDATE_User(_proUser))
                {
                    frmMessageBox.Show("Thông báo", "Cập nhật thông tin nhân viên thành công", "done");
                }
                else
                {
                    frmMessageBox.Show("Thông báo", "Cập nhật thông tin nhân viên thất bại", "error");
                }

            }
            catch (Exception)
            { 
            
            }
        }

        //private void btResetPass_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (lbUserName.Text.Equals(""))
        //        {
        //            frmMessageBox.Show("Thông báo", "Vui lòng chọn nhân viên", "error");
        //        }
        //        else
        //        {
        //            Random rd = new Random();
        //            string _newPass = rd.Next(1000000, 9999999).ToString();

        //            cl_DAL_User _user = new cl_DAL_User();
        //            if (_user.updatePassword(_newPass, lbUserName.Text))
        //            {
        //                DAL.Utilities.SendEmail _myMail = new DAL.Utilities.SendEmail();
        //                string _to = "nhannt@ninomaxx.com.vn";
        //                string _subject = "[No-Reply] Reset mật khẩu";
        //                string _body = "<h3><font face=\"Times New Roman\">Xin chào "+ txtFName.Text.Trim() +"</font></h3>";
        //                _body += "<p><font face=\"Times New Roman\">&emsp;&emsp;&emsp;Mật khẩu của bạn đã được đổi thành </font><b><font  size=\"6\" color=\"red\">"+ _newPass +"</font><b></p>";
        //                _body += "<p><font face=\"Times New Roman\">Regards,</font></p>";
        //                _body += "<p><font face=\"Times New Roman\" size=\"2\"><i>Đây là mail hệ thống. Vui lòng không trả lời lại email này.</i></font></p>";

        //                if (_myMail.NNSendMail(_to, _subject, _body, null))
        //                {
        //                    frmMessageBox.Show("Thông báo", "Đã gửi mail mật khẩu mới thành công", "done");
        //                }
        //                else
        //                {
        //                    frmMessageBox.Show("Thông báo", "Thật là vi diệu", "error");
        //                }
        //            }
        //            else
        //            {
        //                frmMessageBox.Show("Thông báo", "Cập nhật không thành công", "error");
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }            
        //}

        private void btResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbUserName.Text.Equals(""))
                {
                    frmMessageBox.Show("Thông báo", "Vui lòng chọn nhân viên", "error");
                }
                else
                {
                    Random rd = new Random();
                    string _newPass = rd.Next(1000000, 9999999).ToString();

                    cl_DAL_User _user = new cl_DAL_User();
                    if (_user.updatePassword(_newPass, lbUserName.Text))
                    {
                        DAL.Utilities.SendEmail _myMail = new DAL.Utilities.SendEmail();
                        if (_myMail.SQLSendMail_ResetPassword(lbUserName.Text, _newPass))
                        {
                            frmMessageBox.Show("Thông báo", "Gửi mail Reset mật khẩu ["+lbUserName.Text+"] thành công", "done");
                        }
                    }
                    else
                    {
                        frmMessageBox.Show("Thông báo", "Cập nhật không thành công", "error");
                    }
                }
            }
            catch (Exception)
            {

            }
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

        private void chkRegion_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (!lbFirst.Text.Equals("1"))
            {
                _dalUser = new cl_DAL_User();
                string _user = lbUserName.Text;
                string _region = chkRegion.Items[e.Index].Value.ToString();

                if (e.State == CheckState.Checked)
                {
                    if (!_dalUser.UPDATE_UserRegion(_user, _region, "1"))
                    {
                        //frmMessageBox.Show("thông báo", "cập nhật thất bại", "error");
                    }
                }
                else
                {
                    if (!_dalUser.UPDATE_UserRegion(_user, _region, "0"))
                    {
                        frmMessageBox.Show("thông báo", "cập nhật thất bại", "error");
                    }
                }
            }
        }
    }
}