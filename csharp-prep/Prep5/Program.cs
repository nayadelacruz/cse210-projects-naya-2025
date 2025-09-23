using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        /* function that displays message */
        DisplayWelcome();

        /* function that ask and return the users name as a string */
        string userName = PromptUserName();

        /* function that asks and return the user favorite number as an integer */
        int favoriteNumber = PromtUserNumber();

        /* Accepts outinteger parameter and prompts the user for the year they were born 
        * the out parameter is set to the birth year. Doens't return a value but is set 
        * through the out parameter */
        int birthYear;
        PromptUserBirthYear(out birthYear);

        /* function that uses the fav number as a parameter and returns
        *that number as square as an integer*/
        int squareNumber = SquareNumber(favoriteNumber);

        /* function that displays the user name and squared number and calculate how
        * many years old they will be this yeara d display that*/
        DisplayResult(userName, squareNumber, birthYear);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromtUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string favNumber = Console.ReadLine();
        int favoriteNumber = int.Parse(favNumber);
        return favoriteNumber;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("What year were you born? ");
        string yearBorn = Console.ReadLine();
        birthYear = int.Parse(yearBorn);
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        Console.WriteLine($"Hello {name}, the square of your favorite number is {square}.");
        Console.WriteLine($"You will turn {age} years old this year.");
    }

}