using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Deleted : TextDecorator
    {
        public Deleted(IText text) : base(text)
        {
            Tag = "del";
        }
    }
}
