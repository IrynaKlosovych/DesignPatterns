using System;
using lab4.CoR;
using lab4.Mediator;
using lab4.Memento;
using lab4.Observer;
using lab4.Observer.Events;
using lab4.Strategy;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Task 1\n");

IHandler interceptors = ClientCoR.GetInterceptors();

int number = 6;
int? res = null;
do
{
    Console.WriteLine($"It's number {number}");
    for (int i = number; i >= number; i--)
        res = interceptors.Handle(number);
    number--;
} while (res == null);
Console.WriteLine($"It's number {number}");
res = interceptors.Handle(number);

ClearContent();
Console.WriteLine("Task 2\n");
var runway1 = new Runway(false);
var runway2 = new Runway(false);
var runway3 = new Runway(false);

var aircraft1 = new Aircraft("Aircraft 1", true, null);
var aircraft2 = new Aircraft("Aircraft 2", false, runway2.Id);
runway2.IsBusyWithAircraft = true;
var aircraft3 = new Aircraft("Aircraft 3", true, null);


Runway[] runways = [runway1, runway2, runway3];
Aircraft[] aircrafts = [aircraft1, aircraft2, aircraft3];

CommandCentre commandCenter = new CommandCentre(runways, aircrafts);

aircraft1.Land(runway1.Id);

Console.WriteLine();

aircraft3.Land(runway1.Id);
aircraft3.Land(runway3.Id);

Console.WriteLine();
commandCenter.InfoAboutAircrafts();
Console.WriteLine();
commandCenter.InfoAboutRunways();

Console.WriteLine();
aircraft2.TakeOff();

Console.WriteLine();
commandCenter.InfoAboutAircrafts();
Console.WriteLine();
commandCenter.InfoAboutRunways();

ClearContent();
Console.WriteLine("Task 3\n");

var p = new LightElementNode("p", (int)DisplayType.Block, (int)IsPaired.Paired, null);
var click = new Click();
var mouseover = new Mouseover();
p.Subscribe(click);
p.InvokeEvent(click);
p.Subscribe(mouseover);
p.InvokeEvent(mouseover);
p.InvokeEvent(click);
p.Unsubscribe(mouseover);
p.InvokeEvent(mouseover);


ClearContent();
Console.WriteLine("Task 4\n");

Context context = new Context();
context.DownloadImage("https://refactoring.guru/uk/design-patterns/catalog");
context.DownloadImage("C:\\Users\\PC\\DesignPatterns\\lab4\\Strategy.png");

ClearContent();
Console.WriteLine("Task 5\n");


TextDocument document = new TextDocument("Memento", "Memento is a pattern");
ITextEditor originator = new TextEditor(document);
var caretaker = new Caretaker();

caretaker.Backup(originator.Save());

document.UpdateTitle("Snapshot");

caretaker.Backup(originator.Save());

document.UpdateStateByAddingContent(" that lets you save and restore the previous state of an object");

caretaker.Backup(originator.Save());

caretaker.RenderSnapshotList();

Console.WriteLine(originator);

Console.WriteLine("Undo 1");
caretaker.Undo();
Console.WriteLine(originator);
Console.WriteLine("Undo 2");
caretaker.Undo();
Console.WriteLine(originator);

caretaker.RenderSnapshotList();

Console.WriteLine("Undo 3");
caretaker.Undo();
Console.WriteLine(originator);

caretaker.RenderSnapshotList();

ClearContent();

void ClearContent()
{
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();
}
