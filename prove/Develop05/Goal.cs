using System;
using System.Collections.Generic;
using System.IO;
public abstract class Goal 
{
    private string _goalName;
    private string _goalDescription; 
    private bool _isFinished;  
    private int _points;
    private string _goalType;
    public Goal(string type)
    {
        _goalName = "";
        _goalDescription = "";
        _isFinished = false;
        _points = 0;
        _goalType = type;
    }
    public Goal(string name, string description, bool finished, int points, string type)
{
    _goalName = name;
    _goalDescription = description;
    _isFinished = finished;
    _points = points;
    _goalType = type;
}

    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;        
    }
    public bool GetIsFinished()
    {
        return _isFinished;        
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public void SetIsFinished(bool finished)
    {
        _isFinished = finished;
    }
    public virtual void InitializeGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        _isFinished = false;
        Console.WriteLine();

    }
    public abstract void RecordEvent();

}