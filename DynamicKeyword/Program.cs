using System;
using System.Collections.Generic;

namespace DynamicKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinThreeStrings();

            ChangeDynamicDataType();

            InvokeMembersOnDynamicData();
        }

        static void PrinThreeStrings() 
        {
            var s1 = "Greetings";
            object s2 = "From";
            dynamic s3 = "Minneapolis";

            Console.WriteLine($"s1 it type: {s1.GetType()}");
            Console.WriteLine($"s2 it type: {s2.GetType()}");
            Console.WriteLine($"s3 it type: {s3.GetType()}");
        }

        static void ChangeDynamicDataType() 
        {
            dynamic t = "Hello";
            Console.WriteLine($"t is type: {t.GetType()}");

            t = false;
            Console.WriteLine($"t is type: {t.GetType()}");

            t = new List<int>();
            Console.WriteLine($"t is type: {t.GetType()}");
        }

        static void InvokeMembersOnDynamicData() 
        {
            dynamic dynamic1;
            dynamic textData = "Hello";
            Console.WriteLine(textData.ToUpper());

           // Console.WriteLine(textData.toupper());
           // Console.WriteLine(textData.Foo(10, "ee"));

        }
    }
}
