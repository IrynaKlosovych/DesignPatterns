using lab2.Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Builder
{
    public class Enemy: Character, IEnemyBuilder, ICharacter
    {
        public void MakeBadThings(string str)
        {
            Console.WriteLine(str);
        }
        public void Info()
        {
            Console.WriteLine($"Gender: {Gender}\nName: {Name}\nHeight: {Height}\nBodyType: {BodyType}\n" +
                $"HairColor: {HairColor}\nEyesColor: {EyesColor}\nClothes: {Clothes}");
            if (Inventory != null)
            {
                Console.WriteLine($"Inventory:");
                foreach (var inventory in Inventory)
                {
                    Console.Write($" {inventory}");
                }
            }
        }
    }
}
