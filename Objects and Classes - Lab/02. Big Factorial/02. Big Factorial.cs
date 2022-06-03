using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class FactorialCalculator
    {
        public FactorialCalculator(int n)
        {
            numN = n;
        }

        public int numN { get; set; }

        public BigInteger Calculate()
        {
            BigInteger factorial = 1;

            for (int i = 2; i <= numN; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numN = int.Parse(Console.ReadLine());
            FactorialCalculator calculator = new FactorialCalculator(numN);

            Console.WriteLine(calculator.Calculate());
        }
    }

}
