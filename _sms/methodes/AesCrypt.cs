using System;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Drawing;
using System.IO;
using System.Collections.Generic;

namespace _sms.methodes
{
    public class AesCrypt
    {
        private static string IV = "X12+VBYXc3hueG7Y6QMMSg==";
        private static string Key = "v3McfPtyDGdafqCOUE8AVQ==";

        public static string Encrypt(string text)
        {
            text = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));

            byte[] textbytes = Convert.FromBase64String(text);
            AesCryptoServiceProvider aesprovider = new AesCryptoServiceProvider();
            aesprovider.BlockSize = 128;
            aesprovider.KeySize = 256;
            aesprovider.Key = Convert.FromBase64String(Key);
            aesprovider.IV = Convert.FromBase64String(IV);
            aesprovider.Padding = PaddingMode.PKCS7;
            aesprovider.Mode = CipherMode.CBC;

            ICryptoTransform icrypt = aesprovider.CreateEncryptor(aesprovider.Key, aesprovider.IV);
            byte[] encryptedData = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();

            return Convert.ToBase64String(encryptedData);

        }

        public static string Decrypt(string text)
        {
            byte[] textbytes = Convert.FromBase64String(text);
            AesCryptoServiceProvider aesprovider = new AesCryptoServiceProvider();
            aesprovider.BlockSize = 128;
            aesprovider.KeySize = 256;
            aesprovider.Key = Convert.FromBase64String(Key);
            aesprovider.IV = Convert.FromBase64String(IV);
            aesprovider.Padding = PaddingMode.PKCS7;
            aesprovider.Mode = CipherMode.CBC;

            ICryptoTransform icrypt = aesprovider.CreateDecryptor(aesprovider.Key, aesprovider.IV);
            byte[] dencryptedData = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();

            return ASCIIEncoding.ASCII.GetString(dencryptedData);
        }
    }
}
