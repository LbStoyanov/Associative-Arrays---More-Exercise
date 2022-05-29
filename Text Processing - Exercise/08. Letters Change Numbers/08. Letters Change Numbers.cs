using System;
using System.Linq;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            var sum = 0.0;

            for (int i = 0; i < input.Length; i++)
            {
                char[] currentString = input[i].ToCharArray();
                var currentSum = MatematicalOperations(currentString);
                sum += currentSum;
            }

            Console.WriteLine($"{sum:f2}");
        }
        static double MatematicalOperations(char[] currentString)
        {
            var sum = 0.0;
            var firstLetter = currentString[0];
            StringBuilder stringbuilder = new StringBuilder();
            var secondLetter = currentString[currentString.Length - 1];
            for (int j = 0; j < currentString.Length; j++)
            {
                var currChar = currentString[j];
                var result = 0.0;

                if (char.IsDigit(currChar))
                {
                    stringbuilder.Append(currChar);
                }

                if (j + 1 >= currentString.Length)
                {
                    double currentNumber = double.Parse(stringbuilder.ToString());
                    

                    if (char.IsUpper(firstLetter) )
                    {
                        var firstLettersPosition = VerifyUpperLetterPosition(firstLetter);
                        var secondLettersPosition = 0;
                        if (char.IsLower(secondLetter))
                        {
                            secondLettersPosition = VerifyLowerLetterPosition(secondLetter);
                            result = (currentNumber / firstLettersPosition) + secondLettersPosition;
                        }
                        else
                        {
                            secondLettersPosition = VerifyUpperLetterPosition(secondLetter);
                            result = (currentNumber / firstLettersPosition) - secondLettersPosition;
                        }
                        
                        sum += result;
                    }
                    else
                    {
                        var firstLettersPosition = VerifyLowerLetterPosition(firstLetter);
                        var secondLettersPosition = 0;
                        if (char.IsLower(secondLetter))
                        {
                            secondLettersPosition = VerifyLowerLetterPosition(secondLetter);
                            result = (currentNumber * firstLettersPosition) + secondLettersPosition;
                        }
                        else
                        {
                            secondLettersPosition = VerifyUpperLetterPosition(secondLetter);
                            result = (currentNumber * firstLettersPosition) - secondLettersPosition;
                        }
                        sum += result;
                    }
                   
                }
            }

            return sum;
        }
        static int VerifyLowerLetterPosition(char letter)
        {
            int positionOfTheLetterCounter = 1;

            for (char i = 'a'; i < 'z'; i++)
            {
                if (letter == i)
                {
                    break;
                }
                positionOfTheLetterCounter++;
            }

            
            return positionOfTheLetterCounter;
        }
        static int VerifyUpperLetterPosition(char letter)
        {
            int positionOfTheLetterCounter = 1;

            for (char i = 'A'; i < 'Z'; i++)
            {
                if (letter == i)
                {
                    break;
                }
                positionOfTheLetterCounter++;
            }

            
            return positionOfTheLetterCounter;
        }
    }
}
