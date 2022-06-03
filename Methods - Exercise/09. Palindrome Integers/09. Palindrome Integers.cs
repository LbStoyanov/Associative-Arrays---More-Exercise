using System;


namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = string.Empty;

            while (command != "END")
            {
                var currentComand = Console.ReadLine();
                if (currentComand == "END")
                {
                    break;
                }
                var currentNum = int.Parse(currentComand);
                if (VerifyIfIsPalindromOrNot(currentNum))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

            }
        }

        static bool VerifyIfIsPalindromOrNot(int num)
        {
            var temp = num;
            var reversedNum = 0;
            var sum = 0;
            while (num > 0)
            {
                reversedNum = num % 10;
                sum = (sum * 10) + reversedNum;
                num = num / 10;
            }

            if (temp == sum)
                return true;
            else
                return false;

        }
        
    }
}
