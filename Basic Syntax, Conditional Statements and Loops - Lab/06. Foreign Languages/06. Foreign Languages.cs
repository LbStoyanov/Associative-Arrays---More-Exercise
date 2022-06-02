using System;

namespace _06._Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countryName = Console.ReadLine();

            if (countryName == "England" || countryName == "USA")
            {
                Console.WriteLine("English");
            }
            else if(countryName == "Argentina" || countryName == "Mexico" || countryName == "Spain")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
