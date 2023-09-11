using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage did you receive? ");
        string userGrade = Console.ReadLine();
        int userGradeAsInt = int.Parse(userGrade);

        string letterGrade = "";

        if (userGradeAsInt >= 90)
        {
            letterGrade = "A";
        }
        else if (userGradeAsInt >= 80)
        {
            letterGrade = "B";
        }
        else if (userGradeAsInt >= 70)
        {
            letterGrade = "C";
        }
        else if (userGradeAsInt >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.Write($"You received a(n) {letterGrade}. ");

        if (userGradeAsInt >= 70) {
            Console.WriteLine("Congratulations, you passed!");
        }
        else {
            Console.WriteLine("Try again!");
        }
    }
}