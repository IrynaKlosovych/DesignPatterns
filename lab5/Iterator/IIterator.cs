using lab5.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Iterator
{
    public interface IIterator
    {
        public void Iterate(LightNode node);
        public object? Next();
        public object? Current();
        public bool IsDone();
        public void Reset();
    }
}
