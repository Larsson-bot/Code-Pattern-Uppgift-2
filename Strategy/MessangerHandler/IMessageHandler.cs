using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    public interface IMessageHandler
    {
        IMessage Message { get; set; }
        void SendMessage(string message);
    }
}
