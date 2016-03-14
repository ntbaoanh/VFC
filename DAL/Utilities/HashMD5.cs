using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DAL.Utilities
{
    public class HashMD5
    {
        public string toMD5(string pass)
        {
            byte[] asciiBytes = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hashedBytes = MD5CryptoServiceProvider.Create().ComputeHash(asciiBytes);
            string hashedString = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

            return hashedString;
        }
    }
}
