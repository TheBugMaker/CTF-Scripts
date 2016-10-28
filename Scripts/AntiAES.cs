using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;



namespace Scripts
{
    class AntiAES
    {
         

            public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] buffer = null;
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using (MemoryStream stream = new MemoryStream())
            {
                using (RijndaelManaged managed = new RijndaelManaged())
                {
                    managed.KeySize = 0x100;
                    managed.BlockSize = 0x80;
                    Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(passwordBytes, salt, 0x3e8);
                    managed.Key = bytes.GetBytes(managed.KeySize / 8);
                    managed.IV = bytes.GetBytes(managed.BlockSize / 8);
                    managed.Mode = CipherMode.CBC;
                    using (CryptoStream stream2 = new CryptoStream(stream, managed.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        stream2.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        stream2.Close();
                    }
                    buffer = stream.ToArray();
                }
            }
            return buffer;
        }
        

    }
}
