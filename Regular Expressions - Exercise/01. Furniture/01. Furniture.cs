using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furnitureType>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            string input = Console.ReadLine();
            
            double totalPrice = 0.0;
            

            List<string> furnitures = new List<string>();

            while (input != "Purchase")
            {
                Match match = Regex.Match(input,pattern,RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    var furnitureType = match.Groups["furnitureType"].Value;
                    var currentPrice = double.Parse(match.Groups["price"].Value);
                    var quantity = int.Parse(match.Groups["quantity"].Value);
                    furnitures.Add(furnitureType);
                    totalPrice += currentPrice * quantity;
                   
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture: ");
            furnitures.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
