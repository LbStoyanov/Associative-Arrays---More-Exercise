using System;
using System.Linq;
using System.Numerics;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstInteger = BigInteger.Parse(Console.ReadLine());
            BigInteger secondtInteger = BigInteger.Parse(Console.ReadLine());

            var firstNumFactorial = CalculateFactorial(firstInteger);
            var secondNumFactorial = CalculateFactorial(secondtInteger);

            var result = firstNumFactorial / secondNumFactorial;
            Console.WriteLine($"{result:f2}");
        }

        static BigInteger CalculateFactorial(BigInteger num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            
            return factorial;  
        }
    }
}
