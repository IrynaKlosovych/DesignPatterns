using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.AbstractFactory.Devices.interfaces
{
    public interface ISmartphone: IDevice
    {
        string Model {  get; set; }
        string Description { get; set; }
    }
}
