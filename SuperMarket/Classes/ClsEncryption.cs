using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Classes
{
    class ClsEncryption
    {
        public static string Encrypt(string password)
        {
            char[] pass = password.ToCharArray();
            string[] Sysb = { "*", "#", "&", "@", "%" };
            string NewPass = "";
            Random rm = new Random();

            for (int i = pass.Length - 1; i >= 0; i--)
            {
                NewPass += ((int)pass[i]).ToString() + Sysb[rm.Next(0, 5)];
            }
            return NewPass;
        }

        public static string Decrypt(string password)
        {
            string[] tokens = password.Split('*', '#', '&', '@', '%');
            string pass = "";

            for (int i = tokens.Length - 2; i >= 0; i--)
            {
                pass += ((char)Convert.ToDouble(tokens[i])).ToString();
            }
            return pass;
        }

    }
}
