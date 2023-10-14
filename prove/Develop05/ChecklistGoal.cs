class ChecklistGoal : Activity
{
    public int TargetCount { get; protected set; }

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
    }
}