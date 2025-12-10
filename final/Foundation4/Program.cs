using System;
using System.Runtime.CompilerServices;

class Program
{
    private static List<Activity> _activities = new List<Activity>();
    static void Main(string[] args)
    {
        _activities.Add(new Running(DateTime.Now, 30, 3.0));
        _activities.Add(new Cycling(DateTime.Now, 45, 15.0));
        _activities.Add(new Swimming(DateTime.Now, 60, 40));

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}