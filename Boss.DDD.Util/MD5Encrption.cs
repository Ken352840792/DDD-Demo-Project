using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Boss.DDD
{
    public class MD5Encrption
    {
        /// <summary>
        /// MD5 16位加密
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static string GetMD5Str(string pass)
        {
            var md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(pass)));
            return t2.Replace("-", "");
        }
    }
}