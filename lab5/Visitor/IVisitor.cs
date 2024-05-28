using lab5.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Visitor
{
    public interface IVisitor
    {
        public void Visit(LightElementNode element);
        public void Visit(LightTextNode element);
    }
}
