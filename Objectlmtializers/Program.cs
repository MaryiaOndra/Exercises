using System;

namespace Objectlmtializers
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object Point by adding inf by hand
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 20;
            firstPoint.DisplayStats();

            //create new object Point by using special costructor

            Point secondPoint = new Point(30 , 40);
            secondPoint.DisplayStats();

            //Create a Point object using the object initialization syntax.

            Point thirdPoint = new Point { X = 40, Y = 50 };
            thirdPoint.DisplayStats();

            Console.Read();
        }
    }
}
