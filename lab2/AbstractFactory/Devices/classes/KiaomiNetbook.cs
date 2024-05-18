using lab2.AbstractFactory.Devices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.AbstractFactory.Devices.classes
{
    public class KiaomiNetbook: INetbook
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public KiaomiNetbook(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"KiaomiNetbook\nName: {Name}, Width: {Width}, Height: {Height}");
        }
    }
}
