using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            var outputList = new List<decimal>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    outputList.Add(numbers[i]);
                }
                else
                {
                    continue;
                }
            }
            if (outputList.Count == 0)
            {
                Console.WriteLine("empty");
                Environment.ExitCode = 0;
            }
            outputList.Reverse();
            Console.WriteLine(String.Join(" ",outputList));
        }
    }
}
