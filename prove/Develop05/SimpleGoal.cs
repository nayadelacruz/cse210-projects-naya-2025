using System;
using System.Collections.Generic;
using System.IO;
public class SimpleGoal : Goal
{
    public SimpleGoal() : base(type: "SimpleGoal")
    {

    }
    
    public SimpleGoal(string name, string description, bool finished, int points)
    : base(name, description, finished, points, "SimpleGoal")
    {
    }

    public override void RecordEvent()
    {
        if (GetIsFinished())
        { 
            Console.WriteLine("You have already accomplished this goal.");
            return;
        
        }
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        SetIsFinished(true);
    }
}