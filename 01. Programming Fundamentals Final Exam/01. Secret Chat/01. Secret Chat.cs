using System;
using System.Text;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string instructions = Console.ReadLine();

            while (instructions != "Reveal")
            {
                string[] actions = instructions.Split(":|:");
                string command = actions[0];
                if (command == "InsertSpace")
                {
                    int index = int.Parse(actions[1]);
                    concealedMessage = InsertSpace(concealedMessage, index);

                }
                else if (command == "Reverse")
                {
                    string substring = actions[1];
                    if (!concealedMessage.Contains(substring))
                    {
                        Console.WriteLine("error");
                        instructions = Console.ReadLine();
                        continue;
                    }
                    concealedMessage = ReverseSubstring(concealedMessage, substring);
                }
                else
                {
                    string substring = actions[1];
                    string replacement = actions[2];
                    concealedMessage = ChangeAll(concealedMessage, substring, replacement);

                }
                Console.WriteLine(concealedMessage);

                instructions = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
        static string ChangeAll(string concealedMessage, string substring, string replacement)
        {
            string changedMessage = concealedMessage.Replace(substring, replacement);
            return changedMessage;
        }
        static string ReverseSubstring(string concealedMessage, string substring)
        {
            StringBuilder sb = new StringBuilder();
            int startIndex = concealedMessage.IndexOf(substring);

            if (startIndex != -1)
            {
                sb.Append(concealedMessage.Remove(startIndex));
                for (int i = substring.Length - 1; i >= 0; i--)
                {
                    sb.Append(substring[i]);
                }
            }
            else
            {
                return concealedMessage;
            }

            return sb.ToString();
        }
        static string InsertSpace(string concealedMessage, int index)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < concealedMessage.Length; i++)
            {
                var currChar = concealedMessage[i];
                if (i == index)
                {
                    sb.Append(" ");
                }
                sb.Append(currChar);
            }
            return sb.ToString();
        }
    }
}
