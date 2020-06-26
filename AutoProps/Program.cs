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

            Console.Read();
        }
    }

    class Car
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

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
