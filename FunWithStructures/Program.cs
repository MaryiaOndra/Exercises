using System;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****a First Look at Structures *****}");

            //add new variable Point
            Point myPoint;
            myPoint.X = 100;
            myPoint.Y = 1000;
            myPoint.Display();

            //correct values of X and Y
            myPoint.Decrement();
            myPoint.Display();

            Console.Read();

            //create new Point with explisit constructor
            Point point = new Point(20, 50);
            point.Display();

            //create new variable by using a  implisit constructor
            //Point pointCtor = new Point();
            //pointCtor.Display();          
            

        }
    }
}
