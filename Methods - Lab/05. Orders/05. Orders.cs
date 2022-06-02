using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            PrintProductPrice(product, quantity);

        }
        public static void PrintProductPrice(string product, int quantity) 
        {
            var price = 0.0;
            if (product == "coffee") 
            {
                price = 1.50;
            }
            else if (product == "water")
            {
                price = 1.00;
            }
            else if (product == "coke")
            {
                price = 1.40;
            }
            else if (product == "snacks")
            {
                price = 2.00;
            }
            var result = price * quantity;
            Console.WriteLine($"{result:f2}");

        }
    }
}
