using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Regex pattern = new Regex(@"(@[#]{1,})(?<barcodeInfo>[A-Z][A-Za-z0-9]{4,}[A-Z])@[#]{1,}?");

            int barcodeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < barcodeCount; i++)
            {
                string currentBarcode = Console.ReadLine();
                Match match = pattern.Match(currentBarcode);
                if (match.Success)
                {
                    string extractedBarcode = match.Groups["barcodeInfo"].Value;
                    string productGroup = ExtractGroup(extractedBarcode);
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
        static string ExtractGroup(string barcode)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < barcode.Length; i++)
            {
                var currentChar = barcode[i];
                if (char.IsDigit(currentChar))
                {
                    stringBuilder.Append(currentChar);
                }
            }
            if (stringBuilder.Length == 0)
            {
                return "00";
            }
            return stringBuilder.ToString();
        }
    }
}
