using System;
using System.Numerics;

namespace EncryptionScheme
{
    class Program
    {

        static void Main(string[] args)
        {

            // Static void function to start a RSA decryption;
            StartRSADecryption();

            // Static void function to start a decryption of a MD5 hash.
            StartMD5Decryption();
        }

        public static void StartRSADecryption()
        {
            // Variables to send to new rsaEncryptor variable
            int N = 267; // P * Q
            int e = 5;  // Prime number
            int c = 158; // The encrypted message

            // Make a new instance of the RsaEncryptor with the above variables
            RSADecryptor rsaDecryptor = new RSADecryptor(N, e, c);

            // Initialize a decryption of the message 
            rsaDecryptor.Initialize();
        }

        public static void StartMD5Decryption()
        {
            // Change hash to the hash you wanted decrypted 
            string hash = "a34feb63bb51d48ce8992cf0361f8121";

            // Preconfigured Hash above has to have the following result in order to succeed.
            string result = "windesheim";

            // Limit the characterCount so bruteforce don't take all day.
            int characterCount = result.Length;

            // Make a new instance of the MD5Encryptor
            MD5Decrypter mD5Decrypter = new MD5Decrypter(hash, characterCount);

            // Initialize of the MD5 decryption.
            mD5Decrypter.Initialize();

        }
    }
}
