using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\+359([ -])2\1[0-9]{3}\1[0-9]{4}\b");
            string input = Console.ReadLine();

            MatchCollection phoneNumbers = regex.Matches(input);

            //var matchedPhones = phoneNumbers
            //    .Cast<Match>()
            //    .Select(x => x.Value.Trim())
            //    .ToArray();

            Console.WriteLine(string.Join(", ", phoneNumbers));

            //foreach (Match phone in phoneNumbers)
            //{
            //    Console.Write($"{phone.Value}, ");
            //}
        }
    }
}
