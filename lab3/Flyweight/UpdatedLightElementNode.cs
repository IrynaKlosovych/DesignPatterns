using lab3.Composite;

namespace lab3.Flyweight
{
    public enum NewDisplayType
    {
        Block,
        String
    }
    public enum NewIsPaired
    {
        Paired,
        Unpaired
    }
    public class UpdatedLightElementNode : LightNode, IInnerLightHTML
    {
        protected List<LightNode> children;
        protected Tag tag;
        protected List<string> CSSList;
        public UpdatedLightElementNode(string tag, int displayType, int isPaired, List<string>? cssClasses = null)
        {
            this.tag = TagFactory.GetTag(tag, displayType, isPaired);
            CSSList = cssClasses ?? new List<string>();
            children = new List<LightNode>();
        }
        private bool CheckIsPaired()
        {
            if (this.tag.TagIsPaired != 0)
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
        public void InnerLightHTML()
        {
            if (this.tag.TagIsPaired == 0)
                foreach (LightNode node in children)
                {
                    node.OutterLightHTML();
                }
        }

        public override void OutterLightHTML()
        {
            Console.Write($"<{this.tag.TagName}");
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
            if (this.tag.TagIsPaired != 0)
                Console.WriteLine("/>");
            else
            {
                Console.WriteLine(">");
                InnerLightHTML();
                Console.WriteLine($"</{this.tag.TagName}>");
            }
        }
    }
}
