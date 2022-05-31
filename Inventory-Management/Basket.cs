using System.Collections.Generic;
namespace Warehouse
{
    public class Basket
    {
        public List<Item> Item { get; set; }

        public Basket()
        {

            Item = new List<Item>();
        }
        public void AddToBasket(Item item, int stock)
        {
            
        }
}
}