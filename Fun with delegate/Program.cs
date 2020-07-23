using System;
using System.Linq;

namespace Fun_with_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Delegates as event enablers*******\n");

            //ceate Car
            Car c1 = new Car("SlugBug", 100, 10);

            //say to Car what method he shoud call to send a message
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            //save delegate object to cancel registration in future
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler2);

            //cancel registr 2nd worker
            c1.UnRegisterWithCarEngine(handler2);

            //increase speed
            Console.WriteLine("******Speeding up******");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.ReadLine();
        }

        public static void OnCarEngineEvent(string msg ) 
        {
            Console.WriteLine("\n ******Message from car******");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("*********************************");
        }

        public static void OnCarEngineEvent2(string msg) 
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}
