using System;
using System.Collections.Generic;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var secondArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var commonElements = new List<string>();

            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = 0; j < secondArr.Length; j++)
                {
                    if (firstArr[i] != secondArr[j])
                    {
                        continue;
                    }
                    else
                    {
                        commonElements.Add(firstArr[i]);
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",commonElements));

        }
    }
}
