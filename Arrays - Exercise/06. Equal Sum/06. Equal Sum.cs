using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var leftSum = 0;
            var rightSum = 0;
            var indexCounter = 0;
            if (numbers.Length <= 1)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = numbers.Length - 1; j > i; j--)
                {
                    rightSum += numbers[j];
                }

                for (int j = 0  ; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                if (leftSum ==  rightSum)
                {
                    Console.WriteLine(i);
                    indexCounter++;
                }
                
                leftSum = 0;
                rightSum = 0;
            }

            if (indexCounter <= 0)
            {
                Console.WriteLine("no");
            }

        }
    }
}
