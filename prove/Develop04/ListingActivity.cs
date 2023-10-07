using System;
class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        // Add more prompts here
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine($"Duration: {duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000); // Pause for 3 seconds

        Console.WriteLine("Start listing items:");

        DateTime startTime = DateTime.Now;
        int itemCount = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string item = Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");
        Console.WriteLine("Good job! You've completed the Listing Activity.");
        Console.WriteLine($"Total time: {duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }
}