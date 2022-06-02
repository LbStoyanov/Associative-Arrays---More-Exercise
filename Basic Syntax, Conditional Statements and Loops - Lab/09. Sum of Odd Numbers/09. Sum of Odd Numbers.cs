using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var oddSum = 0;
            var oddNumCounter = number;

            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += i;
                    oddNumCounter--;
                    Console.WriteLine(i);
                }
                if (oddNumCounter == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {oddSum}");
        }
    }
}
