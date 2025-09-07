using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        
        // Main loop to play multiple times
        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // 1-100
            int guess = -1;
            int guessCount = 0; // Guess counter

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I've chosen a number between 1 and 100.");

            // Guessing loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++; // Increment counter

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Show number of attempts
            Console.WriteLine($"Congratulations! You guessed it in {guessCount} attempts.");

            // Ask to play again
            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine();
            Console.WriteLine(); // Blank line to separate games
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}