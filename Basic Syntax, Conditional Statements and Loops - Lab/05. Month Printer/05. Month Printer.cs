using System;

namespace _05._Month_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new string[] {"January","February","March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            var number = int.Parse(Console.ReadLine());
            if (number < 1 || number > 12)
            {
                Console.WriteLine("Error!");
                return;
            }
            for (int i = 1; i <= months.Length; i++) 
            {
                if (number == i)
                {
                    Console.WriteLine(months[i - 1]);
                    break;
                }
            }
        }
    }
}
