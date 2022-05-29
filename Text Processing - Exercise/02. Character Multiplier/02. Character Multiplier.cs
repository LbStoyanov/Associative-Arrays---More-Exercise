using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char character = char.Parse(Console.ReadLine());
            //var charValue = Convert.ToInt32(chararcter);
            //Console.WriteLine(charValue);

            //int num = int.Parse(Console.ReadLine());
            //char character = Convert.ToChar(code);
            //Console.WriteLine(character);



            string[] input = Console.ReadLine().Split().ToArray();

            string firstString = input[0];
            string secondString = input[1];

            

            var result = MultiplyAndSumChars(firstString, secondString);

            Console.WriteLine(result);
        }
        static int MultiplyAndSumChars(string firstString, string secondString)
        {
            var lenght = Math.Max(firstString.Length, secondString.Length);
            var sum = 0;

            for (int i = 0; i < lenght; i++)
            {

                char currCharFisrstString = ' ';
                char currCharSecondtString = ' ';

                if (i >= firstString.Length)
                {
                    currCharSecondtString = secondString[i];
                    sum += currCharSecondtString;
                    continue;
                }
                else if (i >= secondString.Length)
                {
                    currCharFisrstString = firstString[i];
                    sum += currCharFisrstString;
                    continue;
                }
                currCharFisrstString = firstString[i];
                currCharSecondtString = secondString[i];

                sum += currCharFisrstString * currCharSecondtString;

            }

            return sum;
        }
    }
}
