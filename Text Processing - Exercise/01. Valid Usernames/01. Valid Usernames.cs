using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");

            char hyphens = '-';
            char underscores = '_';

            List<string> verifiedPasswords = new List<string>();

            bool isPasswordCorrect = true;

            for (int i = 0; i < userNames.Length; i++)
            {
                var currUserName = userNames[i];

                for (int j = 0; j < currUserName.Length; j++)
                {
                    var currChar = currUserName[j];

                    if (!char.IsLetterOrDigit(currChar) && currChar != hyphens && currChar != underscores)
                    {
                        isPasswordCorrect = false;
                        break;
                    }
                }
                if (isPasswordCorrect && currUserName.Length >= 3 && currUserName.Length <= 16)
                {
                    verifiedPasswords.Add(currUserName);
                }
                else
                {
                    isPasswordCorrect = true;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,verifiedPasswords));
        }
    }
}
