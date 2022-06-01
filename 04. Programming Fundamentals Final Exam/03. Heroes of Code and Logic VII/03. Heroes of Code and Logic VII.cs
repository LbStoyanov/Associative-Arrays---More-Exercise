using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            var heroesCapabilitiesDict = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] currentHeroeInfo = Console.ReadLine().Split(" ");
                string heroesName = currentHeroeInfo[0];
                int hitPoints = int.Parse(currentHeroeInfo[1]);
                int manaPoints = int.Parse(currentHeroeInfo[2]);

                List<int> hitAndManaPoints = new List<int>();
                hitAndManaPoints.Add(hitPoints);
                hitAndManaPoints.Add(manaPoints);
                heroesCapabilitiesDict.Add(heroesName, hitAndManaPoints);
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] actions = commands.Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                string mainAction = actions[0];

                if (mainAction == "CastSpell")
                {
                    string heroeName = actions[1];
                    int manaPointsNeeded = int.Parse(actions[2]);
                    string spellName = actions[3];
                    heroesCapabilitiesDict = CastSpell(heroesCapabilitiesDict, heroeName, manaPointsNeeded, spellName);
                }
                else if (mainAction == "TakeDamage")
                {
                    string heroeName = actions[1];
                    int damage = int.Parse(actions[2]);
                    string attacker = actions[3];
                    heroesCapabilitiesDict = TakeDamage(heroesCapabilitiesDict,heroeName,damage, attacker);
                }
                else if (mainAction == "Recharge")
                {
                    string heroeName = actions[1];
                    int amount = int.Parse(actions[2]);
                    heroesCapabilitiesDict = Recharge(heroesCapabilitiesDict, heroeName, amount);
                }
                else
                {
                    string heroeName = actions[1];
                    int amount = int.Parse(actions[2]);
                    heroesCapabilitiesDict = Heal(heroesCapabilitiesDict, heroeName, amount);
                }

                commands = Console.ReadLine();
            }

            foreach (var heroe in heroesCapabilitiesDict)
            {
                string name = heroe.Key;
                int hitPoints = heroesCapabilitiesDict[name][0];
                int manaPoints = heroesCapabilitiesDict[name][1];

                Console.WriteLine(name);
                Console.WriteLine($"  HP: {hitPoints}");
                Console.WriteLine($"  MP: {manaPoints}");
            }
        }
        static Dictionary<string, List<int>> Heal(Dictionary<string, List<int>> heroesCatalog, string heroeName, int amount)
        {
            if (heroesCatalog[heroeName][0] + amount > 100)
            {
                int rechargedAmount = 100 - heroesCatalog[heroeName][0];
                Console.WriteLine($"{heroeName} healed for {rechargedAmount} HP!");
                heroesCatalog[heroeName][0] = 100;
                
            }
            else
            {
                Console.WriteLine($"{heroeName} healed for {amount} HP!");
                heroesCatalog[heroeName][0] += amount;
            }
            ;
            return heroesCatalog;
        }
        static Dictionary<string, List<int>> Recharge(Dictionary<string, List<int>> heroesCatalog, string heroeName, int amount)
        {
            int currentManaPoints = heroesCatalog[heroeName][1];

            if (currentManaPoints + amount > 200)
            {
                int rechargedAmount = 200 - currentManaPoints;
                Console.WriteLine($"{heroeName} recharged for {rechargedAmount} MP!");

                heroesCatalog[heroeName][1] = 200;
            }
            else
            {
                Console.WriteLine($"{heroeName} recharged for {amount} MP!");
                heroesCatalog[heroeName][1] += amount;
            }
            
            return heroesCatalog;
        }
        static Dictionary<string, List<int>> TakeDamage(Dictionary<string, List<int>> heroesCatalog, string heroeName, int damage, string attacker)
        {
            heroesCatalog[heroeName][0] -= damage;
            if (heroesCatalog[heroeName][0] > 0)
            {
                Console.WriteLine($"{heroeName} was hit for {damage} HP by {attacker} and now has {heroesCatalog[heroeName][0]} HP left!");
            }
            else
            {
                Console.WriteLine($"{heroeName} has been killed by {attacker}!");
                heroesCatalog.Remove(heroeName);
            }
            return heroesCatalog;
        }
        static Dictionary<string, List<int>> CastSpell(Dictionary<string, List<int>> heroesCatalog, string heroeName, int manaPointsNeeded, string spellName)
        {
            int heroesCurrentManaPoints = heroesCatalog[heroeName][1];

            if (heroesCurrentManaPoints >= manaPointsNeeded)
            {
                heroesCurrentManaPoints -= manaPointsNeeded;
                Console.WriteLine($"{heroeName} has successfully cast {spellName} and now has {heroesCurrentManaPoints} MP!");
                heroesCatalog[heroeName][1] -= manaPointsNeeded;
            }
            else
            {
                Console.WriteLine($"{heroeName} does not have enough MP to cast {spellName}!");
            }
            return heroesCatalog;
        }
    }
}
