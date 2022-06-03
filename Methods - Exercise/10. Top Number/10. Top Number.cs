using System;
using System.Linq;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var endNum = Console.ReadLine();
            var counter = int.Parse(endNum);

            for (int i = 1; i < counter; i++)
            {
                if (CalculateIfSumOfDigitsIsDivisibleByEight(i.ToString()) && VerifyForOddDigit(i.ToString()))
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool CalculateIfSumOfDigitsIsDivisibleByEight(string num)
        {
            
            var numArr = num.ToCharArray();
            var sum = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                if (char.IsDigit(numArr[i]))
                {
                    sum += Convert.ToInt32(numArr[i] - 48);
                }
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;   
            }

        }
        static bool VerifyForOddDigit(string num)
        {
            var numArr = num.ToCharArray();
            var oddCounter = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                if (char.IsDigit(numArr[i]))
                {
                    var digit = Convert.ToInt32(numArr[i] - 48);
                    if (digit % 2 == 1)
                    {
                        oddCounter++;
                    }
                }
            }

            if (oddCounter == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
