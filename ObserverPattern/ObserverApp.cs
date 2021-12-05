using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using Design_Patterns_Assignment.ObserverPattern.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    public static class ObserverApp
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            var emailservice = new EmailSubject();
            var observer1 = new EmailObserver("Bengt");
            EmailObserver UserObserver = new EmailObserver("") ;
            emailservice.Register(observer1);
            //emailservice.Notify("Jörgen");
            //emailservice.Unregister(observer1);
            //emailservice.Register(new EmailObserver("Kajsa"));
            //emailservice.Notify("Åsa");
            bool loop = true;
   


            while (loop)
            {
                Console.WriteLine("1: Register User/Unregister User");
                Console.WriteLine("2: Send email");
                Console.WriteLine("X End application");
                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '1':
                        Console.Clear();
                        if ( UserObserver.ObserverName == "")
                        {
                            Console.WriteLine("Whats the observers Name?");
                            UserObserver.ObserverName = Console.ReadLine();
                            emailservice.Register(UserObserver);
                            Console.WriteLine("User registered!");
                            Console.WriteLine("Press any key to return to menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            
                            emailservice.Unregister(UserObserver);
                            Console.WriteLine($"User {UserObserver.ObserverName} has been unregistered!");
                            UserObserver.ObserverName = "";
                            Console.WriteLine("Press any key to return to menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Write the senders name!");
                        emailservice.Notify(Console.ReadLine());
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 'X' or 'x':
                        loop = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }


            }
            //Console.ReadKey();
            ////var email = "";
            ////while (string.IsNullOrEmpty(email))
            ////{
            ////    email=_Email.Check();
            ////}            
            ////Console.WriteLine(email);
            //Console.WriteLine();
        }
    }
}
