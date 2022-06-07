using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            Dictionary<string,string> outputDict = new Dictionary<string,string>();

            for (int i = 0; i < linesCount; i++)
            {
                StringBuilder currentName = new StringBuilder();
                StringBuilder currentAge = new StringBuilder();

                string currentStringLine = Console.ReadLine();
                int startNameCharacter = 0;
                int endNameCharacter = 0;
                int startAgeDigit = 0;
                int endAgeDigit = 0;

                for (int j = 0; j < currentStringLine.Length; j++)
                {
                    if (currentStringLine[j] == '@')
                    {
                        startNameCharacter = j + 1;
                    }

                    if (currentStringLine[j] == '|')
                    {
                        endNameCharacter = j;
                    }
                }

                for (int j = 0; j < currentStringLine.Length; j++)
                {
                    if (currentStringLine[j] == '#')
                    {
                        startAgeDigit = j + 1;
                    }

                    if (currentStringLine[j] == '*')
                    {
                        endAgeDigit = j;
                    }
                }

                for (int a = startNameCharacter; a < endNameCharacter; a++)
                {
                    currentName.Append(currentStringLine[a]);
                }

                for (int b = startAgeDigit; b < endAgeDigit; b++)
                {
                    currentAge.Append(currentStringLine[b]);
                }
                outputDict.Add(currentName.ToString(), currentAge.ToString());
            }

            foreach (var userInformation in outputDict)
            {
                Console.WriteLine($"{userInformation.Key} is {userInformation.Value} years old.");
            }
        }
        
    }
}
