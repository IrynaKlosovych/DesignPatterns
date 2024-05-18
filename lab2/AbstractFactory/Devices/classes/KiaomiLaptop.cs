using lab2.AbstractFactory.Devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.AbstractFactory.Devices.classes
{
    public class KiaomiLaptop: ILaptop
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public KiaomiLaptop(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"KiaomiLaptop\nName: {Name}, Description: {Description}");
        }
    }
}
