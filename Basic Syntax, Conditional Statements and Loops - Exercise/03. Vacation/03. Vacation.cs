using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfPeople = int.Parse(Console.ReadLine());
            var typeOfGroupu = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();

            var singlePrice = 0.0;

            if (typeOfGroupu == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    singlePrice = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    singlePrice = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    singlePrice = 10.46;
                }
            }
            else if (typeOfGroupu == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    singlePrice = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    singlePrice = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    singlePrice = 16.00;
                }
            }
            else if (typeOfGroupu == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    singlePrice = 15.00;
                }
                else if (dayOfWeek == "Saturday")
                {
                    singlePrice = 20.00;
                }
                else if (dayOfWeek == "Sunday")
                {
                    singlePrice = 22.50;
                }
            }

            var currentPrice = countOfPeople * singlePrice;
            if (countOfPeople >= 30 && typeOfGroupu == "Students")
            {
                currentPrice -= currentPrice * 0.15;
            }
            else if (countOfPeople >= 100 && typeOfGroupu == "Business")
            {
                currentPrice = (countOfPeople - 10) * singlePrice;
            }
            else if (countOfPeople >= 10 && countOfPeople <=20 && typeOfGroupu == "Regular")
            {
                currentPrice -= currentPrice * 0.05;
            }

            Console.WriteLine($"Total price: {currentPrice:f2}");
        }
    }
}
