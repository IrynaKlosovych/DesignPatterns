using lab2.AbstractFactory.Devices.classes;
using lab2.AbstractFactory.Devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.AbstractFactory.Brands
{
    public class Kiaomi: IAbstractFactory
    {
        public ILaptop CreateLaptop()
        {
            return new KiaomiLaptop("Kiaomi Name Laptop", "Some Laptop Kiaomi");
        }

        public INetbook CreateNetbook()
        {
            return new KiaomiNetbook("Kiaomi Name NetBook", 35, 40);
        }

        public ISmartphone CreateSmartphone()
        {
            return new KiaomiSmartphone("Kiaomi Model", "Some Kiaomi Smartphone description");
        }
    }
}
