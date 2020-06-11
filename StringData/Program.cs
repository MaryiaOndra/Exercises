using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Reflection.Metadata;

namespace StringData
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDateAndTime();
        }

        static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);

            double d = double.Parse("5,564654");
            Console.WriteLine("Value of d: {0}", d);

            int i = int.Parse("52");
            Console.WriteLine("Value of i: {0}", i);

            Console.ReadLine();

            //char c = char.Parse('h');
            //Console.WriteLine("Value of c: {0}", c);

        }

        static void ParseStringWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse");

            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }

            string value = "Hello";

            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double", value);
            }
        }

        static void UseDateAndTime()
        {
            Console.WriteLine("=> Dates and Times");

            //этот конструктор принимает год, месяц и день
            DateTime dt = new DateTime(1991, 12, 26);
            
            //какой это день недели
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            //сейчас месяц декабрь
            dt = dt.AddMonths(12);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            //Этот конструктор принимает часы, минуты и секунды
            TimeSpan ts = new TimeSpan(4, 30, 0);

            //вычесть из текущего значения TimeSpan и вывести результат
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }

    }
}
