using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> firstList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            List<decimal> secondList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            int biggerListCount = firstList.Count;
            if (biggerListCount < secondList.Count)
            {
                biggerListCount = secondList.Count;
            }

            var outputList = new List<decimal>();

            for (int i = 0; i < biggerListCount; i++)
            {
                if (firstList.Count > i)
                {
                    outputList.Add(firstList[i]);
                }
                if (secondList.Count > i)
                {
                    outputList.Add(secondList[i]);
                }
            }

            Console.WriteLine(String.Join(" ",outputList));
        }
    }
}
