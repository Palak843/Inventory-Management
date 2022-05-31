// See https://aka.ms/new-console-template for more information
namespace Warehouse {
    class Program{
        public static void Main (String[]args){
             Item fruit = new Item("Banana" ,2);
            Item vegetable = new Item("Tomato",3);
            Warehouse stock = new Warehouse(new Dictionary<Item, int>());

            fruit.ItemDetails();
            vegetable.ItemDetails();
        }
    }
}
