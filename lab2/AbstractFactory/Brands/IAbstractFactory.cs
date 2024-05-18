using lab2.AbstractFactory.Devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.AbstractFactory.Brands
{
    public interface IAbstractFactory
    {
        public ISmartphone CreateSmartphone();
        public ILaptop CreateLaptop();
        public INetbook CreateNetbook();
    }
}
