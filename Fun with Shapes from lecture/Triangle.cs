using System;
using System.Collections.Generic;
using System.Text;

namespace Fun_with_Shapes_from_lecture
{
    class Triangle:Shapes
    {
        private int  Side { get; set; }
        private int  Height { get; set; }

        public Triangle()
        {
            Side = new Random().Next(1, 10);
            Height = new Random().Next(1, 10);
            Name = "Triangle";
        }

        public override double Square()
        {
            return Height * Side / 2;
        }
    }
}
