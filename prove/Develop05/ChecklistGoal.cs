using System;
using System.Collections.Generic;
using System.IO;
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;
    public ChecklistGoal() : base(type: "ChecklistGoal")
    {
        _targetCount = 0;
        _currentCount = 0;
        _bonusPoints = 0;
    }

    public ChecklistGoal(string name, string desc, bool finished, int points, int target, int bonus, int count)
    : base(name, desc, finished, points, "ChecklistGoal")
{
    _targetCount = target;
    _bonusPoints = bonus;
    _currentCount = count;
}

    public int GetTargetCount()
    {
        return _targetCount;
    }   
    public int GetCurrentCount()
    {
        return _currentCount;
    }   
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override void InitializeGoal()
    {
        base.InitializeGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _targetCount = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");  
        _bonusPoints = int.Parse(Console.ReadLine());
        _currentCount = 0;
        Console.WriteLine();
    }

    public override void RecordEvent()
    {
        if (GetIsFinished())
        { 
            Console.WriteLine("You have already accomplished this goal.");
            return;
        
        }
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            SetIsFinished(true);

            Console.WriteLine($"Congratulations! You have earned {GetPoints()} + {_bonusPoints} points!");
        }
        else
        {
            Console.WriteLine($"You have earned {GetPoints()} points! {_targetCount - _currentCount} more to go!");
        }
        
    }   
}