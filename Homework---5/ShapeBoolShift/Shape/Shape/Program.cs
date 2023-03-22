Rectangle rect = new Rectangle("Rectangle 1", "Red", new int[] { 5, 10 }, 5, 2);

rect.GetArea();
rect.GetPerimeter();
Shape.Move(rect);
Console.WriteLine("New position of Rectangle = ({0}, {1})", rect.Position[0], rect.Position[1]);

Circle circle = new Circle("Circle 1", "Green", new int[] { 2, -2 }, 7);
circle.GetArea();
circle.GetPerimeter();
Circle.Move(circle);
Console.WriteLine("New position of Circle = ({0}, {1})", circle.Position[0], circle.Position[1]);

Shape shape = new Shape("Shape 1", "Green", new int[] { 2, -2 });
shape.GetArea();
shape.GetPerimeter();
Shape.Move(shape);
Console.WriteLine("New position of Shape = ({0}, {1})", shape.Position[0], shape.Position[1]);
