using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousMethods
{
    class Car
    {
        public string PetName { get; set; } = "Jo";
        public int Speed { get; set; } = 300;
        public string Color { get; set; } = "Blue";

        public Car(string name, int speed, string color)
        {
            PetName = name;
            Speed = speed;
            Color = color;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Car Name: {PetName}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Color: {Color}");
        }
    }
}
