using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //string pattern = @"(^|\s)[A-z0-9][\w*\-\.]*[A-z0-9]@[A-z]+([.-][A-z]+)+\b";
            Regex pattern = new Regex(@"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b");


            MatchCollection matches = pattern.Matches(text);
            //matches.ToList().ForEach(Console.WriteLine);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    Console.WriteLine(match.Value.Trim());
                }
            }

        }
    }
}
