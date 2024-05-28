using lab5.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Base
{
    public class LightTextNode : LightNode, IVisitable
    {
        public string text {  get; set; }
        public LightTextNode(string text)
        {
            this.text = text;
            this.TemplateMethod();
        }

        public override void OutterLightHTML()
        {
            Console.WriteLine(text);
        }

        public override void ShortAbout()
        {
            Console.WriteLine(text);
        }
        protected override void OnCreated()
        {
            base.OnCreated();
            Console.WriteLine("TextElement is on created");
        }
        protected override void OnInserted()
        {
            base.OnInserted();
            Console.WriteLine("TextElement is on inserted");
        }
        protected override void OnTextRendered()
        {
            base.OnTextRendered();
            Console.WriteLine("TextElement is on text added");
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
