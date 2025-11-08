using System;
class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity(int duration) : base(duration)
    {
        // Additional initialization if needed
        int _duration = duration;
    }
    public void StartReflecting(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        List<string> prompts = new List<string>(_prompts);
        while (DateTime.Now < endTime && prompts.Count > 0)
        {
            Console.Clear();
            Random randdom = new Random();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            int promptIndex = randdom.Next(prompts.Count);
            Console.WriteLine($"--- {prompts[promptIndex]} ---");
            prompts.RemoveAt(promptIndex);
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            CountDown(5);
            Console.Clear();
            foreach (string question in _questions)
            {
                if (DateTime.Now >= endTime)
                    break;

                Console.WriteLine($"> {question}");
                SpinnerTimer(10);
                Console.WriteLine();
            }
        }
    }

}