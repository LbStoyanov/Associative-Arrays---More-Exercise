using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initialEnergy = int.Parse(Console.ReadLine());

            var wonBattlesCounter = 0;
            

            while (true)
            {
                var currentComand = Console.ReadLine();

                if (currentComand == "End of battle")  
                {
                    break;
                }

                var distanceToReachTheEnemy = int.Parse(currentComand);
                var requeredEnergyToReachTheEnemy = distanceToReachTheEnemy;

                if (initialEnergy < requeredEnergyToReachTheEnemy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattlesCounter} won battles and {initialEnergy} energy");
                    return;
                }
                else
                {
                    initialEnergy -= requeredEnergyToReachTheEnemy;
                    wonBattlesCounter++;
                    if (wonBattlesCounter % 3 == 0)
                    {
                        initialEnergy += wonBattlesCounter;
                    }
                }
            }

            Console.WriteLine($"Won battles: {wonBattlesCounter}. Energy left: {initialEnergy}");
        }
    }
}
