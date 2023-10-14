class RecordEventOption
{
    public static void RecordEvent(List<Activity> goals, ref int totalScore)
    {
        ListGoalsOption.ListGoals(goals);
        Console.Write("Enter the number of the goal you completed: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice >= 1 && choice <= goals.Count)
        {
            var goal = goals[choice - 1];
            goal.Complete();
            totalScore += goal.Value;
            Console.WriteLine($"{goal.Name} completed! You earned {goal.Value} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal choice.");
        }
    }
}