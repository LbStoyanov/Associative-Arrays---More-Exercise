using System;

namespace _02._Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentsGrade = decimal.Parse(Console.ReadLine());
            if (studentsGrade >= 3.00m )
            {
                Console.WriteLine("Passed!");
            }
            
        }
    }
}
