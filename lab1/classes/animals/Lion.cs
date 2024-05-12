using System;

namespace lab1.classes.animals
{
    public class Lion: Animal, IRunnable
    {
        public Lion(int id, string name): base(id, name) { }
        public void Run() {
            Console.WriteLine($"Lion {name} can run");
        }
        public override void toString()
        {
            Console.WriteLine($"Id: {id}, name: {name}");
            Run();
        }
    }
}
