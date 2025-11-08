using System;
using System.ComponentModel;
using System.Threading;

class Activity
{
    private List<string> _ActivityNames = new List<string>()
    {
        "Breathing Activity",
        "Reflecting Activity",
        "Listing Activity"
    };
    private List<string> _ActivityDescriptions = new List<string>()
    {
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    };
    private int _duration;
    public Activity(int duration)
    {
        _duration = duration;
    }
    public void ActivityDisplay(int activityChoice)
    {
        Console.WriteLine($"Welcome to the {_ActivityNames[activityChoice - 1]}.");
        Console.WriteLine();
        Console.WriteLine(_ActivityDescriptions[activityChoice - 1]);
    }
    public void SetDuration()
    {
        Console.Write("How long in seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SpinnerTimer(int seconds)
    {
        int timeOfSpinner = seconds;
        List<string> spinnerChars = new List<string>() { "|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-", "\\", "|" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeOfSpinner);
        while (DateTime.Now < endTime)
        {

            foreach (string s in spinnerChars)
            {
                Console.Write(s);
                System.Threading.Thread.Sleep(100);
                Console.Write("\b \b");
            }
        }
    }
    public void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void GoodByeMessage(int duration, int activityChoice)
    {
        Console.WriteLine($"Well done! You have completed {duration} seconds of the {_ActivityNames[activityChoice - 1]}");
        SpinnerTimer(3);
    }
}