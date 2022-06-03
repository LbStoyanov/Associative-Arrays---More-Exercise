using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; } //ItemName && ItemPrice
        public int ItemQuantity { get; set; }
        public decimal PriceForOneBox { get; set; }
        
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (data != "end")
            {
                var currentData = data.Split().ToArray();

                string serialNumber = currentData[0];
                string itemName = currentData[1];
                int itemQuantity = int.Parse(currentData[2]);
                decimal itemPrice = decimal.Parse(currentData[3]);

                Box currentBox = new Box();
                Item currentItem = new Item();

                currentBox.SerialNumber = serialNumber;
                currentBox.ItemQuantity = itemQuantity;
                currentBox.Item = currentItem;
                currentBox.PriceForOneBox = itemPrice * itemQuantity;

                currentItem.Name = itemName;
                currentItem.Price = itemPrice;
                
                boxes.Add(currentBox);

                data = Console.ReadLine();
            }

            var orderedBoxes = boxes.OrderByDescending(b => b.PriceForOneBox).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForOneBox:f2}");
            }
        }

    }
}
