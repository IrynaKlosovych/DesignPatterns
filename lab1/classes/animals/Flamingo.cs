using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes.animals
{
    public class Flamingo:Animal, IFlyable
    {
        public Flamingo(int id, string name): base(id, name)
        {

        }
        public void Fly()
        {
            Console.WriteLine($"Flamingo {name} can fly");
        }
        public override void toString()
        {
            Console.WriteLine($"Id: {id}, name: {name}");
            Fly();
        }
    }
}
