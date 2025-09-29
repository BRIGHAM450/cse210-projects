using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("==================================");
        Console.WriteLine("  Scripture Memorizer Program");
        Console.WriteLine("==================================");
        Console.WriteLine("Instructions:");
        Console.WriteLine("- A scripture will appear on screen.");
        Console.WriteLine("- Press ENTER to hide random words.");
        Console.WriteLine("- Type 'quit' anytime to end.\n");

        Reference reference = new Reference("Proverbs", 3, 5);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        string input = "";
        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("  Scripture Memorizer Program");
            Console.WriteLine("==================================");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to end.");
            
            input = Console.ReadLine();
            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine("Well done! You completed the scripture memorization.");
    }
}
