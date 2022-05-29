using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigInteger = BigInteger.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            BigInteger result = bigInteger * digit;
            Console.WriteLine(result);
        }
    }
}
