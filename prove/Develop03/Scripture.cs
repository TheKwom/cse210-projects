using System;
public class Scripture
{
    private List<Word> words;
    private Random random = new Random();

    public ScriptureReference Reference { get; }
    public bool AllWordsHidden => words.TrueForAll(word => word.IsHidden);

    public Scripture(string reference, string text)
    {
        Reference = new ScriptureReference(reference);
        words = new List<Word>(text.Split(' ').Select(word => new Word(word)));
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{Reference}\n");

        foreach (var word in words)
        {
            Console.Write($"{word} ");
        }

        Console.WriteLine("\n\nPress Enter to continue or type 'quit' to exit.");
    }

    public void HideRandomWord()
    {
        List<Word> visibleWords = words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }
}