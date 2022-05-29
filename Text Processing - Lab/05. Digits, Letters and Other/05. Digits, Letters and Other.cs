using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            

            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> chars = new List<char>();

            //StringBuilder digits = new StringBuilder();
            //StringBuilder letters = new StringBuilder();
            //StringBuilder chars = new StringBuilder();


            for (int i = 0; i < input.Length; i++)
            {
                var currChar = input[i];

                if (char.IsDigit(currChar))
                {
                    digits.Add(currChar);
                }
                else if (char.IsLetter(currChar))
                {
                    letters.Add(currChar);
                }
                else 
                {
                    chars.Add(currChar); 
                }
                
            }

            //Console.WriteLine($"{digits}\n{letters}\n{chars}");

            Console.WriteLine(String.Join("", digits));
            Console.WriteLine(String.Join("", letters));
            Console.WriteLine(String.Join("", chars));
        }
    }
}
