using System;

namespace Training.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Circle(), new Square(), new   };

            Shape circle = new Circle(25);
            Shape square = new Square(15);
            Shape triangle = new Triangle(15, 16);

            shapes[0] = circle;
            shapes[1] = square;
            shapes[2] = triangle;

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"This is {shapes[i].Name}. CLR Type is {shapes[i]}. Square is {shapes[i].Area}]");
            } 
        }
    }
}
