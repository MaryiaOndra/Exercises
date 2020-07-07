using System;
using System.Drawing;
using FunWithStructures;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeAssignment();

            ReferenceTypeAssignment();

            static void ValueTypeAssignment()
            {
                Console.WriteLine("Assigning value types\n");

                FunWithStructures.Point p1 = new FunWithStructures.Point(25, 50);
                FunWithStructures.Point p2 = p1;

                //show value of two valuables
                p1.Display();
                p2.Display();

                //change value of p1.X
                p1.X = 1000;
                Console.WriteLine("Changed value of p1.X");
                p1.Display();
                p2.Display();
            }

            static void ReferenceTypeAssignment()
            {
                Console.WriteLine("Assigning reference types\n");

                PointRef pointRef1 = new PointRef(50, 500);
                pointRef1.Display();

                PointRef pointRef2 = new PointRef(1500, 700);
                pointRef2.Display();

                pointRef2 = pointRef1;

                //change value of pointRef1.X

                pointRef1.X = 12;
                pointRef1.Display();
                pointRef2.Display();
            }
        }
    }
}
