using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var numA = int.Parse(Console.ReadLine());
            var numB = int.Parse(Console.ReadLine());
            if (command == "add")
            {
                AddOperation(numA, numB);
            }
            else if (command == "multiply") 
            {
                MultiplyOperation(numA, numB);  
            }
            else if (command == "subtract")
            {
                SubstractOperation(numA, numB);
            }
            else if (command == "divide")
            {
                DivideOperation(numA, numB);
            }

        }
        private static void AddOperation(int numberA, int numberB) 
        {
            var result = numberA + numberB;
            Console.WriteLine(result);
        }
        private static void MultiplyOperation(int numberA, int numberB)
        {
            var result = numberA * numberB;
            Console.WriteLine(result);
        }
        private static void DivideOperation(int numberA, int numberB)
        {
            var result = numberA / numberB;
            Console.WriteLine(result);
        }
        private static void SubstractOperation(int numberA, int numberB)
        {
            var result = numberA - numberB;
            Console.WriteLine(result);
        }
    }
}
