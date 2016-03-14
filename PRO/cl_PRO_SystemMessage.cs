using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_SystemMessage
    {
        int _messageId;
        string _message;
        string _createdDate;
        string _createdBy;
        string _modifiedDate;
        string _modifiedBy;
        int _important;
        bool _active;
        string _title;
        string _pushStore;
        int _pushNo;
        bool _pushReadStatus;
        string _pushDateRead;

        public string PushStore
        {
            get
            {
                return _pushStore;
            }
            set
            {
                _pushStore = value;
            }
        }

        public int PushNo
        {
            get
            {
                return _pushNo;
            }
            set
            {
                _pushNo = value;
            }
        }

        public bool PushReadStatus
        {
            get
            {
                return _pushReadStatus;
            }
            set
            {
                _pushReadStatus = value;
            }
        }

        public string PushDateRead
        {
            get
            {
                return _pushDateRead;
            }
            set
            {
                _pushDateRead = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public int Important
        {
            get
            {
                return _important;
            }
            set
            {
                _important = value;
            }
        }        

        public bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }

        public string ModifiedBy
        {
            get
            {
                return _modifiedBy;
            }
            set
            {
                _modifiedBy = value;
            }
        }
        
        public string ModifiedDate
        {
            get
            {
                return _modifiedDate;
            }
            set
            {
                _modifiedDate = value;
            }
        }
        

        public int MessageId
        {
            get
            {
                return _messageId;
            }
            set
            {
                _messageId = value;
            }
        }

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }

        public string CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                _createdDate = value;
            }
        }

        public string CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                _createdBy = value;
            }
        }
    }
}
