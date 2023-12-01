using Iterator_Pattern.ConcreteIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Menus
{
    public class DinnerMenu : IMenu
    {
        private static readonly int MAX_ITEMS = 6;
        private int numberOfItems = 0;
        private MenuItem[] menuItems;

        public DinnerMenu()
        {
            // Constructor to initialize the Diner menu items
            menuItems = new MenuItem[MAX_ITEMS];

            // Adding menu items to the Diner's menu
            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05);
            AddItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89);
        }

        private void AddItem(string name, string description, bool isVegetarian, double price)
        {
            // Method to add an item to the Diner's menu
            if (numberOfItems < MAX_ITEMS)
            {
                menuItems[numberOfItems++] = new MenuItem(name, description, isVegetarian, price);
            }
        }

        public Iterator CreateIterator()
        {
            // Method to create an iterator for the Diner's menu
            return new DinerMenuIterator(menuItems);
        }
    }

}
