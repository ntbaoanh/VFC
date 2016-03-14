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
using DevExpress.XtraGrid.Views.Grid;
using PRO;

namespace VFC._Message
{
    public partial class frmMessage_Push : DevExpress.XtraEditors.XtraForm
    {
        string _region;
        cl_DAL_Store _store;
        cl_DAL_SystemMessage _dalMessage;
        cl_PRO_SystemMessage _proMessage;
        int _messageID;

        public frmMessage_Push()
        {
            InitializeComponent();
        }

        public frmMessage_Push(string _id)
        {            
            InitializeComponent();
            _messageID = int.Parse( _id );
            groupControl_MessageList.Visible = false;
            lbID.Text = _id;            
        }

        private void frmMessage_Push_Load( object sender , EventArgs e )
        {
            this.FillDataToGridMessage();
        }

        private void checkAllRegion_CheckedChanged( object sender , EventArgs e )
        {
            if ( checkAllRegion.CheckState == CheckState.Checked )
            {
                for ( int i = 0 ; i < listRegion.ItemCount ; i++ )
                {
                    if ( listRegion.Items[i].Enabled == true )
                    {
                        listRegion.Items[i].CheckState = CheckState.Checked;
                    }
                    else
                    {
                        listRegion.Items[i].CheckState = CheckState.Unchecked;
                    }
                }
            }
            else
            {
                for ( int i = 0 ; i < listRegion.ItemCount ; i++ )
                {
                    listRegion.Items[i].CheckState = CheckState.Unchecked;
                }
            }
        }

        private void checkAllStores_CheckedChanged( object sender , EventArgs e )
        {
            if ( checkAllStores.CheckState == CheckState.Checked )
            {
                for ( int i = 0 ; i < listStores.ItemCount ; i++ )
                {
                    listStores.Items[i].CheckState = CheckState.Checked;
                }
            }
            else
            {
                for ( int i = 0 ; i < listStores.ItemCount ; i++ )
                {
                    listStores.Items[i].CheckState = CheckState.Unchecked;
                }
            }
        }

        private void listRegion_ItemCheck( object sender , DevExpress.XtraEditors.Controls.ItemCheckEventArgs e )
        {
            try
            {
                DataSet ds = new DataSet();
                string _region = this.getRegionCheck();

                if ( _region.Equals( ",'" ) )
                {
                    listStores.Items.Clear();
                    checkAllStores.CheckState = CheckState.Unchecked;
                    checkAllRegion.CheckState = CheckState.Unchecked;
                }
                else
                {
                    _store = new cl_DAL_Store();
                    DataTable _dt = new DataTable();

                    _dt = _store.returnORA_StoreCodeFromRegion( _region.Substring( 2 , _region.Length - 3 ) );

                    listStores.Items.Clear();
                    foreach ( DataRow dataRow in _dt.Rows )
                    {
                        listStores.Items.Add( dataRow["STORE_CODE"] );
                    }
                }
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private void lbID_TextChanged( object sender , EventArgs e )
        {
            this.FillDataWithID( int.Parse(lbID.Text) );
        }

        private void btPush_Click( object sender , EventArgs e )
        {
            for ( int i = 0 ; i < listStores.ItemCount ; i++ )
            {
                try
                {
                    if ( listStores.Items[i].CheckState == CheckState.Checked )
                    {
                        _dalMessage = new cl_DAL_SystemMessage();
                        _dalMessage.InsertPushMessage( int.Parse( lbID.Text ) , listStores.Items[i].Value.ToString() );                        
                    }
                    else
                    {

                    }
                }
                catch ( Exception ex )
                {
                    frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
                }
            }
        }

        private void gridView1_RowStyle( object sender , DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e )
        {
            GridView View = sender as GridView;
            if ( e.RowHandle >= 0 )
            {
                if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals( "0" ) )
                {
                    e.Appearance.ForeColor = Color.Black;
                }
                else if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals( "1" ) )
                {
                    e.Appearance.ForeColor = Color.Blue;
                }
                else if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals( "2" ) )
                {
                    e.Appearance.ForeColor = Color.Orange;
                }
                else if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals( "3" ) )
                {
                    e.Appearance.ForeColor = Color.Brown;
                }
                else if ( View.GetRowCellDisplayText( e.RowHandle , View.Columns["Important"] ).Equals( "4" ) )
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gridView1_FocusedRowChanged( object sender , DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
        {
            try
            {
                lbID.Text = gridView1.GetFocusedRowCellValue( "MessageID" ).ToString();
            }
            catch ( NullReferenceException ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , "Vui lòng chọn Thông báo." , "error" );
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }
        
        private void btRefresh_Click( object sender , EventArgs e )
        {
            this.FillDataToGridMessage();
        }

        #region Action
        private void FillDataToGridMessage()
        {
            try
            {
                _dalMessage = new cl_DAL_SystemMessage();
                gridControl1.DataSource = _dalMessage.GetAllMessageActive();
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }

        private string getRegionCheck()
        {
            _region = ",'";

            for ( int i = 0 ; i < listRegion.ItemCount ; i++ )
            {
                if ( listRegion.Items[i].CheckState == CheckState.Checked )
                {
                    _region += "'" + listRegion.Items[i].Value + "',";
                }
            }

            return _region;
        }

        private void FillDataWithID( int _id )
        {
            try
            {
                _proMessage = new cl_PRO_SystemMessage();
                _dalMessage = new cl_DAL_SystemMessage();

                _proMessage = _dalMessage.GetMessageInfoByMessageID( _id );

                txtTitle.Text = _proMessage.Title;
                txtBody.Text = _proMessage.Message;
            }
            catch ( Exception ex )
            {
                frmMessageBox.Show( "Thông báo lỗi" , ex.ToString() , "error" );
            }
        }
        #endregion
    }
}