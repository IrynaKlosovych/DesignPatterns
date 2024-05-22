using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Proxy
{
    public class SmartTextReader: ISmartTextReader
    {
        public char[][]? ReadFile(string filepath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                List<char[]> contentList = new List<char[]>();

                foreach (var line in lines)
                {
                    char[] charArray = line.ToCharArray();
                    contentList.Add(charArray);
                }
                char[][] content = contentList.ToArray();
                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return null;
            }
        }
    }
}
