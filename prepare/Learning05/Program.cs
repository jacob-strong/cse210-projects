using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine();

        List<Shape> shapeList = new List<Shape>();
        Square newSquare = new Square("Blue", 4);
        shapeList.Add(newSquare);
        Rectangle newRectangle = new Rectangle("Red", 2, 4);
        shapeList.Add(newRectangle);
        Circle newCircle = new Circle("Yellow", 3);
        shapeList.Add(newCircle);

        foreach(Shape x in shapeList){
            Console.WriteLine(x.getColor());
            Console.WriteLine(x.getArea());
            Console.WriteLine();
        }
    }
}