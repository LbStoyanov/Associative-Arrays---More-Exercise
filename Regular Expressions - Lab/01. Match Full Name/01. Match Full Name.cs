using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}");
            //string regex = @"\b[A-Z][a-z]{2,} [A-Z][a-z]{2,}\b";

            string names = Console.ReadLine();

            MatchCollection matchedNames = regex.Matches(names);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
            
        }
    }
}
