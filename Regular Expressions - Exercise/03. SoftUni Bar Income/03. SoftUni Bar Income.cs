using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[\d]+[.]?[\d]+)?\$";
            string input = Console.ReadLine();

            double totalAmountOfMoney = 0;

            while (input != "end of shift")
            {
                Match match = Regex.Match(input,pattern);

                if (match.Success)
                {
                    string currCustomer = match.Groups[1].Value;
                    string currProduct = match.Groups[2].Value;
                    int currCount = int.Parse(match.Groups[3].Value);
                    double currPrice = double.Parse(match.Groups[4].Value);
                    var totalCurrPrice = currCount * currPrice;
                    totalAmountOfMoney += totalCurrPrice;
                    Console.WriteLine($"{currCustomer}: {currProduct} - {totalCurrPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalAmountOfMoney:f2}");
        }
    }
}
