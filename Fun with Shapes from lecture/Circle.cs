using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Fun_with_Shapes_from_lecture
{
    class Circle:Shapes
    {
        private int Radius { get; set; }

        public Circle()
        {
            Radius = new Random().Next(1, 10);
            Name = "Circle";
        }

        public override double Square()
        {
            return Radius * Math.PI; 
        }
    }
}
