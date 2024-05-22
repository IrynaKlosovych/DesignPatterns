using lab3.Bridge.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Bridge.Shapes
{
    public class Triangle: Shape
    {
        public Triangle(ITypeDrawing impl) : base(impl) { }

        public override void Dwaw()
        {
            _impl.DrawTriangle();
        }
    }
}
