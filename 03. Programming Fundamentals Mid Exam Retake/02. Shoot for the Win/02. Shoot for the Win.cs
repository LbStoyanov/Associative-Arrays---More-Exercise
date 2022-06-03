using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var countOfShotTargets = 0;
            while (true)
            {
                var currentCommand = Console.ReadLine();
                if (currentCommand == "End")
                {
                    break;
                }
                var currentTargetIndex = int.Parse(currentCommand);
                //bool isTargetShot = false;
                if (currentTargetIndex < 0 || currentTargetIndex > targets.Count - 1) 
                {
                    continue;
                }
                else
                {
                    
                    var targetToBeShot = targets[currentTargetIndex];
                    targets[currentTargetIndex] = - 1;
                    countOfShotTargets++;
                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (targets[i] != -1)
                        {
                            if (targets[i] > targetToBeShot)
                            {
                                targets[i] -= targetToBeShot;
                            }
                            else
                            {
                                targets[i] += targetToBeShot;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {countOfShotTargets} -> {string.Join(" ",targets)}");
        }
    }
}
