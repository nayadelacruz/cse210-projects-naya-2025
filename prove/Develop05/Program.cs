using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

//What I did to exceed expectations was to add levels  tot he user based on points earned.
class Program
{
    private List<Goal> _goals = new List<Goal>();
    GoalsDao _goalsDao = new GoalsDao();
    UserInfo _userInfo = new UserInfo();
    UserInfoDao _userInfoDao = new UserInfoDao();
    static void Main(string[] args)
    {
        Program program = new Program();
        int choice = 0;
        while (choice != 6)
        {
            program.DisplayMenu();
            choice = program.GetUserChoice();
            program.HandleUserChoice(choice);
        }

    }
    public void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine($"\nYou have {_userInfo.GetPoints()} points and your are at Level {_userInfo.GetLevel()}.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    public int GetUserChoice()
    {
        string choice = Console.ReadLine();
        return int.Parse(choice);
    }
    public void HandleUserChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                ListGoals();
                break;
            case 3:
                SaveGoals();
                break;
            case 4:
                LoadSavedGoals();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                Console.WriteLine("Quitting the program.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalTypeChoice = Console.ReadLine();
        Goal newGoal;
        switch (goalTypeChoice)
        {
            case "1":
                newGoal = new SimpleGoal();
                break;
            case "2":
                newGoal = new EternalGoal();
                break;
            case "3":
                newGoal = new ChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice. Returning to main menu.");
                return;
        }
        newGoal.InitializeGoal();
        _goals.Add(newGoal);
    }
    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        foreach (Goal goal in _goals)
        {
            bool isFinish = goal.GetIsFinished();
            string goalType = goal.GetGoalType();
            int currentCount = goal is ChecklistGoal ? ((ChecklistGoal)goal).GetCurrentCount() : 0;
            int targetCount = goal is ChecklistGoal ? ((ChecklistGoal)goal).GetTargetCount() : 0;
            string status;
            if (isFinish == true)
            {
                status = "[X]";
            }
            else
            {
                status = "[ ]";
            }
            if (goalType == "ChecklistGoal")
            {
                Console.WriteLine($"{status} {goal.GetGoalName()} ({goal.GetGoalDescription()}) -- Current Progress: {currentCount}/{targetCount}");
            }
            else if (goalType == "EternalGoal" || goalType == "SimpleGoal")
            {
                Console.WriteLine($"{status} {goal.GetGoalName()} ({goal.GetGoalDescription()})");
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter the filename to save your goals: ");
        string filename = Console.ReadLine();
        _goalsDao.SaveGoals(filename, _goals);
        _userInfoDao.SaveUserInfo(_userInfo);
    }
    public void LoadSavedGoals()
    {
        Console.Write("Enter the filename to load your goals: ");
        string filename = Console.ReadLine();
        _goals = _goalsDao.LoadGoals(filename);
        ListGoals();
        _userInfoDao.LoadUserInfo(_userInfo);
    }
    public void RecordEvent()
    {
        int goalNumber = 1;
        Console.WriteLine("The Goals are: ");
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{goalNumber}. {g.GetGoalName()}");
            goalNumber++;
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        Goal goalChoice = _goals[choice - 1];
        int pointsEarned = goalChoice.GetPoints();
        string goalType = goalChoice.GetGoalType();
        if (goalType == "SimpleGoal")
        {
            goalChoice.RecordEvent();
        }
        else if (goalType == "EternalGoal")
        {
            goalChoice.RecordEvent();
        }
        else if (goalType == "ChecklistGoal")
        {
            ChecklistGoal checklist = (ChecklistGoal)goalChoice;
            checklist.RecordEvent();
            if (checklist.GetIsFinished())
            {
                pointsEarned += checklist.GetBonusPoints();
            }
        }
        _userInfo.AddPoints(pointsEarned);
        _userInfo.SetLevel();
        _userInfo.DisplayUserInfo();
    }
    
}