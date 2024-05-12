using System;

namespace lab1.classes.animals
{
    public abstract class Animal
    {
        protected int id { get; set; }
        protected string name { get; set; }

        public Animal(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int GetId()
        {
            return id;
        }
        public abstract void toString();
    }
}
