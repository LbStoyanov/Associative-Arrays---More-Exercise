using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            
            var evenSum = GetSumOfEvenDigits(number);
            var oddSum = GetSumOfOddDigits(number);
            var result = GetMultipleOfEvenAndOdds(evenSum, oddSum);

            Console.WriteLine(result);

        }
        private static int GetSumOfEvenDigits(int number)
        {
            var sum = 0;
            var absValue = 0;
            var temp = 0;
            if (number < 0)
            {
                absValue = Math.Abs(number);
                temp = absValue;
                number = temp;
            }
            else 
            {
                temp = number;
            }
            while (number > 0)
            {
                
                temp = number % 10;
                if (number % 2 == 0)
                {
                    sum += temp;
                }
                temp = number /= 10;
            }
            return sum;
        }
        private static int GetSumOfOddDigits(int number)
        {
            var sum = 0;
            var absValue = 0;
            var temp = 0;
            if (number < 0)
            {
                absValue = Math.Abs(number);
                temp = absValue;
                number = temp;
            }
            else
            {
                temp = number;
            }

            while (number > 0)
            {
                
                temp = number % 10;
                if (number % 2 == 1)
                {
                    sum += temp;
                }
                temp = number /= 10;
            }

            return sum;
        }
        private static int GetMultipleOfEvenAndOdds(int even, int odd)
        {
            var result = even * odd;
            return result;
        }
    }
}
