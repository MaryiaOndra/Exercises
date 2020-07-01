using System;
using System.Collections.Generic;
using System.Text;

namespace Fun_with_Shapes_from_lecture
{
    class Rectangle:Shapes
    {
        private int Side { get; set; }


        public Rectangle()
        {
            Side = new Random().Next(1, 10);
            Name = "Rectangle";
        }

        public override double Square()
        {
            return Side * Side;
        }
    }
}
