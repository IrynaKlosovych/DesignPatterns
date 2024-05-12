//Завдання 1 (Варіант 2): Виконати завдання з дотриманням відомих Вам принципів програмування.
//1. Створіть систему класів для обліку зоопарку. Ви можете
//створювати класи для різних видів і підвидів тварин; для вольєрів
//різних розмірів і типів; корму для тварин; працівників зоопарку.
//2.Створіть класи інвентаризації, для виведення на екран
//інформації про наявних тварин, кількості співробітників тощо.
//Завдання 2: Написати код для тестування отриманої функціональності.
//1. Покажіть правильність роботи свого коду запустивши його в
//головному методі програми.
//2. Достатньо буде просто вивести певну інформацію, щоб
//показати, що класи комунікують певним чином між собою.
using lab1.classes.food;
using lab1.classes.worker;
using lab1.classes.cages;
using lab1.classes.animals;
using lab1.classes.inventory;

ZooKeeper zooKeeperFirst = new ZooKeeper("Iryna", 19, "lions", 10000);
ZooKeeper zooKeeperSecond = new ZooKeeper("George", 19, "tigers", 9000);

Food foodFirst = new Food("Fish for penguins", 10);
Food foodSecond = new Food("Meat for lions and tigers", 56);
Food foodThird = new Food("Some food for dolphins", 18);


Lion lionFirst = new Lion(1, "Leo");
Lion lionSecond = new Lion(2, "Leonardo");
Penguin penguinFirst = new Penguin(3, "Pengui");
Dolphin dolphin = new Dolphin(4, "Dolphy");
Flamingo flamingo = new Flamingo(5, "Flammi");
Penguin penguinSecond = new Penguin(6, "Penni");
Tiger tiger = new Tiger(7, "Tima");


Cage<Lion> lions = new Cage<Lion>(CageSize.Big.ToString());
lions.AddAnimal(lionFirst);
lions.AddAnimal(lionSecond);

Cage<Penguin> penguins = new Cage<Penguin>(CageSize.Middle.ToString());
penguins.AddAnimal(penguinFirst);
penguins.AddAnimal(penguinSecond);

Cage<Dolphin> dolphyns = new Cage<Dolphin>(CageSize.Small.ToString());
dolphyns.AddAnimal(dolphin);

Cage<Flamingo> flamingoes = new Cage<Flamingo>(CageSize.Middle.ToString());
flamingoes.AddAnimal(flamingo);

Cage<Tiger> tigers = new Cage<Tiger>(CageSize.Big.ToString());
tigers.AddAnimal(tiger);



List<ICage<Animal>> cagesAnimals = new List<ICage<Animal>>();
cagesAnimals.Add(lions);
cagesAnimals.Add(flamingoes);
cagesAnimals.Add(tigers);
cagesAnimals.Add(penguins);
cagesAnimals.Add(dolphyns);

List<ZooKeeper> zooKeepers = new List<ZooKeeper>();
zooKeepers.Add(zooKeeperFirst);
zooKeepers.Add(zooKeeperSecond);

List<Food> foods = new List<Food>();
foods.Add(foodFirst);
foods.Add(foodSecond);
foods.Add(foodThird);


Inventory inventory = new Inventory(cagesAnimals, zooKeepers, foods);

inventory.AnimalsToString();
inventory.ZooKeepersToString();
inventory.FoodsToString();