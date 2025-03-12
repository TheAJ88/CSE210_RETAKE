using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        Square sq = new Square(4, "Red");
        Rectangle rg = new Rectangle(3.5, 2, "Blue");
        Circle cr = new Circle(5, "Green");
        shapes.Add(sq);
        shapes.Add(rg);
        shapes.Add(cr);
        foreach(Shape _shape in shapes)
        {
            double area = _shape.GetArea();
            string color = _shape.GetColor();
            string shapeName = _shape.GetShape();
            Console.WriteLine($"The {color} colored {shapeName} has an area of {area}");
        }
    }
}