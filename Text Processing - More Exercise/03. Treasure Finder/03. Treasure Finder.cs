using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string currentString = Console.ReadLine();

            List<string> maps = new List<string>();

            while (currentString != "find")
            {
                var currentMaps = DecreaseAchiCodesOfEveryChar(currentString, keys);
                maps.Add(currentMaps.ToString());
                currentString = Console.ReadLine();
            }

            Dictionary<string, string> tresureInformation = new Dictionary<string, string>();

            foreach (var currentTresureInformation in maps)
            {
                string currentTresureType = FindTresureType(currentTresureInformation);
                string currentTresureLocation = FindTresureLocation(currentTresureInformation);
                tresureInformation.Add(currentTresureType, currentTresureLocation);
            }

            foreach (var item in tresureInformation)
            {
                Console.WriteLine($"Found {item.Key} at {item.Value}");
            }
        }
        static string FindTresureLocation(string currentMap)
        {
            StringBuilder tresureLocation = new StringBuilder();

            for (int i = 0; i < currentMap.Length; i++)
            {
                char currentChar = currentMap[i];

                if (currentChar == '<')
                {
                    currentChar = currentMap[i + 1];
                    while (currentChar != '>')
                    {
                        tresureLocation.Append(currentChar);
                        i++;
                        currentChar = currentMap[i + 1];
                    }
                    break;
                }
            }
            return tresureLocation.ToString();
        }
        static string FindTresureType(string currentMap)
        {
            StringBuilder tresureType = new StringBuilder();
            
            for (int i = 0; i < currentMap.Length; i++)
            {
                char currentChar = currentMap[i];
                if (currentChar == '&')
                {
                    currentChar = currentMap[i + 1];
                    while (currentChar != '&')
                    {
                        tresureType.Append(currentChar);
                        i++;
                        currentChar = currentMap[i + 1];
                    }
                    break;
                }
            }
            return tresureType.ToString();
        }
        static StringBuilder DecreaseAchiCodesOfEveryChar(string currentString, int[] keys)
        {
            StringBuilder currentMap = new StringBuilder();
            int keyCounter = 0;

            for (int i = 0; i < currentString.Length; i++)
            {
                int currentChar = Convert.ToInt32(currentString[i]);
                int currentKey = keys[keyCounter];
                currentChar -= currentKey;
                char decreasedChar = Convert.ToChar(currentChar);
                currentMap.Append(decreasedChar);
                keyCounter++;
                if (keyCounter == keys.Length)
                {
                    keyCounter = 0;
                }
            }

            return currentMap;
        }
    }
}
