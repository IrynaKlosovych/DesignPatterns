using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.AbstractFactory.Devices.interfaces
{
    public interface ILaptop: IDevice
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
