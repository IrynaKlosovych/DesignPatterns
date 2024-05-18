using lab2.AbstractFactory.Brands;
using lab2.Builder;
using lab2.FactoryMethod.Creator;
using lab2.Prototype;
using lab2.Singleton;
using System.Data;

//Task 1
Console.WriteLine("Task1");

WebSite webSite = new WebSite();
var purchesFirst = webSite.BuySubscription();
purchesFirst.ToString();
Console.WriteLine();

MobileApp mob = new MobileApp();
var purchesSecond = mob.BuySubscription();
purchesSecond.ToString();
Console.WriteLine();

ManagerCall call = new ManagerCall();
var purchesThird = call.BuySubscription();
purchesThird.ToString();
ClearContent();

//Task 2
Console.WriteLine("Task2");
Balaxy balaxy = new Balaxy();
var smartphone = balaxy.CreateSmartphone();
smartphone.DisplayInfo();

IProne prone = new IProne();
var laptop = prone.CreateLaptop();
laptop.DisplayInfo();

Kiaomi kiaomi = new Kiaomi();
var netbook = kiaomi.CreateNetbook();
netbook.DisplayInfo();
ClearContent();

//Task 3
Console.WriteLine("Task3");
var someInstanceFirst = Authenticator.GetInstance();
for (int i = 0; i < 10; i++)
{
    Task<Authenticator> task = Task.Run(() =>
    {
        var instance = Authenticator.GetInstance();
        return instance;

    });
    Console.WriteLine($"IsEqual_{i + 1}: {someInstanceFirst == task.Result}");
}
ClearContent();

//Task 4
Console.WriteLine("Task4\n");

Virus virusDaughterChild1 = new Virus(40, 40, "The first daughter of daughter of the oldest virus", "Type of child");
Virus virusDaughterChild2 = new Virus(50, 50, "The second daughter of daughter of the oldest virus", "Type of child");

List<Virus> virusDaughterChildren = new List<Virus>() { virusDaughterChild1, virusDaughterChild2 };

Virus virusSonChild1 = new Virus(60, 60, "The first son of son of the oldest virus", "Type of child");
Virus virusSonChild2 = new Virus(70, 70, "The second son of son of the oldest virus", "Type of child");

List<Virus> virusSonChildren = new List<Virus>() { virusSonChild1, virusSonChild2 };

Virus virusDaughter = new Virus(80, 80, "The daughter of the oldest virus", "Type of daughter", virusDaughterChildren);
Virus virusSon = new Virus(90, 90, "The son of the oldest virus", "Type of son", virusSonChildren);

List<Virus> oldestChildren = new List<Virus>() { virusSon, virusDaughter };

Virus virusOldest = new Virus(100, 100, "The oldest virus", "Type of the oldest viruses", oldestChildren);

Console.WriteLine("Original:");
virusOldest.ShowAllInfo();

var newCopyVirus = (Virus)virusOldest.Clone();

Console.WriteLine();
Console.WriteLine("Copy:");
newCopyVirus.ShowAllInfo();

ClearContent();

Console.WriteLine();
Console.WriteLine("Are they eaual?");
virusOldest.IsEqualVirusAndCopy(newCopyVirus);

ClearContent();

//Task 5
Console.WriteLine("Task5\n");

Director directorFirst = new Director();
var hero = directorFirst.GetHero();
hero.Info();
hero.MakeGoodThings("I make some good thing");
Console.WriteLine();
Director directorSecond = new Director();
var enemy = directorSecond.GetEnemy();
enemy.Info();
enemy.MakeBadThings("I make something bad");

ClearContent();

void ClearContent()
{
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();
}