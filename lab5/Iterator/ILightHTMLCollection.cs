using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Iterator
{
    public enum IteratorType{
        Breadth,
        Depth
    }
    public interface ILightHTMLCollection
    {
        public IIterator GetIterator(IteratorType type);
    }
}
