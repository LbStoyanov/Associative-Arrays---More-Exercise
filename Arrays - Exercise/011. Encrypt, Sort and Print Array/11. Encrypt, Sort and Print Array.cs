using System;
using System.Collections.Generic;

namespace _011._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfStrings = int.Parse(Console.ReadLine());
            var outPut = new List<double>();
            var vowels = new char[] { 'a', 'A', 'e', 'E', 'o', 'O', 'u', 'U', 'i', 'I', };

            for (int i = 0; i < numOfStrings; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                //var currentList = new List<int>();
                double vocalSum = 0;
                double consonantSum = 0;
                double currentSum = 0;
                var isConsonant = true;
                for (int j = 0; j < input.Length; j++)
                {
                    for (int k = 0; k < vowels.Length; k++)
                    {
                        if (input[j] == vowels[k])
                        {
                            vocalSum += input[j] * input.Length;
                            isConsonant = false;
                            break;
                        }
                    }

                    if (isConsonant)
                    {
                        consonantSum += input[j] / input.Length;
                    }
                    isConsonant = true;
                }
                currentSum = vocalSum + consonantSum;
                outPut.Add(currentSum);
            }

            outPut.Sort();

            foreach (var item in outPut)
            {
                Console.WriteLine(item);
            }
        }
    }
}
