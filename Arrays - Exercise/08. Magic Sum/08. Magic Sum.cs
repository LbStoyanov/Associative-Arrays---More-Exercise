using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var magicNum = int.Parse(Console.ReadLine());
            var sum = 0;
            var magicCuples = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    else
                    {
                        sum += numbers[i] + numbers[j];
                        if (sum == magicNum)
                        {
                            magicCuples.Add(numbers[i]);
                            magicCuples.Add(numbers[j]);
                        }
                    }
                    sum = 0;
                }
                
            }
            var counter = 0;

            foreach (var item in magicCuples)
            {
                Console.Write(item + " ");
                counter++;
                if (counter == 2)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
            
        }
    }
}
