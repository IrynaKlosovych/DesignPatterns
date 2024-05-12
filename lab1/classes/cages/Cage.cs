using System;
using lab1.classes.animals;

namespace lab1.classes.cages
{
    public enum CageSize
    {
        Small,
        Middle,
        Big
    }

    public class Cage<T>: ICage<T> where T : Animal
    {
        protected string Size { get; set; }

        protected List<T> _animals;

        public Cage(string size)
        {
            Size = size;
            _animals = new List<T>();
        }

        public void AddAnimal(T animal)
        {
            try
            {
                if (!CheckAnimalInCageByID(animal.GetId()))
                {
                    _animals.Add(animal);
                }
            }
            catch
            {
                Console.WriteLine("Some errors");
            }

        }
        private bool CheckAnimalInCageByID(int id)
        {
            foreach (T animal in _animals)
            {
                if (animal.GetId() == id)
                    return true;
            }
            return false;
        }

        public IEnumerable<T> Animals => _animals;
        public string Type => typeof(T).Name.ToString();
    }
}

