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

            IText ost = new TextInput() { Text = Console.ReadLine() };

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
                        ost = new Bold(ost);
                        Console.WriteLine("Bold tag added!");
                        break;

                    case '1':
                        ost = new Deleted(ost);
                        Console.WriteLine("Deleted tag added!");

                        break;
                    case '2':
                        ost = new Emphasized(ost);
                        Console.WriteLine("Emphasized tag added!");

                        break;
                    case '3':
                        ost = new Important(ost);
                        Console.WriteLine("Important tag added!");

                        break;
                    case '4':
                        ost = new Inserted(ost);
                        Console.WriteLine("Inserted tag added!");

                        break;
                    case '5':
                        ost = new Italic(ost);
                        Console.WriteLine("Italic tag added!");

                        break;
                    case '6':
                        ost = new Marked(ost);
                        Console.WriteLine("Marked tag added!");

                        break;
                    case '7':
                        ost = new Smaller(ost);
                        Console.WriteLine("Smaller tag added!");

                        break;
                    case '8':
                        ost = new Subscript(ost);
                        Console.WriteLine("Subscript tag added!");

                        break;
                    case '9':
                        ost = new SuperScript(ost);
                        Console.WriteLine("SuperScript tag added!");

                        break;

                    case 'X' or 'x':
                        Console.WriteLine(ost.GetTextWithTags());
                        Console.ReadKey();
                        loop = false;
                        break;
                    default:

                        //ConsoleCleaner.ClearRow();
                        Console.WriteLine("You have input a command that does nothing");
                        break;
                }
                // Refactor this code so that it uses the Decorator Pattern
                //Console.WriteLine("Decorator");
                //Console.WriteLine("Please enter the text.");
                //string textInput = Console.ReadLine();
                //Console.WriteLine();
                //Console.WriteLine("Bold");
                //Console.WriteLine("Deleted");
                //Console.WriteLine("Emphasized");
                //Console.WriteLine("Important");
                //Console.WriteLine("Inserted");
                //Console.WriteLine("Italic");
                //Console.WriteLine("Marked");
                //Console.WriteLine("Smaller");
                //Console.WriteLine("SubScript");
                //Console.WriteLine("SuperScript");
                //Console.WriteLine();
                //Console.WriteLine("Type the tags you want separated by space");
                //string tagSelection = Console.ReadLine();
                //string result = HTMLGenerator.TagProcessor(tagSelection, textInput);
                //Console.WriteLine(result);
                //Console.WriteLine(ost.GetTextWithTags());
                //Console.ReadKey();
            }
        }
    }
}