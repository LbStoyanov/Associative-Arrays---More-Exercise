using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            
            var outputList = new List<decimal>();   
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                var result = numbers[i] + numbers[numbers.Count - i - 1];
                outputList.Add(result);
                
            }

            if (numbers.Count % 2 == 1)
            {
                outputList.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(String.Join(" ",outputList));
        }
    }
}
