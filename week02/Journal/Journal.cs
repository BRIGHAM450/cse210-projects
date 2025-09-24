using System;
using System.Collections.Generic;
using System.IO;

// Class representing the entire journal
public class Journal
{
    public List<Entry> _entries = new List<Entry>();  // List of entries
    private List<string> _prompts = new List<string> // List of possible prompts
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could do one thing over today, what would it be?"
    };

    // Method to write a new entry
    public void WriteEntry()
    {
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)]; // Choose random prompt
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString(); // Get today's date

        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry); // Add entry to list
        Console.WriteLine("Entry added!\n");
    }

    // Method to display all entries
    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }

    // Method to save journal to a file
    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                sw.WriteLine(e.ToFileString());
            }
        }
        Console.WriteLine("Journal saved!\n");
    }

    // Method to load journal from a file
    public void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _entries.Clear(); // Clear current entries
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry e = Entry.FromFileString(line);
            if (e != null)
            {
                _entries.Add(e);
            }
        }
        Console.WriteLine("Journal loaded!\n");
    }
}
