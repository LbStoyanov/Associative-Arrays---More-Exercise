using System;
using System.Text;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            /*string articleContent = Console.ReadLine()*/;
            StringBuilder article = new StringBuilder($"<h1>{Environment.NewLine}{string.Concat(" ")}{articleTitle}{Environment.NewLine} </h1>");
            Console.WriteLine(article);
            //Console.WriteLine("<h1>");
            //Console.WriteLine($"{" "}{" "}{" "}{" "}{articleTitle}");
            ////Console.WriteLine("</h1>");
            //Console.WriteLine("<article>");
            //Console.WriteLine($"{" "}{" "}{" "}{" "}{articleContent}");
            //Console.WriteLine("</article>");

            //string comments = Console.ReadLine();

            //while (comments != "end of comments")
            //{
            //    Console.WriteLine($"<div>");
            //    Console.WriteLine($"{" "}{" "}{" "}{" "}{comments}");
            //    Console.WriteLine($"</div>");
            //    comments = Console.ReadLine();
            //}
        }
    }
}
