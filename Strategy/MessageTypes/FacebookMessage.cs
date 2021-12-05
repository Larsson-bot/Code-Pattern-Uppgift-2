using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    class FacebookMessage : IFacebookMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending message: " + "\"" + message + "\"" + " with FacebookMessager!");
        }
    }
}
