using System;
using System.Text;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringText = Console.ReadLine();


            while (stringText != "end")
            {

                var currWord = stringText.ToCharArray();
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = currWord.Length - 1; i >= 0; i--)
                {
                    stringBuilder.Append(currWord[i]);
                }

                Console.WriteLine($"{stringText} = {stringBuilder}");
                stringText = Console.ReadLine();
            }
        }
    }
}
