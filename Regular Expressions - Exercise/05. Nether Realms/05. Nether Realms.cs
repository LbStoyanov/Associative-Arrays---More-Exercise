using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demonsName = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            SortedDictionary<string, SortedDictionary<int, double>> deamonsList = new SortedDictionary< string,SortedDictionary<int, double>>();

            for (int i = 0; i < demonsName.Length; i++)
            {
                string currentDemon = demonsName[i];
                int demonsHealth = CalculateDemonsTotalHealth(currentDemon);
                string damagePattern = @"(?<damage>-?[0-9]\d*(\.\d+)?)";
                double demonsDamage = CalculateDemonsDamage(currentDemon, damagePattern);
                SortedDictionary<int, double> currDict = new SortedDictionary<int, double>();
                currDict.Add(demonsHealth, demonsDamage);
                deamonsList.Add(currentDemon,currDict);
            }

            foreach (var demon in deamonsList)
            {
                var secondDict = deamonsList[demon.Key];
                
                foreach (var item in secondDict)
                {
                    var name = demon.Key;
                    var health = item.Key;
                    var damage = item.Value;
                    Console.WriteLine($"{name} - {health} health, {damage:f2} damage");
                }

            }

        }
        static double CalculateDemonsDamage(string demonsName, string demonsDamage)
        {
            double damage = 0.0;

            MatchCollection matches = Regex.Matches(demonsName, demonsDamage);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    damage += double.Parse(match.Value);
                }
                
            }

            for (int i = 0; i < demonsName.Length; i++)
            {
                var currChar = demonsName[i];
                if (currChar == '*')
                {
                    damage *= 2.0;
                }
                if (currChar == '/')
                {
                    damage /= 2.0;
                }
            }
            
            
            return damage;
        }
        static int CalculateDemonsTotalHealth(string demonsName)
        {
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*', '/','.'};

            var sum = 0;
            //M 3ph-0.5s-0.5t0.0**
            bool isContain = false;

            for (int i = 0; i < demonsName.Length; i++)
            {
                char currentHelathPoints = demonsName[i];
                for (int j = 0; j < chars.Length; j++)
                {
                    var currChar = chars[j];
                    if (currChar == currentHelathPoints)
                    {
                        isContain = true;
                        break;
                    }
                }
                if (isContain)
                {
                    isContain = false;
                }
                else
                {
                    sum += currentHelathPoints;
                }
            }
            
            return sum;
        }
    }
}
