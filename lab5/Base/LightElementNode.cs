using lab5.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace lab5.Base
{
    public enum DisplayType
    {
        Block,
        String
    }
    public enum IsPaired
    {
        Paired,
        Unpaired
    }
    public class LightElementNode : LightNode, IInnerLightHTML, ILightHTMLCollection
    {
        protected List<LightNode> children;
        protected string TagName;
        protected int TagDisplayType;
        protected int TagIsPaired;
        protected List<string> CSSList;
        public LightElementNode(string tag, int displayType, int isPaired, List<string>? cssClasses = null)
        {
            TagName = tag;
            TagDisplayType = displayType;
            TagIsPaired = isPaired;
            CSSList = cssClasses ?? new List<string>();
            children = new List<LightNode>();
        }
        private bool CheckIsPaired()
        {
            if (TagIsPaired != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unpaired Tag doesn't have children");
                Console.ResetColor();
                return false;
            }
            return true;
        }
        public void AddChild(LightNode node)
        {
            if (CheckIsPaired())
                children.Add(node);
        }
        public void RemoveChild(LightNode node)
        {
            if (CheckIsPaired())
                children.Remove(node);
        }
        public void AddCSS(string css)
        {
            CSSList.Add(css);
        }
        public void RemoveCss(string css)
        {
            CSSList.Remove(css);
        }
        public void InnerLightHTML()
        {
            if (TagIsPaired == 0)
                foreach (LightNode node in children)
                {
                    node.OutterLightHTML();
                }
        }

        public override void OutterLightHTML()
        {
            Console.Write($"<{TagName}");
            if (CSSList.Count > 0)
            {
                Console.Write(" style=\"");
                foreach (string css in CSSList)
                {
                    if (css == CSSList.Last())
                    {
                        Console.Write(css);
                        break;
                    }
                    Console.Write(css + " ");
                }
                Console.Write($"\"");
            }
            if (TagIsPaired != 0)
                Console.WriteLine("/>");
            else
            {
                Console.WriteLine(">");
                InnerLightHTML();
                Console.WriteLine($"</{TagName}>");
            }
        }
        public List<LightNode> GetChildren()
        {
            return children;
        }
        public IIterator GetIterator(IteratorType iterator)
        {
            if (iterator == IteratorType.Breadth)
                return new BreadthFirstIterator(this);
            return new DepthFirstIterator(this);
        }

        public override void ShortAbout()
        {
            Console.WriteLine(TagName);
        }
    }
}
