using System;
using System.Collections.Generic;
using System.Text;

namespace ValueAndReferenceTypes
{
    class PointRef
    {
        public int X;
        public int Y;

        public void Increment()
        {
            X++;
            Y++;
        }

        public PointRef(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public void Decrement()
        {
            X--;
            Y--;
        }

        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }
}
