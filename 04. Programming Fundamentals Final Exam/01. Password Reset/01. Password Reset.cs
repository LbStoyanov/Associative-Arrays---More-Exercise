using System;
using System.Text;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] actions = command.Split(' ');
                string mainAction = actions[0];

                if (mainAction == "TakeOdd")
                {
                    password = TakeOdds(password);
                    Console.WriteLine(password);
                }
                else if (mainAction == "Cut")
                {
                    int index = int.Parse(actions[1]);
                    int lenght = int.Parse(actions[2]);
                    password = CutChars(password,index,lenght);
                    Console.WriteLine(password);
                }
                else
                {
                    string substring = actions[1];
                    string replacement = actions[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, replacement);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
        static string CutChars( string text,int index, int lenght)
        {
            string substring = text.Substring(index, lenght);
            int charsToBeRemoved = substring.Length;
            string result = text.Remove(index, charsToBeRemoved);
            return result;
        }
        static string TakeOdds(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i < text.Length; i+=2)
            {
                var currentChar = text[i];
                stringBuilder.Append(currentChar);
            }
            return stringBuilder.ToString();
        }
    }
}
