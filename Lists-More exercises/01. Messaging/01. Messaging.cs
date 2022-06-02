using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var text = Console.ReadLine().ToList();

            var numList = new List<char>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                var currentNum = numbersList[i];
                var sumOfDigitsOfCurrNum = CalculateSumOfDigits(currentNum);
                var indexForRemove = 0;
                for (int j = 1; j <= text.Count; j++)
                {
                    if (j  == text.Count)
                    {
                        j = 0;
                    }
                    sumOfDigitsOfCurrNum--;
                    if (sumOfDigitsOfCurrNum == 0)
                    {
                        indexForRemove = j;
                        var currentLetter = text[j];
                        numList.Add(currentLetter);
                        break;
                    }
                    
                }
                text.RemoveAt(indexForRemove);

            }

            Console.WriteLine(String.Join("", numList));
        }

        static int CalculateSumOfDigits(int num)
        {
            var sum = 0;
            var temp = num;
            while (temp != 0)
            {
                var currentDigit = temp % 10;
                sum += currentDigit;
                temp = temp / 10;
            }
            return sum;
        }
    }
}
