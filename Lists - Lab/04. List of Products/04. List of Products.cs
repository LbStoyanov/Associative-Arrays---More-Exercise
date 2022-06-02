using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var orderedList = new List<string>();

            for (int i = 0; i < number; i++)
            {
                var currentProduct = Console.ReadLine();
                orderedList.Add(currentProduct);
            }
            orderedList.Sort();

            var counter = 1;
            foreach (var item in orderedList)
            {
                Console.WriteLine($"{counter}.{item}");
                counter++;
            }
        }
    }
}
