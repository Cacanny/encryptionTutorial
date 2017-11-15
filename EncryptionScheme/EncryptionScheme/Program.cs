using System;

namespace EncryptionScheme
{
    class Program
    {
        public static int[] primesArray = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        static void Main(string[] args)
        {
            RsaEncryption(267, 5, 158);
        }


        public static void RsaEncryption(int N, int e, int c)
        {
            int[] pq = Primes(N);
            foreach(int i in pq)
            {
                Console.WriteLine(i);

            }
            Console.Read();
        }

        public static int[] Primes(int N)
        {
            int[] pq = new int[2];

            foreach(int i in primesArray)
            {
                foreach(int j in primesArray)
                {
                    if(i*j == N)
                    {
                        pq[0] = i;
                        pq[1] = j;
                        break;
                    }
                }
            }

            return pq;
        }
    }
}
