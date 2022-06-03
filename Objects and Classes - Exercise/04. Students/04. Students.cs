using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class StudentList
    {
        public StudentList()
        {
            StudentsList = new List<Student>();
        }
        public List<Student> StudentsList { get; set; }

    }
    class Student
    {
        public Student(string firstName, string lastName, decimal grades)
        {
            FirstName = firstName;
            LastName = lastName;    
            Grades = grades;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grades { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var countOfStudents = int.Parse(Console.ReadLine());

            List<Student> studensLists = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                var currentInformation = Console.ReadLine().Split(" ").ToArray();
                var firstName = currentInformation[0];
                var lastName = currentInformation[1];
                var grades = decimal.Parse(currentInformation[2]);
                Student student = new Student(firstName, lastName, grades);
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grades = grades;
                studensLists.Add(student);
            }

            var orderedStudentsList = studensLists.OrderByDescending(s => s.Grades).ToList();
            Console.WriteLine(String.Join(Environment.NewLine,orderedStudentsList.Select(x => $"{x.FirstName} {x.LastName}: {x.Grades}")));
        }
    }
}
