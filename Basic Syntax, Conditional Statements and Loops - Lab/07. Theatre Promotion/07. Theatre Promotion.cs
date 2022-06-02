using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var typeOfDay = Console.ReadLine();
            var personAge = int.Parse(Console.ReadLine());

            var price = 0.0m;

            if (typeOfDay == "Weekday")
            {
                if (personAge >= 0 && personAge <= 18)
                {
                    price = 12;
                }
                else if (personAge > 18 && personAge <= 64)
                {
                    price = 18;
                }
                else if (personAge > 64 && personAge <= 122)
                {
                    price = 12;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;    
                }
            }
            else if (typeOfDay == "Weekend")
            {
                if (personAge >= 0 && personAge <= 18)
                {
                    price = 15;
                }
                else if (personAge > 18 && personAge <= 64)
                {
                    price = 20;
                }
                else if (personAge > 64 && personAge <= 122)
                {
                    price = 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            else if (typeOfDay == "Holiday")
            {
                if (personAge >= 0 && personAge <= 18)
                {
                    price = 5;
                }
                else if (personAge > 18 && personAge <= 64)
                {
                    price = 12;
                }
                else if (personAge > 64 && personAge <= 122)
                {
                    price = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            Console.WriteLine($"{price}$");
        }
    }
}
