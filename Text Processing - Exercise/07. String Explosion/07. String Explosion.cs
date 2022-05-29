using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string field = Console.ReadLine();

            char[] fieldArr = field.ToCharArray();
            char explosionMark = '>';

            
            int currExplosionStrenth = 0;

            bool isExplosion = false;

            for (int i = 0; i < fieldArr.Length; i++)
            {
                var currChar = fieldArr[i];

                if (currChar == explosionMark)
                {
                    isExplosion = true;
                    continue;
                }

                if (isExplosion)
                {
                    currExplosionStrenth += fieldArr[i] - 48;
                    isExplosion = false;
                }

                if (currExplosionStrenth > 0)
                {
                    fieldArr[i] = '0';
                    currExplosionStrenth--;
                }
            }

            string result = string.Empty;
            foreach (var ch in fieldArr)
            {
                if (ch != '0')
                {
                    result += ch;
                }
            }
            Console.WriteLine(result);
        }
                
    }
}
