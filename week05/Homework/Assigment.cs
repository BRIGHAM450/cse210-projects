using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getter (necesario para WritingAssignment)
    public string GetStudentName()
    {
        return _studentName;
    }

    // Método compartido por todos
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
