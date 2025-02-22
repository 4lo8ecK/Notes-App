using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public static class Encrypt
    {
        private const string KEY = "Hikemi dies in the end of 'Order 66'";
        // 'Order 66' is my short film inspiered of Star Wars
        // Hikemi is main character in it.


        public static string EncryptDat(string plainText)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(KEY.PadRight(32).Substring(0, 32));

            using (Aes aes = Aes.Create())
            {

                aes.GenerateIV(); // Случайный IV
                byte[] iv = aes.IV;

                using (var encryptor = aes.CreateEncryptor(keyBytes, iv))
                using (var ms = new MemoryStream())
                {

                    ms.Write(iv, 0, iv.Length); // Сохраняем IV в начале
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

                        cs.Write(plainBytes, 0, plainBytes.Length);
                        cs.FlushFinalBlock();

                        return Convert.ToBase64String(ms.ToArray());
                    }

                }
            }
        }

        public static string DecryptDat(string cipherText)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(KEY.PadRight(32).Substring(0, 32));
            byte[] fullBytes = Convert.FromBase64String(cipherText);
            byte[] iv = new byte[16];

            Array.Copy(fullBytes, 0, iv, 0, 16);

            byte[] cipherBytes = new byte[fullBytes.Length - 16];

            Array.Copy(fullBytes, 16, cipherBytes, 0, cipherBytes.Length);

            using (Aes aes = Aes.Create())
            {

                using (var decryptor = aes.CreateDecryptor(keyBytes, iv))
                using (var ms = new MemoryStream())

                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                {

                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.FlushFinalBlock();

                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }

    }
}
