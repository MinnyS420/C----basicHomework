using System;

public class Circle : Shape
{
    private int Radius;

    public Circle(string name, string color, int[] position, int radius) : base(name, color, position)
    {
        Radius = radius;
    }

    public override void GetArea()
    {
        Console.WriteLine("Area of Circle = {0}", 3.14 * Radius * Radius);
    }

    public override void GetPerimeter()
    {
        Console.WriteLine("Perimeter of Circle = {0}", 2 * 3.14 * Radius);
    }
}
