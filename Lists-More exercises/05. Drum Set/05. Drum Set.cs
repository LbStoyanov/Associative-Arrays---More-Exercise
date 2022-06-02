using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var savedMoney = decimal.Parse(Console.ReadLine());
            var initialQualityOfTheDrums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var clonedInitialQualityList = new List<int>(initialQualityOfTheDrums);

            while (true)
            {
                var currentComand = Console.ReadLine();
                if (currentComand == "Hit it again, Gabsy!") 
                {
                    break;
                }

                var currentHitPower = int.Parse(currentComand);

                for (int i = 0; i < initialQualityOfTheDrums.Count; i++)
                {
                    var currentQuality = initialQualityOfTheDrums[i];

                    if(currentQuality - currentHitPower <= 0)
                    {
                        var drumPrice = clonedInitialQualityList[i];
                        var replacedQuality = clonedInitialQualityList[i];

                        if (CalculateExpenses(savedMoney,drumPrice))
                        {
                            savedMoney -= drumPrice * 3;
                            initialQualityOfTheDrums[i] = replacedQuality;
                        }
                        else
                        {
                            initialQualityOfTheDrums.RemoveAt(i);
                            clonedInitialQualityList.RemoveAt(i);
                            i--;
                        }
                    }
                    else
                    {
                        initialQualityOfTheDrums[i] -= currentHitPower;
                    }
                }

            }

            Console.WriteLine(String.Join(" ",initialQualityOfTheDrums));
            Console.WriteLine($"Gabsy has {savedMoney:f2}lv.");
        }
        static bool CalculateExpenses(decimal savedMoney, int drumsQuality) 
        {
            var costFormula = drumsQuality * 3;

            if (savedMoney >= costFormula)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
