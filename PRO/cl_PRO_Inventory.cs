using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO
{
    public class cl_PRO_Inventory
    {
        private string _upc;
        private string _priceList;
        private string _priceRetail;
        private string _UDF10;
        private string _tenSanPham;
        private string _nhaCungCap;
        private string _season;
        private string _sizeRange;
        private string _colorCount;
        private string _uDF7;
        private string _uDF8;
        private string _chatLieu;
        private string _maThietKe;

        public string MaThietKe
        {
            get
            {
                return _maThietKe;
            }
            set
            {
                _maThietKe = value;
            }
        }

        public string NhaCungCap
        {
            get
            {
                return _nhaCungCap;
            }
            set
            {
                _nhaCungCap = value;
            }
        }

        public string Season
        {
            get
            {
                return _season;
            }
            set
            {
                _season = value;
            }
        }

        public string SizeRange
        {
            get
            {
                return _sizeRange;
            }
            set
            {
                _sizeRange = value;
            }
        }

        public string ColorCount
        {
            get
            {
                return _colorCount;
            }
            set
            {
                _colorCount = value;
            }
        }

        public string UDF7
        {
            get
            {
                return _uDF7;
            }
            set
            {
                _uDF7 = value;
            }
        }

        public string UDF8
        {
            get
            {
                return _uDF8;
            }
            set
            {
                _uDF8 = value;
            }
        }

        public string ChatLieu
        {
            get
            {
                return _chatLieu;
            }
            set
            {
                _chatLieu = value;
            }
        }

        public string UPC
        {
            get
            {
                return _upc;
            }
            set
            {
                this._upc = value;
            }
        }

        public string PriceList
        {
            get
            {
                return _priceList;
            }
            set
            {
                this._priceList = value;
            }
        }

        public string PriceRetail
        {
            get
            {
                return _priceRetail;
            }
            set
            {
                this._priceRetail = value;
            }
        }

        public string UDF10
        {
            get
            {
                return _UDF10;
            }
            set
            {
                this._UDF10 = value;
            }
        }

        public string Desc2
        {
            get
            {
                return _tenSanPham;
            }
            set
            {
                this._tenSanPham = value;
            }
        }
    }
}
