using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var allowedAttempts = 4;
            var userName = Console.ReadLine().ToCharArray();
            var correctPass = new char[userName.Length];
            for (int k = 0; k < userName.Length; k++)
            {
                correctPass[k] = userName[userName.Length - k - 1];
            }

            for (int i = 1; i < allowedAttempts; i++)
            {
                var currentInput = Console.ReadLine().ToCharArray();
                bool isEqual = true;
                for (int j = 0; j < currentInput.Length; j++)
                {
                    
                    if (currentInput.Length != correctPass.Length)
                    {
                        isEqual = false;
                        break;
                    }
                    if (currentInput[j] == correctPass[j])
                    {
                        continue;
                    }
                    else
                    {
                        isEqual = false;
                        break;
                    }
                }
                if (isEqual)
                {
                    Console.WriteLine($"User {string.Join("",userName)} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    isEqual = true;
                }
            }

            Console.WriteLine($"User {string.Join("", userName)} blocked!");

        }
    }
}
