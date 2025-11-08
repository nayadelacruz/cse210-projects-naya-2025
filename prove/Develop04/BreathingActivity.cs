using System;
using System.Collections.Generic;
class BreathingActivity : Activity
{
    private int _secondsBreathingIn = 4;
    private int _secondsBreathingOut = 6;

    public BreathingActivity(int duration)
        : base(duration)
    {
        duration = GetDuration();
    }
    public void StartBreathing(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breath in...");
            CountDown(_secondsBreathingIn);
            Console.WriteLine();
            Console.Write("Now breath out...");
            CountDown(_secondsBreathingOut);
            Console.WriteLine();
        }
        
    }
}