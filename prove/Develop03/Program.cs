using System;
class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        scripture.Display();

        while (!scripture.AllWordsHidden)
        {
            var input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
            scripture.Display();
        }

        Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}