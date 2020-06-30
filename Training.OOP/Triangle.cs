using System;
using System.Collections.Generic;
using System.Text;

namespace Training.OOP
{
    class Triangle:Shape
    {
        public int Hight { get; set; }

        public Triangle(int baseTrngl, int hightTrngl)
        {
            Side = baseTrngl;
            Hight = hightTrngl;
            Name = "Triangle";
            this.FindArea();
        }

        public void FindArea() 
        {
            Area = Hight * Side / 2;
        }
    }
}
