using System;
using System.Text;

namespace Problem_01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "For Azeroth")
            {

                string[] actions = command.Split(' ');

                string mainAction = actions[0];

                if (mainAction == "GladiatorStance")
                {
                    message = GladiatorStance(message);
                    Console.WriteLine(message);
                }
                else if (mainAction == "DefensiveStance")
                {
                    message = DefensiveStance(message);
                    Console.WriteLine(message);
                }
                else if (mainAction == "Dispel")
                {
                    int index = int.Parse(actions[1]);
                    char letter = char.Parse(actions[2]);
                    message = Dispel(message, index, letter);

                }
                else if (mainAction == "Target")
                {
                    if (actions[1] == "Change")
                    {
                        string firstSubstring = actions[2];
                        string secondSubstring = actions[3];
                        message = Change(message, firstSubstring, secondSubstring);
                    }
                    else if(actions[1] == "Remove")
                    {
                        string subsstring = actions[2];
                        message = Remove(message, subsstring);
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                
            }
        }
        static string Remove(string message, string substring)
        {
            if (message.Contains(substring))
            {
                message = message.Replace(substring,"");
                Console.WriteLine(message);
            }
            
            return message;
        }
        static string Change(string message, string firstSubstring, string secondSubstring)
        {
            if (message.Contains(firstSubstring))
            {
                message = message.Replace(firstSubstring, secondSubstring);
            }

            Console.WriteLine(message);
            return message;
        }
        static string Dispel(string message, int index, char letter)
        {
            StringBuilder sb = new StringBuilder();

            if (index < 0 && index > message.Length - 1)
            {
                Console.WriteLine("Dispel too weak.");
                return message;
            }
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    if (i == index)
                    {
                        sb.Append(letter);
                        Console.WriteLine("Success!");
                        continue;
                    }
                    sb.Append(message[i]);
                }
            }

            return sb.ToString();
        }
        static string DefensiveStance(string message)
        {
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    sb.Append(char.ToLower(message[i]));
                    continue;
                }
                sb.Append(message[i]);
            }

            return sb.ToString();
        }
        static string GladiatorStance(string message)
        {
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    sb.Append(char.ToUpper(message[i]));
                    continue;
                }
                sb.Append(message[i]);
            }

            return sb.ToString();
        }
    }
}
