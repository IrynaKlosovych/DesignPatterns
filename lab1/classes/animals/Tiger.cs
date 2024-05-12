using System;

namespace lab1.classes.animals
{
    public class Tiger : Animal, IRunnable
    {
        public Tiger(int id, string name):base(id, name) { }
        public void Run()
        {
            Console.WriteLine($"Tiger {name} can run");
        }

        public override void toString()
        {
            Console.WriteLine($"Id: {id}, name: {name}");
            Run();
        }
    }
}
