using System;
class Reception : Event
{
    private string RsvpEmail { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public new string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nEvent Type: Reception\nRSVP Email: {RsvpEmail}";
    }
}
