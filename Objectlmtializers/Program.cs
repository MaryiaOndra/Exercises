using System;

namespace Objectlmtializers
{
    class Program
    {
        static void Main(string[] args)
        {
            //call a more interesting special constructor with initialization sintax
            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();

            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10},
                BottomRight = new Point {X = 200, Y = 200 }
            };

            //traditional method
            Rectangle r = new Rectangle();
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 10;
            r.TopLeft = p1;
            Point p2 = new Point();
            p2.X = 200;
            p2.Y = 200;
            r.BottomRight = p2;


        }
    }
}
