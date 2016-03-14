using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DAL.Utilities
{
    public class GetRandomAlphanumericString
    {
        public string FinalRandomString( string _str , int _charCount )
        {
            string _rs = "";

            _rs = GetRandomString( _charCount , _str );

            return _rs;
        }

        public string GetRandomString( int length , IEnumerable<char> characterSet )
        {
            if ( length < 0 )
                throw new ArgumentException( "length must not be negative" , "length" );
            if ( length > int.MaxValue / 8 ) // 250 million chars ought to be enough for anybody
                throw new ArgumentException( "length is too big" , "length" );
            if ( characterSet == null )
                throw new ArgumentNullException( "characterSet" );
            var characterArray = characterSet.Distinct().ToArray();
            if ( characterArray.Length == 0 )
                throw new ArgumentException( "characterSet must not be empty" , "characterSet" );

            Byte[] bytes = new byte[length * 8];
            new RNGCryptoServiceProvider().GetBytes( bytes );
            Char[] result = new char[length];
            for ( int i = 0 ; i < length ; i++ )
            {
                ulong value = BitConverter.ToUInt64( bytes , i * 8 );
                result[i] = characterArray[value % (uint) characterArray.Length];
            }
            return new string( result );
        }
    }
}
