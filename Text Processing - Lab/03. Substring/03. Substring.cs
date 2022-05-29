using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string stringText = Console.ReadLine();

            int startIndex = stringText.IndexOf(words);

            while (startIndex >= 0)
            {
                stringText = stringText.Remove(startIndex,words.Length);
                startIndex = stringText.IndexOf(words);
            }

            Console.WriteLine(stringText.Trim());


        }
    }
}
