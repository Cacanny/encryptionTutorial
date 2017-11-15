using System;

namespace EncryptionScheme
{
    class Program
    {
        public static int[] primesArray = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        public static int p;
        public static int q;
        public static int d;
        public static int N = 267;
        public static int e = 5;
        public static int c = 158;

        static void Main(string[] args)
        {
            
            RsaEncryption();
        }


        public static void RsaEncryption()
        {
            Primes(N);
            CalculateD(e);
            double message = Decrypt();
            //Console.WriteLine(message.ToString());
            Console.Read();
        }

        public static void Primes(int N)
        {
            foreach(int i in primesArray)
            {
                foreach(int j in primesArray)
                {
                    if(i*j == N)
                    {
                        p = i;
                        q = j;
                        break;
                    }
                }
            }

        }

        public static void CalculateD(int e)
        {
            int pqMinus1 = (p - 1) * (q - 1);

            for(int i=1; i<2000; i++)
            {
                if((e*i) % pqMinus1 == 1)
                {
                    d = i;
                    Console.WriteLine("D: " + d);
                    return;
                }
            }
        }

        public static double Decrypt()
        {
            Console.WriteLine("Decrypt");
            double message = Math.Pow(c, d);
            Console.WriteLine(message);
        
            double result = message % N;
            Console.WriteLine(result);
            return message;

            
        }
    }
}
