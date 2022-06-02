using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lostGamesCount = int.Parse(Console.ReadLine());
            var headsetPrice = decimal.Parse(Console.ReadLine());
            var mousePrice = decimal.Parse(Console.ReadLine());
            var keyboardPrice = decimal.Parse(Console.ReadLine());
            var displayPrice = decimal.Parse(Console.ReadLine());

            var trushedHeadsets = 0;
            var trushedMouses = 0;
            var trushedKeyboards = 0;
            var trushedDisplays = 0;

            var trushedDisplayCounter = 0;
            var trushedKeyboardCounter = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                var trushedHeadsetCounter = 0;
                var trushedMouseCounter = 0;
                
                
                if (i % 2 == 0)
                {
                    trushedHeadsets++;
                    trushedHeadsetCounter++;
                }
                if (i % 3 == 0)
                {
                    trushedMouses++;
                    trushedMouseCounter++;
                    if (trushedHeadsetCounter == trushedMouseCounter)
                    {
                        trushedKeyboards++;
                        trushedKeyboardCounter++;
                    }
                }
                if (trushedKeyboardCounter == 2)
                {
                    trushedDisplays++;
                    trushedDisplayCounter++;
                    trushedKeyboardCounter = 0;
                }
            }

            var totalCostForHeadsets = trushedHeadsets * headsetPrice;
            var totalCostForMouses = trushedMouses * mousePrice;
            var totalCostForKeyboards = trushedKeyboards * keyboardPrice;
            var totalCostForDisplays = trushedDisplays * displayPrice;

            var rageExpenses = totalCostForHeadsets + totalCostForMouses + totalCostForKeyboards + totalCostForDisplays;

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
