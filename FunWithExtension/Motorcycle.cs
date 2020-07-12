using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithExtension
{
    public sealed class Motorcycle
    {
        public int Acceleration { get; set; }
        public int Distance { get; set; }

        public void Move(int km) 
        {
            Acceleration = 1;
            Distance += km;
        }

    }
}
