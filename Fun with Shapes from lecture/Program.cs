using System;

namespace Fun_with_Shapes_from_lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shapes = {new Triangle(), new Rectangle(), new Circle() };

            foreach (Shapes s in shapes)
            {
                Console.WriteLine($"This is {s.Name}. CLR Type is {s.GetType()}].Square is {s.Square()}");
            }
        }
    }
}
