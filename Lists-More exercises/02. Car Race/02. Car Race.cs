using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var raceTrack = Console.ReadLine().Split().Select(int.Parse).ToList();

            var leftRacerTime = new List<int>();
            var rightRacerTime = new List<int>();

            for (int i = 0; i < raceTrack.Count / 2; i++)
            {
                var currentTime = raceTrack[i];
                leftRacerTime.Add(currentTime);
            }

            for (int i =raceTrack.Count - 1 ; i > (raceTrack.Count - 1) / 2; i--)
            {
                var currentTime = raceTrack[i];
                rightRacerTime.Add(currentTime);
            }

            var leftRacer = LeftRacerTime(leftRacerTime);
            var rightRacer = LeftRacerTime(rightRacerTime);

            if (leftRacer < rightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacer}");
            }
        }
        static double RightRacerTime(List<int> rightRacerTime)
        {
            var sum = 0.0;

            for (int i = 0; i < rightRacerTime.Count; i++)
            {
                var speedReducer = 0.0;
                var currentSpeed = rightRacerTime[i];
                if (currentSpeed == 0)
                {
                    speedReducer = sum * 0.20;
                    sum -= speedReducer;
                }
                sum += currentSpeed;
            }
            return sum;
        }

        static double LeftRacerTime(List<int> leftRacerTime)
        {
            var sum = 0.0;

            for (int i = 0; i < leftRacerTime.Count; i++)
            {
                var speedReducer = 0.0;
                var currentSpeed = leftRacerTime[i];
                if (currentSpeed == 0)
                {
                    speedReducer = sum * 0.20;
                    sum -= speedReducer;
                }
                sum += currentSpeed;
            }
            return sum;
        }
    }
}
