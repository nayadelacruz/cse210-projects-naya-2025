using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose from the following scriptures and type which one you would want to practice, then press Enter:");
        Console.WriteLine("1. Genesis 1:1");
        Console.WriteLine("2. 3 Nephi 11:10-11");
        Console.WriteLine("3. John 3:16");
        Console.Write("Your choice (1-3): ");
        int _choice = int.Parse(Console.ReadLine());
        int _chosenScripture = _choice - 1;
        Scripture.InitializeScriptures();
        string _verseText = Scripture.GetScriptureText(_chosenScripture);
        Reference.GenerateReferences();
        Reference _reference;
        if (_chosenScripture != 1)
        {
            _reference = new Reference(_chosenScripture, false);
        }
        else
        {
            _reference = new Reference(_chosenScripture, true);
        }
        Scripture _scripture = new Scripture(_verseText, _reference);
        int _wordsToHidePerIteration = 2;
        Console.Clear();
        Console.WriteLine(_scripture.GetRenderedText());
        while (!_scripture.CompletelyHidden())
        {

            Console.Write("Press Enter to continuo or 'quit' to exit: ");
            string _userInput = Console.ReadLine();
            if (_userInput.ToLower() == "quit")
            {
                return;
            }
            Console.Clear();
            _scripture.HideRandomWords(_wordsToHidePerIteration);
            Console.WriteLine(_scripture.GetRenderedText());
        }
    }
}
/* What I did to exceed expectations was to create a list of scriptures, and the user 
can choose among them which scripture the user wants to practice*/