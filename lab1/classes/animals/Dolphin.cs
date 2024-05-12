using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes.animals
{
    public class Dolphin : Animal, ISwimmable
    {
        public Dolphin(int id, string name): base(id, name)
        {

        }
        public void Swim()
        {
            Console.WriteLine($"Dolphin {name} can swim");
        }
        public override void toString()
        {
            Console.WriteLine($"Id: {id}, name: {name}");
            Swim();
        }
    }
}
