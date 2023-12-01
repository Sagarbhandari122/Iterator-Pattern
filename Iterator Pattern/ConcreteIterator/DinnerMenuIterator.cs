using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.ConcreteIterator
{
    public class DinerMenuIterator : Iterator
    {
        private MenuItem[] items;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            // Constructor to initialize the iterator with an array of items
            this.items = items;
        }

        public bool HasNext()
        {
            // Method to check if there's a next element in the Diner's menu
            return position < items.Length && items[position] != null;
        }

        public object Next()
        {
            // Method to retrieve the next element from the Diner's menu
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }
    }

}
