using lab5.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab5.Iterator
{
    public class DepthFirstIterator : IIterator
    {
        private List<LightNode> elems = new List<LightNode>();
        private int _cursor = -1;

        public DepthFirstIterator(LightElementNode aggregate)
        {
            Iterate(aggregate);
        }
        public object? Current()
        {
            return this._cursor > -1 && this._cursor<elems.Count ? elems[this._cursor] : null;
        }

        public bool IsDone()
        {
            return this._cursor + 1 == this.elems.Count;
        }

        public void Iterate(LightNode node)
        {
            if (node == null) return;
            elems.Add(node);
            if(node is LightElementNode)
            foreach (var child in ((LightElementNode)node).GetChildren())
            {
                Iterate(child);
            }
        }

        public object? Next()
        {
            return this.IsDone() ? null : this.elems[++this._cursor];
        }

        public void Reset()
        {
            this._cursor = -1;
        }
    }
}
