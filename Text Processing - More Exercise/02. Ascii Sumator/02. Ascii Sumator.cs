using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            int firstCharCodeValue = Convert.ToInt32(firstChar);
            int secondCharCodeValue = Convert.ToInt32(secondChar);

            int startCodeNum = Math.Min(firstCharCodeValue, secondCharCodeValue);
            int endCodeNum = Math.Max(firstCharCodeValue, secondCharCodeValue);

            string randomString = Console.ReadLine();

            var sum = 0;

            for (int i = 0; i < randomString.Length; i++)
            {
                int currentCharCode = Convert.ToInt32(randomString[i]);

                if (currentCharCode > startCodeNum && currentCharCode < endCodeNum)
                {
                    sum += currentCharCode;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
