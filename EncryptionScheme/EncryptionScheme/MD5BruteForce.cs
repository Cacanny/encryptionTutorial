using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionScheme
{
    public class MD5BruteForce
    {
        public char[] charArray { get; set; }

        public MD5BruteForce(string hash, int characterCount)
        {

            this.Hash = hash;
            this.CharacterCount = characterCount;
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
            Console.WriteLine("First Test");
            int k = this.CharacterCount;
            printAllKLength(charArray, k);
            Console.Read();
        }

        private void printAllKLength(char[] set, int k)
        {
            int n = set.Length;
            printAllKLengthRec(set, "", n, k);
        }

        private void printAllKLengthRec(char[] set, String prefix, int n, int k)
        {
            // Base case: k is 0, print prefix
            if (k == 0)
            {
                Console.WriteLine(prefix);
                string md5Hash = CreateMD5(prefix);
                Console.WriteLine(md5Hash);

                if (CompareHash(md5Hash))
                {
                    Console.WriteLine($"Your password has been found: {prefix}");
                    Console.ReadLine();
                    return;
                }
                return;
            }

            // One by one add all characters from set and recursively 
            // call for k equals to k-1
            for (int i = 0; i < n; ++i)
            {

                // Next character of input added
                string newPrefix = prefix + set[i];

                // k is decreased, because we have added a new character
                printAllKLengthRec(set, newPrefix, n, k - 1);
            }
        }

        private string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        private bool CompareHash(string hash)
        {
            if(hash == this.Hash)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public string Hash { get; set; }
        public int CharacterCount { get; set; }
    }
}
