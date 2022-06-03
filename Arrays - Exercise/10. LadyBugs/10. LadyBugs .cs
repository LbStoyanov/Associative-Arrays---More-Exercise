using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var initialIndexes = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
           

            var emtyField = new bool[fieldSize];
            var fullField = LocateLadyBugsOnTheField(emtyField, initialIndexes);
            var command = string.Empty;
            command = Console.ReadLine();

            while (command != "end")
            {
                var currentSteps = command.Split().ToArray();
                var ladybugIndex = int.Parse(currentSteps[0]);
                var direction = currentSteps[1];
                var flyLength = int.Parse(currentSteps[2]);

                if (ladybugIndex < 0 || ladybugIndex > fullField.Length - 1)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (flyLength < 0)
                {
                    direction = direction == "right" ? "left" : "right";
                    flyLength = -flyLength;
                }

                if (direction == "right")
                {
                    ApplyCommandRight(fullField, ladybugIndex, flyLength);
                }
                else if (direction == "left")
                {
                    ApplyComandLeft(fullField, ladybugIndex, flyLength);
                }
                command = Console.ReadLine();
            }

            PrintResult(fullField);
        }

        public static void PrintResult(bool[] fullField)
        {
            foreach (bool cell in fullField)
            {
                if (cell == true)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
        }

        static bool[] ApplyComandLeft(bool[] field, int ladybugIndex, int flyLength)
        {
            if (ladybugIndex - flyLength < 0)
            {
                field[ladybugIndex] = false;
            }
            else
            {
                if (field[ladybugIndex - flyLength] == false)
                {
                    field[ladybugIndex] = false;
                    field[ladybugIndex - flyLength] = true;
                }
                else
                {
                    var isFlightDone = false;
                    var startIndex = ladybugIndex - flyLength;
                    for (int k = startIndex; k > 0; k--)
                    {
                        if (field[k] == false)
                        {
                            field[ladybugIndex] = false;
                            field[k] = true;
                            isFlightDone = true;
                            break;
                        }
                    }
                    if (!isFlightDone)
                    {
                        field[ladybugIndex] = false;
                    }
                }
            }
            return field;
        }

        static bool[] ApplyCommandRight(bool[] field, int ladybugIndex, int flyLength)
        {
            if (ladybugIndex + flyLength > field.Length - 1)
            {
                field[ladybugIndex] = false;
            }
            else
            {
                if (field[ladybugIndex + flyLength] == false)
                {
                    field[ladybugIndex] = false;
                    field[ladybugIndex + flyLength] = true;
                }
                else
                {
                    bool flag = false;
                    var startIndex = ladybugIndex + flyLength;
                    for (int k = startIndex; k < field.Length; k++)
                    {
                        if (field[k] == false)
                        {
                            field[k] = true;
                            field[ladybugIndex] = false;
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        field[ladybugIndex] = false;
                    }
                }
            }
            return field;
        }
        static bool[] LocateLadyBugsOnTheField(bool[] field, List<int> ladyBugsPosition)
        {
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < ladyBugsPosition.Count; j++)
                {
                    if (i == ladyBugsPosition[j])
                    {
                        field[i] = true;
                    }
                }
            }
            return field;
        }
    }
}


