using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Memento
{
    public class TextDocument
    {
        public string Title {  get; set; }
        public string Text { get; set; }
        public TextDocument(string title, string text) {
            Title = title;
            Text = text;
        }
        public void UpdateStateByAddingContent(string content)
        {
            Text += content;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}
