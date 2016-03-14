using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace DAL.Utilities
{
    public class WorkingWithXML
    {
        public string readXML( string _url , string _name )
        {
            string _result = "";
            string fileName = _url;
            FileStream fs = new FileStream( fileName , FileMode.Open , FileAccess.Read );
            XmlTextReader xtr = new XmlTextReader( fs );
            try
            {
                while ( !xtr.EOF )
                {
                    if ( xtr.MoveToContent() == XmlNodeType.Element && xtr.Name == _name )
                    {
                        _result = xtr.ReadElementString();
                    }
                    else
                    {
                        xtr.Read();
                    }
                }
            }
            catch ( Exception ex )
            {
                throw ( new Exception( ex.Message ) );
            }

            xtr.Close();

            return _result;
        }
    }    
}
