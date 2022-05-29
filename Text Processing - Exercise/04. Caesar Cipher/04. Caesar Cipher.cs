using System;
using System.Linq;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char newChar = 'P';
            //int nextChar = Convert.ToInt32(newChar + 3);
            //newChar = Convert.ToChar(nextChar);

            string input = Console.ReadLine();

            var charArr = input.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                var currentChar = charArr[i];
                int currentCharNumericValue = Convert.ToInt32(currentChar + 3);
                currentChar = Convert.ToChar(currentCharNumericValue);
                Console.Write(currentChar);
            }
        }
    }
}
