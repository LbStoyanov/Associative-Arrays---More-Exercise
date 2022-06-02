using System;
using System.Collections.Generic;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ordersCount = int.Parse(Console.ReadLine());

            var totalPrice = 0.0m;
            var ordersList = new List<decimal>();

            for (int i = 0; i < ordersCount; i++)
            {
                var capsulesPrice = decimal.Parse(Console.ReadLine());
                var days = int.Parse(Console.ReadLine());
                var capsulesCount = int.Parse(Console.ReadLine());
                var result = (days * capsulesCount) * capsulesPrice;
                totalPrice += result;
                ordersList.Add(result);
            }

            foreach (var order in ordersList)
            {
                Console.WriteLine($"The price for the coffee is: ${order:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
