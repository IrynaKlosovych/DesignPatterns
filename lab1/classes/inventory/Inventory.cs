using lab1.classes.animals;
using lab1.classes.cages;
using lab1.classes.food;
using lab1.classes.worker;
using System;

namespace lab1.classes.inventory
{
    public class Inventory
    {
        protected List<ICage<Animal>> Cages { get; set; }
        protected List<ZooKeeper> ZooKeepers { get; set; }
        protected List<Food> Foods { get; set; }

        public Inventory(List<ICage<Animal>> cages, List<ZooKeeper> zooKeepers, List<Food> foods)
        {
            Cages = cages;
            ZooKeepers = zooKeepers;
            Foods = foods;
        }

        public void AnimalsToString()
        {
            foreach (var cage in Cages)
            {
                Console.WriteLine($"Cage type: {cage.Type}");

                foreach (var animal in cage.Animals)
                {
                    animal.toString();
                }
                Console.Write("\n");
            }
        }

        public void ZooKeepersToString()
        {
            foreach(var keeper in ZooKeepers)
            {
                Console.WriteLine($"Name: {keeper.GetName()}, age: {keeper.GetAge()}\n" +
                    $"Specialization: {keeper.GetSpecialization()}\nSalary in UAH: {keeper.GetSalaryInUAH()}\n");
            }
        }
        public void FoodsToString()
        {
            foreach (var food in Foods)
            {
                Console.WriteLine($"Name: {food.GetName()}, quantity: {food.GetQuantity()}\n");
            }
        }
    }
}
