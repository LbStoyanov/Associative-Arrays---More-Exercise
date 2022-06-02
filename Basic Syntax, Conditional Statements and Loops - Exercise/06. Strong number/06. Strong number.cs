using System;
using System.Collections.Generic;

namespace _06._Strong_number
{
    class Program
    {
        public static int calculateFactorielOfTheNum(long n)
        {
            long fact = n;
            
            for (long i = n - 1; i >= 1; i--)
            {
                fact *= i;
            }
            
            return (int)fact;
        }
        static void Main(string[] args)
        {
            long num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("no");
                return;
            }
            var sum = 0;
            var currentNum = num;
            while (num > 0)
            {
                var factorialDigit = num % 10;
                if (factorialDigit == 0)
                {
                    factorialDigit = 1;
                }
                sum += calculateFactorielOfTheNum(factorialDigit);
                num /= 10;
            }

            if (sum == currentNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
