using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string entry = Console.ReadLine();
        int number = int.Parse(entry);
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            entry = Console.ReadLine();
            number = int.Parse(entry);

        }
        /* foreach (int numero in numbers)
         {
             Console.Write(numero);
         }*/
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        int average = sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        int bigger = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > bigger)
            {
                bigger = numbers[i];
            }
        }
        Console.WriteLine($"The biggest number is: {bigger}");
        /*
        */
    }
}