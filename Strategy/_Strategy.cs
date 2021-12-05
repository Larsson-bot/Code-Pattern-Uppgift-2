using System;

namespace Design_Patterns_Assignment.Strategy
{
    internal static class _Strategy
    {
        public static void Run()
        {
            MessageHandler messageHandler = new MessageHandler();
            messageHandler.Message = new Email();
            bool loop = true;
            var message = "This is the message";
            Console.WriteLine("Strategy");

            Console.WriteLine("M: Send Message");
            Console.WriteLine("F: Switch to sending messages with FacebookMessanger");
            Console.WriteLine("E: Switch to sending messages with Email");
            Console.WriteLine("S: Switch to sending messages with SMS");
            Console.WriteLine("N: Stop Application");
            while (loop)
            {
                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case 'M' or 'm':
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        messageHandler.SendMessage(message);

                        break;

                    case 'F' or 'f':
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        messageHandler.Message = new FacebookMessage();
                        Console.WriteLine($"Currently sending messages though {messageHandler.Message.GetType().Name}");
                        //Console.WriteLine("You will now send facebookmessages.");
                        break;

                    case 'E' or 'e':
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        messageHandler.Message = new Email();
                        Console.WriteLine($"Currently sending messages though {messageHandler.Message.GetType().Name}");

                        //Console.WriteLine("You will now send emails.");

                        break;

                    case 's' or 's':
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        messageHandler.Message = new Sms();
                        Console.WriteLine($"currently sending messages though {messageHandler.Message.GetType().Name}");
                        //Console.WriteLine("You will now send SMS.");

                        break;

                    case 'N' or 'n':
                        loop = false;
                        Console.Clear();
                        break;

                    default:

                        //ConsoleCleaner.ClearRow();
                        Console.WriteLine("You have input a command that does nothing");
                        break;
                }
            }

            // What i want to happen to happen is
            //
            // Change type of message to send to sms etc.
            // send message
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}