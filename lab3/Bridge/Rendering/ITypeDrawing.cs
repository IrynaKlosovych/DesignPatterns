using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Bridge.Rendering
{
    public interface ITypeDrawing
    {
        public void DrawCircle();
        public void DrawSquare();
        public void DrawTriangle();
    }
}
