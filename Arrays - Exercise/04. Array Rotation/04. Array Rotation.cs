using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var nums = Console.ReadLine().Split().ToList();
            var rotationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationsCount; i++)
            {
                nums.Add(nums[0]);
                nums.Remove(nums[0]);
            }

            Console.WriteLine(string.Join(" ", nums));
            //    var result = new int[numbers.Length];

            //    if (rotationsCount <= 0)
            //    {
            //        Console.WriteLine(string.Join(" ", numbers));
            //        return;
            //    }

            //    for (int i = 0; i < rotationsCount; i++)
            //    {
            //        var currentArray = new int[numbers.Length];
            //        var firstIndex = numbers[0];
            //        for (int j = 0; j < numbers.Length; j++)
            //        {
            //            if (j == numbers.Length - 1)
            //            {
            //                currentArray[currentArray.Length - 1] = firstIndex;
            //                result.Append(firstIndex);
            //                numbers = currentArray;
            //                break;
            //            }
            //            currentArray[j] = numbers[j + 1];
            //            result.Append(currentArray[j]);
            //        }
            //        result = currentArray;
            //    }

            //    Console.WriteLine(string.Join(" ",result));
        }
    }
}
