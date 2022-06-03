using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class ListOfArticles
    {
        public ListOfArticles()
        {
            Articles = new List<Article>();
        }
        
        public List<Article> Articles { get; set; }

    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            var numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++) 
            {
                var initialArticle = Console.ReadLine().Split(", ").ToArray();
                string title = initialArticle[0];
                string content = initialArticle[1];
                string author = initialArticle[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            var orderType = Console.ReadLine();

            var orderedArticles = new List<Article>();

            if (orderType == "title")
            {
                orderedArticles = articles.OrderBy(x => x.Title).ToList();
                Console.WriteLine(String.Join(Environment.NewLine, orderedArticles));
            }
            else if (orderType == "content")
            {
                orderedArticles = articles.OrderBy(x => x.Content).ToList();
                Console.WriteLine(String.Join(Environment.NewLine, orderedArticles));
            }
            else
            {
                orderedArticles = articles.OrderBy(x => x.Author).ToList();
                Console.WriteLine(String.Join(Environment.NewLine, orderedArticles));
            }

            
        }
    }
}
