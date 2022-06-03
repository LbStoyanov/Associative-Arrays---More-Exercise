using System;
using System.Linq;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var result = PrintCharsInTheMiddleOfTheText(inputString);
            Console.WriteLine(result);
        }

        static  string  PrintCharsInTheMiddleOfTheText(string text) 
        {
            var textArr = text.ToCharArray();

            var firstSymbolToBePrinted = ' ';
            var secondSymbolToBePrinted = ' ';
            var thirthSymbolToBePrinted = ' ';
            for (int i = 0; i < textArr.Length / 2; i++)
            {
                if (textArr.Length % 2 == 0 && i + 1 == textArr.Length / 2)
                {
                    firstSymbolToBePrinted = textArr[textArr.Length / 2 - 1];
                    secondSymbolToBePrinted = textArr[textArr.Length / 2];
                }
                else
                {
                    thirthSymbolToBePrinted = textArr[textArr.Length / 2];
                }
            }

            if (textArr.Length % 2 == 0)
            {
                var result = $"{firstSymbolToBePrinted}{secondSymbolToBePrinted}";
                return result;
            }
            else
            {
                var result = $"{thirthSymbolToBePrinted}";
                return result;
            }
        }
    }
}
