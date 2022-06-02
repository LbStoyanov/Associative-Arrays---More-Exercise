using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintTriangle(n);

        }

        public static void PrintTriangle(int n) 
        {
            for (int col = 1; col <= n; col++)
            {
                for (int row = 1; row <= col; row++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }

            for (int col = n - 1; col >= 1; col--)
            {
                for (int row = 1; row <= col; row++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
