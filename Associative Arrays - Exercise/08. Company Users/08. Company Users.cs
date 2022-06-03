using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> userIdInformation = new Dictionary<string, List<string>>();

            var command = Console.ReadLine();

            while (command != "End")
            {
                var currentInformation = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string companyName = currentInformation[0];
                string employId = currentInformation[1];

                if (!userIdInformation.ContainsKey(companyName))
                {
                    userIdInformation.Add(companyName, new List<string>());
                    userIdInformation[companyName].Add(employId);
                }
                else
                {
                    if (userIdInformation[companyName].Contains(employId))
                    {
                        continue;
                    }
                    else
                    {
                        userIdInformation[companyName].Add(employId);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in userIdInformation)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"--{string.Join("\n--",item.Value)}");
            }
        }
    }
}
