using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();             
        GeneratePrompt promptGenerator = new GeneratePrompt(); 

        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.RandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Entry entry = new Entry(prompt, response);
                myJournal.AddEntry(entry);
                Console.WriteLine("Your entry has been added.");


            }
            else if (choice == "2")
            {
                Console.WriteLine("Here are your journal entries:");
                myJournal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Please enter the CSV filename to load your journal entries: (example: mylife.csv)");
                string filename = Console.ReadLine();
                myJournal.LoadCsv(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Please enter a CSV file name to save your journal entries: (example: mylife.csv)");
                string filename = Console.ReadLine();
                myJournal.SaveCsv(filename);
                //myJournal.Save(filename);
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
            /*Entry e = new Entry("What was the best part of your day?", "Going for a walk with my kids.");
                e.DisplayEntry();
                -----------------------
                GeneratePrompt gp = new GeneratePrompt();
                Console.WriteLine(gp.RandomPrompt());*/


            /* asking the user to enter a file name when loading a list of entries "LOAD"*/

        }
    }  
}