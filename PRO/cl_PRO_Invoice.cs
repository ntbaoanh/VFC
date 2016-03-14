using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_Invoice
    {
        private string invc_no;
        private string date;
        private string qty;
        private string amount;
        private string storeNo;
        private string discount;
        private string cust_sid;
        private string time;
        private string invc_sid;
        private string storeCode;        

        public cl_PRO_Invoice(){}

        public cl_PRO_Invoice( string _invcNo , 
                                string _createDate , 
                                string _qty , 
                                string _amount , 
                                string _storeNo , 
                                string _discount , 
                                string _custSid,
                                string _createTime,
                                string _invcSid,
                                string _storeCode)
        {
            Invc_No = _invcNo;
            CreatedDate = _createDate;
            Qty = _qty;
            Amount = _amount;
            StoreNo = _storeNo;
            Discount = _discount;
            Cust_sid = _custSid;
            Time = _createTime;
            Invc_sid = _invcSid;
            StoreCode = _storeCode;
        }

        public string StoreCode
        {
            get
            {
                return storeCode;
            }
            set
            {
                storeCode = value;
            }
        }

        public string Invc_sid
        {
            get
            {
                return invc_sid;
            }
            set
            {
                invc_sid = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public string Cust_sid
        {
            get
            {
                return cust_sid;
            }
            set
            {
                cust_sid = value;
            }
        }

        public string Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }

        public string Invc_No
        {
            get
            {
                return invc_no;
            }
            set
            {
                this.invc_no = value;
            }
        }

        public string CreatedDate
        {
            get { return date; }
            set { this.date = value; }
        }

        public string Qty
        {
            get { return qty; }
            set { this.qty = value; }
        }

        public string Amount
        {
            get { return amount; }
            set { this.amount = value; }
        }

        public string StoreNo
        {
            get
            {
                return storeNo;
            }
            set
            {
                this.storeNo = value;
            }
        }
    }
}
