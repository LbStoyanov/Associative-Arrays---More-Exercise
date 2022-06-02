using System;

namespace _03._Passed_or_Failed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentsGrade = decimal.Parse(Console.ReadLine());
            if (studentsGrade >= 3.00m)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }

        }
    }
}
