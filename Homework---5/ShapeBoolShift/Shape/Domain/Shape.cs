using System;

public class Shape
{
    protected string _name;
    protected string _color;
    public int[] Position;


    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Name cannot be null or empty.");
            }
            else
            {
                _name = value;
                Console.WriteLine($"Name has been set to {_name}.");
            }
        }
    }

    public string Color
    {
        get
        {
            return _color;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Color cannot be null or empty.");
            }
            else
            {
                _color = value;
                Console.WriteLine($"Color has been set to {_color}.");
            }
        }
    }
    public Shape(string name, string color, int[] position)
    {
        Name = name;
        Color = color;
        Position = position;
    }

    public virtual void GetArea()
    {
        Console.WriteLine("There is no special implementation for area of this shape.");
    }

    public virtual void GetPerimeter()
    {
        Console.WriteLine("There is no special implementation for perimeter of this shape.");
    }

    public static void Move(Shape shape)
    {
        shape.Position[0] += 5;
        shape.Position[1] += 5;
    }
}


