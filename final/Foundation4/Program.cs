using System;
using System.Runtime.CompilerServices;

class Program
{
    private static List<Activity> activities = new List<Activity>();
    static void Main(string[] args)
    {
        activities.Add(new Running(DateTime.Now, 30, 3.0));
        activities.Add(new Cycling(DateTime.Now, 45, 15.0));
        activities.Add(new Swimming(DateTime.Now, 60, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}