using Iterator_Pattern.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the Pancake House and Diner menus
            IMenu pancakeHouseMenu = new PancakeHouseMenu();
            IMenu dinerMenu = new DinnerMenu();

            // Creating a Waitress to print the menu
            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            waitress.PrintMenu();
        }
    }
}
