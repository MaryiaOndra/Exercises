using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;

namespace StringData
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationsWithStringFromBook();
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

        static void splittingString()
        {
            string newString = Console.ReadLine();
            string[] splitString = newString.Split(' ');
            foreach (var item in splitString)
                Console.WriteLine(item);
        }

        static void CharExp()
        {
            //char toupper = char.toupper('&');
            //char toupper2 = char.toupper('a');
            //char toupperinv = char.toupperinvariant('#');
            //char toupperinv2 = char.toupperinvariant('c');
            //char toupperinv3 = char.toupperinvariant('s');

            //cultureinfo cultureinfo = cultureinfo.invariantculture;
            //console.writeline(cultureinfo);

            //char max = char.maxvalue;
            //char min = char.minvalue;
            //bool isnumber = char.isnumber('h');
            //string tostring = '$'.tostring();
            //string tostring2 = 1.25.tostring();

            //console.writeline("{0} {1} {2} {3}", max, min, isnumber, tostring, tostring2 );


            //console.writeline("toupper chars: {0} {1} {2} {3} {4}", toupper, toupper2, toupperinv, toupperinv2, toupperinv3);

            char[] theOne = "my mothertonque is belorussian".ToCharArray();
            foreach (var item in theOne)
            {
                Console.WriteLine(item);
            }
            string sample = new string(theOne);
            Console.WriteLine(sample);

            string str1 = string.Concat("Hi ", sample);
        }

        static void EscapeSymbols()
        {
            Console.WriteLine("Hello, \'guys");
            Console.WriteLine("\nNice\f to \"see\" you  \0");
            Console.WriteLine("\nHow's \\your\\ \rdoing\a");
            Console.WriteLine("how is your\t doughter\v lives");
        }

        static void ExperimentsFormats()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(string.Format("today is {0:d} and time is {0:t}", now));

            int num = 15000;
            string hello = "Hello";
            DayOfWeek dateTime = DateTime.Now.DayOfWeek;
            Console.WriteLine($"{num} and {hello} aaand {dateTime}");
            DateTime date = DateTime.Today;


            double cost = 1632.54;
            Console.WriteLine(cost.ToString("C",
                              new System.Globalization.CultureInfo("en-US")));
        }

        static void OperationsWithString()
        {
            //Length

            string frase = "I am waiting for you";
            int lengthStr = frase.Length;
            Console.WriteLine($@"length of string: '{frase}'");

            //Contains(string), StartsWith(string), EndWith(string)

            bool compare = frase.Contains("Am");
            bool compare2 = frase.StartsWith('I');
            bool compare3 = frase.EndsWith("me");
            Console.WriteLine($"containts \"am\": {compare}, \nstarts \"I\": {compare2}, \nends \"you\": {compare3}");

            //ToUpper ToLower
            string upper = "maryia".ToUpper();
            string lower = "KENNY".ToLower();
            Console.WriteLine($"{upper} {lower }");

            //Split(Char[])

            string[] splittedString = frase.Split(' ');
            foreach (var item in splittedString)
            {
                Console.WriteLine(item);
            }

            //Replace(String, String)

            string replaceStr = frase.Replace("waiting", "love");
            Console.WriteLine(replaceStr);

            //IndexOf(String)(Substring(Int32))

            string data = "Name: Helen";
            int index = data.IndexOf(':');
            string name = data.Substring(index - 2);
            Console.WriteLine(name);

            //Trim()

            string trimming = "   dkjhJHK4    ".Trim();
            Console.WriteLine(trimming);

            //SringIsNullOrWhiteSpace(String)

            string newFrase = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(newFrase))
            {
                Console.WriteLine("provide fraise");
            }

            //String.Join(string, string)

            string[] apple = new string[]{"антоновка", "малиновка", "груша"};

            string joining = string.Join(" and ", apple);

            Console.WriteLine(joining);
            
            foreach(var item in apple)
            {
                Console.WriteLine(item);
            }

            //Format(Object), String.Format(String, Object)

            decimal prisePerOunce = 17.36m;
            string s = string.Format($"Praice is {prisePerOunce}", new System.Globalization.CultureInfo("en-US"));
            string b = string.Format("Praice is {0:C2}.", prisePerOunce, new System.Globalization.CultureInfo("en-US"));

            Console.WriteLine($"{s} and {b}");


                

        } 

        static void OperationsWithStringFromBook()
        {
            //Insert
            string frase = "I\a am in love with the \acoco";
            string newString = frase.Insert(5, "goood moood");
            Console.WriteLine(newString);

            string longString = @" It is a very   
                                               veryyy
                                                      looong string";
            Console.WriteLine(longString);

            string s1 = "Hello";
            string s2 = "hey";
            Console.WriteLine($"s1: {s1}");
            Console.WriteLine($"s2: {s2}");

            Console.WriteLine("s1==s2: {0}", s1==s2);
            Console.WriteLine("s1== 'HELLO': {0}", s1 == "HELLO");
            Console.WriteLine("s1== 'Hello': {0}", s1 == "Hello");
            Console.WriteLine("s1.Equals(s2)': {0}", s1.Equals(s2));
            Console.WriteLine("hey.Equals(s2)': {0}", "hey".Equals(s2));

            int n1 = Int32.Parse("12313");



        }
            


    }
}
