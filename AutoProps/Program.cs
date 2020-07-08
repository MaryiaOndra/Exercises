using System;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Automatic Properties");

            Car c = new Car();
            c.PetName = "Mo";
            c.Speed = 60;
            c.Color = "Red";

            c.DisplayStats();

            //add car into garage
            Garage garage = new Garage();
            garage.MyAuto = c;

            //show amount of cars  in the garage
            Console.WriteLine($"Number of cars in garage : {garage.NumberOfCars}");
            Console.WriteLine($"Your car is named: {garage.MyAuto.PetName}");

            Car b = new Car();
            b.DisplayStats();

            Garage garage1 = new Garage(b, 2);
            Console.WriteLine($"{garage1.MyAuto.PetName}");

            Console.Read();
        }
    }

    internal class Car
    {
        public string PetName { get; set; } = "Jo";
        public int Speed { get; set; } = 300;
        public string Color { get; set; } = "Blue";

        public void DisplayStats() 
        {
            Console.WriteLine($"Car Name: {PetName}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Color: {Color}");
        }

    }

    class Garage 
    {
        public int NumberOfCars { get; set; }
        public Car MyAuto { get; set; }
        public Garage()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }

}
