using System;
using System.Collections.Generic;
using System.Text;

namespace Training.OOP
{
    class Square:Shape
    {
        public Square(int sideLenght)
        {
            Side = sideLenght;
            Name = "Square";
            FindArea();
        }

        public void FindArea() 
        {
            Area = Side * Side;
        }
    }
}
