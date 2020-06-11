using System;
using System.Net.WebSockets;
using System.Security.Claims;

namespace BasicDataTipes
{
    class Program
    {
        static void Main(string[] args)
        {
            CharFunctionality();
        }

        static void DataDeclarations()
        {
            Console.WriteLine("=> Data declarations");

            int myInt = 0;

            string myString;

            myString = "My string";

            bool b1 = true, b2 = false, b3 = b1;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}", myInt, myString, b1, b2, b3);
        }

        static void DefaultDeclarations()
        {
            int myInt = default;
            Console.WriteLine("Default declaration: {0}", myInt);
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables");

            int i = new int();

            bool f = new bool();

            double d = new double();

            DateTime g = new DateTime();

            Console.WriteLine("{0}, {1}, {2}, {3}", i, f, d, g);                     

        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("System.Object Functionality:");
            Console.WriteLine("12.GetHushCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString = {0}", 12.ToString());
            Console.WriteLine("12.GetType = {0}", 12.GetType());
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type functionality");
            Console.WriteLine("Max and Min values of int: {0} and {1}", int.MaxValue, int.MinValue );
            Console.WriteLine("Max and Min values of double: {0} and {1}", double.MaxValue, double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);

            Console.WriteLine("Bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine("Bool.FalceString: {0}", bool.FalseString);
        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> char type functionality;");

            char myChar = 'a';

            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));

            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));

            Console.WriteLine("char.IsWhiteSpase('Hello There, 5': {0})", char.IsWhiteSpace("Hello There 5", 5));

            Console.WriteLine("char.IsWhiteSpase('Hello There, 6': {0})", char.IsWhiteSpace("Hello There 5", 6));

            Console.WriteLine("char.IsPunctuation('?': {0})", char.IsPunctuation('?'));
            


        }

    }
}
