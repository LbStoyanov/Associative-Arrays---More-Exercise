using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numA = int.Parse(Console.ReadLine());
            var numB = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = numA; i <= numB; i++)
            {
                sum += i;
                Console.Write(i +" ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
