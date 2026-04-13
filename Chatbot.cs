using System;
using System.Threading;

public class Chatbot
{
    private string userName = "";

    public void Start()
    {
        ShowHeader();
        GetUserName();
        ShowPersonalizedWelcome();
        RunChatLoop();
    }

    private void ShowHeader()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@" 
   _____      _                 _____           _   
  / ____|    | |               |  __ \         | |  
 | |     _ __| |_ ___ _ __ ___ | |__) |___   __| |  
 | |    | '__| __/ _ \ '__/ _ \|  _  // _ \ / _` |  
 | |____| |  | ||  __/ | | (_) | | \ \ (_) | (_| |  
  \_____|_|   \__\___|_|  \___/|_|  \_\___/ \__,_|  
                                                    
        Cybersecurity Awareness Bot
");
        Console.ResetColor();
        Console.WriteLine("=".PadLeft(60, '='));
        Console.WriteLine();
    }

    private void GetUserName()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Please enter your name: ");
        Console.ResetColor();

        userName = Console.ReadLine()?.Trim() ?? "";

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Name cannot be empty. Please try again.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your name: ");
            Console.ResetColor();
            userName = Console.ReadLine()?.Trim() ?? "";
        }
    }

    private void ShowPersonalizedWelcome()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nHello {userName}! Welcome to the Cybersecurity Awareness Bot.");
        Console.WriteLine("I'm here to help you stay safe online.\n");
        Console.ResetColor();

        TypeWriter("Type 'help' to see what I can answer or just ask me anything about cybersecurity.\n", 30);
    }

    private void TypeWriter(string text, int delayMs)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delayMs);
        }
    }

    private void RunChatLoop()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("You can type 'exit' or 'quit' to end the chat.\n");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{userName}: ");
            Console.ResetColor();

            string? input = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please type something. I can't respond to empty messages.\n");
                Console.ResetColor();
                continue;
            }

            if (input == "exit" || input == "quit")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nGoodbye {userName}! Stay safe online! 👋");
                Console.ResetColor();
                break;
            }

            ProcessResponse(input);
        }
    }

    private void ProcessResponse(string input)
    {
        if (input.Contains("how are you") || input.Contains("how r u"))
        {
            Console.WriteLine("I'm just a bot, but I'm running perfectly and ready to help you! 😊");
        }
        else if (input.Contains("purpose") || input.Contains("what are you"))
        {
            Console.WriteLine("My purpose is to teach you basic cybersecurity awareness so you can stay safe online.");
        }
        else if (input.Contains("password"))
        {
            Console.WriteLine("Always use strong, unique passwords with letters, numbers, and symbols. Never reuse the same password!");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Beware of phishing! Do not click suspicious links or download attachments from unknown emails.");
        }
        else if (input.Contains("safe browsing") || input.Contains("safe browse"))
        {
            Console.WriteLine("Use HTTPS websites, keep your browser updated, and avoid clicking on pop-up ads.");
        }
        else if (input == "help")
        {
            Console.WriteLine("You can ask me about: passwords, phishing, safe browsing, or say 'how are you'.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorry, I didn't understand that. Try asking about passwords, phishing, or type 'help'.");
            Console.ResetColor();
        }

        Console.WriteLine();
    }
}