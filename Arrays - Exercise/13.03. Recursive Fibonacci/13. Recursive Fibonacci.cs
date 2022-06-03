using System;
using System.Linq;
class Program
{

    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var multiplier = int.Parse(Console.ReadLine());
        var result = 0;
        if (multiplier > 10)
        {
            result = num * multiplier;
            Console.WriteLine($"{num} X {multiplier} = {result}");
            return;
        }

        for (int i = multiplier; i <= 10; i++)
        {
            
            result = num * i;
            Console.WriteLine($"{num} X {i} = {result}");
        }
        //int positionInFibonacciSequence = int.Parse(Console.ReadLine());
        //int[] fibonacciSequence = new int[50];

        //fibonacciSequence[0] = 1;
        //fibonacciSequence[1] = 1;

        //if (positionInFibonacciSequence > 2)
        //{
        //    for (int i = 2; i < positionInFibonacciSequence; i++)
        //    {
        //        fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
        //    }
        //}
        //Console.WriteLine(fibonacciSequence[positionInFibonacciSequence - 1]);
    }
}
