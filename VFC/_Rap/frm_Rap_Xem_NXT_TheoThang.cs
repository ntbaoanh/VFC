using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRO;
using DAL;

namespace VFC._Rap
{
    public partial class frm_Rap_Xem_NXT_TheoThang : DevExpress.XtraEditors.XtraForm
    {
        public frm_Rap_Xem_NXT_TheoThang()
        {
            InitializeComponent();
        }

        private void frm_Rap_Xem_NXT_TheoThang_Load( object sender , EventArgs e )
        {
            try
            {
                int currentMonth = DateTime.Now.Month;
                cbbMonth.SelectedIndex = currentMonth - 1 ;
                txtYear.Text = DateTime.Now.Year.ToString();
            }
            catch ( Exception  )
            {
                frmMessageBox.Show( "Thông báo" , DateTime.Now.Month.ToString() , "Error" );
            }
            //frmMessageBox.Show( "A" , DateTime.Now.Month.ToString() , "Error" );
        }

        private void btFilter_Click( object sender , EventArgs e )
        {
            cl_DAL_RAP_DoSua dosua = new cl_DAL_RAP_DoSua();                         
            gridControl1.DataSource = dosua.Get_NXT_TheoThang(txtYear.Text + this.GetMonthFromCBB());
        }

        private void btKetChuyen_Click( object sender , EventArgs e )
        {

        }

        #region Action
        private string GetMonthFromCBB()
        {
            string _thang = "";
            switch ( cbbMonth.SelectedIndex )
            {
                case 0:
                    _thang = "01";
                    break;
                case 1:
                    _thang = "02";
                    break;
                case 2:
                    _thang = "03";
                    break;
                case 3:
                    _thang = "04";
                    break;
                case 4:
                    _thang = "05";
                    break;
                case 5:
                    _thang = "06";
                    break;
                case 6:
                    _thang = "07";
                    break;
                case 7:
                    _thang = "08";
                    break;
                case 8:
                    _thang = "09";
                    break;
                case 9:
                    _thang = "10";
                    break;
                case 10:
                    _thang = "11";
                    break;
                case 11:
                    _thang = "12";
                    break;
            }

            return _thang;
        }
        #endregion
    }
}