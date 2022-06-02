using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numA = int.Parse(Console.ReadLine());
            var operationSign = Console.ReadLine();
            var numB = int.Parse(Console.ReadLine());
            var result = GetOperationSignAndCalculate(numA,operationSign,numB);
            Console.WriteLine(result);
        }
        static double GetOperationSignAndCalculate(int numA,string operationSign,int numB) 
        {
            var result = 0;
            if (operationSign == "/")
            {
                result = numA / numB;
            }
            else if (operationSign == "*")
            {
                result = numA * numB;
            }
            else if (operationSign == "+")
            {
                result = numA + numB;
            }
            else if (operationSign == "-")
            {
                result = numA - numB;
            }

            return result;
        }
    }
}
