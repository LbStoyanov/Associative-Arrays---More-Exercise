using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            string pattern = @"@(?<planet>[A-z]+)[^@\-!:>]*:(?<population>[\d+]+)[^@\-!:>]*!(?<attackType>[A,D])[^@\-!:>]*!->(?<soldierCount>[\d]+)";
            //Regex pattern = new Regex(@"@(?<planet>[A-z]+)[^@\-!:>]*:(?<population>[\d+]+)[^@\-!:>]*!(?<attackType>[A,D])[^@\-!:>]*!->(?<soldierCount>[\d]+)",RegexOptions.IgnoreCase);

            //char[] letters = { 'S', 's', 'T', 't', 'A', 'a', 'R', 'r' };

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string encryptedMessages = Console.ReadLine();
                int sum = encryptedMessages.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                string decriptedMessage = "";
                foreach (char item in encryptedMessages)
                {
                    decriptedMessage += (char)(item - sum);
                }
                //int lettersCounter = CountLetters(letters, encryptedMessages);
                //string decriptedMessage = RemoveAschiValue(encryptedMessages, lettersCounter);
                Match match = Regex.Match(decriptedMessage, pattern, RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    char attackType = char.Parse(match.Groups["attackType"].Value);
                    int soldureCount = int.Parse(match.Groups["soldierCount"].Value);
                    if (attackType != 'A')
                    {
                        destroyedPlanets.Add(planet);
                    }
                    else
                    {
                        attackedPlanets.Add(planet);
                    }
                }
            }

            int attackedPlanetsCount = attackedPlanets.Count;
            Console.WriteLine($"Attacked planets: {attackedPlanetsCount}");

            foreach (var planet in attackedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }

            int destroyedPlanetsCount = destroyedPlanets.Count;
            Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");

            foreach (var planet in destroyedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
        static string RemoveAschiValue(string encryptedMessages, int lettersCounter)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < encryptedMessages.Length; i++)
            {
                char currChar = encryptedMessages[i];
                int charAschiValue = Convert.ToInt32(currChar);
                charAschiValue -= lettersCounter;
                currChar = Convert.ToChar(charAschiValue);
                stringBuilder.Append(currChar);

            }
            return stringBuilder.ToString();
        }
        static int CountLetters(char[] letter, string encryptedMessages)
        {
            int count = 0;
            for (int i = 0; i < encryptedMessages.Length; i++)
            {
                var currChar = encryptedMessages[i];
                for (int j = 0; j < letter.Length; j++)
                {
                    var currLetter = letter[j];
                    if (currChar == currLetter)
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}
