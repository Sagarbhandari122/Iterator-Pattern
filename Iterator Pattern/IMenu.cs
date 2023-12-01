using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
   

    public interface IMenu
    {
        // Menu interface with a method to create an iterator
        Iterator CreateIterator();
    }

    // MenuItem class representing individual menu items
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegetarian { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            // Constructor to initialize menu item properties
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

    }

}
