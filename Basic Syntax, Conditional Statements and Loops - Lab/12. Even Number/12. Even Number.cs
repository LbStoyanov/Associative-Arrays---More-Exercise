using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (currentNum % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(currentNum)}");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
