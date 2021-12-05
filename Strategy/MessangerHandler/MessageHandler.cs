using Design_Patterns_Assignment.Strategy;
using System;

namespace Design_Patterns_Assignment
{
    internal class MessageHandler : IMessageHandler
    {
        public IMessage Message { get ; set; }

        public void SendMessage(string message)
        {
            Message.SendMessage(message);
        }
    }
}