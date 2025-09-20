using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        /* Console.Write("WHat is the magic number? ");
         string answer = Console.ReadLine();
         int magicNumber = int.Parse(answer);*/

        Random random = new Random();
        int magicNumber = random.Next(1, 100);

        Console.Write(" Between 1-100, what is your guess number? ");
        string guessString = Console.ReadLine();
        int guess = int.Parse(guessString);
        
        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("go higher");
            }
            else
            {
                Console.WriteLine("go lower");
            }

            Console.Write("What is your guess? ");
            guessString = Console.ReadLine();
            guess = int.Parse(guessString);
        }
        if (guess == magicNumber)
        {
            Console.WriteLine("You guess it!");
        }
     

    }
}