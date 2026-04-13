using System;

class Program
{
    static void Main(string[] args)
    {
        // Play voice greeting first
        AudioPlayer.PlayGreeting();

        // Start the chatbot
        Chatbot bot = new Chatbot();
        bot.Start();

        // Keep console open after chat ends
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}