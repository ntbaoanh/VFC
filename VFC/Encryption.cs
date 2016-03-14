using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace VFC
{
    public partial class Encryption : Form
    {
        DAL.Utilities.VFCEncryption encry;
        string mySecrect;

        public Encryption()
        {
            InitializeComponent();
        }

        private void frmHashMD5_Load( object sender , EventArgs e )
        {
            encry = new DAL.Utilities.VFCEncryption();
            mySecrect = "P@SSw0rd";
        }

        private void btHash_Click( object sender , EventArgs e )
        {   
            txtEncrypt.Text = encry.EncryptStringAES( txtInput.Text.Trim() , mySecrect );
        }

        private void btDecrypt_Click( object sender , EventArgs e )
        {
            txtDecrypt.Text = encry.DecryptStringAES( txtEncrypt.Text , mySecrect );
        }
    }
}
