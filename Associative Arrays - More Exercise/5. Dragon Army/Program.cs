using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Dragon_Army
{
    public class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Dragon> dragons = new List<Dragon>();
            Dictionary<string,List<Dragon>> dragons = new Dictionary<string,List<Dragon>>();

            int numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] currentDragonInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = currentDragonInformation[0];
                string name = currentDragonInformation[1];
                int damage = Damage(currentDragonInformation[2]);
                int health = Health(currentDragonInformation[3]);
                int armor = Armor(currentDragonInformation[4]);

                Dragon dragon = new Dragon(name,damage,health,armor);

                if(!dragons.ContainsKey(type))
                {
                    dragons.Add(type,new List<Dragon> { { dragon} });
                }
                else
                {
                    if(dragons[type].Any(x => x.Name == name))
                    {
                        var searchedDragon = dragons[type].FirstOrDefault(x => x.Name == name);

                        searchedDragon.Damage = damage;
                        searchedDragon.Health = health;
                        searchedDragon.Armor = armor;

                    }
                    else
                    {
                        dragons[type].Add(dragon);
                    }
                }
            }

            //Типът се запазва както в реда на въвеждане, но драконите са сортирани по азбучен ред по име;

            foreach (var dragon in dragons)
            {
                var dragonType = dragon.Key;

                var averageDamage = dragons[dragonType].Average(x => x.Damage);
                var averageHealth = dragons[dragonType].Average(x => x.Health);
                var averageArmor = dragons[dragonType].Average(x => x.Armor);

                Console.WriteLine($"{dragonType}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var item in dragons[dragonType].OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{item.Name} -> damage: {item.Damage}, health: {item.Health}, armor: {item.Armor}");
                }
            }

            
        }
        public static int Armor(string stat)
        {
            int result = 0;
            if (stat == "null")
            {
                result = 10;
            }
            else
            {
                result = int.Parse(stat);
            }

            return result;
        }
        public static int Health(string stat)
        {
            int result = 0;
            if (stat == "null")
            {
                result = 250;
            }
            else
            {
                result = int.Parse(stat);
            }

            return result;
        }
        public static int Damage(string stat)
        {
            int result = 0;
            if (stat == "null")
            {
                result = 45;
            }
            else
            {
                result = int.Parse(stat);
            }

            return result;
        }
    }
}
