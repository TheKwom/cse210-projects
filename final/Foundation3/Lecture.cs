using System;
class Lecture : Event
{
    private string Speaker { get; set; }
    private int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public new string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}