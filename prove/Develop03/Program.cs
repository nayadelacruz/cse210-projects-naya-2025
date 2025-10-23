using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string verseText = "In the beginning God created the heaven and the earth.";
        Reference reference = new Reference("Genesis", 1, 1);
        Scripture scripture = new Scripture(verseText, reference);
        int wordsToHidePerIteration = 2;
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