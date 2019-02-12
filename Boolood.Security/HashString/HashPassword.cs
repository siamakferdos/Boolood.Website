using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Boolood.Framework.Security;

namespace Boolood.Security.HashString
{
    public class Sha1HashProvider: ISecurityProvider
    {
        public string HashPassword(string password)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var hashedPassword = sha1.ComputeHash(Encoding.ASCII.GetBytes(password));
            return new ASCIIEncoding().GetString(hashedPassword);
        }

        public string Hash(string plainText, string saltedValue)
        {
            //using (var deriveBytes = new Rfc2898DeriveBytes(plainText, 20))
            //{
            //    byte[] salt = deriveBytes.Salt;
            //    byte[] key = deriveBytes.GetBytes(20);  // derive a 20-byte key

            //    new ASCIIEncoding().GetString(hashedPassword)
            //}
            return "";
        }
    }
}
