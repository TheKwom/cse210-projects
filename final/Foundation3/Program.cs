using System;
class Program
{
    static void Main()
    {
        Address address1 = new Address("55 Linder Rd", "Eagle", "Idaho", "83616");
        Address address2 = new Address("444 Mikan Dr", "Rexburg", "Idaho", "83440");
        Address address3 = new Address("168 Snow Ln", "Rexburg", "Idaho", "83440");

        Event generalEvent = new Event("Networking", "Meet with individuals in your field.", DateTime.Now, new TimeSpan(12, 0, 0), address1);
        Lecture lecture = new Lecture("TED Talk", "Lecture about the future of AI.", DateTime.Now, new TimeSpan(17, 00, 0), address2, "Elon Musk", 300);
        Reception reception = new Reception("Wedding Reception", "Celebrate the marriage of Mike and Amber", DateTime.Now, new TimeSpan(14, 0, 0), address3, "justmarried@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "A family friendly picnic", DateTime.Now, new TimeSpan(12, 0, 0), address1, "A warm, sunny day.");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(generalEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(generalEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Descriptions:");
        Console.WriteLine(generalEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}