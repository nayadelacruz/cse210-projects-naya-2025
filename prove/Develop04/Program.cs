using System;

class Program
{
    static void Main(string[] args)
    {
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
                BreathingActivity bActivity = new BreathingActivity(0);
                bActivity.ActivityDisplay(choice);
                Console.WriteLine();
                bActivity.SetDuration();
                duration = bActivity.GetDuration();
                Console.Clear();
                Console.Write("Get ready...");
                bActivity.SpinnerTimer(5);
                Console.WriteLine();
                //BreathingActivity breathingActivity = new BreathingActivity(0);
                bActivity.StartBreathing(duration);
                Console.WriteLine();
                bActivity.GoodByeMessage(duration, choice);
                Console.Clear();
                
            }
            else if (choice == 2)
            {
                ReflectingActivity rActivity = new ReflectingActivity(0);
                rActivity.ActivityDisplay(choice);
                Console.WriteLine();
                rActivity.SetDuration();
                duration = rActivity.GetDuration();
                Console.Clear();
                Console.WriteLine("Get ready...");
                rActivity.SpinnerTimer(5);
                //ReflectingActivity reflectingActivity = new ReflectingActivity(0);
                Console.WriteLine();
                rActivity.StartReflecting(duration);
                Console.WriteLine();
                rActivity.GoodByeMessage(duration, choice);
                Console.Clear();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity(0);
                listingActivity.ActivityDisplay(choice);
                Console.WriteLine();
                listingActivity.SetDuration();
                duration = listingActivity.GetDuration();
                Console.Clear();
                Console.WriteLine("Get ready...");
                listingActivity.SpinnerTimer(5);
                Console.WriteLine();
                //ListingActivity listingActivity = new ListingActivity(0);
                listingActivity.StartListing(duration);
                Console.WriteLine();
                listingActivity.GoodByeMessage(duration, choice);
                Console.Clear();
            }
            else if (choice == 4)
            {
                break;
            }
            
        }
    } 
}