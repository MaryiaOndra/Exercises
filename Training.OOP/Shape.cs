using System;
using System.Collections.Generic;
using System.Text;

namespace Training.OOP
{
    class Shape
    {
        public int Side { get; set; }
        public int Area { get; set; }

        public string Name { get; set; }

        public int FindArea()
        {
            return Area;
        }
    }
}
