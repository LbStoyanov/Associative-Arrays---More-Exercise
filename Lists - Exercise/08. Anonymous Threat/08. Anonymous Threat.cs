using System;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "3:1")
            {
                
                if (commands[0] == "merge")
                {
                    var startIndex = int.Parse(commands[1]);
                    var endIndex = int.Parse(commands[2]);
                    var lastIndex = arrayData.Count - 1;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex > lastIndex || endIndex < 0)
                    {
                        var concatData = string.Join("", arrayData);
                        arrayData.Clear();
                        arrayData.Add(concatData);
                        break;
                    }
                    
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        arrayData[startIndex] += arrayData[i + 1];
                        arrayData.Remove(arrayData[i + 1]);
                    }
                }
                else if (commands[0] == "divide") 
                {

                }
                commands = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
