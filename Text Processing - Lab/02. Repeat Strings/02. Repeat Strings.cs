using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringText = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < stringText.Length; i++)
            {
                string currentWord = stringText[i];   //work
                for (int j = 0; j < currentWord.Length; j++)
                {
                    Console.Write(currentWord);
                }
            }
        }
    }
}
