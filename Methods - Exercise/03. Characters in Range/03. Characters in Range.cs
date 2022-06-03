using System;
using System.Collections.Generic;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var charA = char.Parse(Console.ReadLine());
            var charB = char.Parse(Console.ReadLine());
            PrintAschiiCharacters(charA, charB);
        }

        static void PrintAschiiCharacters(char charA,char charB) 
        {
            var charALikeInt = Convert.ToInt32(charA);
            var charBLikeInt = Convert.ToInt32(charB);
            var end = Math.Max(charALikeInt, charBLikeInt) - 1;
            var start = Math.Min(charALikeInt, charBLikeInt) + 1;

            for (int i = start; i <= end; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
        
    }
}
