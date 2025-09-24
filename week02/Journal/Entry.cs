using System;

// Class representing a journal entry
public class Entry
{
    public string _date;      // Entry date
    public string _prompt;    // Question or prompt
    public string _response;  // User's response

    // Constructor: initializes the entry with date, prompt, and response
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // Display the entry on console
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("----------------------");
    }

    // Convert the entry to a string to save to a file
    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    // Create an Entry object from a line read from a file
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        return null;
    }
}
