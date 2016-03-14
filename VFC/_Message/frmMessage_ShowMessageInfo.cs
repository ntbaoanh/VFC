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
using PRO;

namespace VFC._Message
{
    public partial class frmMessage_ShowMessageInfo : DevExpress.XtraEditors.XtraForm
    {
        string _messageNo;
        cl_DAL_SystemMessage _dalMessage;

        public frmMessage_ShowMessageInfo(string _no)
        {
            InitializeComponent();
            _messageNo = _no;
        }

        private void frmMessage_ShowMessageInfo_Load( object sender , EventArgs e )
        {
            this.FillDataToForm( int.Parse( _messageNo ) );
        }

        private void checkAgree_CheckedChanged( object sender , EventArgs e )
        {
            if ( checkAgree.CheckState == CheckState.Checked )
            {
                btAgree.Enabled = true;
            }
            else
            {
                btAgree.Enabled = false;
            }
        }

        private void btAgree_Click( object sender , EventArgs e )
        {
            _dalMessage = new cl_DAL_SystemMessage();

            if ( _dalMessage.UpdateRead( int.Parse( _messageNo ) , lbStore.Text , int.Parse( lbMessageID.Text ) ) )
            {
                this.Dispose();
            }
            else
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Có lỗi trong quá trình thực hiện." , "error" );
            }
        }

        private void btClose_Click( object sender , EventArgs e )
        {
            this.Dispose();
        }

        #region Action
        private void FillDataToForm(int _no)
        {
            _dalMessage = new cl_DAL_SystemMessage();
            cl_PRO_SystemMessage _proMessage = new cl_PRO_SystemMessage();

            _proMessage = _dalMessage.GetMessageInfoByPushMessageNo( _no );

            lbTieuDe.Text = _proMessage.Title;
            txtBody.Text = _proMessage.Message;
            lbStore.Text = _proMessage.PushStore;
            lbMessageID.Text = _proMessage.MessageId.ToString();

            this.Text = lbTieuDe.Text;
        }
        #endregion
    }
}