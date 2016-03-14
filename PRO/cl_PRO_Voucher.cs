using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_Voucher
    {
        private string vouSid;
        private string slipSid;
        private string slipOutStoreCode;
        private string slipCreatedDate;
        private string slipNo;
        private int sumQty;

        public string VouSid
        {
            get
            {
                return vouSid;
            }
            set
            {
                vouSid = value;
            }
        }
        
        public string SlipSid
        {
            get
            {
                return slipSid;
            }
            set
            {
                slipSid = value;
            }
        }        

        public string SlipOutStoreCode
        {
            get
            {
                return slipOutStoreCode;
            }
            set
            {
                slipOutStoreCode = value;
            }
        }

        public string SlipCreatedDate
        {
            get
            {
                return slipCreatedDate;
            }
            set
            {
                slipCreatedDate = value;
            }
        }

        public string SlipNo
        {
            get
            {
                return slipNo;
            }
            set
            {
                slipNo = value;
            }
        }

        public int SumQty
        {
            get
            {
                return sumQty;
            }
            set
            {
                sumQty = value;
            }
        }
    }
}
