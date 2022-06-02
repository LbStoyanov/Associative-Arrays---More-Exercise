using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            var countOfStudents = int.Parse(Console.ReadLine());
            var lightsabersSinglePrice = double.Parse(Console.ReadLine());
            var robesSinglePrice = double.Parse(Console.ReadLine());
            var beltsSinglePrice = double.Parse(Console.ReadLine());
            var lightsabersNeededToBeBought = Math.Ceiling(countOfStudents + (countOfStudents * 0.10));
            var freeBeltsCounter = 0;
            for (int i = 1; i <= countOfStudents; i++)
            {
                if (i % 6 == 0)
                {
                    freeBeltsCounter++;
                }
            }

            var totalLightsabersPrice = lightsabersNeededToBeBought * lightsabersSinglePrice;
            var totalRobesPrice = countOfStudents * robesSinglePrice;
            var totalBeltsPrice = (countOfStudents - freeBeltsCounter) * beltsSinglePrice;

            var totalCost = totalLightsabersPrice + totalRobesPrice + totalBeltsPrice;

            if (amountOfMoney >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                var difference = totalCost - amountOfMoney;
                Console.WriteLine($"John will need {difference:f2}lv more.");
            }


        }
    }
}

