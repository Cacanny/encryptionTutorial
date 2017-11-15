using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionScheme
{
    public class MD5Decrypter
    {
        public char[] charArray { get; set; }

        public MD5Decrypter()
        {
            FillArray();

            Console.Read();
        }

        public void FillArray()
        {
            charArray = new char[36];
            int index = 0;
            for (char c = 'a'; c <= 'z'; c++)
            {
                charArray[index++] = c;
            }

            index = 26;
            for (char c = '0'; c <= '9'; c++)
            {
                charArray[index++] = c;
            }

            foreach (char c in charArray)
            {
                Console.Write(c);
            }
        }

        public void BruteForce()
        {

        }
    }
}
