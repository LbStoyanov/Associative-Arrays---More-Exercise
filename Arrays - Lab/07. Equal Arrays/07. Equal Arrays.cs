﻿using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var sum = 0;
            bool isIdentical = true;
            
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isIdentical = false;
                    break;
                }
                else
                {
                    sum += firstArr[i];
                }
            }
            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}
