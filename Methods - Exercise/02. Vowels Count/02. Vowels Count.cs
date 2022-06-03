using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var result =PrintVowelsCount(text);
            Console.WriteLine(result);
        }

        static string PrintVowelsCount(string text) 
        {
            
            char[] charArray = text.ToCharArray();
            char[] vowelsArr = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            var vowelsCount = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < vowelsArr.Length; j++)
                {
                   
                    if (charArray[i] == vowelsArr[j])
                    {
                        vowelsCount++;
                    }
                }
            }
            return vowelsCount.ToString();
        }
    }
}
