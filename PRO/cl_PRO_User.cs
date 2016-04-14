using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_User
    {
        private string _user;
        private string _pass;
        private string _fname;
        private string _departmentID;
        private string _forceChangePass;
        private string _active;
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public string UserName
        {
            get
            {
                return _user;
            }
            set
            {
                this._user = value;
            }
        }

        public string Password
        {
            get
            {
                return _pass;
            }
            set
            {
                this._pass = value;
            }
        }

        public string FullName
        {
            get
            {
                return _fname;
            }
            set
            {
                this._fname = value;
            }
        }

        public string DepartmentID
        {
            get
            {
                return _departmentID;
            }
            set
            {
                this._departmentID = value;
            }
        }

        public string ForceChangePass
        {
            get
            {
                return _forceChangePass;
            }
            set
            {
                this._forceChangePass = value;
            }
        }
    }
}
