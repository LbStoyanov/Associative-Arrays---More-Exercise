using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToList();
            var outPutList = new List<string>();
            for (int index = 0; index < array.Count; index++)
            {
                var currentString = array[index].ToCharArray();
                StringBuilder currentArr = new StringBuilder();
                for (int j = 0; j < currentString.Length; j++)
                {
                    if (char.IsDigit(currentString[j]))
                    {
                        currentArr.Append(currentString[j] + " ");
                    }
                }
                outPutList.Add(currentArr.ToString());

            }
            outPutList.Reverse();
            Console.WriteLine(String.Join("",outPutList));
        }
    }
}
