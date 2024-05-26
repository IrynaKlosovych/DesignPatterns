using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab4.Strategy
{
    public class Context
    {
        private static string pattern = @"^(http|https):\/\/[^\s$.?#].[^\s]*$";

        public void DownloadImage(string href)
        {
            if(Regex.IsMatch(href, pattern, RegexOptions.IgnoreCase))
            {
                FromNetwork network = new FromNetwork();
                network.Execute(href);
                return;
            }
            FromPC pc = new FromPC();
            pc.Execute(href);
        }
    }
}
