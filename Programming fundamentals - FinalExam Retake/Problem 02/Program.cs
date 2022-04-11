using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (message != "Last note")
            {
                Regex pattern = new Regex(@"\b(?<peakName>[^\.\,\:][A-Za-z!@#$?]+?)=(?<geohashlenght>[0-9]+?)<<(?<geohashcode>.+)\b");

                Match match = pattern.Match(message);

                if (match.Success)
                {
                    string nameOfMountain = match.Groups["peakName"].Value;
                    string hashCode = match.Groups["geohashcode"].Value;
                    int hashCodeLenght = int.Parse(match.Groups["geohashlenght"].Value);

                    if (hashCodeLenght != hashCode.Length)
                    {
                        Console.WriteLine("Nothing found!");
                        message = Console.ReadLine();
                        continue;
                    }
                    nameOfMountain = ExtractWord(nameOfMountain);
                    Console.WriteLine($"Coordinates found! {nameOfMountain} -> {hashCode}");
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

                message = Console.ReadLine();
            }
        }

        static string ExtractWord(string nameOfMountain)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < nameOfMountain.Length; i++)
            {
                var currenChar = nameOfMountain[i];
                if (char.IsLetter(currenChar)||char.IsDigit(currenChar))
                {
                    sb.Append(currenChar);
                }
            }
            return sb.ToString();
        }
    }
}
