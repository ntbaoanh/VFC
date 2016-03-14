using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_PromotionCode
    {
        int proCodeSid;
        string proCode;
        string dateCreate;
        string dateModified;
        string dateExpire;
        string modifiedBy;
        int usedCount;
        string createdBy;
        int partNumber;
        int status;
        string _storeNo;
        int _invcNo;
        string _customerSid;
        string _loaiKM;
        int _amountKM;
        string _storeCode;

        public string StoreCode
        {
            get
            {
                return _storeCode;
            }
            set
            {
                _storeCode = value;
            }
        }

        public string LoaiKM
        {
            get
            {
                return _loaiKM;
            }
            set
            {
                _loaiKM = value;
            }
        }

        public int AmountKM
        {
            get
            {
                return _amountKM;
            }
            set
            {
                _amountKM = value;
            }
        }

        public string StoreNo
        {
            get
            {
                return _storeNo;
            }
            set
            {
                _storeNo = value;
            }
        }

        public int InvcNo
        {
            get
            {
                return _invcNo;
            }
            set
            {
                _invcNo = value;
            }
        }

        public string CustomerSid
        {
            get
            {
                return _customerSid;
            }
            set
            {
                _customerSid = value;
            }
        }

        public int ProCodeSid
        {
            get
            {
                return proCodeSid;
            }
            set
            {
                proCodeSid = value;
            }
        }

        public string ProCode
        {
            get
            {
                return proCode;
            }
            set
            {
                proCode = value;
            }
        }

        public string DateCreate
        {
            get
            {
                return dateCreate;
            }
            set
            {
                dateCreate = value;
            }
        }

        public string DateModified
        {
            get
            {
                return dateModified;
            }
            set
            {
                dateModified = value;
            }
        }

        public string DateExpire
        {
            get
            {
                return dateExpire;
            }
            set
            {
                dateExpire = value;
            }
        }

        public string ModifiedBy
        {
            get
            {
                return modifiedBy;
            }
            set
            {
                modifiedBy = value;
            }
        }

        public string CreatedBy
        {
            get
            {
                return createdBy;
            }
            set
            {
                createdBy = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public int UsedCount
        {
            get
            {
                return usedCount;
            }
            set
            {
                usedCount = value;
            }
        }

        public int PartNumber
        {
            get
            {
                return partNumber;
            }
            set
            {
                partNumber = value;
            }
        }
    }
}
