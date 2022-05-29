using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split("\\").ToArray();
            string file = filePath[filePath.Length - 1];
            string[] splittedWord = file.Split('.');
            var fileName = splittedWord[0];
            var fileExtension = splittedWord[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
