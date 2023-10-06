// MathAssignment.cs
using System;

class MathAssignment : Assignment
{
    // Private member variables (additional ones for MathAssignment)
    private string mathProblems;
    private string textbookSection;


    // Constructor for MathAssignment
    public MathAssignment(string studentName, string topic, string textbookSection ,string mathProblems)
        : base(studentName, topic) // Call base class constructor to set base class attributes
    {
        this.mathProblems = mathProblems;
        this.textbookSection = textbookSection;
    }

    // Method to get homework list for MathAssignment
    public string GetHomeworkList()
    {
        return $"Section: {textbookSection} Problems: {mathProblems}";
    }
}
