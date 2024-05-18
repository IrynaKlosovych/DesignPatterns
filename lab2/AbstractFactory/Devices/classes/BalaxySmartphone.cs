using lab2.AbstractFactory.Devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.AbstractFactory.Devices.classes
{
    public class BalaxySmartphone : ISmartphone
    {
        public string Model { get; set; }
        public string Description { get; set; }
        public BalaxySmartphone(string model, string description)
        {
            Model = model;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"BalaxySmartphone\nModel: {Model}, Description: {Description}");
        }
    }
}
