using lab5.Base;
using lab5.Command;
using lab5.Iterator;
using lab5.Visitor;

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
    iterator.Reset();
}

ClearContent();
Console.WriteLine("Task2\n");


ICommand edit = new EditTextCommand(textTitleHead, "Updated Title by Command");
ICommand replace = new ReplaceNodeCommand(body, p, br);

Invoker invoker = new Invoker(edit, replace);
invoker.Editor();
invoker.Replacer();

Console.WriteLine("Update\n");
titleHead.OutterLightHTML();
Console.WriteLine();
body.OutterLightHTML();

invoker.EditorUndo();
invoker.ReplacerUndo();

Console.WriteLine("\nUndo\n");
titleHead.OutterLightHTML();
Console.WriteLine();
body.OutterLightHTML();

ClearContent();
Console.WriteLine("Task3\n");

html.Show();
html.Hide();
html.Hide();
html.Show();

ClearContent();
Console.WriteLine("Task4\n");

var p2 = new LightElementNode("p", (int)DisplayType.Block, (int)IsPaired.Paired);
Console.WriteLine();
var newText = new LightTextNode("some text for task 4");

ClearContent();
Console.WriteLine("Task5\n");

var firstVisitor = new FirstVisitor();
var secondVisitor = new SecondVisitor();

titleHead.Accept(firstVisitor);
textTitleHead.Accept(firstVisitor);

titleHead.Accept(secondVisitor);
textTitleHead.Accept(secondVisitor);

ClearContent();

void ClearContent()
{
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();
}
