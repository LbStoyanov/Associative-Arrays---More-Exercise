using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, Dictionary<string, int>>();

            var individualStanding = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();

                if (input[0] == "no more time")
                {
                    break;
                }

                string username = input[0];
                string contest = input[1];
                int points = int.Parse(input[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest][username] = points;
                    //contests[contest].Add(username, points);
                }
                else
                {
                    if (!contests[contest].ContainsKey(username))
                    {
                        contests[contest][username] = points;
                        //contests[contest].Add(username, points);
                    }
                    else
                    {
                        if (contests[contest][username] < points)
                        {
                            contests[contest][username] = points;
                        }
                    }
                }
            }

            foreach (var contest in contests)
            {
                string currentContest = contest.Key;
                int contestersCount = contest.Value.Count();

                Console.WriteLine($"{currentContest}: {contestersCount} participants");
                int counter = 0;

                foreach (var name in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");
                }
                counter = 0;
            }

            Console.WriteLine("Individual standings:");

            foreach (var contest in contests)
            {
                foreach (var name in contest.Value)
                {
                    if (!individualStanding.ContainsKey(name.Key))
                    {
                        individualStanding.Add(name.Key, name.Value);
                    }
                    else
                    {
                        individualStanding[name.Key] = individualStanding[name.Key] + name.Value;
                    }
                }
            }
            int rankingCounter = 0;
            foreach (var name in individualStanding.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                rankingCounter++;
                string currentName = name.Key;
                int currentPoints = name.Value;

                Console.WriteLine($"{rankingCounter}. {currentName} -> {currentPoints}");
            }
        }
    }
}