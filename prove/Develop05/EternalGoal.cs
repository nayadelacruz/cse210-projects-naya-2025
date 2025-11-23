using System;
using System.Collections.Generic;
using System.IO;
public class EternalGoal : Goal
{ 
    public EternalGoal() : base(type: "EternalGoal")
    {
    }
    public EternalGoal(string name, string description, bool finished, int points)
    : base(name, description, finished, points, "EternalGoal")
    { }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}