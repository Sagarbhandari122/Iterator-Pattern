using Iterator_Pattern.ConcreteIterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Menus
{
    // PancakeHouseMenu class implementing the IMenu interface
    public class PancakeHouseMenu : IMenu
    {
        private ArrayList menuItems;

       
        public PancakeHouseMenu()
        {
            // Constructor to initialize the Pancake House menu items
            menuItems = new ArrayList();

            // Adding menu items to the Pancake House's menu
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries, and blueberry syrup", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        private void AddItem(string name, string description, bool isVegetarian, double price)
        {
            // Correct instantiation with the correct class name
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
            menuItems.Add(menuItem);
        }

        public Iterator CreateIterator()
        {
            // Method to create an iterator for the Pancake House's menu
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
