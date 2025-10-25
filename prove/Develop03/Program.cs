using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chose from the followinf scriptures and tipe which one you would want then press Enter:");
        Console.WriteLine("1. Genesis 1:1");
        Console.WriteLine("2. 3 Nephi 11:10-11");
        Console.WriteLine("3. John 3:16");
        Console.Write("Your choice (1-3): ");
        int choice = int.Parse(Console.ReadLine());
        int chosenScripture = choice - 1;
        Scripture.InitializeScriptures();
        string verseText = Scripture.GetScriptureText(chosenScripture);
        Reference.GenerateReferences();
        Reference reference;
        if (chosenScripture != 1)
        {
            reference = new Reference(chosenScripture, false);
        }
        else
        {
            reference = new Reference(chosenScripture, true);
        }
        Scripture scripture = new Scripture(verseText, reference);
        int wordsToHidePerIteration = 2;
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText());
        while (!scripture.CompletelyHidden())
        {

            Console.Write("Press Enter to continuo or 'quit' to exit: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                return;
            }
            Console.Clear();
            scripture.HideRandomWords(wordsToHidePerIteration);
            Console.WriteLine(scripture.GetRenderedText());
        }
    }
}
/* What I did to exceed expectations was to create a list of scriptures, and the user 
can choose among them which scripture the user wants to practice*/