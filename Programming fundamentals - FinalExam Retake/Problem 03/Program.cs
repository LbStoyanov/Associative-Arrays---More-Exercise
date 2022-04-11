using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> notePad = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Go Shopping")
            {
                string[] actions = input.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string mainAction = actions[0];

                if (mainAction == "Add")
                {
                    string store = actions[1];
                    List<string> products = actions[2].Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
                    Add(notePad, store, products);

                }
                else if (mainAction == "Important")
                {
                    string store = actions[1];
                    string product = actions[2];
                    AddImportant(notePad, store, product);

                }
                else if (mainAction == "Remove")
                {
                    string store = actions[1];
                    Remove(notePad, store);
                }

                input = Console.ReadLine();
            }

            foreach (var store in notePad)
            {
                Console.WriteLine($"{store.Key}:");

                foreach (var item in notePad[store.Key])
                {
                    Console.WriteLine($" - {item}");
                }
            }
        }
        static void Remove(Dictionary<string, List<string>> notePade, string store)
        {
            if (notePade.ContainsKey(store))
            {
                var firstProduct = notePade[store][0];
                if (firstProduct[0] == 'I')
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < firstProduct.Length; i++)
                    {
                        sb.Append(firstProduct[i]);
                    }

                    notePade[store][0] = sb.ToString();
                    return;
                }
                else
                {
                    notePade.Remove(store);
                }

            }
        }
        static void AddImportant(Dictionary<string, List<string>> notePade, string store, string product)
        {

            if (!notePade.ContainsKey(store))
            {
                notePade.Add(store, new List<string> { product });
            }
            else
            {
                bool isExist = false;
                foreach (var currStore in notePade)
                {
                    var currentStoreList = notePade[currStore.Key];

                    foreach (var currProduct in currentStoreList)
                    {
                        if (currentStoreList.Contains(product))
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (isExist)
                    {
                        break;
                    }
                }
                if (!isExist)
                {
                    notePade[store].Remove(product);
                    notePade[store].Insert(0, "I" + product);
                }

            }
        }

        static void Add(Dictionary<string, List<string>> notePade, string store, List<string> products)
        {
            bool isExist = false;
            if (!notePade.ContainsKey(store))
            {
                notePade.Add(store, new List<string>());
            }
            foreach (var shop in notePade)
            {
                foreach (var item in notePade[shop.Key])
                {
                    var currentProduct = item;

                    for (int i = 0; i < products.Count; i++)
                    {
                        if (currentProduct == products[i])
                        {
                            break;
                        }
                    }
                }
            }

        }
    }
}
