using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Prototype
{
    public class Virus: IClone
    {
        private int Weight { get; set; }
        private int Age { get; set; }
        private string Name { get; set; }
        private string Type { get; set; }
        private List<Virus> Children { get; set; } = new List<Virus>();
        public Virus(int weight, int age, string name, string type, List<Virus>? children=null)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            if(children != null)
                Children = children;
        }
        public Virus(Virus virus)
        {
            Weight = virus.Weight;
            Age = virus.Age;
            Name = virus.Name;
            Type = virus.Type;
            Children = DeepCopy(virus.Children);
        }
        public IClone Clone()
        {
            return new Virus(this);
        }

        public void ShowAllInfo(int start=0)
        {
            Console.WriteLine($"Generation: {start}, Weight: {Weight}, Age: {Age}, Name: {Name}, Type: {Type}");
            if(Children.Count > 0)
            {
                foreach(Virus child in Children)
                    child.ShowAllInfo(start+1);
            }
        }

        public void IsEqualVirusAndCopy(Virus virus, int start = 0)
        {
            string indent = new string(' ', start * 4);
            Console.WriteLine($"{indent}Generation: {start}");
            Console.WriteLine($"{indent}Weight: {Weight == virus.Weight}");
            Console.WriteLine($"{indent}Age: {Age == virus.Age}");
            Console.WriteLine($"{indent}Name: {Name == virus.Name}");
            Console.WriteLine($"{indent}Type: {Type == virus.Type}");
            Console.WriteLine($"{indent}Children: {Children == virus.Children}");
            for(int i = 0; i < Children.Count; i++)
            {
                Console.WriteLine($"{indent}Children {i}: {Children[i] == virus.Children[i]}");
                Children[i].IsEqualVirusAndCopy(virus.Children[i], start+1);
            }
        }

        private List<Virus> DeepCopy(List<Virus> originalList)
        {
            List<Virus> copiedList = new List<Virus>();

            foreach (Virus originalVirus in originalList)
            {
                Virus copiedVirus = new Virus(originalVirus.Weight, originalVirus.Age, originalVirus.Name, originalVirus.Type);
                copiedVirus.Children = DeepCopy(originalVirus.Children);
                copiedList.Add(copiedVirus);
            }

            return copiedList;
        }
    }
}
