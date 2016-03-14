using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_AppConfig
    {
        private String _afterUpdateRunFile;
        private String _sourceUpdate;
        private String _ora248IP;
        private String _sqlIP;
        private String _oraLocalIP;
        private String _oraLanIP;
        private String _storeNo;
        private String _storeCode;
        private string _sbsNo;

        public String AfterUpdateRunFile
        {
            get
            {
                return _afterUpdateRunFile;
            }
            set
            {
                _afterUpdateRunFile = value;
            }
        }

        public string SbsNo
        {
            get
            {
                return _sbsNo;
            }
            set
            {
                _sbsNo = value;
            }
        }

        public String SourceUpdate
        {
            get
            {
                return _sourceUpdate;
            }
            set
            {
                _sourceUpdate = value;
            }
        }

        public String Ora248IP
        {
            get
            {
                return _ora248IP;
            }
            set
            {
                _ora248IP = value;
            }
        }        

        public String SqlIP
        {
            get
            {
                return _sqlIP;
            }
            set
            {
                _sqlIP = value;
            }
        }        

        public String StoreNo
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

        public String StoreCode
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

        public String OraLanIP
        {
            get
            {
                return _oraLanIP;
            }
            set
            {
                _oraLanIP = value;
            }
        }        

        public String OraLocalIP
        {
            get
            {
                return _oraLocalIP;
            }
            set
            {
                _oraLocalIP = value;
            }
        }
    }
}
