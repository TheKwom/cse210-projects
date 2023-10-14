class ListGoalsOption
{
    public static void ListGoals(List<Activity> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("List of Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            var goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.Name} {goal.Status()} - {goal.Progress()} (Score: {goal.Value})");
        }
    }
}