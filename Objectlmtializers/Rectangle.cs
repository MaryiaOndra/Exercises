﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Objectlmtializers
{
    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();
        
        public Point TopLeft 
        {
            get { return topLeft; }
            set { topLeft = value; }
        }

        public Point BottomRight 
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats() 
        {
            Console.WriteLine($"[TopLeft: {topLeft.X}, {topLeft.Y}, {topLeft.Color} " +
                $"\nBottom Right: {bottomRight.X}, {bottomRight.Y}, {bottomRight.Color}]");
        }
    }
}