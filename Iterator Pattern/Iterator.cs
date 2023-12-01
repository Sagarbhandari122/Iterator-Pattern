using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public interface Iterator
    {
        // Iterator interface with methods to check if there's a next element and retrieve the next element
        bool HasNext();
        object Next();
    }
}
