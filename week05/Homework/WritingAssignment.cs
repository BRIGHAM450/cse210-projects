using System;

public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor: llama al base
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Método específico para escritura
    public string GetWritingInformation()
    {
        // Usa el getter del padre para obtener el nombre
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}
