using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int keyValue = int.Parse(Console.ReadLine());
            Regex pattern = new Regex(@"@(?<childsName>[A-Za-z]+)([^\@\-\!\:\>]*)!(?<childsBehavior>[G|N])!");

            string message = Console.ReadLine();

            List<string> goodChilds = new List<string>();

            while (message != "end")
            {
                string decodedMessage = DecodeMessages(message, keyValue);

                Match match = pattern.Match(decodedMessage);
                if (match.Success)
                {
                    string childsName = match.Groups["childsName"].Value;
                    string childsBehavior = match.Groups["childsBehavior"].Value;
                    if (childsBehavior == "G")
                    {
                        goodChilds.Add(childsName);
                    }

                }

                message = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine,goodChilds));
        }
        static string DecodeMessages(string message, int keyValue)
        {
           StringBuilder result = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                int currCharValue = Convert.ToInt32(message[i]) - keyValue;
                char convertedChar = Convert.ToChar(currCharValue);
                result.Append(convertedChar);
            }

            return result.ToString();
        }
    }
}
