using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();
            var conditionsChecker = 0;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                conditionsChecker++;
            }
            if (!CheckingIfIsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                conditionsChecker++;
            }
            if(!IsContainEnoughDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                conditionsChecker++;
            }
            if(conditionsChecker == 0)
            {
                Console.WriteLine("Password is valid");
            }
             
        }


        static bool IsContainEnoughDigits(string password) 
        {
            var charArr = password.ToCharArray();
            var digitsCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(charArr[i]))
                {
                    digitsCounter++;
                }
            }
            if (digitsCounter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckingIfIsOnlyLettersAndDigits(string password) 
        {
            var charArr = password.ToCharArray();
            var wrongCharsCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(charArr[i]))
                {
                    wrongCharsCounter++;
                }
            }
            if (wrongCharsCounter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
