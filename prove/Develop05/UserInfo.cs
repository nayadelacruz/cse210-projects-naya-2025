using System;
using System.Collections.Generic;
using System.IO;
public class UserInfo
{
    private int _userPoints;
    private string _level;
    public UserInfo()
    {
        _userPoints = 0;
        _level = "Beginner";
    }
    public int GetPoints()
    {
        return _userPoints;
    }
    public string GetLevel()
    {
        return _level;
    }
    public void AddPoints(int addPoints)
    {
        _userPoints += addPoints;
    }
    public void SetLevel()
    {
        if (_userPoints >= 10000)
        {
            _level = "Master";
        }
        else if (_userPoints >= 1000)
        {
            _level = "Expert";
        }
        else if (_userPoints >= 500)
        {
            _level = "Intermediate";
        }
        else
        {
            _level = "Beginner";
        }
    }
    public void DisplayUserInfo()
    {
        Console.WriteLine($"You have {_userPoints} points and your are at Level {_level}!!!");
    }
}