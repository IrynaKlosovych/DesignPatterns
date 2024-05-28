using lab5.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Iterator
{
    public class BreadthFirstIterator : IIterator
    {
        private List<LightNode> elems = new List<LightNode>();
        private int _cursor = -1;
        public BreadthFirstIterator(LightElementNode node) { 
            Iterate(node);
        }
        public object? Current()
        {
            return this._cursor > -1 && this._cursor < elems.Count ? elems[this._cursor] : null;
        }

        public bool IsDone()
        {
            return this._cursor + 1 == this.elems.Count;
        }

        public void Iterate(LightNode node)
        {
            if (node == null) return;

            Queue<LightNode> queue = new Queue<LightNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                LightNode currentNode = queue.Dequeue();
                elems.Add(currentNode);
                if(currentNode is LightElementNode)
                foreach (var child in ((LightElementNode)currentNode).GetChildren())
                {
                    queue.Enqueue(child);
                }
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
