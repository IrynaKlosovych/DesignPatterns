using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab3.Flyweight
{
    public class TagFactory
    {
        private static Dictionary<string, Tag> tags = new Dictionary<string, Tag>();
        public static Tag GetTag(string nameTag, int display, int ispaired)
        {
            Tag? tag = tags.GetValueOrDefault(nameTag);
            if (tag == null)
            {
                tag = new Tag(nameTag, display, ispaired);
                tags.Add(nameTag, tag);
            }
            return tag;
        }
    }
}
