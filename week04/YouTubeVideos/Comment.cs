using System;

public class Comment
{
    // Encapsulation: attributes are private
    private string _name;
    private string _text;

    // Constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Method to display the comment
    public string GetDisplayText()
    {
        return $"{_name}: {_text}";
    }
}
