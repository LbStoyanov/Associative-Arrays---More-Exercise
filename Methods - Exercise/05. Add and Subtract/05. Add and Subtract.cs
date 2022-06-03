using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstInt = int.Parse(Console.ReadLine());
            var secondInt = int.Parse(Console.ReadLine());
            var thirtInt = int.Parse(Console.ReadLine());
            var result = SubstractThirtNumFromSumOfPreviousTwo(firstInt, secondInt, thirtInt);
            Console.WriteLine(result);

        }

        static int SumOfFirstTwoNums(int numA,int numB) 
        {
            var sum = numA + numB;
            return sum;
        }

        static int SubstractThirtNumFromSumOfPreviousTwo(int numA, int numB, int numC) 
        {
            var result = SumOfFirstTwoNums(numA,numB) - numC;
            return result;
        }
    }
}
