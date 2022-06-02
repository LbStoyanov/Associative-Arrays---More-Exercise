using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstHand.Count > 0 && secondHand.Count > 0)
            {
                for (int index = 0; index < firstHand.Count; index++)
                {
                    var currentCardFirstPlayer = firstHand[index];
                    var currentCardSecondPlayer = secondHand[index];

                    if (currentCardFirstPlayer == currentCardSecondPlayer)
                    {
                        firstHand.Remove(currentCardFirstPlayer);
                        secondHand.Remove(currentCardSecondPlayer);
                    }
                    else if (currentCardFirstPlayer > currentCardSecondPlayer)
                    {
                        firstHand.Add(currentCardSecondPlayer);
                        firstHand.Add(currentCardFirstPlayer);
                        firstHand.RemoveAt(index);
                        secondHand.RemoveAt(index);
                    }
                    else
                    {
                        secondHand.Add(currentCardFirstPlayer);
                        secondHand.Add(currentCardSecondPlayer);
                        secondHand.RemoveAt(index);
                        firstHand.RemoveAt(index);
                    }
                    if (firstHand.Count == 0 || secondHand.Count == 0)
                    {
                        break;
                    }
                    index = -1;
                }
            }
            if (firstHand.Count > 0)
            {
                var sum = firstHand.Sum();  
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                var sum = secondHand.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            
        }
    }
}
