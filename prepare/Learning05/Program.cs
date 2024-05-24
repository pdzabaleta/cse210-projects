using System;

class Program
{
    static void Main(string[] args)
    {
        // Square  square = new Square("White", 2);
        // Console.WriteLine(square.GetArea());
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine();

        // Rectangle rectangle = new Rectangle("Black",5, 3);
        // Console.WriteLine(rectangle.GetArea());

        // Console.WriteLine();

        // Circle circle = new Circle("Blue",10);
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
    
        Square  square = new Square("White", 2);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Black",5, 3);
        shapes.Add(rectangle);

        Circle circle = new Circle("Blue",10);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string  color = shape.GetColor();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}