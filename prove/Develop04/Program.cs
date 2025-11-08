using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity(0);
        int duration;
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1.Start Breathing Activity");
            Console.WriteLine("  2.Start Reflecting Activity");
            Console.WriteLine("  3.Start Listing Activity");
            Console.WriteLine("  4.Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            if (choice == 1)
            {
                activity.ActivityDisplay(choice);
                Console.WriteLine();
                activity.SetDuration();
                duration = activity.GetDuration();
                Console.Clear();
                Console.Write("Get ready...");
                activity.SpinnerTimer(5);
                Console.WriteLine();
                BreathingActivity breathingActivity = new BreathingActivity(0);
                breathingActivity.StartBreathing(duration);
                Console.WriteLine();
                activity.GoodByeMessage(duration, choice);
                Console.Clear();
            }
            else if (choice == 2)
            {
                activity.ActivityDisplay(choice);
                Console.WriteLine();
                activity.SetDuration();
                duration = activity.GetDuration();
                Console.Clear();
                Console.WriteLine("Get ready...");
                activity.SpinnerTimer(5);
                ReflectingActivity reflectingActivity = new ReflectingActivity(0);
                Console.WriteLine("Get ready...");
                reflectingActivity.StartReflecting(duration);
                activity.GoodByeMessage(duration, choice);
                Console.Clear();
            }
            else if (choice == 3)
            {
                activity.ActivityDisplay(choice);
                Console.WriteLine();
                activity.SetDuration();
                duration = activity.GetDuration();
                Console.Clear();
                Console.WriteLine("Get ready...");
                activity.SpinnerTimer(5);
                Console.WriteLine();
                ListingActivity listingActivity = new ListingActivity(0);
                listingActivity.StartListing(duration);
                activity.GoodByeMessage(duration, choice);
                Console.Clear();
            }
            else if (choice == 4)
            {
                break;
            }
            
        }
    } 
}