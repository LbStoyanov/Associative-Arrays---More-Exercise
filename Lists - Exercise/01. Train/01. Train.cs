using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var maxCapacityOfWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                if (command[0] == "Add") 
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(command[0]) <= maxCapacityOfWagon)
                        {
                            wagons[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ",wagons));

        }
    }
}
