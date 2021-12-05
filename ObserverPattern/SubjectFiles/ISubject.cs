using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern.SubjectFiles
{
     public interface ISubject
    {
        List<IObserver> Observers { get; set; }

        

        void Register(IObserver observer);
        void Unregister(IObserver observer);

        void Notify(string name);
    }
}
