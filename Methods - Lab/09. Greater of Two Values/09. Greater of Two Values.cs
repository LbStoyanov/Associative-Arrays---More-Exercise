using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataType = Console.ReadLine();
            var firstData = Console.ReadLine();
            var secondData = Console.ReadLine();
            var result = string.Empty;
            if (dataType == "int")
            {
                result = GetMaxFromTwoIntegers(int.Parse(firstData), int.Parse(secondData)).ToString();
            }
            else if (dataType == "char")
            {
                result = GetMaxFromTwoChars(char.Parse(firstData), char.Parse(secondData)).ToString();
            }
            else if (dataType == "string")
            {
                result = GetMaxFromTwoStrings(firstData, secondData);
            }
            Console.WriteLine(result);
        }
        private static char GetMaxFromTwoChars(char firstData, char secondData) 
        {
            if (firstData > secondData)
            {
                return firstData;
            }
            else if (firstData < secondData) 
            {
                return secondData;
            }
            else
            {
                return firstData;
            }
        }
        private static int GetMaxFromTwoIntegers(int firstData, int secondData)
        {
            var result = Math.Max(firstData, secondData);
            return result;
        }
        private static string GetMaxFromTwoStrings(string firstData, string secondData)
        {
            var comparation = firstData.CompareTo(secondData);
            if (comparation > 0) 
            {
                return firstData;
            }
            else
            {
                return secondData;
            }
        }
    }
}
