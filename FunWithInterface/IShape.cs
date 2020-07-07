using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FunWithInterface
{
    interface IShape
    {
        const int Angle = 30;
        int Square(int side);
        void Draw();
    }
}
