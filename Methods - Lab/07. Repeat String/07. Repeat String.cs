using System;
using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var num = int.Parse(Console.ReadLine());
            var result = PrintStringNTimes(text, num);
            Console.WriteLine(result);
        }
        static string PrintStringNTimes(string text, int n) 
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}
