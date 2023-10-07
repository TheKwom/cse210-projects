using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Activities Menu:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter your choice (1/2/3): ");

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
        {
            Console.Write("Enter the duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
            {
                MindfulnessActivity activity = choice switch
                {
                    1 => new BreathingActivity(duration),
                    2 => new ReflectionActivity(duration),
                    3 => new ListingActivity(duration),
                    _ => null,
                };

                if (activity != null)
                {
                    activity.StartActivity();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
            {
                Console.WriteLine("Invalid duration. Please enter a positive integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
        }
    }
}