using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using Design_Patterns_Assignment.ObserverPattern.SubjectFiles;
using System;
using System.Timers;

namespace Design_Patterns_Assignment.ObserverPattern
{
    public static class ObserverApp
    {
        public static EmailSubject EmailSubject { get; set; }

        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            EmailSubject = new EmailSubject();
            var observer1 = new EmailObserver("Bengt");
            EmailObserver UserObserver = new EmailObserver("");
            EmailSubject.Register(observer1);
            bool loop = true;
            var emailTimer = new Timer();
            emailTimer.Interval = 5000;
            emailTimer.Elapsed += OnTimedEvent;
            emailTimer.AutoReset = true;
            // Start the timer
            emailTimer.Enabled = true;

            while (loop)
            {
                Console.WriteLine("1: Register User/Unregister User");
                Console.WriteLine("X End application");
                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '1':
                        Console.Clear();
                        emailTimer.Stop();
                        if (UserObserver.ObserverName == "")
                        {
                            Console.WriteLine("Whats the observers Name?");
                            UserObserver.ObserverName = Console.ReadLine();
                            EmailSubject.Register(UserObserver);
                            Console.WriteLine("User registered!");
                            Console.WriteLine("Press any key to return to menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            EmailSubject.Unregister(UserObserver);
                            Console.WriteLine($"User {UserObserver.ObserverName} has been unregistered!");
                            UserObserver.ObserverName = "";
                            Console.WriteLine("Press any key to return to menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        emailTimer.Start();
                        break;

                    case 'X' or 'x':
                        loop = false;
                        emailTimer.Stop();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            EmailSubject.Notify(e.SignalTime);
        }
    }
}