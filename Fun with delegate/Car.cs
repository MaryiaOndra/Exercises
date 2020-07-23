using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Fun_with_delegate
{
    class Car
    {
        //condition
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        //is car OK
        private bool carIsDead;

        //constractors
        public Car()
        {

        }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        public delegate void CarEngineHandler(string msgForCaller);

        private CarEngineHandler listOfHandlers;

        public void RegisterWithCarEngine(CarEngineHandler methodToCall) 
        {
            listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta) 
        {
            //if its broken send a message
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers("sorry, this car is dead...");
                }
            }
            else
            {
                CurrentSpeed += delta;
                //car is almost brocken
                if (10 == (MaxSpeed - CurrentSpeed)
                    && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("Current Speed = {0}", CurrentSpeed);
                }
            }
        }
    }
}
