using System;

namespace FunWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(12);
            Rectangle[] rectangles = { new Rectangle(10), new Rectangle(20), new Rectangle(30) };

            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i].Draw();

                if (rectangles[i] is IShape ip)
                {
                    Console.WriteLine("You are here");
                }
                else
                {
                    Console.WriteLine("No you not");
                }
            }
        }
    }
}

