class CreateGoalOption
{
    public static void CreateNewGoal(List<Activity> goals)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice (1-3): ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter point value: ");
        int pointValue = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(goalName, pointValue));
                break;
            case "2":
                goals.Add(new EternalGoal(goalName, pointValue));
                break;
            case "3":
                Console.Write("Enter the target count for the checklist goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(goalName, pointValue, targetCount));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }
}