using System;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                var currentInput = Console.ReadLine();
                if (currentInput == "End") 
                {
                    break;
                }
                var currentCommand = currentInput.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                if (currentCommand[0] == "Shoot")
                {
                    var index = int.Parse(currentCommand[1]);
                    var power = int.Parse(currentCommand[2]);

                    if (index < 0 || index > targets.Count - 1)
                    {
                        continue;
                    }

                    if (targets[index] <= 0)
                    {
                        targets.RemoveAt(index);
                    }
                    else
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }

                }
                else if(currentCommand[0] == "Add")
                {
                    var index = int.Parse(currentCommand[1]);
                    var value = int.Parse(currentCommand[2]);
                    if (index < 0 || index > targets.Count - 1) 
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                    else
                    {
                        targets.Insert(index, value);
                    }
                }
                else if (currentCommand[0] == "Strike")
                {
                    var index = int.Parse(currentCommand[1]);
                    var radius = int.Parse(currentCommand[2]);
                    

                    if ((index - radius) < 0 || (index + radius) > targets.Count - 1)
                    {
                        Console.WriteLine($"Strike missed!");
                        continue;
                    }
                    else
                    {
                        var startIndexToBeShot = index - radius;
                        var countOfTargetsToBeshot = (radius * 2) + 1;  
                        targets.RemoveRange(startIndexToBeShot,countOfTargetsToBeshot);
                    }
                }
            }

            Console.WriteLine(string.Join("|",targets));
        }
    }
}
