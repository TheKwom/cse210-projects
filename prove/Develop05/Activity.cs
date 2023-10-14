class Activity
{
    public string Name { get; set; }
    public int Value { get; set; }

    private bool IsCompleted { get; set; }
    private int TimesCompleted { get; set; }

    public Activity(string name, int value)
    {
        Name = name;
        Value = value;
        IsCompleted = false;
        TimesCompleted = 0;
    }

    public void Complete()
    {
        IsCompleted = true;
        TimesCompleted++;
    }

    public bool GetIsCompleted()
    {
        return IsCompleted;
    }

    public int GetTimesCompleted()
    {
        return TimesCompleted;
    }

    public virtual string Status()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }

    public virtual string Progress()
    {
        return IsCompleted ? $"Completed {TimesCompleted} times" : "";
    }

    // Helper method to serialize IsCompleted and TimesCompleted
    public string Serialize()
    {
        return $"{IsCompleted}:{TimesCompleted}";
    }

    // Helper method to deserialize and set IsCompleted and TimesCompleted
    public void Deserialize(string serializedData)
    {
        string[] parts = serializedData.Split(':');
        IsCompleted = bool.Parse(parts[0]);
        TimesCompleted = int.Parse(parts[1]);
    }
}