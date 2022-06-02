using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Take_SkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<int> numList = new List<int>();
            List<char> nonNumList = new List<char>();

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    numList.Add((int)char.GetNumericValue(symbol));
                }
                else
                {
                    nonNumList.Add(symbol);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numList[i]);
                }
                else
                {
                    skipList.Add(numList[i]);
                }
            }

            //StringBuilder decodedMessage = new StringBuilder();
            var decodedMessage = new List<char>();
            //var skipSum = 0;

            //var lenght = nonNumList.Count;
            int indexToRemove = 0;
            while (nonNumList.Count > 0)
            {
                var takeCount = takeList[indexToRemove];
                var skipCount = skipList[indexToRemove];
                var takeResult = nonNumList.Take(takeCount);

                foreach (char item in takeResult)
                {
                    decodedMessage.Add(item);
                }

                if (skipCount + takeCount > nonNumList.Count - 1)
                {
                    var rangeToRemove = nonNumList.Count;
                    nonNumList.RemoveRange(0, rangeToRemove);
                    break;
                }
                nonNumList.RemoveRange(0, skipCount);
                nonNumList.RemoveRange(0,takeCount);
                indexToRemove++;

                if (indexToRemove == takeList.Count)
                {
                    break;
                }
            }

            Console.WriteLine(String.Join("",decodedMessage));
        }
    }
}
