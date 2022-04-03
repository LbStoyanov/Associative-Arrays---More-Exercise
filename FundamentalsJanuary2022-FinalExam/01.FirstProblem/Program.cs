using System;
using System.Text;

namespace _01.FirstProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Complete")
            {
                string[] actions = command.Split(" ");
                string mainAction = actions[0];

                if (mainAction == "Make")
                {
                    string secondAction = actions[1];
                    int index = int.Parse(actions[2]);

                    if (secondAction == "Upper")
                    {
                        password = MakeUpper(password, index);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        password = MakeLower(password, index);
                        Console.WriteLine(password);
                    }
                }
                else if (mainAction == "Insert")
                {
                    int index = int.Parse(actions[1]);
                    if (index < 0 || index > password.Length - 1)
                    {
                        continue;
                    }
                    char currentChar = char.Parse(actions[2]);
                    password = Insert(password, index, currentChar);
                    Console.WriteLine(password);

                }
                else if (mainAction == "Replace")
                {
                    char currentChar = char.Parse(actions[1]);
                    int value = int.Parse(actions[2]);
                    if (!password.Contains(currentChar))
                    {
                        continue;
                    }
                    else
                    {
                        password = Replace(password, currentChar, value);
                        Console.WriteLine(password);
                    }
                }
                else if (mainAction == "Validation")
                {
                    PasswordValidation(password);
                }
                
            }
        }
        static string Replace(string password, char currentChar, int value)
        {
            var sum = Convert.ToInt32(currentChar) + value;
            var charForReplacing = Convert.ToChar(sum);
            password = password.Replace(currentChar,charForReplacing);
            return password;
        }
        static string Insert(string password, int index, char currentChar)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < password.Length; i++)
            {
                if (i == index)
                {
                    sb.Append(currentChar);
                }
                sb.Append(password[i]);
            }

            return sb.ToString();
        }
        static string MakeLower(string password, int index)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < password.Length; i++)
            {
                var currentChar = password[i];
                if (i == index)
                {
                    sb.Append(char.ToLower(currentChar));
                    continue;
                }
                sb.Append(currentChar);
            }
            return sb.ToString();

        }
        static string MakeUpper(string password,int index)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < password.Length; i++)
            {
                var currentChar = password[i];
                if (i == index)
                {
                    sb.Append(char.ToUpper(currentChar));
                    continue;
                }
                sb.Append(currentChar);
            }
            return sb.ToString();

        }
        static bool PasswordValidation(string password)
        {
            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long!");
                return false;
            }

            if (!IsConsistLettersAndDigitsOnly(password))
            {
                Console.WriteLine("Password must consist only of letters, digits and _!");
                return false;
            }

            if (!VerifyForOneUppercase(password))
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
                return false;
            }

            if (!VerifyForOneLowercase(password))
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
                return false;
            }

            if (!VerifyForOneDigit(password))
            {
                Console.WriteLine("Password must consist at least one digit!");
                return false;
            }

            return true;
        }
        static bool VerifyForOneDigit(string password)
        {


            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        static bool VerifyForOneLowercase(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        static bool VerifyForOneUppercase(string password)
        {


            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsConsistLettersAndDigitsOnly(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                var currentChar = password[i];

                if (char.IsLetter(currentChar) || char.IsDigit(currentChar) || currentChar == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
