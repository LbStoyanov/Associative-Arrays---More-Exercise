using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ");

            Dictionary<string,int> participantsRecords = new Dictionary<string,int>();

            for (int i = 0; i < participants.Length; i++)
            {
                var currentParticipant = participants[i];
                if (!participantsRecords.ContainsKey(currentParticipant))
                {
                    participantsRecords.Add(currentParticipant, 0);
                }
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                StringBuilder name = new StringBuilder();
                int distance = 0;

                foreach (char item in input)
                {
                    if (char.IsLetter(item))
                    {
                        name.Append(item);
                    }
                    else if (char.IsDigit(item))
                    {
                        distance += item - 48;
                    }
                }
                var currParticipant = name.ToString();
                

                if (participantsRecords.ContainsKey(currParticipant))
                {
                    participantsRecords[currParticipant] += distance;
                }
                
                input = Console.ReadLine();
            }

            List<string> names = new List<string>();
            foreach (var participant in participantsRecords.OrderByDescending(p => p.Value))
            {
                names.Add(participant.Key);
            }

            Console.WriteLine($"1st place: {names[0]}");
            Console.WriteLine($"2nd place: {names[1]}");
            Console.WriteLine($"3rd place: {names[2]}");
        }
    }
}
