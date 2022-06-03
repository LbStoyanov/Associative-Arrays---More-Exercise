using System;
using System.Linq;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title  { get; set; }
        public string Content  { get; set; }
        public string Author  { get; set; }
        public void Edit(string newContend)
        {
            Content = newContend;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var initialArticle = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(initialArticle[0],initialArticle[1], initialArticle[2]);
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] mainCommand = Console.ReadLine().Split(": ");
                string currentCommand = mainCommand[0];
                string argument = mainCommand[1];
                
                if (currentCommand == "Edit")
                {
                    article.Edit(argument);
                }
                else if (currentCommand == "ChangeAuthor")
                {
                    article.ChangeAuthor(argument);
                }
                else if (currentCommand == "Rename")
                {
                    article.Rename(argument);
                }
            }

            Console.WriteLine(article);
        }
    }
}
