namespace Warehouse
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price {get; set;}


        public Item(string name, decimal price )
        {
            Name = name;
            Price = price;
        }
         public void ItemDetails()
        {
            Console.WriteLine($"Item name: {Name}, Price: £{Price}");
        }
    }
}