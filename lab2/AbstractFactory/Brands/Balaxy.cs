using lab2.AbstractFactory.Devices.classes;
using lab2.AbstractFactory.Devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.AbstractFactory.Brands
{
    public class Balaxy : IAbstractFactory
    {
        public ILaptop CreateLaptop()
        {
            return new BalaxyLaptop("Balaxy Name Laptop", "Some Laptop");
        }

        public INetbook CreateNetbook()
        {
            return new BalaxyNetbook("Balaxy Name NetBook", 20, 30);
        }

        public ISmartphone CreateSmartphone()
        {
            return new BalaxySmartphone("Balaxy Model", "Some Balaxy Smartphone description");
        }
    }
}
