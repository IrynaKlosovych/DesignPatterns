using lab5.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Visitor
{
    public class SecondVisitor: IVisitor
    {
        public void Visit(LightElementNode element)
        {
            Console.WriteLine($"I visited {element.GetTagName()} using SecondVisitor");
        }

        public void Visit(LightTextNode element)
        {
            Console.WriteLine($"I visited some text: {element.text} - using SecondVisitor");
        }
    }
}
