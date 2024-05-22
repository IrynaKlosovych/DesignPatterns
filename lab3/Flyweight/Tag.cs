using lab3.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Flyweight
{
    public class Tag
    {
        public string TagName { get; }
        public int TagDisplayType { get; }
        public int TagIsPaired { get; }
        public Tag(string tag, int displayType, int isPaired)
        {
            this.TagName = tag;
            this.TagDisplayType = displayType;
            this.TagIsPaired = isPaired;
        }
    }
}
