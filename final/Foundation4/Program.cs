using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 10, 20), 30, 5),
            new Cycling(new DateTime(2023, 10, 21), 45, 15),
            new Swimming(new DateTime(2023, 10, 22), 60, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}