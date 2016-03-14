using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DAL
{
    public class cl_DAL_Version
    {
        Utilities.VFCEncryption _myEncrypt;

        public void WriteVersion( string _version , string _xmlURL , string _mySecrect )
        {
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.Indent = true;
            xws.IndentChars = "\t";
            xws.NewLineOnAttributes = true;

            _myEncrypt = new Utilities.VFCEncryption();

            using ( XmlWriter writer = XmlWriter.Create( _xmlURL , xws ) )
            {
                writer.WriteStartDocument();
                writer.WriteStartElement( "xVersion" );

                writer.WriteElementString( "version" , _myEncrypt.EncryptStringAES( _version , _mySecrect ) );

                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Close();
            }
        }
    }
}
