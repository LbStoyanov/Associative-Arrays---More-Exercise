using System;
using System.Collections.Generic;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int startSiqLengh = 0;
            int endSiqLengh = 0;

            List<char> printList = new List<char>();

            for (int i = 0; i < inputText.Length; i++)
            {
                char currChar = inputText[i];

                if (i + 1 > inputText.Length - 1)
                {
                    printList.Add(currChar);
                }
                else
                {
                    if (currChar == inputText[i + 1])
                    {
                        continue;
                    }
                    else
                    {
                        printList.Add(currChar);
                    }
                }
            }

            Console.WriteLine(string.Join("",printList));
        }
    }
}
