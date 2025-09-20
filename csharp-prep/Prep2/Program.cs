using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade porcentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A"; ;
        }

        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you have not passed the class but you can try again!");
        }

    }
}
