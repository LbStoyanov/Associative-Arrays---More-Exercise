using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] condensedArr = new int[numbers.Length - 1];

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            for(int i = 0; i < numbers.Length; i++)
        {
                for (int j = 0; j < condensedArr.Length - i; j++)
                {
                    condensedArr[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condensedArr;
            }
            Console.WriteLine(condensedArr[0]);
         }

        //Туй нящо да ми го нарисуваш как става???
    }
}
