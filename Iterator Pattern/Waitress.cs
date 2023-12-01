using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    internal class Waitress
    {
        private IMenu pancakeHouseMenu;
        private IMenu dinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            // Constructor to initialize the Waitress with Pancake House and Diner menus
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            // Method to print the combined menu
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeHouseMenu.CreateIterator());

            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerMenu.CreateIterator());
        }

        private void PrintMenu(Iterator iterator)
        {
            // Method to iterate through and print menu items
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price} -- {menuItem.Description}");
            }
        }
    }
}
