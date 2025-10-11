using System;
using System.Collections.Generic;

public class GeneratePrompt
{
    private static Random _random = new Random();
    private readonly List<string> _prompts = new List<string>()
    {
        "What did you enjoy doing the most today?",
        "What was something that made you happy today?",
        "What was something you learned today?",
        "What is something you are grateful for today?",
        "What is a challenge you faced today and how did you overcome it?"
    };
    public string RandomPrompt()
    {
        
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}