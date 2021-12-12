using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator.Decorators;
using System;

namespace Design_Patterns_Assignment.Decorator
{
    internal class Decorator
    {
        internal static void Run()
        {
            bool loop = true;
            Console.WriteLine("Please write your text.");

            IText textFromUser = new TextInput() { Text = Console.ReadLine() };

            Console.Clear();
            Console.WriteLine("The TagAdder!");
            Console.WriteLine("0: Add a Bold tag");
            Console.WriteLine("1: Add a Deleted tag");
            Console.WriteLine("2: Add a Emphasized tag");
            Console.WriteLine("3: Add a Important tag");
            Console.WriteLine("4: Add a Inserted tag");
            Console.WriteLine("5: Add a Italic tag");
            Console.WriteLine("6: Add a Marked tag");
            Console.WriteLine("7: Add a Smaller tag");
            Console.WriteLine("8: Add a Subscript tag");
            Console.WriteLine("9: Add a SuperScript tag");
            Console.WriteLine("X: Print out my beautiful text!");
            while (loop)
            {
                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '0':
                        textFromUser = new Bold(textFromUser);
                        Console.WriteLine("Bold tag added!");
                        break;

                    case '1':
                        textFromUser = new Deleted(textFromUser);
                        Console.WriteLine("Deleted tag added!");

                        break;
                    case '2':
                        textFromUser = new Emphasized(textFromUser);
                        Console.WriteLine("Emphasized tag added!");

                        break;
                    case '3':
                        textFromUser = new Important(textFromUser);
                        Console.WriteLine("Important tag added!");

                        break;
                    case '4':
                        textFromUser = new Inserted(textFromUser);
                        Console.WriteLine("Inserted tag added!");

                        break;
                    case '5':
                        textFromUser = new Italic(textFromUser);
                        Console.WriteLine("Italic tag added!");

                        break;
                    case '6':
                        textFromUser = new Marked(textFromUser);
                        Console.WriteLine("Marked tag added!");

                        break;
                    case '7':
                        textFromUser = new Smaller(textFromUser);
                        Console.WriteLine("Smaller tag added!");

                        break;
                    case '8':
                        textFromUser = new Subscript(textFromUser);
                        Console.WriteLine("Subscript tag added!");

                        break;
                    case '9':
                        textFromUser = new SuperScript(textFromUser);
                        Console.WriteLine("SuperScript tag added!");

                        break;

                    case 'X' or 'x':
                        Console.WriteLine(textFromUser.GetTextWithTags());
                        Console.WriteLine("Press any key to return to the pattern menu.");
                        Console.ReadKey();
                        loop = false;
                        Console.Clear();
                        break;
                    default:

             
                        Console.WriteLine("You have input a command that does nothing");
                        break;
                }
            }
        }
    }
}