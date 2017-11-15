using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionScheme
{
    public class MD5Decrypter
    {
        public char[] charArray { get; set; }

        public MD5Decrypter(string hash, int hashLength)
        {

            this.Hash = hash;
            this.HashLength = hashLength;
            FillArray();
        }

        private void FillArray()
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
        }

        public void Initialize()
        {
            StartPerm(charArray);
        }

        private void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }
    
        private void StartPerm(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.WriteLine(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        public string Hash { get; set; }
        public int HashLength { get; set; }
    }
}
