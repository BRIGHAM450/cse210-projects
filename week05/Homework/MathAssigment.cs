using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor: llama al constructor base con "base()"
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Método específico para tareas de matemáticas
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
