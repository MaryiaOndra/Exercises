using System;
using System.Collections.Generic;
using System.Text;

namespace Training.OOP
{
    class Circle:Shape
    {
        public Circle(int radius)
        {
            Side = radius;
            Name = "Circle";
            FindArea();
        }

        public void FindArea() 
        {
            Area = (int)(Math.PI * Side * Side);
        }
    }
}
