using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithStructures
{
    public struct Point
    {
        //fields of structure
        public int X;
        public int Y;

        //add 1 to (X,Y) 
        public void Increment() 
        {
            X++;
            Y++;
        }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        //take 1 from (X,Y)
        public void Decrement()
        {
            X--;
            Y--;
        }

        //show current position
        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }
}
