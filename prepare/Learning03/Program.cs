using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Test all constructors
        Fraction f1 = new Fraction();        // 1/1
        Fraction f2 = new Fraction(6);       // 6/1
        Fraction f3 = new Fraction(3, 4);    // 3/4

        // Display each fraction and its decimal value
        Console.WriteLine(f1.FractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.FractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.FractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Test getters and setters
        f3.SetNumerator(1);
        f3.SetDenominator(3);
        Console.WriteLine($"Updated fraction: {f3.FractionString()}  = {f3.GetDecimalValue()}");
    }
}