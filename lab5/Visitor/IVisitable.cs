using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Visitor
{
    public interface IVisitable
    {
        public void Accept(IVisitor visitor);
    }
}
