using System;
using System.Collections.Generic;
using System.IO;
public class GoalsDao
{   

    public GoalsDao()
    {
    }

    public void SaveGoals(string filename, List<Goal> goals)
    { 
        try
        {
            using (StreamWriter newFile = new StreamWriter(filename))
            {
                foreach (Goal goal in goals)
                {
                    string line = $"{goal.GetGoalType()}|{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetIsFinished()}|{goal.GetPoints()}|{(goal is ChecklistGoal ? ((ChecklistGoal)goal).GetTargetCount().ToString() : "0")}|{(goal is ChecklistGoal ? ((ChecklistGoal)goal).GetBonusPoints().ToString() : "0")}|{(goal is ChecklistGoal ? ((ChecklistGoal)goal).GetCurrentCount().ToString() : "0")}";
                    newFile.WriteLine(line);
                }
            }

            Console.WriteLine("Your Goals have been saved to " + filename);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the goals: {ex.Message}");
        }
        
    }
    
    public List<Goal> LoadGoals(string filename)
    {
        List<Goal> goals = new List<Goal>();
        string[] lines  = File.ReadAllLines(filename);
        foreach (string line in lines)
        {   
            if (string.IsNullOrWhiteSpace(line))
                continue;
            string[] parts = line.Split('|');
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            bool isFinished = bool.Parse(parts[3]);
            int points = int.Parse(parts[4]);   
            if (goalType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, isFinished, points);
                goals.Add(simpleGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int targetCount = int.Parse(parts[5]);
                int bonusPoints = int.Parse(parts[6]);
                int currentCount = int.Parse(parts[7]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, isFinished, points, targetCount, bonusPoints, currentCount);
                // Set current count if needed
                goals.Add(checklistGoal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, isFinished, points);
                goals.Add(eternalGoal);
            }
        }
        return goals;
    }
}