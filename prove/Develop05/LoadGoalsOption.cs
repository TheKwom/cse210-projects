class LoadGoalsOption
{
    public static void LoadGoals(List<Activity> goals)
    {
        goals.Clear();

        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Deserialize and construct goal objects from the file
                    var goal = CreateGoalFromSerializedData(line);
                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals loaded from goals.txt");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    private static Activity CreateGoalFromSerializedData(string serializedData)
    {
        // Determine the goal type based on the data (e.g., SimpleGoal, EternalGoal, ChecklistGoal)
        // You'll need to implement this logic based on your data format.

        // Deserialize the data to set IsCompleted and TimesCompleted
        var goal = new SimpleGoal("GoalName", 0); // Create an instance with default values
        goal.Deserialize(serializedData);
        return goal;
    }
}