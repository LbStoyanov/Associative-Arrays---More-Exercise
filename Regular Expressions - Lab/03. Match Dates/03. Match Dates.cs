using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\b(?<days>\d{2})(?<separator>[-.\/])(?<months>[A-Z][a-z]{2})\k<separator>(?<years>\d{4})\b");
            //Regex pattern = new Regex(@"\b(?<days>\d{2})(?<>[-.\/])(?<months>[A-Z][a-z]{2})\2(?<years>\d{4})\b");
            //var pattern = @"\b(?<days>\d{2})([-.\/])(?<months>[A-Z][a-z]{2})\2(?<years>\d{4})\b";

            string dates = Console.ReadLine();

            MatchCollection validDates = pattern.Matches(dates);

            foreach (Match date in validDates)
            {
                var day = date.Groups["days"].Value;
                var month = date.Groups["months"].Value;
                var year = date.Groups["years"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
