class Menu
{
    private int totalScore;
    private List<Activity> goals;

    public Menu(int totalScore, List<Activity> goals)
    {
        this.totalScore = totalScore;
        this.goals = goals;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit");
        Console.Write("Enter your choice (1-6): ");
    }

    public void HandleChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                CreateGoalOption.CreateNewGoal(goals);
                break;
            case "2":
                ListGoalsOption.ListGoals(goals);
                break;
            case "3":
                SaveGoalsOption.SaveGoals(goals);
                break;
            case "4":
                LoadGoalsOption.LoadGoals(goals);
                break;
            case "5":
                RecordEventOption.RecordEvent(goals, ref totalScore);
                break;
            case "6":
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}