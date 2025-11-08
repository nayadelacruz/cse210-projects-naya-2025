using System;
class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity(int duration) : base(duration)
    {
        int _duration = duration;// Additional initialization if needed
    }
    public void StartListing(int time)
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Random random = new Random();
        int listingCount = 0;
        int promptIndex = random.Next(_listingPrompts.Count);
        Console.WriteLine($"--- {_listingPrompts[promptIndex]} ---");
        Console.WriteLine("You may begin in: ");
        CountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            listingCount++;
        }
        Console.WriteLine($"You listed {listingCount} items!");
    }
}