using System;

namespace _01._Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentsName = Console.ReadLine();
            var studentsAge = int.Parse(Console.ReadLine());
            var studentsAverageGrade = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentsName}, Age: {studentsAge}, Grade: {studentsAverageGrade}");
        }
    }
}
