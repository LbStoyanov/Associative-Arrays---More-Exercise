using System;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nPairOfRows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();

            for (int i = 0; i < nPairOfRows; i++)
            {
                var studentName = Console.ReadLine();
                var studentGrade = double.Parse(Console.ReadLine());

                if (!studentsInfo.ContainsKey(studentName))
                {
                    studentsInfo.Add(studentName,new List<double>());
                    studentsInfo[studentName].Add(studentGrade);
                }
                else
                {
                    studentsInfo[studentName].Add(studentGrade);
                }
            }

            foreach (var student in studentsInfo)
            {
                List<double> listOfGrades = student.Value;
                var result = CalculateAverageGrade(listOfGrades);
                if (result < 4.50)
                {
                    studentsInfo.Remove(student.Key);
                }
            }

            foreach (var item in studentsInfo)
            {
                var averageGrade = CalculateAverageGrade(item.Value);
                Console.WriteLine($"{item.Key} -> {averageGrade:f2}");
            }
        }
        static double CalculateAverageGrade(List<double> grades)
        {
            var averageGrade = 0.0;
            var gradesCounter = 0;
            foreach (var grade in grades)
            {
                averageGrade += grade;
                gradesCounter++;
            }

            var result = averageGrade / gradesCounter;

            return result;
        }
    }
}
