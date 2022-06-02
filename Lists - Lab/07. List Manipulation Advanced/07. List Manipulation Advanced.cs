using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var changesCounter = 0;
            while (true)
            {
                var currentCommand = Console.ReadLine().Split().ToList();
                if (currentCommand[0] == "end")
                {
                    break;
                }
                if (currentCommand[0] == "Add")
                {
                    numbers.Add(int.Parse(currentCommand[1]));
                    changesCounter++;
                }
                else if (currentCommand[0] == "Remove")
                {
                    numbers.Remove(int.Parse(currentCommand[1]));
                    changesCounter++;
                }
                else if (currentCommand[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(currentCommand[1]));
                    changesCounter++;
                }
                else if (currentCommand[0] == "Insert")
                {
                    numbers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                    changesCounter++;
                }
                else if (currentCommand[0] == "Contains")
                {
                    
                    if (numbers.Contains(int.Parse(currentCommand[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    
                }
                else if (currentCommand[0] == "PrintEven")
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                    
                }
                else if (currentCommand[0] == "PrintOdd")
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 1)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                    
                }
                else if(currentCommand[0] == "GetSum")
                {
                    var sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (currentCommand[0] == "Filter")
                {
                    foreach (var item in numbers)
                    {
                        PrintNumberByGivenCondition(currentCommand[1],item,int.Parse(currentCommand[2]));
                    }
                    Console.WriteLine();
                }

            }
            if (changesCounter > 0)
            {
                Console.WriteLine(String.Join(" ",numbers));
            }
        }
        public static void PrintNumberByGivenCondition(string condition, int numberA, int numberB) 
        {
            if (condition == "<" && numberA < numberB)
            {
                Console.Write(numberA + " ");
            }
            else if (condition == ">" && numberA > numberB) 
            {
                Console.Write(numberA + " ");
            }
            else if(condition == ">=" && numberA >= numberB)
            {
                Console.Write(numberA + " ");
            }
            else if (condition == "<=" && numberA <= numberB)
            {
                Console.Write(numberA + " ");
            }
            
        }
    }
}
