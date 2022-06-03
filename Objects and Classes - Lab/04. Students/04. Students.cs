using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var information = Console.ReadLine();

            List<Student> studentList = new List<Student>();

            while (information != "end")
            {
                var currentInformation = information.Split().ToArray();

                string firstName = currentInformation[0];
                string lastName = currentInformation[1];
                var age = currentInformation[2];
                var homeTown = currentInformation[3];

                Student currentStudent = new Student();

                currentStudent.FirstName = firstName;
                currentStudent.LastName = lastName;
                currentStudent.Age = age;
                currentStudent.HomeTown = homeTown;

                studentList.Add(currentStudent);

                information = Console.ReadLine();
            }

            var cityName = Console.ReadLine();

            foreach (Student student in studentList)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
