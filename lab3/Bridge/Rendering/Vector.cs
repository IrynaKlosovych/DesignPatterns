using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Bridge.Rendering
{
    public class Vector : ITypeDrawing
    {
        public void DrawCircle()
        {
            Console.WriteLine("Drawing Circle as vectors");
        }

        public void DrawSquare()
        {
            Console.WriteLine("Drawing Square as vectors");
        }

        public void DrawTriangle()
        {
            Console.WriteLine("Drawing Triangle as vectors");
        }
    }
}
