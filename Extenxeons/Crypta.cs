using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Extenxeons
{
    public static class Crypta
    {
        static public byte[] RSAEncrypt(byte[] byteEncrypt, RSAParameters RSAInfo, bool isOAEP)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAInfo);

                    //Encrypt the passed byte array and specify OAEP padding.
                    encryptedData = RSA.Encrypt(byteEncrypt, isOAEP);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        static public byte[] RSADecrypt(byte[] byteDecrypt, RSAParameters RSAInfo, bool isOAEP)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAInfo);

                    //Encrypt the passed byte array and specify OAEP padding.
                    decryptedData = RSA.Decrypt(byteDecrypt, isOAEP);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        public static byte[] DESEncrypt(string strText, SymmetricAlgorithm key)
        {
            // Create a memory stream.
            MemoryStream ms = new MemoryStream();

            // Create a CryptoStream using the memory stream and the
            // CSP(cryptoserviceprovider) DES key.
            CryptoStream crypstream = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);

            // Create a StreamWriter to write a string to the stream.
            StreamWriter sw = new StreamWriter(crypstream);

            // Write the strText to the stream.
            sw.WriteLine(strText);

            // Close the StreamWriter and CryptoStream.
            sw.Close();
            crypstream.Close();

            // Get an array of bytes that represents the memory stream.
            byte[] buffer = ms.ToArray();

            // Close the memory stream.
            ms.Close();

            // Return the encrypted byte array.
            return buffer;
        }

        private static class Hash
        {
            public static string SHA1(string plaintext)
            {
                var sha = new SHA1Managed();
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                return Convert.ToBase64String(hash);
            }

            public static string SHA256(string plaintext)
            {
                var sha = new SHA256Managed();
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                return Convert.ToBase64String(hash);
            }

            public static string MD5(string plaintext)
            {
                var md5 = new MD5Cng();
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                return Convert.ToBase64String(hash);
            }
        }
    }
}