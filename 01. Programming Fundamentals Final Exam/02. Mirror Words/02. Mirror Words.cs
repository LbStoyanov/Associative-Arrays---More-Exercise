using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string patternt = @"\#{1}[A-z]{3,}\#{2}[A-z]{3,}\#{1}|\@{1}[A-z]{3,}\@{2}[A-z]{3,}\@{1}";

            //string adTypeOfWords = @"[@](?<firstWord>[A-Za-z]{3,})[@]{2}(?<secondWord>[A-Za-z]{3,})[@]";

            MatchCollection regex = Regex.Matches(text, patternt);
            //MatchCollection adGroup = Regex.Matches(text, adTypeOfWords);

            var mirrorWordsList = new Dictionary<string, string>();
            var validPairs = 0;

            foreach (Match match in regex)
            {
                if (match.Success)
                {
                    string pair = match.Value;
                    string firstWord = ExtractFirstWord(pair);
                    string secondWord = ExtractSecondWord(pair);
                    
                    validPairs++;
                    if (firstWord == secondWord)
                    {
                        secondWord = ReverseSecondWord(secondWord);
                        mirrorWordsList.Add(firstWord, secondWord);
                    }
                }
            }

            if (validPairs > 0)
            {
                Console.WriteLine($"{validPairs} word pairs found!");
            }
            else
            {
                Console.WriteLine($"No word pairs found!");
            }

            if (mirrorWordsList.Count == 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                var commaCounter = 0;
                foreach (var pair in mirrorWordsList)
                {
                    var lastPair = mirrorWordsList.Count - 1;
                    if (commaCounter == lastPair)
                    {
                        Console.Write($"{pair.Key} <=> {pair.Value}");
                        break;
                    }
                    Console.Write($"{pair.Key} <=> {pair.Value}, ");
                    commaCounter++;
                }
            }

        }
        static string ReverseSecondWord(string secondWord)
        {
            StringBuilder reversedWord = new StringBuilder();
            for (int i = secondWord.Length - 1; i >= 0; i--)
            {
                reversedWord.Append(secondWord[i]);
            }
            return reversedWord.ToString();
        }
        static string ExtractSecondWord(string pair)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = pair.Length - 2; i >= 1; i--)
            {
                var currChar = pair[i];
                if (currChar == '#' || currChar == '@')
                {
                    break;
                }
                stringBuilder.Append(currChar);
            }
            return stringBuilder.ToString();
        }
        static string ExtractFirstWord(string pair)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i <= pair.Length; i++)
            {
                var currChar = pair[i];
                if (currChar == '#' || currChar == '@')
                {
                    break;
                }
                stringBuilder.Append(currChar);
            }
            return stringBuilder.ToString();
        }
    }
}
