using System;
using System.Collections.Generic;

public class Video
{
    // Private attributes
    private string _title;
    private string _author;
    private int _length; // seconds
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Return number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Display video information and its comments
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"  - {comment.GetDisplayText()}");
        }
        Console.WriteLine();
    }
}
