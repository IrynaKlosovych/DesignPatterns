using lab3.Adapter;
using lab3.Bridge.Rendering;
using lab3.Bridge.Shapes;
using lab3.Composite;
using lab3.Decorator.Heroes;
using lab3.Decorator.Inventory;
using lab3.Flyweight;
using lab3.Proxy;
using System.Diagnostics;

Console.WriteLine("Task1\n");
FileWriter writer = new FileWriter();
AdapterFileLogger adapter = new AdapterFileLogger(writer);

adapter.NewLog("Some message", WriteMode.write);
adapter.NewError("error message", WriteMode.writeline);
adapter.NewWarn("Warn, warn, warn", WriteMode.write);

ClearContent();
Console.WriteLine("Task2\n");

Mage mage = new Mage();
mage.GetPower();
mage.GetEnergy();
Palladin palladin = new Palladin();
palladin.GetPower();
palladin.GetEnergy();
Warrior warrior = new Warrior();
warrior.GetPower();
warrior.GetEnergy();
Console.WriteLine("..........");

Artefact artefact = new Artefact(mage);
artefact.GetPower();
artefact.GetEnergy();
Clothes clothes = new Clothes(mage);
clothes.GetPower();
clothes.GetEnergy();
Console.WriteLine("..........");

artefact = new Artefact(palladin);
artefact.GetPower();
artefact.GetEnergy();
Console.WriteLine("..........");

Weapons weapons = new Weapons(warrior);
weapons.GetPower();
weapons.GetEnergy();

ClearContent();
Console.WriteLine("Task3\n");

Raster raster = new Raster();
Vector vector = new Vector();


Circle circle = new Circle(raster);
circle.Dwaw();

Square square = new Square(vector);
square.Dwaw();

circle.SetImpl(vector);
circle.Dwaw();

Triangle triangle = new Triangle(vector);
triangle.Dwaw();

triangle.SetImpl(raster);
triangle.Dwaw();

square.SetImpl(raster);
square.Dwaw();

ClearContent();
Console.WriteLine("Task4\n");

Console.WriteLine("SmartTextReader");
string path = "..\\..\\..\\..\\lab3\\SomeMaterialsForLab\\demo.txt";
SmartTextReader reader = new SmartTextReader();
var arr = reader.ReadFile(path);
if (arr != null)
    foreach (var line in arr)
    {
        Console.WriteLine(line);
    }
Console.WriteLine("\nSmartTextChecker");
SmartTextChecker checker = new SmartTextChecker(reader);
checker.ReadFile(path);

Console.WriteLine("\nSmartTextReaderLocker 1");
SmartTextReaderLocker lockerFirst = new SmartTextReaderLocker(reader, ".txt");
lockerFirst.ReadFile(path);

Console.WriteLine("\nSmartTextReaderLocker 2");
SmartTextReaderLocker lockerSecond = new SmartTextReaderLocker(reader, ".pdf");
lockerSecond.ReadFile(path);


ClearContent();
Console.WriteLine("Task5\n");

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

html.OutterLightHTML();

Console.WriteLine("----------------------------");

p.RemoveCss("color: red;");
p.RemoveChild(textSecondP);

html.OutterLightHTML();

Console.WriteLine("----------------------------");
br.AddChild(textSecondP);

ClearContent();
Console.WriteLine("Task6\n");
string pathForFlyweight = "..\\..\\..\\..\\lab3\\SomeMaterialsForLab\\text.txt";

Console.WriteLine("Without Flyweight");
ReadFiles.ReadFilesWithoutFlyweight(pathForFlyweight);
Console.WriteLine("----------------------------");
Console.WriteLine("With Flyweight");
ReadFiles.ReadFilesWithFlyweight(pathForFlyweight);

ClearContent();

void ClearContent()
{
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();
}
