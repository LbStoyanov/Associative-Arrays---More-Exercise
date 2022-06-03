using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            
            var flag = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    flag = false;
                    continue;
                }
                else
                {
                    Console.Write(numbers[i] + " ");
                }
                
            }
        }
    }
}
