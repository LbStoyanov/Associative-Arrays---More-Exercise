using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = GetRectangleArea(width, height);
            Console.WriteLine(area);

        }
        public static double GetRectangleArea(double width, double height) 
        {
            return width * height;
        }
    }
}
