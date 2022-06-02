using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "end") 
                {
                    break;
                }
                if (command[0] == "Delete")
                {
                    numbers.RemoveAll((x => x == int.Parse(command[1])));
                }
                if (command[0] == "Insert") 
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
