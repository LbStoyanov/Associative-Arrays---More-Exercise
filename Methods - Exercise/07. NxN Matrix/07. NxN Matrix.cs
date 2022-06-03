using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintNxNmatrix(n);
        }

        static void PrintNxNmatrix(int n) 
        {
            var filter = n;

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write($"{filter} ");
                }
                Console.WriteLine();
            }
        }
    }
}
