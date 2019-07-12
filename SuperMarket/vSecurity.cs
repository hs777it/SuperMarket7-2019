using System;
using System.Text;
using System.Security.Cryptography;

namespace SuperMarket
{
    class vSecurity
    {
        //MD5Hash
        public static string MD5Serial(string value)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
            byte[] result = md5.Hash;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("X2"));//It formats the string as two uppercase hexadecimal characters.
            }
            string sn = sb.ToString();
            string serial = sn.Substring(0, 5) + "-" + sn.Substring(5, 5) + "-" + sn.Substring(10, 5) + "-" + sn.Substring(15, 5) + "-" + sn.Substring(20, 5);
            return serial.ToString();
        }

        public static string Encrypt(string value)
        {
            return "";
        }
    }
}
