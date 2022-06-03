using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketsCollection = Console.ReadLine();
            string[] ticketsArr = ticketsCollection.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < ticketsArr.Length; i++)
            {
                string currTicket = ticketsArr[i].Trim();
                if (currTicket.Length == 20)
                {
                    if (IsJackpot(currTicket))
                    {
                        var ticketSymbol = currTicket[0];
                        Console.WriteLine($"ticket \"{currTicket}\" - 10{ticketSymbol} Jackpot!");
                    }
                    else
                    {
                        IsWinning(currTicket);
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
                
            }

        }
        static void IsWinning(string ticket)
        {
            StringBuilder firstHalf = new StringBuilder();
            StringBuilder secondHalf = new StringBuilder();

            int splitIndex = ticket.Length / 2;

            for (int i = 0; i < ticket.Length; i++)
            {
                if (i < 10)
                {
                    firstHalf.Append(ticket[i]);
                }
                else
                {
                    secondHalf.Append(ticket[i]);
                }
            }
            Regex regex = new Regex(@"[@#$^]{6,}");
            Match first = regex.Match(firstHalf.ToString());
            Match second = regex.Match(secondHalf.ToString());

            if (first.Success && second.Success)
            {
                var ticketSymbol = first.Value[0];
                Console.WriteLine($"ticket \"{ticket}\" - 6{ticketSymbol}");
            }
            else
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
        static bool IsJackpot(string ticket)
        {
            StringBuilder firstHalf = new StringBuilder();
            StringBuilder secondHalf = new StringBuilder();

            int splitIndex = ticket.Length / 2;

            for (int i = 0; i < ticket.Length; i++)
            {
                if (i < 10)
                {
                    firstHalf.Append(ticket[i]);
                }
                else
                {
                    secondHalf.Append(ticket[i]);
                }
            }
            Regex regex = new Regex(@"[@#$^]{10}");
            Match first = regex.Match(firstHalf.ToString());
            Match second = regex.Match(secondHalf.ToString());

            if (first.Success && second.Success)
            {
                return true;
            }
            else
            {
                return false;
            }

            //bool isFirstFullMatch = true;
            //bool isSecondFullMatch = true;
            //for (int i = 1; i < firstHalf.Length; i++)
            //{
            //    var previousChar = firstHalf[i - 1];
            //    var nextChar = firstHalf[i];
            //    if (previousChar != nextChar)
            //    {
            //        isFirstFullMatch = false;
            //        break;
            //    }
            //}
            //for (int i = 1; i < secondHalf.Length; i++)
            //{
            //    var previousChar = secondHalf[i - 1];
            //    var nextChar = secondHalf[i];
            //    if (previousChar != nextChar)
            //    {
            //        isSecondFullMatch = false;
            //        break;
            //    }
            //}
            //if (isFirstFullMatch && isSecondFullMatch)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            
        }
    }
}
