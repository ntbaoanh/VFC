using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VFC._IT
{
    public partial class frmIT_ViewLogs : DevExpress.XtraEditors.XtraForm
    {
        int countDown;
        public frmIT_ViewLogs()
        {
            InitializeComponent();
        }

        private void frmIT_ViewLogs_Load( object sender , EventArgs e )
        {
            this.FillLogData();

            countDown = 60;
            timer.Interval = 1 * 1 * 1000;
            timer.Start();
        }

        private void timer_Tick( object sender , EventArgs e )
        {
            countDown--;

            if ( countDown < 0 )
            {
                countDown = 60;
                this.FillLogData();
            }

            lbCountDown.Text = countDown.ToString();
        }

        private void FillLogData()
        {
            try
            {
                DataTable _dt = new DataTable();
                DAL.Utilities.SQLCon _conn = new DAL.Utilities.SQLCon();

                string sql = "SELECT * FROM tb_RecordTransactions ORDER BY Sid DESC";

                _dt = _conn.returnDataTable( sql );

                gridControl1.DataSource = _dt;
            }catch(Exception ex)
            {
                gridControl1.DataSource = null;
            }
        }

        private void btRefresh_Click( object sender , EventArgs e )
        {
            this.FillLogData();
        }
    }
}