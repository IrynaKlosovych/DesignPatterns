using System;
namespace lab1.classes.worker
{
    public class ZooKeeper
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Specialization { get; set; }
        protected decimal SalaryInUAH { get; set; }

        public ZooKeeper(string name, int age, string specialization, decimal salary)
        {
            Name = name;
            Age = age;
            Specialization = specialization;
            SalaryInUAH = salary;

        }
        public string GetName()
        {
            return Name;
        }
        public int GetAge()
        {
            return Age;
        }
        public string GetSpecialization()
        {
            return Specialization;
        }
        public decimal GetSalaryInUAH()
        {
            return SalaryInUAH;
        }
    }
}
