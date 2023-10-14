class SaveGoalsOption
{
    public static void SaveGoals(List<Activity> goals)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                // Serialize the goal and save it to the file
                string serializedGoal = goal.Serialize();
                writer.WriteLine(serializedGoal);
            }
        }

        Console.WriteLine("Goals saved to goals.txt");
    }
}