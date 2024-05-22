using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab3.Proxy
{
    public class SmartTextReaderLocker:ISmartTextReader
    {
        private SmartTextReader reader;
        private Regex regex;

        public SmartTextReaderLocker(SmartTextReader reader, string pattern)
        {
            this.reader = reader;
            regex = new Regex(pattern);
        }

        public char[][]? ReadFile(string filepath)
        {
            if (regex.IsMatch(filepath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            Console.WriteLine("It's ok");
            return reader.ReadFile(filepath);
        }
    }
}
