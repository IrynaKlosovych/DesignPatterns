using lab5.Base;
using lab5.Iterator;

Console.WriteLine("Task1\n");

var html = new LightElementNode("html", (int)DisplayType.Block, (int)IsPaired.Paired);
var head = new LightElementNode("head", (int)DisplayType.Block, (int)IsPaired.Paired);
var body = new LightElementNode("body", (int)DisplayType.Block, (int)IsPaired.Paired);

var titleHead = new LightElementNode("title", (int)DisplayType.Block, (int)IsPaired.Paired);
var textTitleHead = new LightTextNode("Title");
titleHead.AddChild(textTitleHead);
head.AddChild(titleHead);

var p = new LightElementNode("p", (int)DisplayType.Block, (int)IsPaired.Paired);
p.AddCSS("color: red;");
p.AddCSS("background-color: yellow;");
var textFirstP = new LightTextNode("Text1");
var span = new LightElementNode("span", (int)DisplayType.String, (int)IsPaired.Paired);
var textSpan = new LightTextNode("Text Span");
span.AddChild(textSpan);
var textSecondP = new LightTextNode("Text2");
p.AddChild(textFirstP);
p.AddChild(span);
p.AddChild(textSecondP);

var br = new LightElementNode("br", (int)DisplayType.String, (int)IsPaired.Unpaired);

body.AddChild(p);
body.AddChild(br);


html.AddChild(head);
html.AddChild(body);

Console.WriteLine("DFS\n");
var iterator = html.GetIterator(IteratorType.Depth);
logEach(iterator);
Console.WriteLine("\nBFS\n");
iterator = html.GetIterator(IteratorType.Breadth);
logEach(iterator);

static void logEach(IIterator iterator)
{
    while (!iterator.IsDone())
    {
        var nextNode = iterator.Next();
        if (nextNode != null)
        {
            ((LightNode)nextNode).ShortAbout();
        }
    };
}

ClearContent();

void ClearContent()
{
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();
}
