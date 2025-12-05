using System;
/* the way I exceeded expectatons was by in the Reflecting Activity, I created code so the prompts
 and questions wouldn't repeat. I made that the prompt can just be chosen once and the questions 
 can appear in order and once each question has appeared and there is still time, another different 
 prompt will appear and then the list will start againg but for the new prompt*/
class Program
{
    static int _choice;
    static int _duration;
    static void Main(string[] args)
    {
        //int _duration;
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1.Start Breathing Activity");
            Console.WriteLine("  2.Start Reflecting Activity");
            Console.WriteLine("  3.Start Listing Activity");
            Console.WriteLine("  4.Quit");
            Console.Write("Select a choice from the menu: ");
            _choice = int.Parse(Console.ReadLine());
            Console.Clear();
            if (_choice == 1)
            {
                BreathingActivity bActivity = new BreathingActivity(0);
                bActivity.ActivityDisplay(_choice);
                Console.WriteLine();
                bActivity.SetDuration();
                _duration = bActivity.GetDuration();
                Console.Clear();
                Console.Write("Get ready...");
                bActivity.SpinnerTimer(5);
                Console.WriteLine();
                //BreathingActivity breathingActivity = new BreathingActivity(0);
                bActivity.StartBreathing(_duration);
                Console.WriteLine();
                bActivity.GoodByeMessage(_duration, _choice);
                Console.Clear();
                
            }
            else if (_choice == 2)
            {
                ReflectingActivity rActivity = new ReflectingActivity(0);
                rActivity.ActivityDisplay(_choice);
                Console.WriteLine();
                rActivity.SetDuration();
                _duration = rActivity.GetDuration();
                Console.Clear();
                Console.WriteLine("Get ready...");
                rActivity.SpinnerTimer(5);
                //ReflectingActivity reflectingActivity = new ReflectingActivity(0);
                Console.WriteLine();
                rActivity.StartReflecting(_duration);
                Console.WriteLine();
                rActivity.GoodByeMessage(_duration, _choice);
                Console.Clear();
            }
            else if (_choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity(0);
                listingActivity.ActivityDisplay(_choice);
                Console.WriteLine();
                listingActivity.SetDuration();
                _duration = listingActivity.GetDuration();
                Console.Clear();
                Console.WriteLine("Get ready...");
                listingActivity.SpinnerTimer(5);
                Console.WriteLine();
                //ListingActivity listingActivity = new ListingActivity(0);
                listingActivity.StartListing(_duration);
                Console.WriteLine();
                listingActivity.GoodByeMessage(_duration, _choice);
                Console.Clear();
            }
            else if (_choice == 4)
            {
                break;
            }
            
        }
    } 
}