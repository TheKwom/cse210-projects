using System;
class Event
{
    private string Title { get; set; }
    private string Description { get; set; }
    private DateTime Date { get; set; }
    private TimeSpan Time { get; set; }
    private Address EventAddress { get; set; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {EventAddress.Street}, {EventAddress.City}, {EventAddress.State} {EventAddress.ZipCode}";
    }

    public string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Event Type: General\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}