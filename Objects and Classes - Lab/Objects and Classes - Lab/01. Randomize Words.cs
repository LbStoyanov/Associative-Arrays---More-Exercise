using System;

namespace Objects_and_Classes___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomWord = random.Next(words.Length);
                var temp = words[i];
                words[i] = words[randomWord];
                words[randomWord] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
