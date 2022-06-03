using System;
using System.Collections.Generic;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firsArr = new List<string>();
            var secondArr = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var currentNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (i % 2 == 0)
                {
                    firsArr.Add(currentNums[1]);
                    secondArr.Add(currentNums[0]);
                }
                else
                {
                    firsArr.Add(currentNums[0]);
                    secondArr.Add(currentNums[1]);
                }
                
            }

            Console.WriteLine(string.Join(" ",secondArr));
            Console.WriteLine(string.Join(" ",firsArr));
        }
    }
}
