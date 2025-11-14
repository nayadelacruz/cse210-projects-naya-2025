using System;
public class Circle : Shape {
    private double _radious;
    public Circle(string color, double radious) : base (color)
    {
        _radious = radious;
    }
    public override double GetArea()
    {
        return  Math.PI * _radious * _radious;
    }
}