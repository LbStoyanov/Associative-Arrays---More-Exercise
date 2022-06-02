using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           

            var resultList = new List<int>();
            var rangeToPrint = new List<int>();
            
            


            var biggerList = 0;

            if (firstList.Count >= secondList.Count)
            {
                rangeToPrint.Add(firstList[firstList.Count - 1]);
                rangeToPrint.Add(firstList[firstList.Count - 2]);
                firstList.RemoveAt(firstList.Count - 1);
                firstList.RemoveAt(firstList.Count - 1);
                biggerList = firstList.Count;
                secondList.Reverse();
            }
            else
            {
                rangeToPrint.Add(secondList[0]);
                rangeToPrint.Add(secondList[1]);
                secondList.Reverse();
                secondList.RemoveAt(secondList.Count - 1);
                secondList.RemoveAt(secondList.Count - 1);
                biggerList = secondList.Count;
            }

            

            for (int i = 0; i < biggerList; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            var startRangeIndex = Math.Min(rangeToPrint[0], rangeToPrint[1]);
            var endRangeIndex = Math.Max(rangeToPrint[0], rangeToPrint[1]);
            
            var finalList = new List<int>();
            
            for (int i = 0; i < resultList.Count; i++)
            {
                var currentNum = resultList[i];

                if (currentNum > startRangeIndex && currentNum < endRangeIndex)
                {
                    finalList.Add(currentNum);
                }
            }

            finalList.Sort();
            Console.WriteLine(String.Join(" ",finalList));
        }
    }
}
