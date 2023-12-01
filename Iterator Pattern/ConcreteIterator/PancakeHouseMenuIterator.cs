using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.ConcreteIterator
{
    public class PancakeHouseMenuIterator : Iterator
    {
        private ArrayList items;
        private int position = 0;

        public PancakeHouseMenuIterator(ArrayList items)
        {
            // Constructor to initialize the iterator with a collection of items
            this.items = items;
        }

        public bool HasNext()
        {
            // Method to check if there's a next element in the Pancake House's menu
            return position < items.Count;
        }

        public object Next()
        {
            // Method to retrieve the next element from the Pancake House's menu
            MenuItem menuItem = (MenuItem)items[position];
            position++;
            return menuItem;
        }
    }

}
