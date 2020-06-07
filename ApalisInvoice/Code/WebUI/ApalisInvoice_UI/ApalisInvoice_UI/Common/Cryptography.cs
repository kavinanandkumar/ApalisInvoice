using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Common
{
    public static class Cryptography
    {
        public static string Encrypt(string strClearText, string strPassword)
        {
            byte[] _objClearBytes = System.Text.Encoding.Unicode.GetBytes(strClearText);
            PasswordDeriveBytes _objPasswordDeriveBytes = new PasswordDeriveBytes(strPassword,
                new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            byte[] _objEncryptedData = ByteEncrypt(_objClearBytes, _objPasswordDeriveBytes.GetBytes(32), _objPasswordDeriveBytes.GetBytes(16));
            return Convert.ToBase64String(_objEncryptedData);
        }

        public static string Decrypt(string strCipherText, string strPassword)
        {
            byte[] _objCipherBytes = Convert.FromBase64String(strCipherText);
            PasswordDeriveBytes _objPasswordDeriveBytes = new PasswordDeriveBytes(strPassword,
                new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            byte[] _objDecryptedData = ByteDecrypt(_objCipherBytes, _objPasswordDeriveBytes.GetBytes(32), _objPasswordDeriveBytes.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(_objDecryptedData);
        }

        public static byte[] ByteDecrypt(byte[] objCipherData, byte[] objKey, byte[] objIV)
        {
            byte[] _objDecryptedData;
            using (MemoryStream _objMemoryStream = new MemoryStream())
            {
                Rijndael _objRijndael = Rijndael.Create();
                _objRijndael.Key = objKey;
                _objRijndael.IV = objIV;
                CryptoStream _objCryptoStream = new CryptoStream(_objMemoryStream, _objRijndael.CreateDecryptor(), CryptoStreamMode.Write);
                _objCryptoStream.Write(objCipherData, 0, objCipherData.Length);
                _objCryptoStream.Close();
                _objDecryptedData = _objMemoryStream.ToArray();
            }
            return _objDecryptedData;
        }

        public static byte[] ByteEncrypt(byte[] objClearData, byte[] objKey, byte[] objIV)
        {
            byte[] _objEncryptedData;
            using (MemoryStream _objMemoryStream = new MemoryStream())
            {
                Rijndael _objRijndael = Rijndael.Create();
                _objRijndael.Key = objKey;
                _objRijndael.IV = objIV;
                CryptoStream _objCryptoStream = new CryptoStream(_objMemoryStream, _objRijndael.CreateEncryptor(), CryptoStreamMode.Write);
                _objCryptoStream.Write(objClearData, 0, objClearData.Length);
                _objCryptoStream.Close();
                _objEncryptedData = _objMemoryStream.ToArray();
            }
            return _objEncryptedData;
        }
    }
}
