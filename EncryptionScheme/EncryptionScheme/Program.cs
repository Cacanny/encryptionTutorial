using System;

namespace EncryptionScheme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables for the RSA encryption bruteforce operation.
            int N = 267;
            int c = 158;
            int e = 5;

            BruteForceRsaEncryption(N, c, e);
        }


        public static void BruteForceRsaEncryption(int N, int e, int c)
        {
            Console.WriteLine("################################################################");
            Console.WriteLine(" Waiting ...");
            Console.WriteLine("################################################################");
            Console.Read();

            // calculate d. 

        }

        public static int[] ReturnPrime(int N)
        {
            int p;
            int q;

           int[] arrayWithPandQ = new int[10];

            return arrayWithPandQ;
        }

    }
}
