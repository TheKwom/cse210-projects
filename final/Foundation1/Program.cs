using System;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Create and populate video objects
        Video video1 = new Video("Abstraction in C#", "Mike Davis", 250);
        video1.AddComment("Amber D", "Thanks for explaining!");
        video1.AddComment("Kevin B", "Where did you learn all of this?");
        video1.AddComment("Tyler J", "Can't wait to implement this in my code!");

        Video video2 = new Video("BYUI CS Degree Review", "Andrew G", 420);
        video2.AddComment("Mike Davis", "Seems great!");
        video2.AddComment("Zack J", "Maybe I'll pick something else...");

        Video video3 = new Video("Life in Rexburg", "Author 3", 240);
        video3.AddComment("Brian B", "Why so many potholes???");
        video3.AddComment("Jason R", "Food looks great!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.LengthSeconds);
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}