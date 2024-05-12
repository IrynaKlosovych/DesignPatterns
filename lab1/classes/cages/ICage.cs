using lab1.classes.animals;
using System;

namespace lab1.classes.cages
{
    public interface ICage<out T> where T : Animal
    {
        IEnumerable<T> Animals { get; }
        string Type {  get; }
    }
}
