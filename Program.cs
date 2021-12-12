using Autofac;
using Design_Patterns_Assignment;
using Design_Patterns_Assignment._Repository;
using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.ObserverPattern;
using Design_Patterns_Assignment.Strategy;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool loop = true;
     
            while (loop)
            {

                Console.WriteLine("1: Strategy Pattern");
                Console.WriteLine("2: Repository Pattern");
                Console.WriteLine("3: Observer Pattern");
                Console.WriteLine("4: Decorator Pattern");
                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '1':
                        Console.Clear();
                        _Strategy.Run();
                        break;
                    case '2':
                        Console.Clear();
                        Repository.Run();
                        break;
                    case '3':
                        Console.Clear();
                        ObserverApp.Run();
                        break;
                    case '4':
                        Console.Clear();
                        Decorator.Run();
                   
                        break;
                    case 'X' or 'x':
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input.");
                        break;
                }

                //Decorator.Run();
                //_Strategy.Run();
                //Repository.Run();
                //Observer.Run();
            }
        }
    }
}
