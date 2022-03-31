using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;

            var playerStatisticDict = new Dictionary<string, Dictionary<string,int>>();

            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] splittedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string mainAction = splittedInput[1];

                if (mainAction == "->")
                {
                    string player = splittedInput[0];
                    string position = splittedInput[2];
                    int skill = int.Parse(splittedInput[4]);

                    ModifyCurrentPlayer(playerStatisticDict, player, position, skill);
                }
                else
                {
                    string firstPlayer = splittedInput[0];

                    string secondPlayer = splittedInput[2];

                    CombatModification(playerStatisticDict, firstPlayer, secondPlayer);
                }
            }

            PrintResult(playerStatisticDict);

        }
        static void PrintResult(Dictionary<string, Dictionary<string, int>> playerStatisticDict)
        {
            foreach (var player in playerStatisticDict.OrderByDescending(player => player.Value.Sum(y => y.Value)).ThenBy(player => player))
            {
                var currentPlayer = player.Key;
                var contestDict = playerStatisticDict[currentPlayer];

                
                int result = contestDict.Sum(x => x.Value);

                Console.WriteLine($"{currentPlayer}: { result} skill");

                foreach (var game in contestDict.OrderByDescending(game => game.Value).ThenBy(game => game.Key))
                {
                    var currentPosition = game.Key;
                    var currentSkill = game.Value;

                    Console.WriteLine($"- {currentPosition} <::> {currentSkill}");
                }
            }
        }
        static void CombatModification(Dictionary<string, Dictionary<string, int>> playerStatisticDict, string firstPlayer, string secondPlayer)
        {

            if (!playerStatisticDict.ContainsKey(firstPlayer) || !playerStatisticDict.ContainsKey(secondPlayer))
            {
                return;
            }
            else
            {
                //Battle
                //At least one commmon position Requiered!!
                IsThereCommonPositions(playerStatisticDict, firstPlayer, secondPlayer);
            }
        }
        static void IsThereCommonPositions(Dictionary<string, Dictionary<string, int>> playerStatisticDict, string firstPlayer, string secondPlayer)
        {
            var playersPositionsDict = playerStatisticDict[firstPlayer];

            foreach (var position in playersPositionsDict)
            {
                var currentPositionFirstPlayer = position.Key;

                if (playerStatisticDict[secondPlayer].ContainsKey(currentPositionFirstPlayer))
                {
                    var firstPlayerSkill = playerStatisticDict[firstPlayer][currentPositionFirstPlayer];
                    var secondPlayerSkill = playerStatisticDict[secondPlayer][currentPositionFirstPlayer];
                    if (firstPlayerSkill > secondPlayerSkill)
                    {
                        playerStatisticDict.Remove(secondPlayer);
                        break;
                    }
                    else if (secondPlayerSkill > firstPlayerSkill)
                    {
                        playerStatisticDict.Remove(firstPlayer);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }


        }

        static void ModifyCurrentPlayer(Dictionary<string, Dictionary<string, int>> playerStatisticDict, string player, string position, int skill)
        {
            if (!playerStatisticDict.ContainsKey(player))
            {
                playerStatisticDict.Add(player, new Dictionary<string, int> { { position, skill } }); 
            }
            else
            {
                if (!playerStatisticDict[player].ContainsKey(position))
                {
                    playerStatisticDict[player].Add(position, skill);
                }
                else
                {
                    var oldSkill = playerStatisticDict[player][position];

                    if (skill > oldSkill)
                    {
                        playerStatisticDict[player][position] = skill;
                    }
                }
            }
        }
    }
}