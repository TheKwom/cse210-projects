// Reflection Activity
class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        // Add more reflection questions here
    };

    public ReflectionActivity(int duration) : base(duration) { }

   private void DisplaySpinner(int seconds)
{
    int index = 0;
    for (int i = 0; i < seconds; i++)
    {
        Console.Write("\r" + "/-\\|"[index % 4]);
        Thread.Sleep(2000); // Pause for 1 second
        index++;
    }
    Console.WriteLine();
}


    public override void StartActivity()
    {
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine($"Duration: {duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds

        Random random = new Random();

        for (int i = 0; i < duration;)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            DisplaySpinner(3); // Pause for 3 seconds with spinner

            foreach (string question in reflectionQuestions)
            {
                Console.WriteLine(question);
                DisplaySpinner(3); // Pause for 3 seconds with spinner
                i += 6; // 2 questions * 3 seconds per question
            }
        }

        Console.WriteLine("Good job! You've completed the Reflection Activity.");
        Console.WriteLine($"Total time: {duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }
}
