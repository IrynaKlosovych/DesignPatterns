using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Proxy
{
    public class SmartTextChecker: ISmartTextReader
    {
        private ISmartTextReader reader { get; set; }
        public SmartTextChecker(ISmartTextReader reader)
        {
            this.reader = reader;
        }

        public char[][]? ReadFile(string filepath)
        {
            char[][]? result = reader.ReadFile(filepath);
            if(result == null) {
                Console.WriteLine("Some errors");
                return null;
            }
            Console.WriteLine("Successfully open, read and close the file");
            Console.WriteLine($"Lines: {result.GetLength(0)}, Chars: {CountChars(result)}");
            return result;
        }

        private int CountChars(char[][] arr)
        {
            int count= 0;
            foreach(var line in arr)
            {
                foreach(var c in line)
                    count++;
            }
            return count;
        }
    }
}
