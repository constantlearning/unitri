using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.Service.util
{
    class EncryptPassword
    {

        public static string Encrypt(string cleanPassword)
        {
            return Reverse(cleanPassword);
        }

        public static string Decrypt(string encryptedPassword)
        {
            return Reverse(encryptedPassword);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
