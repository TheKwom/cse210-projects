using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Assignment
        Assignment firstAssignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(firstAssignment.GetSummary());

        // Create a MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Create a WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());

        // Keep the console window open
        Console.ReadLine();
    }
}
