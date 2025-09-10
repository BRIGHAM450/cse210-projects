using System;

using System;

class Program
{
    // Function 1: Displays welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: Prompts for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function 3: Prompts for and returns the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function 4: Accepts an integer and returns its square
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 5: Displays the result with user's name and squared number
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }

    // Main function - orchestrates the program flow
    static void Main(string[] args)
    {
        // Call functions in sequence
        DisplayWelcome();
        
        // Get user input
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        
        // Calculate square
        int squaredNumber = SquareNumber(userNumber);
        
        // Display final result
        DisplayResult(userName, squaredNumber);
    }
}