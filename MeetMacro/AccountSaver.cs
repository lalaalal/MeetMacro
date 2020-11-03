using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace MeetMacro
{
    public class AccountSaver
    {
        public static readonly string FILE_NAME = "account.txt";
        private FileManager fileManager = new FileManager(FILE_NAME);

        private static readonly string KEY = "@MeetMacro";
        public string Id { private set; get; }
        public string Pw { private set; get; }

        public AccountSaver() => Load();

        public bool AccountExists()
            => Id != null && Pw != null;

        public void SetAccount(string id, string pw)
        {
            Id = id;
            Pw = pw;
        }

        public void Load()
        {
            string[] lines = fileManager.Read();
            if (lines.Length < 2)
                return;

            Id = lines[0];
            Pw = Decrypt(lines[1], Id + KEY);
        }

        public void Save() => fileManager.Write(Save);

        private void Save(TextWriter writer)
        {
            writer.WriteLine(Id);
            writer.WriteLine(Encrypt(Pw, Id + KEY));
        }

        public static string Encrypt(string textToEncrypt, string key)
        {
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
                len = keyBytes.Length;
            Array.Copy(pwdBytes, keyBytes, len);

            RijndaelManaged rijndaelCipher = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 128,
                BlockSize = 128,
                Key = keyBytes,
                IV = keyBytes
            };

            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);
            return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));
        }

        public static string Decrypt(string textToDecrypt, string key)
        {
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
                len = keyBytes.Length;
            Array.Copy(pwdBytes, keyBytes, len);

            RijndaelManaged rijndaelCipher = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 128,
                BlockSize = 128,
                Key = keyBytes,
                IV = keyBytes
            };

            byte[] encryptedData = Convert.FromBase64String(textToDecrypt);
            byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(plainText);
        }
    }
}
