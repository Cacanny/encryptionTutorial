using System;
using System.Numerics;

namespace EncryptionScheme
{
    class Program
    {

        static void Main(string[] args)
        {

            // Static void function to start the RSA decryption;
            StartRSADecryption();

        }

        public static void StartRSADecryption()
        {
            // Variables to send to new rsaEncryptor variable
            int N = 267; // P * Q
            int e = 5;  // Prime number
            int c = 158; // The encrypted message

            // Make a new instance of the RsaEncryptor with the above variables
            RsaDecryptor rsaDecryptor = new RsaDecryptor(N, e, c);

            // Initialize a decryption of the message 
            rsaDecryptor.RsaDecryption();
        }
    }
}
