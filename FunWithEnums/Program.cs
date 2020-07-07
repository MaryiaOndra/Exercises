using System;

namespace FunWithEnums
{
    class Program
    {
        enum EmpType 
        {
         Manager, // = 0
         Grunt = 100, // = 1
         Contractor, // = 2
         VicePresident  // = 3
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Enums!");

            EmpType emp = EmpType.Grunt;
            AskForBonus(emp);

            Console.WriteLine($"EmpType uses a {Enum.GetUnderlyingType(typeof(EmpType))}");
            Console.WriteLine($"emp is a {emp.ToString()}");
            Console.WriteLine($"{emp.ToString()} = {(int)emp}");

            Console.Read();
        }

        static void AskForBonus(EmpType e) 
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock oprions instead?");
                    break;

                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already have enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
    }
}
