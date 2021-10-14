using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _5_A_Side
{
    public class Encryption
    {
        public string Hashing(string password)
        {
            string hash = "f0xle@rn"
            string encrypted;
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using(MD5CryptoProvider = new Md5CryptoServiceProvider)

            return encrypted; 
        }

        public string DeHashing(string encrypted)
        {
            string password;
            return password;
        }
    }
}
