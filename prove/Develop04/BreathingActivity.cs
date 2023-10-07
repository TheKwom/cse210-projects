using System;
class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine($"Duration: {duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000); // Pause for 1 second
        }

        Console.WriteLine("Good job! You've completed the Breathing Activity.");
        Console.WriteLine($"Total time: {duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }
}