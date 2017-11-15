using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace EncryptionScheme
{
    public class RsaDecryptor
    {

        public RsaDecryptor(int N, int e, int c)
        {
            this.N = N;
            this.c = c;
            this.e = e;
        }

        public void Initialize()
        {
            Console.WriteLine("### Starting RsaEncryption operation ### ");
            Console.WriteLine($"### Given variables are N = {N}, c = {c} and e = {e} ");
           
            Primes(this.N);
            CalculateD(this.e);
            BigInteger decryptedMessage = Decrypt();
            Console.WriteLine($"The decrypted message contains : {decryptedMessage}");
            Console.WriteLine("### End of RsaEncryption operation ###");
            Console.Read();
        }

        public void Primes(int N)
        {
            Console.WriteLine($"Calculating what P and Q are if N = {N}");

            foreach (int i in this.primesArray)
            {
                foreach (int j in this.primesArray)
                {
                    if (i * j == N)
                    {
                        this.p = i;
                        this.q = j;
                        Console.WriteLine($"P({this.p}) * Q ({this.q}) = N({this.N})");
                        return;
                    }
                }
            }

        }

        public void CalculateD(int e)
        {
            Console.WriteLine($"Calculating what 'D' is in the formula e * d mod (p-1)(q-1) = 1");
            int pqMinus1 = (this.p - 1) * (q - 1);

            for (int i = 1; i < 2000; i++)
            {
                if ((e * i) % pqMinus1 == 1)
                {
                    this.d = i;
                    Console.WriteLine($"The number 'd' is : {this.d}");
                    return;
                }
            }
        }

        public BigInteger Decrypt()
        {
            Console.WriteLine($"Decrypting the message of C = {this.c} with the values d = {this.d} and N = {this.N}");
            BigInteger cd = BigInteger.Pow(this.c, this.d);
       
            BigInteger decryptedMessage = cd % N;
            Console.WriteLine($"Result of the formula C^d mod N : {c} ^ {d} mod {N} = {decryptedMessage}");
            return decryptedMessage;

        }


        // Properties of the class
        public int N { get; set; }
        public int e { get; set; }

        public int c { get; set; }

        public int p { get; set; }

        public int q { get; set; }

        public int d { get; set; }

        // Array of the primesArray used for this assignment.
        public int[] primesArray { get; set; } = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

    }
}

