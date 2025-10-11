using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToShortDateString();
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine();

    }
    

}