using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());
            var result = CalculatePow(number, power);
            Console.WriteLine(result);
        }
        static double CalculatePow(double number, double power) 
        {
            var result = Math.Pow(number, power);
            
            
            return result;
        }
    }
}
