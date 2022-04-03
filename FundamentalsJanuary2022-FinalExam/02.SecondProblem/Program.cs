using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.SecondProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfInputs; i++)
            {
                string inputForValidation = Console.ReadLine();
                Regex pattern = new Regex(@"!(?<command>[A-Z][a-z]{3,})!:\[(?<message>[A-Za-z]{8,})\]");
                MatchCollection matches = pattern.Matches(inputForValidation);
                if (matches.Count == 0)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }

                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        string currentMessage = match.Groups["message"].Value;
                        string currentCommand = match.Groups["command"].Value;
                        

                        Console.Write($"{currentCommand}: ");
                        TranslateMessage(currentMessage);
                        
                    }
                }
            }
        }

        static void TranslateMessage(string currentMessage)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < currentMessage.Length; i++)
            {
                var currentChar = currentMessage[i];
                int currentCharValue = Convert.ToInt32(currentMessage[i]);
                result.Add(currentCharValue);
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
