using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Loop to get numbers from user until they enter 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Only add to list if not zero
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // 1. Calculate sum of all numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // 2. Calculate average (using float casting to get decimal result)
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // 3. Find the largest number in the list
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // 4. STRETCH CHALLENGE: Find smallest positive number (closest to zero)
        int smallestPositive = int.MaxValue; // Initialize with maximum possible value
        foreach (int number in numbers)
        {
            // Check if number is positive AND smaller than current smallest positive
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // 5. STRETCH CHALLENGE: Sort the list in ascending order
        numbers.Sort(); // Built-in method to sort the list
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}