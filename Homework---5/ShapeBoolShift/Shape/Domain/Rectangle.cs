using System;

public class Rectangle : Shape
{
    private int SideA;
    private int SideB;

    public Rectangle(string name, string color, int[] position, int sideA, int sideB) : base(name, color, position)
    {
        SideA = sideA;
        SideB = sideB;
    }

    public override void GetArea()
    {
        Console.WriteLine("Area of Rectangle = {0}", SideA * SideB);
    }

    public override void GetPerimeter()
    {
        Console.WriteLine("Perimeter of Rectangle = {0}", 2 * (SideA + SideB));
    }
}
