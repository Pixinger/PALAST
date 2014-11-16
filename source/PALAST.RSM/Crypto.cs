using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace PALAST.RSM
{
    public static class Crypto
    {
        public static void CreateKeys(out string privateKey, out string publicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            privateKey = rsa.ToXmlString(true);
            publicKey = rsa.ToXmlString(false);
        }
        public static string Encrypt(string publicKey, string text)
        {
            System.Text.UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
            byte[] encryptedBuffer = Encrypt(publicKey, unicodeEncoding.GetBytes(text));

            // In einen lesbaren string konvertieren
            int length = encryptedBuffer.Count();
            int index = 0;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte item in encryptedBuffer)
            {
                index++;
                stringBuilder.Append(item);

                if (index < length)
                    stringBuilder.Append(",");
            }

            return stringBuilder.ToString();
        }
        public static byte[] Encrypt(string publicKey, byte[] data)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);
            return rsa.Encrypt(data, false);
        }
        public static string Decrypt(string privateKey, string text)
        {
            string[] textArray = text.Split(new char[] { ',' });
            byte[] buffer = new byte[textArray.Length];
            for (int i = 0; i < textArray.Length; i++)
                buffer[i] = Convert.ToByte(textArray[i]);

            byte[] decryptedBuffer = Decrypt(privateKey, buffer);

            System.Text.UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
            return unicodeEncoding.GetString(decryptedBuffer);
        }
        public static byte[] Decrypt(string privateKey, byte[] data)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);
            return rsa.Decrypt(data, false);
        }       
    }
}
