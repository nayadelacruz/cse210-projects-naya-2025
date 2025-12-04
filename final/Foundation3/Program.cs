using System;

class Program
{
    private static List<Event> _events = new List<Event>();
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("The Future of AI", "An in-depth look at AI advancements", new DateTime(2024, 10, 15), new TimeSpan(14, 0, 0), new Address("123 Tech St", "Innovation City", "CA", "USA"), "Lecture", "Dr. Jane Smith", 150);
        Reception reception = new Reception("Annual Gala", "A night of celebration and networking", new DateTime(2024, 11, 20), new TimeSpan(19, 0, 0), new Address("456 Grand Ave", "Metropolis", "NY", "USA"), "Reception", "reception@outlook.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "A fun day outdoors", new DateTime(2024, 9, 5), new TimeSpan(12, 0, 0), new Address("789 Park Blvd", "Greenville", "TX", "USA"), "Outdoor Gathering", "Sunny with a chance of clouds");
        _events.Add(lecture);
        _events.Add(reception);
        _events.Add(outdoorGathering);
        foreach (Event e in _events)
        {
            Console.WriteLine($"\nEvent Standard Details: \n{e.GetStandardDetails()}");
            Console.WriteLine($"\nEvent Full Details: \n{e.GetFullDetails()}");
            Console.WriteLine($"\nEvent Short Description: \n{e.GetShortDescription()}");
        }
        /*Console.WriteLine($"\nLecture Standard Details: \n{lecture.GetStandardDetails()}");
        Console.WriteLine($"\nLecture Full Details: \n{lecture.GetFullDetails()}");
        Console.WriteLine($"\nLecture Short Description: \n{lecture.GetShortDescription()}");
        Console.WriteLine($"\nOutdoor Gathering Standard Details: \n{outdoorGathering.GetStandardDetails()}");
        Console.WriteLine($"\nOutdoor Gathering Full Details: \n{outdoorGathering.GetFullDetails()}");
        Console.WriteLine($"\nOutdoor Gathering Short Description: \n{outdoorGathering.GetShortDescription()}");                            
        Console.WriteLine($"\nReception Standard Details: \n{reception.GetStandardDetails()}");
        Console.WriteLine($"\nReception Full Details: \n{reception.GetFullDetails()}");
        Console.WriteLine($"\nReception Short Description: \n{reception.GetShortDescription()}");*/   
    }
}