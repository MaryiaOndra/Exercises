using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithExtension
{
    static class MotorcycleExtencions
    {
        public static void TakeWeellie(this Motorcycle moto, int acceleration) 
        {
            moto.Acceleration = acceleration;
            moto.Move(10);
        }
    }
}
