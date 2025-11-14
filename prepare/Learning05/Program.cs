using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square square = new Square("blue", 5.0);
        //square.SetColor("Red");
        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");
        Rectangle rectangle = new Rectangle("green", 4.0, 6.0);
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        Circle circle = new Circle("yellow", 3.0);
        Console.WriteLine($"Circle Color: {circle.GetColor()}");
        Console.WriteLine($"Circle Area: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The shape Color {s.GetColor()} has an area of {s.GetArea()}");
        }
    }
}