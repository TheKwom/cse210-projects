// Assignment.cs
using System;

class Assignment
{
    // Private member variables
    private string studentName;
    private string topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        this.studentName = studentName;
        this.topic = topic;
    }

    // Method to get the summary
    public string GetSummary()
    {
        return $"{studentName} - {topic}";
    }

    // Public method to get the student name (added as per your instructions)
    public string GetStudentName()
    {
        return studentName;
    }

    public string GetTopic()
    {
        return topic;
    }
}
