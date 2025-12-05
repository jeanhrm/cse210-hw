using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Polymorphism with Shapes\n");

        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        Console.WriteLine("Testing each shape individually:");
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Yellow", 2));
        shapes.Add(new Rectangle("Purple", 3, 7));
        shapes.Add(new Circle("Orange", 4));
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("Displaying shapes from a Shape list (polymorphism):");

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            string typeName = shape.GetType().Name;

            Console.WriteLine($"{typeName} - Color: {color}, Area: {area}");
        }

        Console.WriteLine("\nPress ENTER to finish...");
        Console.ReadLine();
    }
}
