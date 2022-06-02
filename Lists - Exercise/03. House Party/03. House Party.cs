using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfComands = int.Parse(Console.ReadLine());

            var guestList = new List<string>();

            for (int i = 0; i < numberOfComands; i++)
            {
                var command = Console.ReadLine().Split().ToArray();
                
                if (command[2] == "going!")
                {
                    if (guestList.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(command[0]);
                    }
                }
                else if (command[2] == "not") 
                {
                    if (guestList.Contains(command[0]))
                    {
                        guestList.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            foreach (var name in guestList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
