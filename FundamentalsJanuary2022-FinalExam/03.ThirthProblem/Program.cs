using System;
using System.Collections.Generic;

namespace _03.ThirthProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animalsDict = new Dictionary<string, int>();
            var hungryAnimalsAreas = new Dictionary<string, int>();

            string command;

            while ((command = Console.ReadLine()) != "EndDay")
            {
                string[] actions = command.Split(new Char[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                string mainAction = actions[0];

                if (mainAction == "Add")
                {
                    string animalName = actions[1];
                    int neededFood = int.Parse(actions[2]);
                    string area = actions[3];


                    if (!animalsDict.ContainsKey(animalName) && !hungryAnimalsAreas.ContainsKey(area))
                    {
                        hungryAnimalsAreas.Add(area, neededFood);
                    }
                    else
                    {
                        if (!hungryAnimalsAreas.ContainsKey(area))
                        {
                            hungryAnimalsAreas.Add(area, 1);
                        }
                        else
                        {
                            hungryAnimalsAreas.Remove(area);
                        }
                    }
                    Add(animalsDict, animalName, neededFood);

                }
                else if (mainAction == "Feed")
                {
                    string animalName = actions[1];
                    int food = int.Parse(actions[2]);
                    
                    Feed(animalsDict, animalName, food);
                }
            }



            Console.WriteLine("Animals:");

            foreach (var item in animalsDict)
            {
                var currentName = item.Key;
                var currentQuantity = item.Value;
                Console.WriteLine($"{currentName} -> {currentQuantity}g");
            }

            Console.WriteLine("Areas with hungry animals:");

            foreach (var item in hungryAnimalsAreas)
            {
                var areaName = item.Key;
               
                var numberOfHungryAnimals = hungryAnimalsAreas.Count;
                

                Console.WriteLine($"{areaName}: {numberOfHungryAnimals}");
            }
        }
        static void Feed(Dictionary<string, int> animalsDict, string animalName, int food)
        {

            if (animalsDict.ContainsKey(animalName))
            {
                animalsDict[animalName] -= food;
                if (animalsDict[animalName] <= 0)
                {
                    Console.WriteLine($"{animalName} was successfully fed");
                    animalsDict.Remove(animalName);
                }
            }
        }
        static void Add(Dictionary<string, int> animalsDict, string animalName, int neededFood)
        {

            if (!animalsDict.ContainsKey(animalName))
            {
                animalsDict.Add(animalName, neededFood);
            }
            else
            {
                animalsDict[animalName] += neededFood;
            }
        }
    }
}
