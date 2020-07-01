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
        }

        public override int Square()
        {
            return (int)(Radius * Math.PI); 
        }
    }
}
