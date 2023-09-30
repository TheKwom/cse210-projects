using System;
public class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    public ScriptureReference(string reference)
    {
        // Parse the reference format, e.g., "Proverbs 3:5-6"
        var parts = reference.Split(':');
        Book = parts[0];
        var verseParts = parts[1].Split('-');
        Chapter = int.Parse(verseParts[0]);
        StartVerse = int.Parse(verseParts[1]);
        EndVerse = verseParts.Length == 2 ? int.Parse(verseParts[1]) : StartVerse;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}