using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> _shapes = new List<Shape>();

        _shapes.Add(new Square("Red", 5));
        _shapes.Add(new Rectangle("Blue", 4, 6));
        _shapes.Add(new Circle("Green", 3));

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }

    }
}