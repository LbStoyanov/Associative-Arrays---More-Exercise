using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name,string iD, int age)
        {
            Name = name;
            Id = iD;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = Console.ReadLine();
            List<Person> persons = new List<Person>();

            while (lines != "End")
            {
                string[] personInformation = lines.Split(' ');

                string name = personInformation[0];
                string iD = personInformation[1];
                int age = int.Parse(personInformation[2]);

                Person person = new Person(name, iD, age);
                persons.Add(person);

                if(persons.Any(person => person.Id.Contains(iD)))
                {
                    person.Name = name;
                    person.Age = age;
                }
                lines = Console.ReadLine();
            }

            foreach (Person person in persons.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
