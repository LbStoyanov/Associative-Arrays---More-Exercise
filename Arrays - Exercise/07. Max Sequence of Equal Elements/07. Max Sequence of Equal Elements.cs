using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var longestSeqLength = 1;
            var longestSeqStart = 0;
            var currentSeqLength = 1;
            var currentSeqStart = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSeqLength++;

                    if (currentSeqLength > longestSeqLength)
                    {
                        longestSeqLength = currentSeqLength;
                        longestSeqStart = currentSeqStart;
                    }
                }
                else
                {
                    currentSeqLength = 1;
                    currentSeqStart = i;
                }
            }

            for (int i = longestSeqStart; i < longestSeqStart + longestSeqLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
