using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace FunWithInterface
{
    internal class Rectangle : IShape
    {
        private int _side;
        int angle;
        public int Side { get { return _side; } set { _side = value; } }

        public Rectangle(int side)
        {
            Side = side;
            angle = IShape.Angle;
        }

        public void Draw()
        {
            Console.WriteLine("It is Rectangle");
        }

        public int Square(int side)
        {
            return side * side;
        }
    }
}

