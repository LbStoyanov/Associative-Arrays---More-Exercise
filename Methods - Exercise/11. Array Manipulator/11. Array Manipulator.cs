using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var command = Console.ReadLine();

            while (command != "end")
            {
                var currentCmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (currentCmd[0] == "exchange")
                {
                    var index = int.Parse(currentCmd[1]);
                    var exchange = SplitListAndExchangeIndex(integers, index);
                    integers = exchange;
                }
                else if (currentCmd[0] == "max")
                {
                    var cmd = currentCmd[1];
                    PrintMaxEvenOrOddIndex(integers, cmd);
                }
                else if (currentCmd[0] == "min")
                {
                    var cmd = currentCmd[1];
                    PrintMinEvenOrOddIndex(integers, cmd);
                }
                else if (currentCmd[0] == "first")
                {
                    var cmd = currentCmd[2];
                    var count = int.Parse(currentCmd[1]);
                    PrintFirstNOddOrEvenElements(integers, cmd, count);
                }
                else if (currentCmd[0] == "last")
                {
                    var cmd = currentCmd[2];
                    var count = int.Parse(currentCmd[1]);
                    PrintLastNOddOrEvenElements(integers, cmd, count);
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", integers)}]");
        }

        static void PrintLastNOddOrEvenElements(List<int> integers, string command, int count)
        {
            if (count > integers.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var listWithValuesToBePrinted = new List<int>();

            for (int i = integers.Count - 1; i >= 0; i--)
            {
                if (command == "even")
                {
                    if (integers[i] % 2 == 0)
                    {
                        listWithValuesToBePrinted.Add(integers[i]);
                        count--;
                    }
                    if (count == 0)
                    {
                        break;
                    }
                }
                else if (command == "odd")
                {
                    if (integers[i] % 2 == 1)
                    {
                        listWithValuesToBePrinted.Add(integers[i]);
                        count--;
                    }
                    if (count == 0)
                    {
                        break;
                    }
                }
            }
            if (listWithValuesToBePrinted.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", listWithValuesToBePrinted)}]");
            }
        }
        static void PrintFirstNOddOrEvenElements(List<int> integers, string command, int count)
        {
            if (count > integers.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var listWithValuesToBePrinted = new List<int>();

            for (int i = 0; i < integers.Count; i++)
            {
                if (command == "even")
                {
                    if (integers[i] % 2 == 0)
                    {
                        listWithValuesToBePrinted.Add(integers[i]);
                        count--;
                    }
                    if (count == 0)
                    {
                        break;
                    }
                }
                else if (command == "odd")
                {
                    if (integers[i] % 2 == 1)
                    {
                        listWithValuesToBePrinted.Add(integers[i]);
                        count--;
                    }
                    if (count == 0)
                    {
                        break;
                    }
                }
            }
            if (listWithValuesToBePrinted.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", listWithValuesToBePrinted)}]");
            }
        }
        static void PrintMaxEvenOrOddIndex(List<int> integers, string command)
        {
            var result = 0;
            if (command == "even")
            {
                var indexToBePrinted = 0;
                var maxEven = int.MinValue;
                for (int index = 0; index < integers.Count; index++)
                {
                    if (integers[index] % 2 == 0 && integers[index] >= maxEven)
                    {
                        maxEven = integers[index];
                        indexToBePrinted = index;
                    }
                }
                if (maxEven == int.MaxValue)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                result = indexToBePrinted;
            }
            else if (command == "odd")
            {
                var maxOdd = int.MinValue;
                var indexToReturn = 0;
                for (int index = 0; index < integers.Count; index++)
                {
                    if (integers[index] % 2 == 1 && integers[index] >= maxOdd)
                    {
                        maxOdd = integers[index];
                        indexToReturn = index;
                    }
                }
                if (maxOdd == int.MinValue)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                result = indexToReturn;
            }
            Console.WriteLine(result);
        }

        static void PrintMinEvenOrOddIndex(List<int> integers, string command)
        {
            var result = 0;
            if (command == "even")
            {
                var minEven = int.MaxValue;
                for (int index = 0; index < integers.Count; index++)
                {
                    if (integers[index] % 2 == 0 && integers[index] <= minEven)
                    {
                        minEven = index;
                    }
                }
                if (minEven == int.MaxValue)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                result = minEven;
            }
            else if (command == "odd")
            {
                var maxOdd = int.MinValue;
                var indexToReturn = 0;
                for (int index = 0; index < integers.Count; index++)
                {
                    if (integers[index] % 2 == 1 && integers[index] >= maxOdd)
                    {
                        maxOdd = integers[index];
                        indexToReturn = index;
                    }
                }
                if (maxOdd == int.MinValue)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                result = indexToReturn;
            }
            Console.WriteLine(result);
        }

        static List<int> SplitListAndExchangeIndex(List<int> integers, int index)
        {
            var exchangedList = new List<int>();

            if (index < 0 || index > integers.Count - 1)
            {
                Console.WriteLine("Invalid index");
                return integers;
            }
            var indexForInsert = 0;
            var startIndex = 0;
            for (int i = 0; i < integers.Count; i++)
            {
                exchangedList.Add(integers[i]);
                if (i == index)
                {
                    startIndex = i + 1;
                    break;
                }
            }

            for (int i = startIndex; i < integers.Count; i++)
            {
                exchangedList.Insert(indexForInsert, integers[i]);
                indexForInsert++;
            }
            integers = exchangedList;
            return integers;
        }
    }


}

