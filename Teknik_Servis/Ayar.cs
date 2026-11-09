using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using System.IO;


namespace Teknik_Servis
{
    internal class Ayar
    {
        public static SqlConnection con;
        public static string anahtarkelime="";
        public static string kullaniciid= "";
        public static string sifrele(string sifrelenecek, string anahtar)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifrelenecek);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(anahtar));
                using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = triple.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        public static string sifreCoz(string cozulecek, string key)
        {
            byte[] data = Convert.FromBase64String(cozulecek);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider triplesDes = new TripleDESCryptoServiceProvider() { Key =keys, Mode = CipherMode.ECB, Padding =PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = triplesDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}