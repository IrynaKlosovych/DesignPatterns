using lab2.AbstractFactory.Devices.classes;
using lab2.AbstractFactory.Devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.AbstractFactory.Brands
{
    public class IProne: IAbstractFactory
    {
        public ILaptop CreateLaptop()
        {
            return new IProneLaptop("IProne Name Laptop", "Some IProne Laptop");
        }

        public INetbook CreateNetbook()
        {
            return new IProneNetbook("IProne Name NetBook", 35, 40);
        }

        public ISmartphone CreateSmartphone()
        {
            return new IProneSmartphone("IProne Model", "Some IProne Smartphone description");
        }
    }
}
