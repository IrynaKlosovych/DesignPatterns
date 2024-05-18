using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Builder
{
    public class Character
    {
        public string? Gender { set; get; }
        public string? Name { set; get; }
        public int? Height { set; get; }
        public string? BodyType { set; get; }
        public string? HairColor { set; get; }
        public string? EyesColor { set; get; }
        public string? Clothes { set; get; }
        public List<string>? Inventory { set; get; }
    }
}
