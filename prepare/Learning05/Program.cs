using System;

class Program
{
    static void Main(string[] args)
    {
        Square shape1 = new Square("black", 2);
        Rectangle shape2 = new Rectangle("blue", 1, 2);
        Circle shape3 = new Circle("white", 2);


        List<Shape> shapesList = new List<Shape>();
        shapesList.Add(shape1);
        shapesList.Add(shape2);
        shapesList.Add(shape3);

        foreach (Shape element in shapesList) {
            string color = element.GetColor();
            double area = element.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}. ");
        }
    
    }
}