using System;

namespace lab1.classes.animals
{
    public class Penguin: Animal, ISwimmable, IRunnable
    {
        public Penguin(int id, string name) : base(id, name) { }
        public void Swim()
        {
            Console.WriteLine($"Penguin {name} can swim");
        }
        public void Run()
        {
            Console.WriteLine($"Penguin {name} can run");
        }
        public override void toString()
        {
            Console.WriteLine($"Id: {id}, name: {name}");
            Run();
            Swim();
        }
    }
}
