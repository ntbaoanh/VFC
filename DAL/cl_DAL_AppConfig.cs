using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRO;
using System.Xml;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_AppConfig
    {
        cl_PRO_AppConfig myConfig;
        Utilities.WorkingWithXML _myXml;
        Utilities.VFCEncryption _myEncrypt;

        public cl_PRO_AppConfig readAllConfig( string _url , string _mySecrect)
        {
            myConfig = new cl_PRO_AppConfig();
            _myXml = new Utilities.WorkingWithXML();
            _myEncrypt = new Utilities.VFCEncryption();

            myConfig.AfterUpdateRunFile = _myEncrypt.DecryptStringAES( _myXml.readXML( _url , "afterUpdateRunFile" ) , _mySecrect);
            myConfig.SourceUpdate = _myEncrypt.DecryptStringAES(_myXml.readXML( _url , "sourceUrl") , _mySecrect);
            myConfig.Ora248IP = _myEncrypt.DecryptStringAES(_myXml.readXML( _url , "ora248IP") , _mySecrect);
            myConfig.SqlIP = _myEncrypt.DecryptStringAES(_myXml.readXML( _url , "sqlIP" ) , _mySecrect);
            myConfig.OraLocalIP = _myEncrypt.DecryptStringAES(_myXml.readXML( _url , "oraLocalIP" ) , _mySecrect);
            myConfig.OraLanIP = _myEncrypt.DecryptStringAES( _myXml.readXML( _url , "oraLanIP" ) , _mySecrect );
            myConfig.StoreCode = _myEncrypt.DecryptStringAES( _myXml.readXML( _url , "storeCode" ) , _mySecrect );
            myConfig.StoreNo = _myEncrypt.DecryptStringAES( _myXml.readXML( _url , "storeNo" ) , _mySecrect );
            myConfig.SbsNo = _myEncrypt.DecryptStringAES( _myXml.readXML( _url , "sbsNo" ) , _mySecrect );  

            return myConfig;
        }

        public cl_PRO_AppConfig writeConfigurationXML( cl_PRO_AppConfig _myAppConfig , string _xmlURL, string _mySecrect)
        {
            _myEncrypt = new Utilities.VFCEncryption();
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.Indent = true;
            xws.IndentChars = "\t";
            xws.NewLineOnAttributes = true;

            using ( XmlWriter writer = XmlWriter.Create( _xmlURL , xws ) )
            {
                writer.WriteStartDocument();
                writer.WriteStartElement( "config" );

                writer.WriteElementString( "afterUpdateRunFile" , _myEncrypt.EncryptStringAES( _myAppConfig.AfterUpdateRunFile , _mySecrect ) );
                writer.WriteElementString( "sourceUrl" , _myEncrypt.EncryptStringAES( _myAppConfig.SourceUpdate , _mySecrect ) );
                writer.WriteElementString( "ora248IP" , _myEncrypt.EncryptStringAES( _myAppConfig.Ora248IP , _mySecrect ) );
                writer.WriteElementString( "sqlIP" , _myEncrypt.EncryptStringAES( _myAppConfig.SqlIP , _mySecrect ) );
                writer.WriteElementString( "oraLocalIP" , _myEncrypt.EncryptStringAES( _myAppConfig.OraLocalIP , _mySecrect ) );
                writer.WriteElementString( "oraLanIP" , _myEncrypt.EncryptStringAES( _myAppConfig.OraLanIP , _mySecrect ) );
                writer.WriteElementString( "storeCode" , _myEncrypt.EncryptStringAES( _myAppConfig.StoreCode , _mySecrect ) );
                writer.WriteElementString( "storeNo" , _myEncrypt.EncryptStringAES( _myAppConfig.StoreNo , _mySecrect ) );
                writer.WriteElementString( "sbsNo" , _myEncrypt.EncryptStringAES( _myAppConfig.SbsNo , _mySecrect ) );
                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Close();
            }

            return _myAppConfig;
        }
    }
}
