using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wagons = new int[n];

            for (int i = 0; i < n; i++)
            {
                var currentPassenger = int.Parse(Console.ReadLine());
                wagons[i] = currentPassenger;
            }

            foreach (var passanger in wagons)
            {
                Console.Write(passanger + " ");
            }
            Console.WriteLine();
            Console.WriteLine(string.Join("",wagons.Sum()));
            
        }
    }
}
