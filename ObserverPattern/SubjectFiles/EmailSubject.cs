
using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern.SubjectFiles
{
    internal class EmailSubject : ISubject
    {
        public List<IObserver> Observers { get; set; }

        public EmailSubject()
        {
            Observers = new();
        }

        public void Register(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify(string name)
        {
            Observers.ForEach(x => x.Update(name));
        }
    }
}
