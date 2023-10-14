using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        int totalScore = 0;
        List<Activity> goals = new List<Activity>();

        // Display the user's points
        Console.WriteLine($"Total Score: {totalScore}");

        Menu menu = new Menu(totalScore, goals);

        while (true)
        {
            menu.DisplayMenu();
            string choice = Console.ReadLine();
            menu.HandleChoice(choice);
        }
    }
}