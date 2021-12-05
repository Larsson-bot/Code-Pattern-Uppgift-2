using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Italic : TextDecorator
    {
        public Italic(IText text) : base(text)
        {
            Tag = "i";
        }
    }
}
