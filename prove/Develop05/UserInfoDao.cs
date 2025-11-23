using System;
using System.Collections.Generic;
using System.IO;
public class UserInfoDao
{
    public UserInfoDao()
    { }
    public void SaveUserInfo(UserInfo userInfo)
    {
        try
        {
            using (StreamWriter newFile = new StreamWriter("UserInfo.txt"))
            {
                string line = $"{userInfo.GetPoints()}|{userInfo.GetLevel()}";
                newFile.WriteLine(line);
            }

            Console.WriteLine("Your User Info has been saved to UserInfo.txt");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the user info: {ex.Message}");
        }
    }
    public void LoadUserInfo(UserInfo userinfo)
    {
        try
        {
            string[] lines = File.ReadAllLines("UserInfo.txt");
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                string[] parts = line.Split('|');
                int points = int.Parse(parts[0]);
                string level = parts[1];
                userinfo.AddPoints(points);
                // Assuming SetLevel method sets the level based on points
                userinfo.SetLevel();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the user info: {ex.Message}");
        }
    }
}

