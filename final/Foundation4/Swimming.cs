using System;
class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62; // Convert to miles
    }

    public override double GetSpeed()
    {
        return (laps * 50 / 1000 * 0.62) / Minutes * 60; // Convert to miles per hour
    }

    public override double GetPace()
    {
        return Minutes / (laps * 50 / 1000 * 0.62); // Convert to minutes per mile
    }
}