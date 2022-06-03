using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');

            string capitalLetters = input[0];
            Regex capitalLettersPattern = new Regex(@"([\#\$\%\*\&])[A-Z]+\1");
            Match capitalsMatch = capitalLettersPattern.Match(capitalLetters);
            string matchedCapitals = capitalsMatch.Value;

            var extractedCapitalLetters = new StringBuilder();

            for (int i = 0; i < matchedCapitals.Length; i++)
            {
                var currChar = matchedCapitals[i];
                if (char.IsLetter(currChar))
                {
                    extractedCapitalLetters.Append(currChar);
                }
            }

            string startingLetter = input[1];
            Regex startingLetterPattern = new Regex(@"(?<aschiCode>[0-9]{2})\:(?<lenght>[0-9]{2})");
            MatchCollection lettersMatch = startingLetterPattern.Matches(startingLetter);

            string[] words = input[2].Split(" ");

            for (int i = 0; i < extractedCapitalLetters.Length; i++)
            {
                var currLetter = extractedCapitalLetters[i];
                
                var aschiCodeValueOfCurrChar = Convert.ToInt32(currLetter);

                foreach (Match item in lettersMatch)
                {
                    int aschiCode = int.Parse(item.Groups["aschiCode"].Value);
                    int lenghtCount = int.Parse(item.Groups["lenght"].Value);

                    if (aschiCodeValueOfCurrChar == aschiCode)
                    {
                        bool isMatched = false;
                        for (int j = 0; j < words.Length; j++)
                        {
                            var currWord = words[j];
                            if (VerifyIfWordMatch(currLetter, currWord, lenghtCount))
                            {
                                Console.WriteLine(currWord);
                                isMatched = true;
                                break;
                            }
                        }
                        if (isMatched)
                        {
                            isMatched = false;
                            break;
                        }
                        
                    }
                    
                    
                }
                
            }
        }
        static bool VerifyIfWordMatch(char currentChar, string word,int wordLenght)
        {
            if (currentChar == word[0] && word.Length == wordLenght + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
