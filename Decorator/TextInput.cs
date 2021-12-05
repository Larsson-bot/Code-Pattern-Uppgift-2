using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class TextInput : IText
    {
        public string Text { get; set; }

        public TextInput()
        {
          
        }

        public string GetTextWithTags()
        {
            return Text;
        }
    }
}
