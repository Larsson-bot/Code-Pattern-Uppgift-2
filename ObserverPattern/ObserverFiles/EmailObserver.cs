using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern.ObserverFiles
{
    public class EmailObserver : IObserver
    {
        public string ObserverName { get; set; }

        public EmailObserver(string observerName)
        {
            ObserverName = observerName;
        }

        public void Update(string name)
        {
            Console.WriteLine($"{ObserverName} has been notifed about a new email from {name}!");
        }
    }
}
