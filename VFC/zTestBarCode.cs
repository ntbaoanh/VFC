using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace VFC
{
    public partial class zTestBarCode : DevExpress.XtraReports.UI.XtraReport
    {
        public zTestBarCode(string _text)
        {
            InitializeComponent();
            xrBarCode1.Text = _text;
        }


    }
}
