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

namespace VFC._CTKM
{
    public partial class frm_CTKM_Generate_XXX : DevExpress.XtraEditors.XtraForm
    {
        public frm_CTKM_Generate_XXX()
        {
            InitializeComponent();
        }
        #region Action

        private void LoadDataToControl()
        {
            cl_DAL_Store _dalStore = new cl_DAL_Store();
            listStore.Properties.DataSource = _dalStore.returnORA_AllStoreCode();
        }

        private void LoadDataToLabel()
        {
            txtLoaiQT1.Text = "1";
            txtLoaiQT2.Text = "1";
            txtLoaiQT3.Text = "1";
            txtLoaiQT4.Text = "1";
            txtLoaiQT5.Text = "2";
            txtLoaiQT6.Text = "2";
            txtLoaiQT7.Text = "3";
            txtLoaiQT8.Text = "3";
            txtLoaiQT9.Text = "3";
            txtLoaiQT10.Text = "3";

            txtGiaTriQT1.Text = "1";
            txtGiaTriQT2.Text = "1";
            txtGiaTriQT3.Text = "2";
            txtGiaTriQT4.Text = "2";
            txtGiaTriQT5.Text = "1";
            txtGiaTriQT6.Text = "1";
            txtGiaTriQT7.Text = "1";
            txtGiaTriQT8.Text = "1";
            txtGiaTriQT9.Text = "2";
            txtGiaTriQT10.Text = "3";

            txtQty.Text = "50";

            cl_DAL_CTKM_TriAnKH_112015 _myCKTM = new cl_DAL_CTKM_TriAnKH_112015();
            lbSoLanQuay.Text = _myCKTM.CTKM_TriAnKH_112015_Count_SoLan_CoTheQuay(frmMain._myAppConfig.StoreNo);
            lbDaQuay.Text = _myCKTM.CTKM_TriAnKH_112015_Count_SoLan_DaQuay(frmMain._myAppConfig.StoreNo, DateTime.Now.ToShortDateString());
            lbConLai.Text = (int.Parse(lbSoLanQuay.Text) - int.Parse(lbDaQuay.Text)).ToString();
        }

        private string IValidate()
        {
            string _rs = "";

            try {
                if (txtQty.Equals(""))
                {
                    _rs += "Vui lòng điền số lượng" + Environment.NewLine;
                }

                if (txtLoaiQT1.Equals("") || txtLoaiQT2.Equals("") 
                    || txtLoaiQT3.Equals("") || txtLoaiQT4.Equals("")
                    || txtLoaiQT5.Equals("") || txtLoaiQT6.Equals("") 
                    || txtLoaiQT7.Equals("") || txtLoaiQT8.Equals("")
                    || txtLoaiQT9.Equals("") || txtLoaiQT10.Equals(""))
                {
                    _rs += "Vui lòng loại Quà Tặng" + Environment.NewLine;
                }

                if (txtGiaTriQT1.Equals("") || txtGiaTriQT2.Equals("")
                    || txtGiaTriQT3.Equals("") || txtGiaTriQT4.Equals("")
                    || txtGiaTriQT5.Equals("") || txtGiaTriQT6.Equals("")
                    || txtGiaTriQT7.Equals("") || txtGiaTriQT8.Equals("")
                    || txtGiaTriQT9.Equals("") || txtGiaTriQT10.Equals(""))
                {
                    _rs += "Vui lòng loại Giá trị" + Environment.NewLine;
                }
            }
            catch (Exception )
            {
                
            }

            return _rs;
        }

        private int[] PrepareArrayLoaiQT()
        {
            int[] rs = new int[10];
            try
            {
                rs[0] = int.Parse(txtLoaiQT1.Text);
                rs[1] = int.Parse(txtLoaiQT2.Text);
                rs[2] = int.Parse(txtLoaiQT3.Text);
                rs[3] = int.Parse(txtLoaiQT4.Text);
                rs[4] = int.Parse(txtLoaiQT5.Text);
                rs[5] = int.Parse(txtLoaiQT6.Text);
                rs[6] = int.Parse(txtLoaiQT7.Text);
                rs[7] = int.Parse(txtLoaiQT8.Text);
                rs[8] = int.Parse(txtLoaiQT9.Text);
                rs[9] = int.Parse(txtLoaiQT10.Text);
            }
            catch (Exception )
            { 
                
            }

            return rs;
        }

        private int[] PrepareArrayGiaTriQT()
        {
            int[] rs = new int[10];
            try
            {
                rs[0] = int.Parse(txtGiaTriQT1.Text);
                rs[1] = int.Parse(txtGiaTriQT2.Text);
                rs[2] = int.Parse(txtGiaTriQT3.Text);
                rs[3] = int.Parse(txtGiaTriQT4.Text);
                rs[4] = int.Parse(txtGiaTriQT5.Text);
                rs[5] = int.Parse(txtGiaTriQT6.Text);
                rs[6] = int.Parse(txtGiaTriQT7.Text);
                rs[7] = int.Parse(txtGiaTriQT8.Text);
                rs[8] = int.Parse(txtGiaTriQT9.Text);
                rs[9] = int.Parse(txtGiaTriQT10.Text);
            }
            catch (Exception )
            {

            }

            return rs;
        }

        #endregion
        private void frm_CTKM_Generate_XXX_Load(object sender, EventArgs e)
        {
            this.LoadDataToControl();
            this.LoadDataToLabel();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            int[] _loaiQT = new int[10];
            _loaiQT = this.PrepareArrayLoaiQT();

            int[] _giatriQT = new int[10];
            _giatriQT = this.PrepareArrayGiaTriQT();

            cl_DAL_CTKM_TriAnKH_112015 _myCTKM = new cl_DAL_CTKM_TriAnKH_112015();
            _myCTKM.CTKM_TriAnKH_112015_Insert_XXX(int.Parse(txtQty.Text), _loaiQT, _giatriQT ,int.Parse(listStore.EditValue.ToString()));

            this.Dispose();
        }

        private void listStore_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}