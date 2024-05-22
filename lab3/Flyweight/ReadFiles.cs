using lab3.Composite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Flyweight
{
    public static class ReadFiles
    {
        public static LightElementNode ReadFilesWithoutFlyweight(string filepath)
        {
            double first=CheckProsessMemory();
            LightElementNode html = new LightElementNode("html", (int)DisplayType.Block, (int)IsPaired.Paired);
            LightElementNode body = new LightElementNode("body", (int)DisplayType.Block, (int)IsPaired.Paired);
            html.AddChild(body);
            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {               
                string element;
                int display;
                int ispaired;
               
                if (line.Length < 20)
                {
                    element = "h2";
                    display = (int)DisplayType.String;
                    ispaired = (int)IsPaired.Paired;

                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    element = "blockquote";
                    display = (int)DisplayType.Block;
                    ispaired = (int)IsPaired.Paired;

                }
                else
                {
                    element = "p";
                    display = (int)DisplayType.Block;
                    ispaired = (int)IsPaired.Paired;
                }
                if (line==lines.First())
                {
                    element = "h1";
                    display = (int)DisplayType.String;
                    ispaired = (int)IsPaired.Paired;
                }
                var tag = new LightElementNode(element, display, ispaired);
                tag.AddChild(new LightTextNode(line));
                body.AddChild(tag);
            }
            double second=CheckProsessMemory();
            Console.WriteLine($"{second:F2} - {first:F2} = {second-first:F2}");
            return html;
        }

        public static UpdatedLightElementNode ReadFilesWithFlyweight(string filepath)
        {
            double first = CheckProsessMemory();
            UpdatedLightElementNode html = new UpdatedLightElementNode("html", (int)NewDisplayType.Block, (int)NewIsPaired.Paired);
            UpdatedLightElementNode body = new UpdatedLightElementNode("body", (int)NewDisplayType.Block, (int)NewIsPaired.Paired);
            html.AddChild(body);
            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                string element;
                int display;
                int ispaired;

                if (line.Length < 20)
                {
                    element = "h2";
                    display = (int)NewDisplayType.String;
                    ispaired = (int)NewIsPaired.Paired;

                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    element = "blockquote";
                    display = (int)NewDisplayType.Block;
                    ispaired = (int)NewIsPaired.Paired;

                }
                else
                {
                    element = "p";
                    display = (int)NewDisplayType.Block;
                    ispaired = (int)NewIsPaired.Paired;
                }     
                
                if (line == lines.First())
                {
                    element = "h1";
                    display = (int)NewDisplayType.String;
                    ispaired = (int)NewIsPaired.Paired;
                }
                var tag = new UpdatedLightElementNode(element, display, ispaired);
                tag.AddChild(new LightTextNode(line));
                body.AddChild(tag);
            }
            double second = CheckProsessMemory();
            Console.WriteLine($"{second:F2} - {first:F2} = {second - first:F2}");
            return html;
        }

        private static double CheckProsessMemory()
        {
            double memoryUsedInMB = GC.GetTotalMemory(false) / (1024.0 * 1024.0);
            Console.WriteLine($"Allocated Memory: {memoryUsedInMB:F2} MB");
            return memoryUsedInMB;
        }
    }
}
