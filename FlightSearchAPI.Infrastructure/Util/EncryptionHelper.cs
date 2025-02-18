using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Infrastructure.Util
{
    public static class EncryptionHelper
    {


        // Encrypt the connection string using AES algorithm with compression
        public static string Encrypt(string plainText, byte[] key, byte[] iv)
        {
            // First, compress the string to reduce the size
            byte[] compressedData = Compress(plainText);

            // Now encrypt the compressed data
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(compressedData, 0, compressedData.Length);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        // Decrypt the encrypted connection string and decompress it
        public static string Decrypt(string cipherText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (MemoryStream msDecompressed = new MemoryStream())
                        {
                            csDecrypt.CopyTo(msDecompressed);
                            // Decompress the data after decryption
                            byte[] decompressedData = Decompress(msDecompressed.ToArray());
                            return Encoding.UTF8.GetString(decompressedData);
                        }
                    }
                }
            }
        }

        // Method to compress data using GZip (to reduce size before encryption)
        private static byte[] Compress(string data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(ms, CompressionLevel.Optimal))
                using (StreamWriter writer = new StreamWriter(gzip))
                {
                    writer.Write(data);
                }
                return ms.ToArray();
            }
        }

        // Method to decompress data after decryption
        private static byte[] Decompress(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            using (GZipStream gzip = new GZipStream(ms, CompressionMode.Decompress))
            using (MemoryStream msDecompressed = new MemoryStream())
            {
                gzip.CopyTo(msDecompressed);
                return msDecompressed.ToArray();
            }
        }
    }

}
