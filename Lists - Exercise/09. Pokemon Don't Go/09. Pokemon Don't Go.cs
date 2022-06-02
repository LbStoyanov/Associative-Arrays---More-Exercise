using System;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var distanceToPokemon = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            //var elementsCount = distanceToPokemon.Count;
            var sumOfTheElements = 0;
            while (distanceToPokemon.Count != 0)
            {
                //Получаваш индекс, който да търсиш в колекцията.
                var currentIndex = int.Parse(Console.ReadLine());

                for (int i = 0; i < distanceToPokemon.Count; i++)
                {
                    if (currentIndex == i)
                    {
                        var valueOfTheRemovedElement = distanceToPokemon[i];
                        sumOfTheElements += valueOfTheRemovedElement;
                        distanceToPokemon.RemoveAt(i);
                        for (int j = 0; j < distanceToPokemon.Count; j++)
                        {
                            if (distanceToPokemon[j] <= valueOfTheRemovedElement)
                            {
                                distanceToPokemon[j] += valueOfTheRemovedElement;
                            }
                            else
                            {
                                distanceToPokemon[j] -= valueOfTheRemovedElement;
                            }
                        }
                        break;
                    }
                    else if (currentIndex < 0)
                    {
                        var valueOfTheRemovedElement = distanceToPokemon[0];
                        sumOfTheElements += valueOfTheRemovedElement;
                        distanceToPokemon.RemoveAt(0);
                        distanceToPokemon.Insert(0, distanceToPokemon[distanceToPokemon.Count - 1]);
                        for (int j = 0; j < distanceToPokemon.Count; j++)
                        {
                            if (distanceToPokemon[j] <= valueOfTheRemovedElement)
                            {
                                distanceToPokemon[j] += valueOfTheRemovedElement;
                            }
                            else
                            {
                                distanceToPokemon[j] -= valueOfTheRemovedElement;
                            }
                        }
                        break;
                    }
                    else if (currentIndex > distanceToPokemon.Count - 1) 
                    {

                        var lastElement = distanceToPokemon.Count - 1;
                        var valueOfTheRemovedElement = distanceToPokemon[distanceToPokemon.Count - 1];
                        sumOfTheElements += valueOfTheRemovedElement;
                        distanceToPokemon.RemoveAt(lastElement);
                        distanceToPokemon.Add(distanceToPokemon[0]);
                        for (int j = 0; j < distanceToPokemon.Count; j++)
                        {
                            if (distanceToPokemon[j] <= valueOfTheRemovedElement)
                            {
                                distanceToPokemon[j] += valueOfTheRemovedElement;
                            }
                            else
                            {
                                distanceToPokemon[j] -= valueOfTheRemovedElement;
                            }
                        }
                        break;
                    }       
                }
            }

            Console.WriteLine(sumOfTheElements);
        }
    }
}
