using System;
using System.Collections.Generic;
namespace Warehouse
{
    public class Warehouse
    {
         public Dictionary<Item, int> Stock { get; }
         string Name { get; set; }

        decimal Budget { get; set; }

        public Warehouse(Dictionary<Item, int> stock)
        {
            Stock = stock;
        }
         public void Add(Item item, int amount)
        {
            Stock.Add(item, amount);
        }
       public void CurrentStock()
        {
            Console.WriteLine("\nCurrent stock in Warehouse:");
            foreach (var item in Stock)
            {
                Console.WriteLine($"\tItem: {item.Key.Name}, Amount: {item.Value}");
            }

        }
         public void ItemDetails()
        {
            Console.WriteLine("\nFood names with their prices in stock in Warehouse:");
            foreach (var item in Stock)
            {
                item.Key.ItemDetails();
            }

        }
    }
}