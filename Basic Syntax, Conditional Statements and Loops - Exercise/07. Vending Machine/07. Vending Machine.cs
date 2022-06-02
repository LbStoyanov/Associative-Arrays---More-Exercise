using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var sum = 0.0m;
            var input = Console.ReadLine();
            while (input != "Start")
            {

                switch (input)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        sum +=  decimal.Parse(input);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {input}");
                        break;
                }
                input = Console.ReadLine();

            }
            var nuts = 2.00m;
            var water = 0.70m;
            var crisps = 1.50m;
            var soda = 0.80m;
            var coke = 1.00m;
            string product = Console.ReadLine();
            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (sum - nuts >= 0)
                    {
                        Console.WriteLine($"Purchased nuts");
                        sum -= nuts;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (product == "Water"  )
                {
                    if (sum - water >= 0)
                    {
                        Console.WriteLine("Purchased water");
                        sum -= water;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (sum - crisps >= 0)
                    {
                        Console.WriteLine($"Purchased crisps");
                        sum -= crisps;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (sum - soda >= 0)
                    {
                        Console.WriteLine($"Purchased soda");
                        sum -= soda;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (sum - coke >= 0)
                    {
                        Console.WriteLine($"Purchased coke");
                        sum -= coke;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}
