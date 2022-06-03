using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirtNum = int.Parse(Console.ReadLine());
            var result = PrintSmallestInteger(firstNum, secondNum, thirtNum);
            Console.WriteLine(result);
        }

        static int PrintSmallestInteger(int numA,int numB,int numC) 
        {
            if (numA < numB && numA < numC)
            {
                return numA;
            }
            else if (numB< numA && numB < numC)
            {
                return numB;
            }
            else
            {
                return numC;
            }
            
        }
    }
}
